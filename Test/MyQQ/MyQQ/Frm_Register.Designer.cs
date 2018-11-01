namespace MyQQ
{
    partial class Frm_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Register));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.grpDetials = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblStar = new System.Windows.Forms.Label();
            this.cboxBlooadType = new System.Windows.Forms.ComboBox();
            this.cboxStar = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBaseInfo = new System.Windows.Forms.GroupBox();
            this.rbtnFamale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.lblPwdAgain = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblNiceName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPwdAgain = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtNiceName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpDetials.SuspendLayout();
            this.grpBaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(95, 310);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(220, 160);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 21);
            this.textBox5.TabIndex = 13;
            // 
            // grpDetials
            // 
            this.grpDetials.BackColor = System.Drawing.Color.Transparent;
            this.grpDetials.Controls.Add(this.txtName);
            this.grpDetials.Controls.Add(this.lblName);
            this.grpDetials.Controls.Add(this.lblBloodType);
            this.grpDetials.Controls.Add(this.lblStar);
            this.grpDetials.Controls.Add(this.cboxBlooadType);
            this.grpDetials.Controls.Add(this.cboxStar);
            this.grpDetials.Location = new System.Drawing.Point(114, 206);
            this.grpDetials.Margin = new System.Windows.Forms.Padding(2);
            this.grpDetials.Name = "grpDetials";
            this.grpDetials.Padding = new System.Windows.Forms.Padding(2);
            this.grpDetials.Size = new System.Drawing.Size(259, 116);
            this.grpDetials.TabIndex = 17;
            this.grpDetials.TabStop = false;
            this.grpDetials.Text = "选填详细资料";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 22);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 21);
            this.txtName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "真实姓名";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(47, 82);
            this.lblBloodType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(29, 12);
            this.lblBloodType.TabIndex = 20;
            this.lblBloodType.Text = "血型";
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Location = new System.Drawing.Point(47, 54);
            this.lblStar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(29, 12);
            this.lblStar.TabIndex = 19;
            this.lblStar.Text = "星座";
            // 
            // cboxBlooadType
            // 
            this.cboxBlooadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBlooadType.FormattingEnabled = true;
            this.cboxBlooadType.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cboxBlooadType.Location = new System.Drawing.Point(82, 79);
            this.cboxBlooadType.Margin = new System.Windows.Forms.Padding(2);
            this.cboxBlooadType.Name = "cboxBlooadType";
            this.cboxBlooadType.Size = new System.Drawing.Size(142, 20);
            this.cboxBlooadType.TabIndex = 9;
            // 
            // cboxStar
            // 
            this.cboxStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStar.FormattingEnabled = true;
            this.cboxStar.Items.AddRange(new object[] {
            "♈",
            "♉",
            "♊",
            "♋",
            "♌",
            "♍",
            "♎",
            "♏",
            "♐",
            "♑",
            "♒",
            "♓"});
            this.cboxStar.Location = new System.Drawing.Point(82, 50);
            this.cboxStar.Margin = new System.Windows.Forms.Padding(2);
            this.cboxStar.MaxDropDownItems = 12;
            this.cboxStar.Name = "cboxStar";
            this.cboxStar.Size = new System.Drawing.Size(142, 20);
            this.cboxStar.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(234, 326);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(63, 23);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(303, 326);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpBaseInfo
            // 
            this.grpBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpBaseInfo.Controls.Add(this.rbtnFamale);
            this.grpBaseInfo.Controls.Add(this.rbtnMale);
            this.grpBaseInfo.Controls.Add(this.lblPwdAgain);
            this.grpBaseInfo.Controls.Add(this.lblPwd);
            this.grpBaseInfo.Controls.Add(this.lblNiceName);
            this.grpBaseInfo.Controls.Add(this.lblAge);
            this.grpBaseInfo.Controls.Add(this.lblSex);
            this.grpBaseInfo.Controls.Add(this.txtAge);
            this.grpBaseInfo.Controls.Add(this.txtPwdAgain);
            this.grpBaseInfo.Controls.Add(this.txtPwd);
            this.grpBaseInfo.Controls.Add(this.txtNiceName);
            this.grpBaseInfo.Location = new System.Drawing.Point(114, 10);
            this.grpBaseInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpBaseInfo.Name = "grpBaseInfo";
            this.grpBaseInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpBaseInfo.Size = new System.Drawing.Size(259, 180);
            this.grpBaseInfo.TabIndex = 20;
            this.grpBaseInfo.TabStop = false;
            this.grpBaseInfo.Text = "注册基本信息";
            // 
            // rbtnFamale
            // 
            this.rbtnFamale.AutoSize = true;
            this.rbtnFamale.Location = new System.Drawing.Point(133, 85);
            this.rbtnFamale.Name = "rbtnFamale";
            this.rbtnFamale.Size = new System.Drawing.Size(35, 16);
            this.rbtnFamale.TabIndex = 4;
            this.rbtnFamale.Text = "女";
            this.rbtnFamale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point(82, 85);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(35, 16);
            this.rbtnMale.TabIndex = 3;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "男";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // lblPwdAgain
            // 
            this.lblPwdAgain.AutoSize = true;
            this.lblPwdAgain.Location = new System.Drawing.Point(23, 147);
            this.lblPwdAgain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPwdAgain.Name = "lblPwdAgain";
            this.lblPwdAgain.Size = new System.Drawing.Size(53, 12);
            this.lblPwdAgain.TabIndex = 21;
            this.lblPwdAgain.Text = "重复密码";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(47, 119);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(29, 12);
            this.lblPwd.TabIndex = 20;
            this.lblPwd.Text = "密码";
            // 
            // lblNiceName
            // 
            this.lblNiceName.AutoSize = true;
            this.lblNiceName.Location = new System.Drawing.Point(47, 30);
            this.lblNiceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNiceName.Name = "lblNiceName";
            this.lblNiceName.Size = new System.Drawing.Size(29, 12);
            this.lblNiceName.TabIndex = 19;
            this.lblNiceName.Text = "昵称";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(47, 60);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 12);
            this.lblAge.TabIndex = 18;
            this.lblAge.Text = "年龄";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(47, 87);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 17;
            this.lblSex.Text = "性别";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(82, 56);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(42, 21);
            this.txtAge.TabIndex = 2;
            // 
            // txtPwdAgain
            // 
            this.txtPwdAgain.Location = new System.Drawing.Point(82, 143);
            this.txtPwdAgain.Margin = new System.Windows.Forms.Padding(2);
            this.txtPwdAgain.Name = "txtPwdAgain";
            this.txtPwdAgain.PasswordChar = '*';
            this.txtPwdAgain.Size = new System.Drawing.Size(142, 21);
            this.txtPwdAgain.TabIndex = 6;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(82, 115);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(142, 21);
            this.txtPwd.TabIndex = 5;
            // 
            // txtNiceName
            // 
            this.txtNiceName.Location = new System.Drawing.Point(85, 26);
            this.txtNiceName.Margin = new System.Windows.Forms.Padding(2);
            this.txtNiceName.Name = "txtNiceName";
            this.txtNiceName.Size = new System.Drawing.Size(142, 21);
            this.txtNiceName.TabIndex = 1;
            // 
            // Frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 353);
            this.Controls.Add(this.grpBaseInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpDetials);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "申请账号";
            this.Load += new System.EventHandler(this.Frm_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpDetials.ResumeLayout(false);
            this.grpDetials.PerformLayout();
            this.grpBaseInfo.ResumeLayout(false);
            this.grpBaseInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox grpDetials;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpBaseInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.ComboBox cboxBlooadType;
        private System.Windows.Forms.ComboBox cboxStar;
        private System.Windows.Forms.Label lblPwdAgain;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblNiceName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPwdAgain;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtNiceName;
        private System.Windows.Forms.RadioButton rbtnFamale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.TextBox txtName;
    }
}