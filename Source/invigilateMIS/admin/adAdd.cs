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
    public partial class adAdd : Form
    {
        public adAdd()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (this.txtID.Text.Trim().Length == 0)
            {
                strErr += "密码不能为空！";
            }
            if (this.txtPwd.Text.Trim().Length == 0)
            {
                strErr += "用户名不能为空！";
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
            model.user_id = user_id;
            model.user_Pwd = user_Pwd;
            model.user_type = user_type;

            if (DBHelper.AddAdmin(model) > 0)
            {
                MessageBox.Show("添加成功！", "OK");
                this.Close();
            }
            else
            { MessageBox.Show("添加失败！", "Err"); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adAdd_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
