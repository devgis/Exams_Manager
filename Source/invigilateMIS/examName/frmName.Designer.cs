namespace invigilateMIS
{
    partial class frmName
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
            this.label2 = new System.Windows.Forms.Label();
            this.gp = new System.Windows.Forms.GroupBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtQue = new System.Windows.Forms.Button();
            this.txtDel = new System.Windows.Forms.Button();
            this.txtRev = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "名称：";
            // 
            // gp
            // 
            this.gp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp.Controls.Add(this.txtCon);
            this.gp.Controls.Add(this.label2);
            this.gp.Controls.Add(this.txtQue);
            this.gp.Location = new System.Drawing.Point(12, 9);
            this.gp.Name = "gp";
            this.gp.Size = new System.Drawing.Size(569, 51);
            this.gp.TabIndex = 7;
            this.gp.TabStop = false;
            this.gp.Text = "考试信息";
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(71, 16);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(100, 21);
            this.txtCon.TabIndex = 7;
            // 
            // txtQue
            // 
            this.txtQue.Location = new System.Drawing.Point(201, 16);
            this.txtQue.Name = "txtQue";
            this.txtQue.Size = new System.Drawing.Size(75, 23);
            this.txtQue.TabIndex = 0;
            this.txtQue.Text = "查询";
            this.txtQue.UseVisualStyleBackColor = true;
            this.txtQue.Click += new System.EventHandler(this.txtQue_Click);
            // 
            // txtDel
            // 
            this.txtDel.Location = new System.Drawing.Point(12, 131);
            this.txtDel.Name = "txtDel";
            this.txtDel.Size = new System.Drawing.Size(75, 23);
            this.txtDel.TabIndex = 3;
            this.txtDel.Text = "删除";
            this.txtDel.UseVisualStyleBackColor = true;
            this.txtDel.Click += new System.EventHandler(this.txtDel_Click);
            // 
            // txtRev
            // 
            this.txtRev.Location = new System.Drawing.Point(12, 160);
            this.txtRev.Name = "txtRev";
            this.txtRev.Size = new System.Drawing.Size(75, 23);
            this.txtRev.TabIndex = 2;
            this.txtRev.Text = "修改";
            this.txtRev.UseVisualStyleBackColor = true;
            this.txtRev.Click += new System.EventHandler(this.txtRev_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(12, 102);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(75, 23);
            this.txtAdd.TabIndex = 1;
            this.txtAdd.Text = "增加";
            this.txtAdd.UseVisualStyleBackColor = true;
            this.txtAdd.Click += new System.EventHandler(this.txtAdd_Click);
            // 
            // dataView
            // 
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.user_id});
            this.dataView.Location = new System.Drawing.Point(111, 66);
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Height = 23;
            this.dataView.Size = new System.Drawing.Size(471, 232);
            this.dataView.TabIndex = 6;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // user_id
            // 
            this.user_id.HeaderText = "考试名称";
            this.user_id.Name = "user_id";
            this.user_id.Width = 200;
            // 
            // id
            // 
            this.id.HeaderText = "流水";
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // frmName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 306);
            this.Controls.Add(this.gp);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtDel);
            this.Controls.Add(this.txtRev);
            this.Name = "frmName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试名称管理";
            this.Load += new System.EventHandler(this.frmName_Load);
            this.gp.ResumeLayout(false);
            this.gp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gp;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Button txtDel;
        private System.Windows.Forms.Button txtRev;
        private System.Windows.Forms.Button txtAdd;
        private System.Windows.Forms.Button txtQue;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
    }
}