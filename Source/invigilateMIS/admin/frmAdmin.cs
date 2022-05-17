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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void txtAdd_Click(object sender, EventArgs e)
        {
            adAdd obj = new adAdd();
            obj.Owner = this;
            obj.ShowDialog();
            BindData();
        }

        private void txtQue_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            if (txtCon.Text.Trim() != "")
            {
                strWhere.AppendFormat("user_id like '%{0}%'", txtCon.Text.Trim());
            }
            ds = DBHelper.GetListAdmin(strWhere.ToString());//绑定数据，同  public void BindData()这个方法
            dataView.Rows.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int index = dataView.Rows.Add();
                dataView.Rows[index].Cells[0].Value = dr["id"];
                dataView.Rows[index].Cells[1].Value = dr["user_id"];
                dataView.Rows[index].Cells[2].Value = dr["user_Pwd"];
            }
          
        }

        private void txtDel_Click(object sender, EventArgs e)
        {
            int rowindex = dataView.CurrentRow.Index;
            if (MessageBox.Show("是否删除所选中的数据", "删除！", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (DBHelper.DeleteListAdmin(dataView.Rows[rowindex].Cells[0].Value.ToString()))
                { MessageBox.Show("删除成功！", "OK"); }
                else
                { MessageBox.Show("删除失败！", "Err"); }
            }
            BindData();
        }

        private void txtRev_Click(object sender, EventArgs e)
        {
            int rowindex = dataView.CurrentRow.Index;
            adRev obj = new adRev();
            obj.id = Convert.ToInt32(dataView.Rows[rowindex].Cells[0].Value);
            obj.Owner = this;
            obj.ShowDialog();
            BindData();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            dataView.Columns[0].Visible = false;
            BindData();
        }
        public void BindData()//绑定数据
        {
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            
            ds = DBHelper.GetListAdmin(strWhere.ToString());
            dataView.Rows.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int index = dataView.Rows.Add();
                dataView.Rows[index].Cells[0].Value = dr["id"];
                dataView.Rows[index].Cells[1].Value = dr["user_id"];
                dataView.Rows[index].Cells[2].Value = dr["user_Pwd"];
            }
          
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gp_Enter(object sender, EventArgs e)
        {

        }
    }
}
