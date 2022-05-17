using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace invigilateMIS.invInfo
{
    public partial class InvAdd : Form
    {
        DataSet examInfo = null;
        private string abList;
        public InvAdd()
        {
            InitializeComponent();
        }

        private void InvAdd_Load(object sender, EventArgs e)
        {
            DataSet examName = DBHelper.GetListExamName(" 1=1;");
            cmExam.DataSource = examName.Tables[0];
            cmExam.DisplayMember = "ex_name";
            cmExam.ValueMember = "id";
            cmExam.SelectedIndex = 0;
            examInfo = DBHelper.GetListExamInfo(" 1=1;");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet exRoom = DBHelper.GetRMListInvInfo(string.Format(" ex_remark = '{0}' group by ex_room ", cmExam.Text.Trim()));
            inView.Rows.Clear();
            foreach (DataRow dr in exRoom.Tables[0].Rows)
            {

                int index = inView.Rows.Add();
                try
                {
                    inView.Rows[index].Cells[0].Value = dr["ex_room"];
                }
                catch
                {
                    continue;
                }
            }
            DataSet exRank = null;
            int j = 1;
            foreach (DataRow dr in examInfo.Tables[0].Rows)
            {
                int i = 0;
                //exRank = inv.GetList(string.Format(" ex_id = '{0}' order by id ", dr["ex_id"]));
                exRank = DBHelper.GetListInvInfo(string.Format(" ex_id = '{0}' and ex_remark = '{1}' order by id ", dr["ex_id"], cmExam.Text.Trim()));

                int index = inView.Rows.Add();
                foreach (DataRow rk in exRank.Tables[0].Rows)
                {

                    try
                    {
                        if (rk["state"].ToString() == "1")
                        {
                            //inView.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            abList += rk["id"].ToString() + ",";
                        }
                        else
                        {
                            //inView.Rows[i].Cells[j].Style.BackColor = Color.Green;
                        }
                        inView.Rows[i].Cells[j].Value = rk["tc_name"];
                    }
                    catch
                    {
                        continue;
                    }
                    i++;
                }
                j++;
            }

        }

        private void cmExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            fresh();
        }
        private void fresh()
        {
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.AppendFormat(" ex_name = '{0}'", cmExam.Text);
            ds = DBHelper.GetListExamInfo(strWhere.ToString());
            dataView.Rows.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int index = dataView.Rows.Add();

                dataView.Rows[index].Cells[0].Value = dr["ex_id"];
                dataView.Rows[index].Cells[1].Value = dr["ex_date"];
                dataView.Rows[index].Cells[2].Value = dr["ex_remark"];
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string exName = "";
            abList = abList.Substring(0, abList.Length - 1);
            ArrayList abs = SplitStringToList(abList);
            foreach (string id in abs)
            {
                int inv_id = int.Parse(id);
                Maticsoft.Model.tb_InvInfo model = DBHelper.GetModelInvInfo(inv_id);

                DataSet ds = DBHelper.GetListTeacher(1, string.Format(" tc_state<>'请假' and tc_id not in (select tc_id from tb_InvInfo where ex_remark ='{0}' and ex_id = '{1}') and tc_id <> '{2}'",
                    model.ex_remark, model.ex_id, model.tc_id), " newid()");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    model.tc_id = dr["tc_id"].ToString();
                    model.tc_name = dr["tc_name"].ToString();
                    if (DBHelper.UpdateInvInfo(model))
                    {
                        MessageBox.Show("替换成功", "监考管理系统");
                    }

                }
            }
            btnSearch_Click(sender, e);
        }
        public ArrayList SplitStringToList(string str)
        {
            string[] arrStr = str.Split(new char[] { ',', '，', ':', '：', '/' });
            ArrayList list = new ArrayList();
            try
            {

                for (int i = 0; i < arrStr.Length; i++)
                {
                    if (arrStr[i].Trim() != "" && !String.IsNullOrEmpty(arrStr[i]))
                    {
                        list.Add(arrStr[i]);

                    }
                }
            }
            catch (Exception e)
            {

            }
            return list;
        }
    }
}
