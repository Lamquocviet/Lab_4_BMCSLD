namespace WinFormsApp1_lab4
{
    partial class QLNV
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
            btnEdit = new Button();
            btnAdd = new Button();
            txtPassword = new TextBox();
            txtSaraly = new TextBox();
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtId = new TextBox();
            lblPassword = new Label();
            lblSaraly = new Label();
            btnExit = new Button();
            groupBox3 = new GroupBox();
            btnDelete = new Button();
            lblName = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            llbId = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(515, 26);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(19, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(615, 97);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(287, 27);
            txtPassword.TabIndex = 11;
            // 
            // txtSaraly
            // 
            txtSaraly.Location = new Point(615, 65);
            txtSaraly.Name = "txtSaraly";
            txtSaraly.Size = new Size(287, 27);
            txtSaraly.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(615, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 27);
            txtName.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(172, 100);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(283, 27);
            txtUsername.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(172, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(283, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(172, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(283, 27);
            txtId.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(486, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Mật khẩu";
            // 
            // lblSaraly
            // 
            lblSaraly.AutoSize = true;
            lblSaraly.Location = new Point(486, 65);
            lblSaraly.Name = "lblSaraly";
            lblSaraly.Size = new Size(51, 20);
            lblSaraly.TabIndex = 4;
            lblSaraly.Text = "Lương";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(800, 26);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExit);
            groupBox3.Controls.Add(btnEdit);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new Point(14, 241);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(944, 61);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(292, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AccessibleRole = AccessibleRole.None;
            lblName.Location = new Point(486, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Họ tên";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(46, 65);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(46, 100);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(107, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // llbId
            // 
            llbId.AutoSize = true;
            llbId.Location = new Point(46, 32);
            llbId.Name = "llbId";
            llbId.Size = new Size(54, 20);
            llbId.TabIndex = 0;
            llbId.Text = "Mã NV";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(-11, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(970, 331);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(933, 218);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtSaraly);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(lblSaraly);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(llbId);
            groupBox1.Location = new Point(-11, -24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(970, 141);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // QLNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QLNV";
            Text = "QLNV";
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtPassword;
        private TextBox txtSaraly;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtId;
        private Label lblPassword;
        private Label lblSaraly;
        private Button btnExit;
        private GroupBox groupBox3;
        private Button btnDelete;
        private Label lblName;
        private Label lblEmail;
        private Label lblUsername;
        private Label llbId;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
    }
}