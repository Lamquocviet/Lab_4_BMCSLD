namespace WinFormsApp1_lab4
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            passwoe = new Label();
            TenDangNhap = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(524, 261);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 11;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(316, 261);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(303, 179);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(315, 27);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(303, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(315, 27);
            txtUsername.TabIndex = 8;
            // 
            // passwoe
            // 
            passwoe.AutoSize = true;
            passwoe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwoe.Location = new Point(105, 175);
            passwoe.Name = "passwoe";
            passwoe.Size = new Size(102, 28);
            passwoe.TabIndex = 7;
            passwoe.Text = "Mật khẩu";
            // 
            // TenDangNhap
            // 
            TenDangNhap.AutoSize = true;
            TenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenDangNhap.Location = new Point(105, 98);
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.Size = new Size(152, 28);
            TenDangNhap.TabIndex = 6;
            TenDangNhap.Text = "Tên đăng nhập";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(passwoe);
            Controls.Add(TenDangNhap);
            Name = "frmLogin";
            Text = "Đăng nhập";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label passwoe;
        private Label TenDangNhap;
    }
}
