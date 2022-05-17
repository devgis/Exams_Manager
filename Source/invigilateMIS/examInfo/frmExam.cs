using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace invigilateMIS
{
    public partial class frmExam : Form
    {
        public frmExam()
        {
            InitializeComponent();
        }

        private void frmExam_Load(object sender, EventArgs e)
        {
            cmType.SelectedIndex = 0;
            dataView.Columns[0].Visible = false;
            BindData();
        }

        private void btnQue_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            if (txtCon.Text.Trim() != "")
            {
                switch (cmType.Text)
                {
                    case "考试场次":
                        strWhere.AppendFormat(" tc_id like '%{0}%'", txtCon.Text.Trim());
                        break;
                    case "考试名称":
                        strWhere.AppendFormat(" tc_name like '%{0}%'", txtCon.Text.Trim());
                        break;
                    case "考试备注":
                        strWhere.AppendFormat(" tc_name like '%{0}%'", txtCon.Text.Trim());
                        break;
                    default:
                        break;
                }

            }
            ds = DBHelper.GetListExamInfo(strWhere.ToString());
            dataView.Rows.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int index = dataView.Rows.Add();
                dataView.Rows[index].Cells[0].Value = dr["id"];
                dataView.Rows[index].Cells[1].Value = dr["ex_id"];
                dataView.Rows[index].Cells[2].Value = dr["ex_name"];
                dataView.Rows[index].Cells[3].Value = dr["ex_date"];
                dataView.Rows[index].Cells[4].Value = dr["ex_remark"];
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            examAdd obj = new examAdd();
            obj.Owner = this;
            obj.ShowDialog();
            BindData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            int rowindex = dataView.CurrentRow.Index;
            if (MessageBox.Show("是否删除所选中的数据", "删除！", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (DBHelper.DeleteListExamInfo(dataView.Rows[rowindex].Cells[0].Value.ToString()))
                { MessageBox.Show("删除成功！", "OK"); }
                else
                { MessageBox.Show("删除失败！", "Err"); }
            }
            BindData();
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            int rowindex = dataView.CurrentRow.Index;
            examRev obj = new examRev();
            obj.id = Convert.ToInt32(dataView.Rows[rowindex].Cells[0].Value);
            obj.Owner = this;
            obj.ShowDialog();
            BindData();
        }
        public void BindData()
        {
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();

            ds = DBHelper.GetListExamInfo (strWhere.ToString());
            dataView.Rows.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int index = dataView.Rows.Add();
                dataView.Rows[index].Cells[0].Value = dr["id"];
                dataView.Rows[index].Cells[1].Value = dr["ex_id"];
                dataView.Rows[index].Cells[2].Value = dr["ex_name"];
                dataView.Rows[index].Cells[3].Value = dr["ex_date"];
                dataView.Rows[index].Cells[4].Value = dr["ex_remark"];
            }

        }
    }
}
