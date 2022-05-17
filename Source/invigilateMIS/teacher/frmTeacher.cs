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
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void frmTeacher_Load(object sender, EventArgs e)
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
                    case "教员编号":
                        strWhere.AppendFormat(" tc_id like '%{0}%'", txtCon.Text.Trim());
                        break;
                    case "教员姓名":
                        strWhere.AppendFormat(" tc_name like '%{0}%'", txtCon.Text.Trim());
                        break;
                    default:
                        break;
                }

            }
            ds = DBHelper.GetListTeacher(strWhere.ToString());
            dataView.Rows.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int index = dataView.Rows.Add();
                dataView.Rows[index].Cells[0].Value = dr["id"];
                dataView.Rows[index].Cells[1].Value = dr["tc_id"];
                dataView.Rows[index].Cells[2].Value = dr["tc_name"];
                dataView.Rows[index].Cells[3].Value = dr["tc_pwd"];
                dataView.Rows[index].Cells[4].Value = dr["sex"];
                dataView.Rows[index].Cells[5].Value = dr["Birthday"];
                dataView.Rows[index].Cells[6].Value = dr["tc_email"];
                dataView.Rows[index].Cells[7].Value = dr["tc_phone"];
                dataView.Rows[index].Cells[8].Value = dr["tc_state"];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tcAdd obj = new tcAdd();
            obj.Owner = this;
            obj.ShowDialog();
            BindData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int rowindex = dataView.CurrentRow.Index;
            if (MessageBox.Show("是否删除所选中的数据", "删除！", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (DBHelper.DeleteListTeacher(dataView.Rows[rowindex].Cells[0].Value.ToString()))
                { MessageBox.Show("删除成功！", "OK"); }
                else
                { MessageBox.Show("删除失败！", "Err"); }
            }
            BindData();
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            int rowindex = dataView.CurrentRow.Index;
            tcRev obj = new tcRev();
            obj.id = Convert.ToInt32(dataView.Rows[rowindex].Cells[0].Value);
            obj.Owner = this;
            obj.ShowDialog();
            BindData();
        }
        public void BindData()
        {
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();

            ds = DBHelper.GetListTeacher(strWhere.ToString());
            dataView.Rows.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int index = dataView.Rows.Add();
                dataView.Rows[index].Cells[0].Value = dr["id"];
                dataView.Rows[index].Cells[1].Value = dr["tc_id"];
                dataView.Rows[index].Cells[2].Value = dr["tc_name"];
                dataView.Rows[index].Cells[3].Value = dr["tc_pwd"];
                dataView.Rows[index].Cells[4].Value = dr["sex"];
                dataView.Rows[index].Cells[5].Value = dr["Birthday"];
                dataView.Rows[index].Cells[6].Value = dr["tc_email"];
                dataView.Rows[index].Cells[7].Value = dr["tc_phone"];
                dataView.Rows[index].Cells[8].Value = dr["tc_state"];
            }

        }
    }
}
