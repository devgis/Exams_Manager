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
    public partial class adRev : Form
    {
        public int id = 0;
        public adRev()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (this.txtID.Text.Trim().Length == 0)
            {
                strErr += "用户名不能为空！";
            }
            if (this.txtPwd.Text.Trim().Length == 0)
            {
                strErr += "密码不能为空！";
            }


            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string user_id = this.txtID.Text;
            string user_Pwd = this.txtPwd.Text;
            string user_type = "0";

            Maticsoft.Model.tb_Admin model = new Maticsoft.Model.tb_Admin();
            model.id = id;
            model.user_id = user_id;
            model.user_Pwd = user_Pwd;
            model.user_type = user_type;
            if (DBHelper.UpdateAdmin(model) )
            {
                MessageBox.Show("修改成功！", "OK");
                this.Close();
            }
            else
            { MessageBox.Show("修改失败！", "Err"); }
        }

        private void adRev_Load(object sender, EventArgs e)
        {
            
            ShowInfo(id);
        }
        private void ShowInfo(int id)
        {
            Maticsoft.Model.tb_Admin model = DBHelper.GetModelAdmin(id);
            this.txtID.Text = model.user_id.ToString();
            this.txtPwd.Text = model.user_Pwd.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
