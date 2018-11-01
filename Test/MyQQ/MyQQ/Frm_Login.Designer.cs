namespace MyQQ
{
    partial class Frm_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.pBoxClose = new System.Windows.Forms.PictureBox();
            this.pBoxMin = new System.Windows.Forms.PictureBox();
            this.pBoxLogin = new System.Windows.Forms.PictureBox();
            this.linkLblReg = new System.Windows.Forms.LinkLabel();
            this.cboxRemember = new System.Windows.Forms.CheckBox();
            this.cboxAutoLogin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(135, 231);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(191, 22);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtID.Location = new System.Drawing.Point(135, 200);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // pBoxClose
            // 
            this.pBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pBoxClose.Location = new System.Drawing.Point(402, 1);
            this.pBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxClose.Name = "pBoxClose";
            this.pBoxClose.Size = new System.Drawing.Size(27, 28);
            this.pBoxClose.TabIndex = 2;
            this.pBoxClose.TabStop = false;
            this.pBoxClose.Click += new System.EventHandler(this.pBoxClose_Click);
            // 
            // pBoxMin
            // 
            this.pBoxMin.BackColor = System.Drawing.Color.Transparent;
            this.pBoxMin.Location = new System.Drawing.Point(375, 1);
            this.pBoxMin.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxMin.Name = "pBoxMin";
            this.pBoxMin.Size = new System.Drawing.Size(27, 28);
            this.pBoxMin.TabIndex = 3;
            this.pBoxMin.TabStop = false;
            this.pBoxMin.Click += new System.EventHandler(this.pBoxMin_Click);
            // 
            // pBoxLogin
            // 
            this.pBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pBoxLogin.Location = new System.Drawing.Point(135, 286);
            this.pBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxLogin.Name = "pBoxLogin";
            this.pBoxLogin.Size = new System.Drawing.Size(191, 33);
            this.pBoxLogin.TabIndex = 4;
            this.pBoxLogin.TabStop = false;
            this.pBoxLogin.Click += new System.EventHandler(this.pBoxLogin_Click);
            // 
            // linkLblReg
            // 
            this.linkLblReg.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLblReg.AutoSize = true;
            this.linkLblReg.Location = new System.Drawing.Point(343, 221);
            this.linkLblReg.Name = "linkLblReg";
            this.linkLblReg.Size = new System.Drawing.Size(53, 12);
            this.linkLblReg.TabIndex = 5;
            this.linkLblReg.TabStop = true;
            this.linkLblReg.Text = "申请账号";
            this.linkLblReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblReg_LinkClicked);
            // 
            // cboxRemember
            // 
            this.cboxRemember.AutoSize = true;
            this.cboxRemember.Location = new System.Drawing.Point(135, 260);
            this.cboxRemember.Name = "cboxRemember";
            this.cboxRemember.Size = new System.Drawing.Size(72, 16);
            this.cboxRemember.TabIndex = 3;
            this.cboxRemember.Text = "记住密码";
            this.cboxRemember.UseVisualStyleBackColor = true;
            this.cboxRemember.CheckedChanged += new System.EventHandler(this.cboxRemember_CheckedChanged);
            // 
            // cboxAutoLogin
            // 
            this.cboxAutoLogin.AutoSize = true;
            this.cboxAutoLogin.Location = new System.Drawing.Point(254, 260);
            this.cboxAutoLogin.Name = "cboxAutoLogin";
            this.cboxAutoLogin.Size = new System.Drawing.Size(72, 16);
            this.cboxAutoLogin.TabIndex = 4;
            this.cboxAutoLogin.Text = "自动登陆";
            this.cboxAutoLogin.UseVisualStyleBackColor = true;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(432, 331);
            this.Controls.Add(this.cboxAutoLogin);
            this.Controls.Add(this.cboxRemember);
            this.Controls.Add(this.linkLblReg);
            this.Controls.Add(this.pBoxLogin);
            this.Controls.Add(this.pBoxMin);
            this.Controls.Add(this.pBoxClose);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q友登录";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.PictureBox pBoxClose;
        private System.Windows.Forms.PictureBox pBoxMin;
        private System.Windows.Forms.PictureBox pBoxLogin;
        private System.Windows.Forms.LinkLabel linkLblReg;
        private System.Windows.Forms.CheckBox cboxRemember;
        private System.Windows.Forms.CheckBox cboxAutoLogin;
    }
}

