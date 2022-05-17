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
    public partial class tcRev : Form
    {
        public int id=0;
        public string tc_id = "";
        DataSet ds = null;
        public tcRev()
        {
            InitializeComponent();
        }

        private void tcRev_Load(object sender, EventArgs e)
        {
            cmSex.SelectedIndex = 0;
            cmState.SelectedIndex = 0;           
            ShowInfo(id);
        }
        private void ShowInfo(int id)
        {
            if (tc_id != "")
            {
                /* ds = bll.GetList(string.Format(" tc_id='{0}'", tc_id));
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    id = Convert.ToInt32(dr["id"]);
                    
                }*/
                this.txtID.Enabled = false;
            }
            Maticsoft.Model.tb_Teacher model = DBHelper.GetModelTeacher(id);
            this.txtID.Text = model.tc_id;            
            this.txtPwd.Text = model.tc_pwd;
            this.txtName.Text = model.tc_name;
            this.cmSex.Text = model.Sex;
            this.dtBirth.Text = model.Birthday;
            this.cmState.Text = model.tc_state;
            this.txtPhone.Text = model.tc_phone;
            this.txtEmail.Text = model.tc_email;

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
            model.id = id;
            model.tc_id = tc_id;
            model.tc_pwd = tc_pwd;
            model.tc_name = tc_name;
            model.Sex = Sex;
            model.Birthday = Birthday;
            model.tc_state = tc_state;
            model.tc_phone = tc_phone;
            model.tc_email = tc_email;

            if (DBHelper.UpdateTeacher(model) )
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
