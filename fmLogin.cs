using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomestayApp
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K8S89SB\SQLEXPRESS;Initial Catalog=QuanLyHomestay;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtUserName.Text;
                string mk = txtPassWord.Text;
                string sql = " Select * from TAIKHOAN where TaiKhoan='"+tk+"' and MatKhau='"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng đăng nhập lại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
    }
}
