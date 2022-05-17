namespace invigilateMIS
{
    partial class tcMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tcMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsInv = new System.Windows.Forms.ToolStripButton();
            this.txtExist = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tsAdmin = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUser,
            this.tsInv,
            this.txtExist});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(537, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsUser
            // 
            this.tsUser.Image = ((System.Drawing.Image)(resources.GetObject("tsUser.Image")));
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(76, 22);
            this.tsUser.Text = "个人信息";
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.tsAdmin);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 314);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(46, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "    退出";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.txtExist_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(257, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 61);
            this.button4.TabIndex = 5;
            this.button4.Text = "     监考信息管理";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.tsInv_Click);
            // 
            // tsAdmin
            // 
            this.tsAdmin.BackColor = System.Drawing.Color.Transparent;
            this.tsAdmin.FlatAppearance.BorderSize = 0;
            this.tsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsAdmin.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tsAdmin.Image")));
            this.tsAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsAdmin.Location = new System.Drawing.Point(40, 53);
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(146, 61);
            this.tsAdmin.TabIndex = 0;
            this.tsAdmin.Text = "    个人信息";
            this.tsAdmin.UseVisualStyleBackColor = false;
            this.tsAdmin.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tcMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 344);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "tcMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教员主界面";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsInv;
        private System.Windows.Forms.ToolStripButton txtExist;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button tsAdmin;
        public System.Windows.Forms.Button button1;
    }
}