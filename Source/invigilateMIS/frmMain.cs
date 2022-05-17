using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using invigilateMIS.invInfo;

namespace invigilateMIS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin obj = new frmAdmin();
            obj.Owner = this;
            obj.ShowDialog();
        }

        private void tsExam_Click(object sender, EventArgs e)
        {
            frmExam obj = new frmExam();
            obj.Owner = this;
            obj.ShowDialog();
        }

        private void tsTeacher_Click(object sender, EventArgs e)
        {
            frmTeacher obj = new frmTeacher();
            obj.Owner = this;
            obj.ShowDialog();
        }

        private void tsInv_Click(object sender, EventArgs e)
        {
            frmInv obj = new frmInv();
            obj.Owner = this;
            obj.ShowDialog();
        }

        private void tsName_Click(object sender, EventArgs e)
        {
            frmName obj = new frmName();
            obj.Owner = this;
            obj.ShowDialog();
        }

        private void tsInvM_Click(object sender, EventArgs e)
        {
            InvAdd obj = new InvAdd();
            obj.Owner = this;
            obj.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tsAdmin_Click_1(object sender, EventArgs e)
        {
            frmAdmin obj = new frmAdmin();
            obj.Owner = this;
            obj.ShowDialog();

        }

        private void tsName_Click_1(object sender, EventArgs e)
        {
            frmName obj = new frmName();
            obj.Owner = this;
            obj.ShowDialog();
        }
    }
}
