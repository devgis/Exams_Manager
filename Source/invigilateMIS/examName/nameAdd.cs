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
    public partial class nameAdd : Form
    {
        public nameAdd()
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
            model.ex_name = ex_name;

            if (DBHelper.AddExamName(model) > 0)
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
    }
}
