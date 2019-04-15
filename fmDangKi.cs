using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomestayApp
{
    public partial class fmDangKi : Form
    {
        QuanLyHomestayEntities db;
        public fmDangKi()
        {
            InitializeComponent();
            db = new QuanLyHomestayEntities();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {

            if (Register.checkMK(txtMatKhau.Text, txtXNMK.Text) == false)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng", "Thông báo", MessageBoxButtons.OKCancel);

            }
            else if (Register.checkTK(txtTaikhoan.Text) != true)
            {
                TAIKHOAN tk = new TAIKHOAN();
                tk.HoTen = txtHoten.Text;
                tk.Email = txtEmail.Text;
                tk.Matkhau = txtMatKhau.Text;
                tk.TaiKhoan1 = txtTaikhoan.Text;
                tk.Phone = txtPhone.Text;
                if (txtMatKhau.TextLength < 8 || txtMatKhau.TextLength > 16)
                {
                    MessageBox.Show("Mật khẩu quá ngắn, mật khẩu tối thiểu là 8 kí tự và tối đa là 15 kí tự. \n\n Xin vui lòng nhập lại mật khẩu.", "", MessageBoxButtons.OKCancel);
                    txtMatKhau.Focus();
                }
                else
                if (Register.addNew(db, tk))
                {
                    MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OKCancel);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công. \n\nXin vui lòng đăng ký lai.", "Thông báo", MessageBoxButtons.OKCancel);
                }

            }
            else
            {
                MessageBox.Show("Tài khoản này hiện đã tồn tại. \n\nXin vui lòng nhập tài khoản khác.", "Thông báo", MessageBoxButtons.OKCancel);
            }

        }
    }
}
