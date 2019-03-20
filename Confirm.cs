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
        public Confirm(HOADON obj,string status)
        {
            InitializeComponent();
            db = new QuanLyHomestayEntities();
            bindingSource1.DataSource = obj;
            hd = obj;
            LOAIPHONG p = (from i in db.LOAIPHONGs where i.MaLoaiPhong == obj.MaLoaiPhong select i).FirstOrDefault();
            textBox1.Text = p.TenLoaiPhong;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            db.HOADONs.Add(hd);
            db.SaveChanges();
            this.Close();
        }

    }
}
