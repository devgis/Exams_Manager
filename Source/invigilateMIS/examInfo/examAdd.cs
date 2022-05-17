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
    public partial class examAdd : Form
    {
        public examAdd()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (this.txtID.Text.Trim().Length == 0)
            {
                strErr += "ex_id不能为空！\\n";
            }
            if (this.cmName.Text.Trim().Length == 0)
            {
                strErr += "ex_name不能为空！\\n";
            }
            
            if (this.txtRemark.Text.Trim().Length == 0)
            {
                strErr += "ex_remark不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string ex_id = this.txtID.Text;
            string ex_name = this.cmName.Text;
            DateTime ex_date = DateTime.Parse(this.dtDate.Text);
            string ex_remark = this.txtRemark.Text;

            Maticsoft.Model.tb_ExamInfo model = new Maticsoft.Model.tb_ExamInfo();
            model.ex_id = ex_id;
            model.ex_name = ex_name;
            model.ex_date = ex_date;
            model.ex_remark = ex_remark;

            if (DBHelper.AddExamInfo(model)>0)
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

        private void examAdd_Load(object sender, EventArgs e)
        {
            DataSet ds = DBHelper.GetListExamName (" 1=1;");
            cmName.DataSource = ds.Tables[0];
            cmName.DisplayMember = "ex_name";
            cmName.ValueMember = "id";
        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
