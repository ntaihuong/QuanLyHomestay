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
    public partial class fmDanhGia : Form
    {
        QuanLyHomestayEntities db = new QuanLyHomestayEntities();
        public fmDanhGia()
        {
            InitializeComponent();
            reload();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void reload()
        {
            danhGiaBindingSource.DataSource = db.DANHGIAs.ToList();
            lOAIPHONGBindingSource.DataSource = db.LOAIPHONGs.ToList();
        }
        private void btnGui_Click(object sender, EventArgs e)
        {
            DANHGIA dg = new DANHGIA();
            dg.MaLoaiPhong = comboBox1.SelectedValue.ToString();
            dg.DanhGia1 = textBox1.Text;
            db.DANHGIAs.Add(dg);
            db.SaveChanges();
            MessageBox.Show("Cảm ơn bạn đã thực hiện đánh giá này.", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

      
    }
}
