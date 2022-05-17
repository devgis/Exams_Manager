namespace invigilateMIS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAdmin1 = new System.Windows.Forms.ToolStripButton();
            this.tsName1 = new System.Windows.Forms.ToolStripButton();
            this.tsExam = new System.Windows.Forms.ToolStripButton();
            this.tsTeacher = new System.Windows.Forms.ToolStripButton();
            this.tsInv = new System.Windows.Forms.ToolStripButton();
            this.tsInvM = new System.Windows.Forms.ToolStripButton();
            this.txtExist = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tsName = new System.Windows.Forms.Button();
            this.tsAdmin = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdmin1,
            this.tsName1,
            this.tsExam,
            this.tsTeacher,
            this.tsInv,
            this.tsInvM,
            this.txtExist});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(688, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsAdmin1
            // 
            this.tsAdmin1.Image = ((System.Drawing.Image)(resources.GetObject("tsAdmin1.Image")));
            this.tsAdmin1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdmin1.Name = "tsAdmin1";
            this.tsAdmin1.Size = new System.Drawing.Size(76, 22);
            this.tsAdmin1.Text = "用户管理";
            this.tsAdmin1.Click += new System.EventHandler(this.tsAdmin_Click);
            // 
            // tsName1
            // 
            this.tsName1.Image = ((System.Drawing.Image)(resources.GetObject("tsName1.Image")));
            this.tsName1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsName1.Name = "tsName1";
            this.tsName1.Size = new System.Drawing.Size(76, 22);
            this.tsName1.Text = "考试名称";
            this.tsName1.Click += new System.EventHandler(this.tsName_Click);
            // 
            // tsExam
            // 
            this.tsExam.Image = ((System.Drawing.Image)(resources.GetObject("tsExam.Image")));
            this.tsExam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExam.Name = "tsExam";
            this.tsExam.Size = new System.Drawing.Size(76, 22);
            this.tsExam.Text = "考试管理";
            this.tsExam.Click += new System.EventHandler(this.tsExam_Click);
            // 
            // tsTeacher
            // 
            this.tsTeacher.Image = ((System.Drawing.Image)(resources.GetObject("tsTeacher.Image")));
            this.tsTeacher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTeacher.Name = "tsTeacher";
            this.tsTeacher.Size = new System.Drawing.Size(76, 22);
            this.tsTeacher.Text = "教员管理";
            this.tsTeacher.Click += new System.EventHandler(this.tsTeacher_Click);
            // 
            // tsInv
            // 
            this.tsInv.Image = ((System.Drawing.Image)(resources.GetObject("tsInv.Image")));
            this.tsInv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsInv.Name = "tsInv";
            this.tsInv.Size = new System.Drawing.Size(100, 22);
            this.tsInv.Text = "监考信息管理";
            this.tsInv.Click += new System.EventHandler(this.tsInv_Click);
            // 
            // tsInvM
            // 
            this.tsInvM.Image = ((System.Drawing.Image)(resources.GetObject("tsInvM.Image")));
            this.tsInvM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsInvM.Name = "tsInvM";
            this.tsInvM.Size = new System.Drawing.Size(64, 22);
            this.tsInvM.Text = "监考表";
            this.tsInvM.Click += new System.EventHandler(this.tsInvM_Click);
            // 
            // txtExist
            // 
            this.txtExist.Image = ((System.Drawing.Image)(resources.GetObject("txtExist.Image")));
            this.txtExist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtExist.Name = "txtExist";
            this.txtExist.Size = new System.Drawing.Size(52, 22);
            this.txtExist.Text = "退出";
            this.txtExist.Click += new System.EventHandler(this.txtExist_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tsName);
            this.panel1.Controls.Add(this.tsAdmin);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 314);
            this.panel1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(520, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 61);
            this.button6.TabIndex = 7;
            this.button6.Text = "   监考表";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.tsInvM_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(343, 178);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 61);
            this.button5.TabIndex = 6;
            this.button5.Text = "     退出";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.txtExist_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(325, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 61);
            this.button4.TabIndex = 5;
            this.button4.Text = "      监考信息管理";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.tsInv_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(166, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "      教员管理";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.tsTeacher_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(170, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "    考试管理";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.tsExam_Click);
            // 
            // tsName
            // 
            this.tsName.BackColor = System.Drawing.Color.Transparent;
            this.tsName.FlatAppearance.BorderSize = 0;
            this.tsName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsName.Image = ((System.Drawing.Image)(resources.GetObject("tsName.Image")));
            this.tsName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsName.Location = new System.Drawing.Point(3, 178);
            this.tsName.Name = "tsName";
            this.tsName.Size = new System.Drawing.Size(148, 67);
            this.tsName.TabIndex = 1;
            this.tsName.Text = "       考试名称";
            this.tsName.UseVisualStyleBackColor = false;
            this.tsName.Click += new System.EventHandler(this.tsName_Click);
            // 
            // tsAdmin
            // 
            this.tsAdmin.BackColor = System.Drawing.Color.Transparent;
            this.tsAdmin.FlatAppearance.BorderSize = 0;
            this.tsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsAdmin.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tsAdmin.Image")));
            this.tsAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsAdmin.Location = new System.Drawing.Point(12, 46);
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(152, 61);
            this.tsAdmin.TabIndex = 0;
            this.tsAdmin.Text = "      用户管理";
            this.tsAdmin.UseVisualStyleBackColor = false;
            this.tsAdmin.Click += new System.EventHandler(this.tsAdmin_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教务管理员主界面";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAdmin1;
        private System.Windows.Forms.ToolStripButton tsExam;
        private System.Windows.Forms.ToolStripButton tsTeacher;
        private System.Windows.Forms.ToolStripButton tsInv;
        private System.Windows.Forms.ToolStripButton txtExist;
        private System.Windows.Forms.ToolStripButton tsName1;
        private System.Windows.Forms.ToolStripButton tsInvM;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button tsAdmin;
        private System.Windows.Forms.Button tsName;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button5;
    }
}