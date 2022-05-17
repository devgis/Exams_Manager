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
    public partial class nameRev : Form
    {
        public int id;
        public nameRev()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (this.txtName.Text.Trim().Length == 0)
            {
                strErr += "ex_name不能为空！\\n";
            }


            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string ex_name = this.txtName.Text;


            Maticsoft.Model.tb_ExamName model = new Maticsoft.Model.tb_ExamName();
            model.id = id;
            model.ex_name = ex_name;

            if (DBHelper.UpdateExamName(model))
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

        private void nameRev_Load(object sender, EventArgs e)
        {
            ShowInfo(id);
        }
        private void ShowInfo(int id)
        {
            Maticsoft.Model.tb_ExamName model = DBHelper.GetModelExamName(id);
            this.txtName.Text = model.ex_name;

        }
    }
}
