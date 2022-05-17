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
    public partial class frmTCinv : Form
    {
        public frmTCinv()
        {
            InitializeComponent();
        }

        private void frmTCinv_Load(object sender, EventArgs e)
        {
            dataView.Columns[0].Visible = false;
            DataSet ds = DBHelper.GetListInvInfo(string.Format(" tc_id = '{0}' ", loginHelper.UserID));
            dataView.Rows.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int index = dataView.Rows.Add();
                dataView.Rows[index].Cells[0].Value = dr["id"];
                dataView.Rows[index].Cells[1].Value = dr["ex_room"];
                dataView.Rows[index].Cells[2].Value = dr["ex_id"];
                dataView.Rows[index].Cells[3].Value = dr["tc_id"];
                dataView.Rows[index].Cells[4].Value = dr["tc_name"];
                dataView.Rows[index].Cells[5].Value = dr["ex_remark"];
                dataView.Rows[index].Cells[6].Value = dr["state"];
            }

        }

        private void btnQue_Click(object sender, EventArgs e)
        {
          
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
           
            dataView.Rows.Clear();
            if (txtCon.Text.Trim() != "")
            {
                switch (cmType.Text)
                {
                    case "考场":
                        strWhere.AppendFormat(" ex_room like '%{0}%'", txtCon.Text.Trim());
                        break;
                    case "考试场次":
                        strWhere.AppendFormat(" ex_id like '%{0}%'", txtCon.Text.Trim());
                        break;
                    case "考试名称":
                        strWhere.AppendFormat(" ex_remark like '%{0}%'", txtCon.Text.Trim());
                        break;
                    default:
                        strWhere.Append(" 1=1 ");
                        break;
                }

            }
            strWhere.AppendFormat("  and tc_id = '{0}' ", loginHelper.UserID);
            ds = DBHelper.GetListInvInfo(strWhere.ToString());
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int index = dataView.Rows.Add();
                dataView.Rows[index].Cells[0].Value = dr["id"];
                dataView.Rows[index].Cells[1].Value = dr["ex_room"];
                dataView.Rows[index].Cells[2].Value = dr["ex_id"];
                dataView.Rows[index].Cells[3].Value = dr["tc_id"];
                dataView.Rows[index].Cells[4].Value = dr["tc_name"];
                dataView.Rows[index].Cells[5].Value = dr["ex_remark"];
                dataView.Rows[index].Cells[6].Value = dr["state"];
            }
        }
    }
}
