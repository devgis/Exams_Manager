namespace invigilateMIS
{
    partial class frmInv
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTeac = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmExam = new System.Windows.Forms.ComboBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabNum = new System.Windows.Forms.TabPage();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.gd_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInvInfo = new System.Windows.Forms.TabPage();
            this.InvView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.tabInvInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "考试名称：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnTeac);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmExam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "考试信息";
            // 
            // btnTeac
            // 
            this.btnTeac.Location = new System.Drawing.Point(593, 41);
            this.btnTeac.Name = "btnTeac";
            this.btnTeac.Size = new System.Drawing.Size(82, 23);
            this.btnTeac.TabIndex = 10;
            this.btnTeac.Text = "教师筛选";
            this.btnTeac.UseVisualStyleBackColor = true;
            this.btnTeac.Click += new System.EventHandler(this.btnTeac_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(593, 74);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "生成监考表";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(101, 76);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(155, 21);
            this.txtNum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 80);
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
            this.cmNum.Location = new System.Drawing.Point(390, 41);
            this.cmNum.Name = "cmNum";
            this.cmNum.Size = new System.Drawing.Size(156, 20);
            this.cmNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "监考人数：";
            // 
            // cmExam
            // 
            this.cmExam.FormattingEnabled = true;
            this.cmExam.Location = new System.Drawing.Point(101, 41);
            this.cmExam.Name = "cmExam";
            this.cmExam.Size = new System.Drawing.Size(156, 20);
            this.cmExam.TabIndex = 1;
            this.cmExam.SelectedIndexChanged += new System.EventHandler(this.cmExam_SelectedIndexChanged);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabNum);
            this.tabMain.Controls.Add(this.tabInvInfo);
            this.tabMain.Location = new System.Drawing.Point(12, 151);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(735, 190);
            this.tabMain.TabIndex = 2;
            // 
            // tabNum
            // 
            this.tabNum.Controls.Add(this.dataView);
            this.tabNum.Location = new System.Drawing.Point(4, 22);
            this.tabNum.Name = "tabNum";
            this.tabNum.Padding = new System.Windows.Forms.Padding(3);
            this.tabNum.Size = new System.Drawing.Size(727, 164);
            this.tabNum.TabIndex = 0;
            this.tabNum.Text = "考试场次";
            this.tabNum.UseVisualStyleBackColor = true;
            // 
            // dataView
            // 
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gd_Name,
            this.Column1,
            this.Column3});
            this.dataView.Location = new System.Drawing.Point(3, 6);
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Height = 23;
            this.dataView.Size = new System.Drawing.Size(721, 219);
            this.dataView.TabIndex = 13;
            // 
            // gd_Name
            // 
            this.gd_Name.HeaderText = "场次";
            this.gd_Name.Name = "gd_Name";
            this.gd_Name.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "时间";
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "备注";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // tabInvInfo
            // 
            this.tabInvInfo.Controls.Add(this.InvView);
            this.tabInvInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInvInfo.Name = "tabInvInfo";
            this.tabInvInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvInfo.Size = new System.Drawing.Size(727, 164);
            this.tabInvInfo.TabIndex = 1;
            this.tabInvInfo.Text = "监考表";
            this.tabInvInfo.UseVisualStyleBackColor = true;
            // 
            // InvView
            // 
            this.InvView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.InvView.Location = new System.Drawing.Point(3, 6);
            this.InvView.Name = "InvView";
            this.InvView.RowTemplate.Height = 23;
            this.InvView.Size = new System.Drawing.Size(721, 208);
            this.InvView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "考场编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "第一场";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "第二场";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "第三场";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "第四场";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "第五场";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "第六场";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 353);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "监考表生成";
            this.Load += new System.EventHandler(this.frmInv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabNum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.tabInvInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmExam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabNum;
        private System.Windows.Forms.TabPage tabInvInfo;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.DataGridView InvView;
        private System.Windows.Forms.DataGridViewTextBoxColumn gd_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnTeac;
    }
}