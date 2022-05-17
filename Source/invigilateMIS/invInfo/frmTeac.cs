using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace invigilateMIS.invInfo
{
    public partial class frmTeac : Form
    {
        public int num
        {
            set
            {
                cmNum.Text = value.ToString();
            }
            get
            {
                return Convert.ToInt32(cmNum.Text);
            }

        }
        public int tcCount
        {
            set
            {
                txtNum.Text = value.ToString();
            }
            get
            {
                return Convert.ToInt32(txtNum.Text);
            }
        }
        public string name
        {
            set
            {
                txtName.Text = value;
            }

        }
        public frmTeac()
        {
            InitializeComponent();
        }

        private void btnTeac_Click(object sender, EventArgs e)
        {
            #region 新方法
            if (ds != null)
            {
                calTeacher(ds);
            }
            #endregion

        }
        int age = 40;
        Hashtable hs = new Hashtable();
        bool bFirst = true;
        private DataSet calTeacher(DataSet ds)
        {
                   
            dataView.Rows.Clear();
            if (bFirst) //首次按公式计算w
            {
                if (ds != null && ds.Tables.Count > 0)
                {
                    if (!ds.Tables[0].Columns.Contains("wvalue"))
                    {
                        ds.Tables[0].Columns.Add("wvalue", typeof(double));
                    }
                }
                //计算W值
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int Age = DateTime.Now.Year - DateTime.Parse(dr["Birthday"].ToString()).Year + 1;
                    string sex = dr["Sex"].ToString();
                    double nWx = 0;

                    //年龄系数A 年龄x   22≤x≤65
                    //A(x) = -0.02x + 1.44
                    double A = 0;
                    if (Age >= 22 && Age <= 65)
                    {
                        A= -0.02*Age + 1.44;
                    }

                    //性别系数S 性别y       y = 男， S = 0.7
                    //y = 女， S = 0.3
                    //其中S可根据实际男女教师比例自定义设置
                    //公平度公式 W = mA + nS     0＜m，n＜1且m + n = 1
                    double S = 0.7;

                    if (sex == "男")
                    {
                        S = 0.7;
                    }
                    else
                    {
                        S = 0.3;
                    }

                    double m = 0.6, n = 0.4;

                    nWx = m * A + n * S;
                    dr["wvalue"] = nWx;
                }
                bFirst = false;
            }

            //根据数量取得值
            //DataView dv = ds.Tables[0].DefaultView;
            //dv.Sort = "wvalue Asc";
            //DataTable dt2 = dv.ToTable();

            //根据概率取
            //新增字典
            Dictionary<int, Zone> dicValue = new Dictionary<int, Zone>();
            double dMax = 0d;//加上d说明是double型的
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Zone z = new Zone();
                z.Min = dMax;
                dMax += Convert.ToDouble(dr["wvalue"]);
                z.Max = dMax;
                dicValue.Add(Convert.ToInt32(dr["id"]), z);
            }

            Dictionary<int, int> dicSelected = new Dictionary<int, int>();
            Random rd = new Random();
            int count= tcCount * num;
            dataView.Rows.Clear();
            if (count >= ds.Tables[0].Rows.Count)
            {
                //所有都选中 添加到试图中 并对值进行衰减

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int index = dataView.Rows.Add();
                    dataView.Rows[index].Cells[0].Value = dr["id"];
                    dataView.Rows[index].Cells[1].Value = txtName.Text;
                    dataView.Rows[index].Cells[2].Value = dr["tc_id"];
                    dataView.Rows[index].Cells[3].Value = dr["tc_name"];
                    dataView.Rows[index].Cells[4].Value = dr["wvalue"];
                    dr["wvalue"] = Convert.ToDouble(dr["wvalue"]) * 0.7;
                }
            }
            else
            {

                //随机产生
                for (int i = 0; i < count; i++)
                {
                    bool bnotok=false;
                    while (!bnotok)
                    {
                        double d = rd.NextDouble();
                        foreach (int key in dicValue.Keys)
                        {
                            if (!dicSelected.ContainsKey(key) && d * dMax >= dicValue[key].Min && d * dMax < dicValue[key].Max)
                            {
                                dicSelected.Add(key, key);
                                bnotok = true;
                                break;
                            }

                        }
                    }
                }

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    foreach (int key in dicSelected.Keys)
                    {
                        if (key == Convert.ToInt32(dr["id"]))
                        {
                            int index = dataView.Rows.Add();
                            dataView.Rows[index].Cells[0].Value = dr["id"];
                            dataView.Rows[index].Cells[1].Value = txtName.Text;
                            dataView.Rows[index].Cells[2].Value = dr["tc_id"];
                            dataView.Rows[index].Cells[3].Value = dr["tc_name"];
                            dataView.Rows[index].Cells[4].Value = dr["wvalue"];
                            dr["wvalue"] = Convert.ToDouble(dr["wvalue"]) * 0.7;
                        }
                    }
                    
                }


                //添加到视图中 并且将选中的dw值进行修改
            }


            //int index = dataView.Rows.Add();
            //dataView.Rows[index].Cells[0].Value = dr["id"];
            //dataView.Rows[index].Cells[1].Value = txtName.Text;
            //dataView.Rows[index].Cells[2].Value = dr["tc_id"];
            //dataView.Rows[index].Cells[3].Value = dr["tc_name"];
            //dataView.Rows[index].Cells[4].Value = nWx;



            /* */
            return ds;
        }
        DataSet ds = null;
        private void frmTeac_Load(object sender, EventArgs e)
        {
            int num = 0;
            dataView.Columns[0].Visible = false;
            int cNum = Convert.ToInt32(cmNum.Text.Trim());
            try
            {
                if (txtNum.Text.Trim() == "")
                {
                    MessageBox.Show("请输入考场数", "Err");
                }
                else
                {
                    num = Convert.ToInt32(txtNum.Text.Trim());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Err");
            }
            //double addPart = num * cNum * (double.Parse(cmPart.Text.Replace("%", ""))) / 100;
            double addPart = 1;
            if (addPart > (DBHelper.GetRecordCountTeacher(" tc_state <>'请假';") + 1))
            {
                MessageBox.Show("考场大于监考人数", "Err");
                return;
            }

            ds = DBHelper.GetListTeacher((int)addPart, " tc_state<>'请假'", " newid()");
            calTeacher(ds);
        }
    }

    public class Zone
    {
        public double Min
        {
            get;
            set;
        }
        public double Max
        {
            get;
            set;
        }
    }
}
