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
    public partial class examRev : Form
    {
        public int id = 0;
        public examRev()
        {
            InitializeComponent();
        }

        private void examRev_Load(object sender, EventArgs e)
        {
            DataSet ds = DBHelper.GetListExamName(" 1=1;");
            cmName.DataSource = ds.Tables[0];
            cmName.DisplayMember = "ex_name";
            cmName.ValueMember = "id";
            ShowInfo(id);
        }
        private void ShowInfo(int id)
        {
            Maticsoft.Model.tb_ExamInfo model = DBHelper.GetModelExamInfo(id);

            this.txtID.Text = model.ex_id;
            this.cmName.Text = model.ex_name;
            this.dtDate.Text = model.ex_date.ToString();
            this.txtRemark.Text = model.ex_remark;

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
            model.id = id;
            model.ex_id = ex_id;
            model.ex_name = ex_name;
            model.ex_date = ex_date;
            model.ex_remark = ex_remark;

            if (DBHelper.UpdateExamInfo(model))
            {
                MessageBox.Show("修改成功！", "OK");
                this.Close();
            }
            else
            { MessageBox.Show("修改失败！", "Err"); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
