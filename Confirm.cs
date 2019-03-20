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
    public partial class Confirm : Form
    {
        HOADON hd;
        QuanLyHomestayEntities db;
        string status;
        public Confirm(HOADON obj,string status)
        {
            InitializeComponent();
            db = new QuanLyHomestayEntities();
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
                LOAIPHONG p = (from i in db.LOAIPHONGs where i.MaLoaiPhong == obj.MaLoaiPhong select i).FirstOrDefault();
                unlock();
                textBox1.Text = p.TenLoaiPhong;
                this.status = status;
            }
        }
        private void unlock()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            btnXoa.Visible = true;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(status.Equals("add"))
            {
                db.HOADONs.Add(hd);
            }         
            db.SaveChanges();
            this.Close();
        }

    }
}
