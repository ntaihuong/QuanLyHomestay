﻿using System;
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
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public void init()
        {
            lOAIPHONGBindingSource.DataSource = (from i in db.LOAIPHONGs select i).ToList();
        }

        void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            LOAIPHONG lp = (from i in db.LOAIPHONGs where i.MaLoaiPhong == comboBox2.SelectedValue select i).FirstOrDefault();
            if (comboBox2.SelectedValue != null)
            {
                string pathI = path + "\\Resources\\" + comboBox2.SelectedValue.ToString() + extention;
                Bitmap bm = new Bitmap(pathI);
                pictureBox1.Image = bm;
                txtthongtin.Text = lp.TrangBi;
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
        private HOADON Picked(string MaLoaiPhong, DateTime NgayDen, DateTime NgayDi)
        {
            int maso = (from i in db.HOADONs select i).Count();
            HOADON hd = new HOADON();
            hd.NgayDen = NgayDen;
            hd.NgayDi = NgayDi;
            hd.SoTienDatTruoc = 0;
            PHONG p = (from i in db.PHONGs where MaLoaiPhong == i.MaLoaiPhong select i).FirstOrDefault();
            hd.GiaTien = p.GiaPhong.ToString();
            hd.MaLoaiPhong = MaLoaiPhong;
            hd.DonVi = "VND";
            hd.MaHoaDon = RandomString(5) + MaLoaiPhong;
            hd.NgayThanhToan = NgayDi;
            //hd.StringCode = RandomString(8);
            return hd;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            HOADON hd = Picked(comboBox2.SelectedValue.ToString(), dateTimePicker1.Value, dateTimePicker2.Value);
            Confirm fm = new Confirm(hd, "add");
            if (fm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HOADON hd = (from i in db.HOADONs where i.MaHoaDon == txtFind.Text select i).FirstOrDefault();
            Confirm fm = new Confirm(hd, "edit");
            if (fm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
