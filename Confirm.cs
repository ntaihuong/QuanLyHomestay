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

        public Confirm(HOADON obj)
        {
            InitializeComponent();
            bindingSourceHoaDon.DataSource = obj;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Load(object sender, EventArgs e)
        {

        }
    }
}
