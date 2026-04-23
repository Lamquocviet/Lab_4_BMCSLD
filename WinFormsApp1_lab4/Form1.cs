using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace WinFormsApp1_lab4
{
    public partial class frmLogin : Form
    {
        string connStr = "Data Source=.;Initial Catalog=QLSV_Lab4;Integrated Security=True;Trust Server Certificate=True";

    public static byte[] HashSHA1(string input)
    {
        using (SHA1 sha1 = SHA1.Create())
        {
            return sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
        }
    }
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
            string manv = txtUsername.Text.Trim(); // 👉 dùng MANV
            string mk = txtPassword.Text.Trim();

            // 🔐 Hash mật khẩu ở client
            byte[] mkHash = HashSHA1(mk);

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_SEL_PUBLIC_ENCRYPT_NHANVIEN", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MANV", manv);
                cmd.Parameters.AddWithValue("@MK", mkHash);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //string hoten = reader["HOTEN"].ToString();

                    MessageBox.Show("Đăng nhập thành công!\nXin chào");

                    // 👉 chuyển form nếu cần
                    QLNV f = new QLNV();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mã nhân viên hoặc mật khẩu!");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
