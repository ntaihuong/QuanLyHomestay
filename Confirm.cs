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
    public partial class Confirm : Form
    {
        HOADON hd;
        QuanLyHomestayEntities db;
        string status;
        public Confirm(HOADON obj,string status)
        {
            InitializeComponent();
            db = new QuanLyHomestayEntities();
            lOAIPHONGBindingSource.DataSource = db.LOAIPHONGs.ToList();
            if(status.Equals("add"))
            {
                bindingSource1.DataSource = obj;
                hd = obj;
                LOAIPHONG p = (from i in db.LOAIPHONGs where i.MaLoaiPhong == obj.MaLoaiPhong select i).FirstOrDefault();
                textBox1.Text = p.TenLoaiPhong;
                this.status = status;
            }
            else if (status.Equals("edit"))
            {
                bindingSource1.DataSource = obj;
                hd = obj;
                db.HOADONs.Attach(hd);              
                unlock();
                this.status = status;
            }
        }

        public Confirm()
        {
        }

        private void unlock()
        {
            textBox1.Enabled = false;
            textBox1.Visible = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            btnXoa.Visible = true;
            comboBox1.Visible = true;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(status.Equals("add"))
            {
                if (DatPhong.addnewHoaDon(db, hd))
                    MessageBox.Show("Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi. Xin quý khách ghi nhớ mã hóa đơn để tiện cho việc nhận phòng. \n\n Mã hóa đơn của bạn là: " + hd.MaHoaDon, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Đặt phòng không thành công.");
                this.Close();
            }        
            else
            {
                hd.MaLoaiPhong = comboBox1.SelectedValue.ToString();
                hd.GiaTien = textBox4.Text;
                MessageBox.Show("Bạn đã đổi phòng thành công.");
            }
            db.SaveChanges();
            this.Close();          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PHONG p = (from i in db.PHONGs where i.MaLoaiPhong == comboBox1.SelectedValue.ToString() select i).FirstOrDefault();
            if(p!=null)
            textBox4.Text = p.GiaPhong.ToString();
            else
            {
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DatPhong.deletePhong(db, hd);
            MessageBox.Show("Bạn đã xóa phòng thành công.");
            this.Close();
        }
    }
}
