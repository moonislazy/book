namespace book
{
    partial class Login
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
            this.label_account = new System.Windows.Forms.Label();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.txt_passwd = new System.Windows.Forms.TextBox();
            this.label_passwd = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_account.Location = new System.Drawing.Point(95, 89);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(52, 21);
            this.label_account.TabIndex = 0;
            this.label_account.Text = "账号";
            // 
            // txt_account
            // 
            this.txt_account.Location = new System.Drawing.Point(168, 85);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(222, 28);
            this.txt_account.TabIndex = 1;
            // 
            // txt_passwd
            // 
            this.txt_passwd.Location = new System.Drawing.Point(168, 150);
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.PasswordChar = '*';
            this.txt_passwd.Size = new System.Drawing.Size(222, 28);
            this.txt_passwd.TabIndex = 3;
            // 
            // label_passwd
            // 
            this.label_passwd.AutoSize = true;
            this.label_passwd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_passwd.Location = new System.Drawing.Point(95, 154);
            this.label_passwd.Name = "label_passwd";
            this.label_passwd.Size = new System.Drawing.Size(52, 21);
            this.label_passwd.TabIndex = 2;
            this.label_passwd.Text = "密码";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.Location = new System.Drawing.Point(204, 208);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(87, 43);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 295);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_passwd);
            this.Controls.Add(this.label_passwd);
            this.Controls.Add(this.txt_account);
            this.Controls.Add(this.label_account);
            this.Name = "Login";
            this.Text = "图书管理系统-登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_account;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.TextBox txt_passwd;
        private System.Windows.Forms.Label label_passwd;
        private System.Windows.Forms.Button btn_login;
    }
}

