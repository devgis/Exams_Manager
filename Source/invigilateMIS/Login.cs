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
    public partial class Login : Form
    {
        private string checkCode;
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string userType = cmUser.Text.Trim();
            string userid = txtID.Text.Trim();
            string userpwd = txtPwd.Text.Trim();
            bool istrue = true;
            if (userid != "" && userpwd != "")
            {
                if (userType=="教务管理员")
                {
                    Maticsoft.Model.tb_Admin model = new Maticsoft.Model.tb_Admin();

                    if (DBHelper.GetRecordCountAdmin(" user_ID='" + txtID.Text.Trim() +
                        "' and user_Pwd='" + txtPwd.Text.Trim() + "'") > 0)
                    {
                        loginHelper.UserID = txtID.Text.Trim();
                        frmMain main = new frmMain();
                        main.Show();
                        this.Owner = main;
                        this.Hide();
                    }
                    else
                    {
                        istrue = false;
                    }
                }
                else
                {
                    Maticsoft.Model.tb_Teacher model = new Maticsoft.Model.tb_Teacher();
                    if (DBHelper.GetRecordCountTeacher(" tc_ID='" + txtID.Text.Trim() +
                        "' and tc_Pwd='" + txtPwd.Text.Trim() + "'") > 0)
                    {
                        loginHelper.UserType = "tc";
                        loginHelper.UserID = txtID.Text.Trim();
                        tcMain main = new tcMain();
                        main.Show();
                        this.Owner = main;
                        this.Hide();
                    }
                    else
                    {
                        istrue = false;
                    }
                }
                if (!istrue)
                {
                    MessageBox.Show("用户名/密码不匹配！", "监考管理系统");
                }
            }
            else
            {
                MessageBox.Show("用户名/密码不能为空！", "监考管理系统");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cmUser.SelectedIndex = 0;
            freshCode();
        }
        private void freshCode()
        {
            CheckCode cc = new CheckCode();
            checkCode = cc.checkCode;
            //picCode.BackgroundImage = cc.image;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFre_Click(object sender, EventArgs e)
        {
            freshCode();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
