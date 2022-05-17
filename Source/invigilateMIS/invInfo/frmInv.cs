using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using invigilateMIS.invInfo;

namespace invigilateMIS
{
    public partial class frmInv : Form
    {
        public frmInv()
        {
            InitializeComponent();
        }
        private void frmInv_Load(object sender, EventArgs e)
        {
            DataSet ds = DBHelper.GetListExamName(" 1=1;");
            cmExam.DataSource = ds.Tables[0];
            cmExam.DisplayMember = "ex_name";
            cmExam.ValueMember = "id";
            cmExam.SelectedIndex = 0;
            cmNum.SelectedIndex = 0;
            fresh();
        }
        int age = 40;
        Hashtable hs = new Hashtable();
        private DataSet calTeacher(DataSet ds)
        {
            DataSet dsNow = ds;
            int downAge = DBHelper.GetdownAgeTeacher();
            int topAge = DBHelper.GetTopAgeTeacher();
            double k = 0.9 / (topAge - downAge);
            if (topAge - downAge == 0)
            {
                k = 0;
            }
            double b = 1 - k * downAge;
            double part = DBHelper.getPartTeacher();
            int count = Int32.Parse(txtNum.Text);
           
            dataView.Rows.Clear();
            while (dsNow.Tables[0].Rows.Count > count)
            {
                double Wx = 0;
                string tc_id = "";
                foreach (DataRow dr in dsNow.Tables[0].Rows)
                {
                    int Age = DateTime.Now.Year - DateTime.Parse(dr["Birthday"].ToString()).Year + 1;
                    string sex = dr["Sex"].ToString();
                    double nWx = 0;
                    if (sex == "男")
                    {
                        nWx = k * Age + part;
                    }
                    else
                    {
                        nWx = k * Age + 1 / part;
                    }
                    if (Wx < nWx)
                    {
                        tc_id = dr["tc_id"].ToString();
                    }
                }
                for (int i = 0; i < dsNow.Tables[0].Rows.Count; i++)
                {
                    DataRow dr = dsNow.Tables[0].Rows[i];
                    if (tc_id == dr["tc_id"].ToString())
                    {
                        dsNow.Tables[0].Rows.Remove(dr);
                    }
                }
                   /* foreach (DataRow dr in dsNow.Tables[0].Rows)
                    {

                        if (tc_id == dr["tc_id"].ToString())
                        {
                            dsNow.Tables[0].Rows.Remove(dr);
                        }
                    }*/

            }




            return dsNow;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            int num = 0;
            dataView.Columns[0].Visible = false;
            int cNum = Convert.ToInt32(cmNum.Text.Trim());
            try
            {
                if (txtNum.Text.Trim() == "")
                {
                    MessageBox.Show("请输入考场数", "Err");
                    return;
                }
                else
                {
                    num = Convert.ToInt32(txtNum.Text.Trim());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Err");
                return;
            }
            //double addPart = num * cNum * (double.Parse(cmPart.Text.Replace("%", ""))) / 100;
            double addPart = 1;
            if (addPart > (DBHelper.GetRecordCountTeacher(" tc_state <>'请假';") + 1))
            {
                MessageBox.Show("考场大于监考人数", "Err");
                return;
            }
            else
            {
                DataSet ex = new DataSet();
                StringBuilder strWhere = new StringBuilder();
                strWhere.AppendFormat(" ex_name = '{0}'", cmExam.Text);
                ex = DBHelper.GetListExamInfo(strWhere.ToString());
             
                bool isSueccess = true;
                if (DBHelper.GetListInvInfo(string.Format("ex_remark = ''", cmExam.Text)).Tables[0].Rows.Count == 0)
                {

                    foreach (DataRow dr in ex.Tables[0].Rows)
                    {
                        DataSet ds = DBHelper.GetListTeacher((int)addPart, " tc_state<>'请假'", " newid()");
                        ds = calTeacher(ds);//算法
                        for (int i = 0; i < num; i++)
                        {
                            for (int j = 0; j < cNum; j++)
                            {
                                Maticsoft.Model.tb_InvInfo invInfo = new Maticsoft.Model.tb_InvInfo();
                                invInfo.ex_room = string.Format("第{0}考场", i);
                                invInfo.ex_id = dr["ex_id"].ToString();
                                invInfo.tc_id = ds.Tables[0].Rows[i * cNum + j]["tc_id"].ToString();
                                invInfo.tc_name = ds.Tables[0].Rows[i * cNum + j]["tc_name"].ToString();
                                invInfo.ex_remark = cmExam.Text.Trim();
                                if (DBHelper.AddInvInfo(invInfo))
                                {
                                }
                                else
                                {
                                    isSueccess = false;
                                    continue;
                                }
                            }
                        }
                    }
                }
                else
                {
                    isSueccess = false;
                }
                if (isSueccess)
                {
                    MessageBox.Show("监考表生成成功", "OK");
                    freshInv();
                }
                else
                {
                    MessageBox.Show("监考表生成失败", "Err");
                }
            }


        }
        private void freshInv()
        {
            DataSet exRoom = DBHelper.GetRMListInvInfo(string.Format(" ex_remark = '{0}' group by ex_room ", cmExam.Text.Trim()));
            InvView.Rows.Clear();
            foreach (DataRow dr in exRoom.Tables[0].Rows)
            {

                int index = InvView.Rows.Add();
                try
                {
                    InvView.Rows[index].Cells[0].Value = dr["ex_room"];
                }
                catch
                {
                    continue;
                }
            }
            DataSet exRank = null;
            DataSet exam = DBHelper.GetListExamInfo(" 1=1;");
            int j = 1;
            foreach (DataRow dr in exam.Tables[0].Rows)
            {
                int i = 0;
                exRank = DBHelper.GetListInvInfo(string.Format(" ex_id = '{0}' and ex_remark = '{1}' order by id ", dr["ex_id"], cmExam.Text.Trim()));
                int index = InvView.Rows.Add();
                foreach (DataRow rk in exRank.Tables[0].Rows)
                {

                    try
                    {
                        InvView.Rows[i].Cells[j].Value = rk["tc_name"];
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
            freshInv();
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

        private void btnTeac_Click(object sender, EventArgs e)
        {
            int num = 0;

            int cNum = Convert.ToInt32(cmNum.Text.Trim());
            try
            {
                if (txtNum.Text.Trim() == "")
                {
                    MessageBox.Show("请输入考场数", "Err");
                    return;
                }
                else
                {
                    num = Convert.ToInt32(txtNum.Text.Trim());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Err");
                return;
            }
            //double addPart = num * cNum * (double.Parse(cmPart.Text.Replace("%", ""))) / 100;
            double addPart = 1;
            if (addPart > (DBHelper.GetRecordCountTeacher(" tc_state <>'请假';") + 1))
            {
                MessageBox.Show("考场大于监考人数", "Err");
                return;
            }
            else
            {

                frmTeac obj = new frmTeac();
                obj.tcCount = Int32.Parse(txtNum.Text);
                obj.name = cmExam.Text;
                obj.num = Int32.Parse(cmNum.Text);
                //obj.part = cmPart.Text;
                obj.Show();
            }
        }
    }
}
