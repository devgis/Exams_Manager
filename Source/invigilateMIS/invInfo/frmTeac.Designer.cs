namespace invigilateMIS.invInfo
{
    partial class frmTeac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnTeac = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gd_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnTeac);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "考试信息";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 21);
            this.txtName.TabIndex = 13;
            // 
            // btnTeac
            // 
            this.btnTeac.Location = new System.Drawing.Point(593, 36);
            this.btnTeac.Name = "btnTeac";
            this.btnTeac.Size = new System.Drawing.Size(82, 51);
            this.btnTeac.TabIndex = 10;
            this.btnTeac.Text = "教师筛选";
            this.btnTeac.UseVisualStyleBackColor = true;
            this.btnTeac.Click += new System.EventHandler(this.btnTeac_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(100, 71);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(155, 21);
            this.txtNum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "考场个数：";
            // 
            // cmNum
            // 
            this.cmNum.FormattingEnabled = true;
            this.cmNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmNum.Location = new System.Drawing.Point(390, 36);
            this.cmNum.Name = "cmNum";
            this.cmNum.Size = new System.Drawing.Size(156, 20);
            this.cmNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "监考人数：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "考试名称：";
            // 
            // dataView
            // 
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.gd_Name,
            this.lid,
            this.Column3});
            this.dataView.Location = new System.Drawing.Point(3, 151);
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Height = 23;
            this.dataView.Size = new System.Drawing.Size(735, 234);
            this.dataView.TabIndex = 15;
            // 
            // id
            // 
            this.id.HeaderText = " 流水";
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "      考试名称      ";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // gd_Name
            // 
            this.gd_Name.HeaderText = "  教员编号";
            this.gd_Name.Name = "gd_Name";
            // 
            // lid
            // 
            this.lid.HeaderText = "   教员名称";
            this.lid.Name = "lid";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "  公平度";
            this.Column3.Name = "Column3";
            // 
            // frmTeac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 353);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTeac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师筛选";
            this.Load += new System.EventHandler(this.frmTeac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTeac;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gd_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}