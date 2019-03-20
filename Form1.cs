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
    public partial class Form1 : Form
    { 
        QuanLyHomestayEntities db = new QuanLyHomestayEntities();
        string extention = ".jpg";
        string path = "C:\\Users\\Huong\\Documents\\GitHub\\QuanLyHomestay";

        public Form1()
        {
            InitializeComponent();
            init();
            comboBox2.SelectedValueChanged += comboBox2_SelectedValueChanged;
        }

        public void init()
        {
            lOAIPHONGBindingSource.DataSource = (from i in db.LOAIPHONGs select i).ToList();
            //comboBox2.DataSource = (from i in db.LOAIPHONGs select i.MaLoaiPhong).ToList();
            //comboBox2.DisplayMember = "TenLoaiPhong";
        }

        void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null)
            {
                string pathI=path+ "\\Resources\\" + comboBox2.SelectedValue.ToString() + extention;
                Bitmap bm = new Bitmap(pathI);
                pictureBox1.Image = bm;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            fmLogin frm = new fmLogin();
            frm.ShowDialog();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            fmDangKi frm = new fmDangKi();
            frm.ShowDialog();
        }
        private HOADON Picked(string MaLoaiPhong,DateTime NgayDen,DateTime NgayDi)
        {
            HOADON hd = new HOADON();
            hd.NgayDen = NgayDen;
            hd.NgayDi = NgayDi;
            hd.SoTienDatTruoc = 0;
            PHONG p = (from i in db.PHONGs where MaLoaiPhong == i.MaLoaiPhong select i).FirstOrDefault();
            hd.GiaTien = p.GiaPhong.ToString();
            hd.MaLoaiPhong = MaLoaiPhong;
            hd.DonVi = "VND";
            hd.MaHoaDon = NgayDen.ToString() + NgayDi.ToString();
            hd.NgayThanhToan = NgayDi;
            return hd;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            Confirm fm = new Confirm(Picked(comboBox2.SelectedValue.ToString(), dateTimePicker1.Value, dateTimePicker2.Value));
            fm.ShowDialog();
        }
    }
}
