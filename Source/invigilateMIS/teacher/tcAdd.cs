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
    public partial class tcAdd : Form
    {
        public tcAdd()
        {
            InitializeComponent();
        }

        private void tcAdd_Load(object sender, EventArgs e)
        {
            cmSex.SelectedIndex = 0;
            cmState.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (this.txtID.Text.Trim().Length == 0)
            {
                strErr += "tc_id不能为空！\\n";
            }
            if (this.txtPwd.Text.Trim().Length == 0)
            {
                strErr += "tc_pwd不能为空！\\n";
            }
            if (this.txtName.Text.Trim().Length == 0)
            {
                strErr += "tc_name不能为空！\\n";
            }
            if (this.cmSex.Text.Trim().Length == 0)
            {
                strErr += "Sex不能为空！\\n";
            }
            if (this.dtBirth.Text.Trim().Length == 0)
            {
                strErr += "Birthday不能为空！\\n";
            }
            if (this.cmState.Text.Trim().Length == 0)
            {
                strErr += "tc_state不能为空！\\n";
            }
            if (this.txtPhone.Text.Trim().Length == 0)
            {
                strErr += "tc_phone不能为空！\\n";
            }
            if (this.txtEmail.Text.Trim().Length == 0)
            {
                strErr += "tc_email不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string tc_id = this.txtID.Text;
            string tc_pwd = this.txtPwd.Text;
            string tc_name = this.txtName.Text;
            string Sex = this.cmSex.Text;
            string Birthday = this.dtBirth.Text;
            string tc_state = this.cmState.Text;
            string tc_phone = this.txtPhone.Text;
            string tc_email = this.txtEmail.Text;

            Maticsoft.Model.tb_Teacher model = new Maticsoft.Model.tb_Teacher();
            model.tc_id = tc_id;
            model.tc_pwd = tc_pwd;
            model.tc_name = tc_name;
            model.Sex = Sex;
            model.Birthday = Birthday;
            model.tc_state = tc_state;
            model.tc_phone = tc_phone;
            model.tc_email = tc_email;

            if (DBHelper.AddTeacher(model) > 0)
            {
                MessageBox.Show("添加成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
