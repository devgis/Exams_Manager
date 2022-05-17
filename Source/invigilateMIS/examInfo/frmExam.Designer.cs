namespace invigilateMIS
{
    partial class frmExam
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
            this.btnRev = new System.Windows.Forms.Button();
            this.gp = new System.Windows.Forms.GroupBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQue = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gd_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRev
            // 
            this.btnRev.Location = new System.Drawing.Point(33, 212);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(75, 23);
            this.btnRev.TabIndex = 12;
            this.btnRev.Text = "修改";
            this.btnRev.UseVisualStyleBackColor = true;
            this.btnRev.Click += new System.EventHandler(this.btnRev_Click);
            // 
            // gp
            // 
            this.gp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp.Controls.Add(this.txtCon);
            this.gp.Controls.Add(this.label2);
            this.gp.Controls.Add(this.cmType);
            this.gp.Controls.Add(this.label1);
            this.gp.Controls.Add(this.btnQue);
            this.gp.Location = new System.Drawing.Point(12, 9);
            this.gp.Name = "gp";
            this.gp.Size = new System.Drawing.Size(698, 51);
            this.gp.TabIndex = 13;
            this.gp.TabStop = false;
            this.gp.Text = "考试信息";
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(255, 14);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(190, 21);
            this.txtCon.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "内容：";
            // 
            // cmType
            // 
            this.cmType.FormattingEnabled = true;
            this.cmType.Items.AddRange(new object[] {
            "考试场次",
            "考试名称",
            "考试备注"});
            this.cmType.Location = new System.Drawing.Point(73, 16);
            this.cmType.Name = "cmType";
            this.cmType.Size = new System.Drawing.Size(121, 20);
            this.cmType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "查询类别：";
            // 
            // btnQue
            // 
            this.btnQue.Location = new System.Drawing.Point(464, 14);
            this.btnQue.Name = "btnQue";
            this.btnQue.Size = new System.Drawing.Size(75, 23);
            this.btnQue.TabIndex = 0;
            this.btnQue.Text = "查询";
            this.btnQue.UseVisualStyleBackColor = true;
            this.btnQue.Click += new System.EventHandler(this.btnQue_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(33, 170);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dataView
            // 
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.type,
            this.Column1,
            this.gd_Name,
            this.lid});
            this.dataView.Location = new System.Drawing.Point(138, 66);
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Height = 23;
            this.dataView.Size = new System.Drawing.Size(572, 232);
            this.dataView.TabIndex = 12;
            // 
            // id
            // 
            this.id.HeaderText = "流水";
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // type
            // 
            this.type.HeaderText = "考试场次";
            this.type.Name = "type";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "考试名称";
            this.Column1.Name = "Column1";
            // 
            // gd_Name
            // 
            this.gd_Name.HeaderText = "考试日期";
            this.gd_Name.Name = "gd_Name";
            // 
            // lid
            // 
            this.lid.HeaderText = "备注";
            this.lid.Name = "lid";
            this.lid.Width = 200;
            // 
            // frmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 306);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRev);
            this.Controls.Add(this.gp);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.btnDel);
            this.Name = "frmExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试信息管理";
            this.Load += new System.EventHandler(this.frmExam_Load);
            this.gp.ResumeLayout(false);
            this.gp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.GroupBox gp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQue;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gd_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lid;
    }
}