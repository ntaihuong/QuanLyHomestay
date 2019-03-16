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
        public Form1()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            comboBox2.DataSource = (from i in db.LOAIPHONGs select i).ToList();
            comboBox2.DisplayMember = "TenLoaiPhong";
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
