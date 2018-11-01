namespace SqlServerConn
{
    partial class FormConn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.btnCS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAlt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据库";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(42, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(41, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "密  码";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(127, 10);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(223, 25);
            this.txtServer.TabIndex = 1;
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(127, 175);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '*';
            this.txtPWD.Size = new System.Drawing.Size(223, 25);
            this.txtPWD.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(127, 123);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(223, 25);
            this.txtUserName.TabIndex = 3;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(127, 66);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(223, 25);
            this.txtDB.TabIndex = 2;
            // 
            // btnCS
            // 
            this.btnCS.Location = new System.Drawing.Point(45, 221);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(117, 28);
            this.btnCS.TabIndex = 5;
            this.btnCS.Text = "测试连接(&T)";
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "保存(&S)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAlt
            // 
            this.BtnAlt.Location = new System.Drawing.Point(168, 221);
            this.BtnAlt.Name = "BtnAlt";
            this.BtnAlt.Size = new System.Drawing.Size(89, 28);
            this.BtnAlt.TabIndex = 7;
            this.BtnAlt.Text = "修改(&A)";
            this.BtnAlt.UseVisualStyleBackColor = true;
            this.BtnAlt.Click += new System.EventHandler(this.BtnAlt_Click);
            // 
            // FormConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 269);
            this.Controls.Add(this.BtnAlt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCS);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConn";
            this.Text = "SqlServerConnection";
            this.Load += new System.EventHandler(this.FormConn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAlt;
    }
}

