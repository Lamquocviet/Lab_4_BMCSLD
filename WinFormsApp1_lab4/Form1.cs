using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace WinFormsApp1_lab4
{
    public partial class frmLogin : Form
    {
        string connStr = "Data Source=.;Initial Catalog=QLSV_Lab4;Integrated Security=True;Trust Server Certificate=True";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblTenDa_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string manv = txtUsername.Text.Trim();
            string mk = txtPassword.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV=@manv AND CONVERT(VARCHAR(MAX), MATKHAU)=@mk";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@mk", mk);

                int kq = (int)cmd.ExecuteScalar();

                if (kq > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");

                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
