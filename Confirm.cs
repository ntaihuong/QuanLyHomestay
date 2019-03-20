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
        QuanLyHomestayEntities db;
        public Confirm(HOADON obj)
        {
            InitializeComponent();
            db = new QuanLyHomestayEntities();
            bindingSource1.DataSource = obj;
            
            LOAIPHONG p = (from i in db.LOAIPHONGs where i.MaLoaiPhong == obj.MaLoaiPhong select i).FirstOrDefault();
            textBox1.Text = p.TenLoaiPhong;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
