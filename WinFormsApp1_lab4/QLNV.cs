using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1_lab4
{
    public partial class QLNV : Form
    {
        string connStr = "Data Source=.;Initial Catalog=QLSV_Lab4;Integrated Security=True;Trust Server Certificate=True";

        RSACryptoServiceProvider rsa;
        string publicKey;
        string privateKey;

        public QLNV()
        {
            InitializeComponent();
            dgvEmployeeList.CellClick += dgvEmployeeList_CellClick;


            rsa = new RSACryptoServiceProvider(2048);
            publicKey = rsa.ToXmlString(false);
            privateKey = rsa.ToXmlString(true);
        }

        // ================= SHA1 =================
        public static byte[] HashSHA1(string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }

        // ================= ENCRYPT =================
        public byte[] EncryptLuong(string luong)
        {
            RSACryptoServiceProvider rsaTemp = new RSACryptoServiceProvider();
            rsaTemp.FromXmlString(publicKey);

            return rsaTemp.Encrypt(Encoding.UTF8.GetBytes(luong), false);
        }

        // ================= DECRYPT =================
        public string DecryptLuong(byte[] data)
        {
            try
            {
                RSACryptoServiceProvider rsaTemp = new RSACryptoServiceProvider();
                rsaTemp.FromXmlString(privateKey);

                return Encoding.UTF8.GetString(
                    rsaTemp.Decrypt(data, false)
                );
            }
            catch
            {
                return "ERROR";
            }
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // ================= LOAD =================
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SP_SEL_NHANVIEN", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (!dt.Columns.Contains("LUONG_DISPLAY"))
                    dt.Columns.Add("LUONG_DISPLAY", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    try
                    {
                        if (row["LUONG"] != DBNull.Value)
                        {
                            byte[] enc = (byte[])row["LUONG"];
                            row["LUONG_DISPLAY"] = DecryptLuong(enc);
                        }
                        else
                        {
                            row["LUONG_DISPLAY"] = "";
                        }
                    }
                    catch
                    {
                        row["LUONG_DISPLAY"] = "ERROR";
                    }
                }

                dgvEmployeeList.DataSource = dt;

                dgvEmployeeList.Columns["LUONG"].Visible = false;

                if (dgvEmployeeList.Columns["LUONG_DISPLAY"] != null)
                    dgvEmployeeList.Columns["LUONG_DISPLAY"].HeaderText = "LƯƠNG";
            }
        }
        // ================= CLICK ROW (FIX) =================
        private void dgvEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvEmployeeList.Rows[e.RowIndex];

                txtId.Text = row.Cells["MANV"].Value?.ToString();
                txtName.Text = row.Cells["HOTEN"].Value?.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value?.ToString();
                txtUsername.Text = row.Cells["TENDN"].Value?.ToString();

                txtSaraly.Text = row.Cells["LUONG_DISPLAY"].Value?.ToString();
            }
        }
        private void ClearForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtSaraly.Clear();

            txtId.Focus();
        }

        // ================= ADD =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            byte[] mkHash = HashSHA1(txtPassword.Text);
            byte[] luongEnc = EncryptLuong(txtSaraly.Text);

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_INS_PUBLIC_ENCRYPT_NHANVIEN", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MANV", txtId.Text);
                cmd.Parameters.AddWithValue("@HOTEN", txtName.Text);
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);

                cmd.Parameters.Add("@LUONG", SqlDbType.VarBinary).Value = luongEnc;
                cmd.Parameters.AddWithValue("@TENDN", txtUsername.Text);
                cmd.Parameters.Add("@MK", SqlDbType.VarBinary).Value = mkHash;
                cmd.Parameters.AddWithValue("@PUB", "KEY_" + txtId.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Thêm thành công!");
            LoadData();
            ClearForm();
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SP_DELETE_NHANVIEN", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = txtId.Text;

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Xóa thành công!");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        // ================= UPDATE =================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            byte[] mkHash = HashSHA1(txtPassword.Text);
            byte[] luongEnc = EncryptLuong(txtSaraly.Text);

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SP_UPDATE_NHANVIEN", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = txtId.Text;
                    cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = txtName.Text;
                    cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = txtEmail.Text;
                    cmd.Parameters.Add("@TENDN", SqlDbType.NVarChar).Value = txtUsername.Text;
                    cmd.Parameters.Add("@MK", SqlDbType.VarBinary).Value = mkHash;
                    cmd.Parameters.Add("@LUONG", SqlDbType.VarBinary).Value = luongEnc;

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật thành công!");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi update: " + ex.Message);
            }
        }

        private void dgvEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployeeList.Rows[e.RowIndex];

                txtId.Text = row.Cells["MANV"].Value.ToString();
                txtName.Text = row.Cells["HOTEN"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtUsername.Text = row.Cells["TENDN"].Value.ToString();
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}