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
    public partial class tcMain : Form
    {
        public tcMain()
        {
            InitializeComponent();
        }

        private void txtExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsInv_Click(object sender, EventArgs e)
        {
            frmTCinv obj = new frmTCinv();
            obj.Owner = this;
            obj.ShowDialog();
        }

        private void tsUser_Click(object sender, EventArgs e)
        {
            tcRev obj = new tcRev();
           DataSet ds = DBHelper.GetListTeacher(string.Format(" tc_id='{0}'", loginHelper.UserID));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                obj.id = Convert.ToInt32(dr["id"]);
               
            }
            
            obj.tc_id = loginHelper.UserID;
            obj.Show();
        }
    }
}
