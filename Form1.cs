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
            comboBox2.DataSource = (from i in db.LOAIPHONGs select i.MaLoaiPhong).ToList();
            comboBox2.DisplayMember = "TenLoaiPhong";
        }
        void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null)
            {
                string pathI = path + "\\Resources\\" + comboBox2.SelectedValue.ToString() + extention;

                Bitmap bm = new Bitmap(pathI);
                pictureBox1.Image = bm;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            fmLogin frm = new fmLogin();
            frm.ShowDialog();

        }

    
    }
}
