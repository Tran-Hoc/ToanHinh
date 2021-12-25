using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToanHinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnTamgiac_Click_1(object sender, EventArgs e)
        {
            Tamgiac tg = new Tamgiac();
            tg.Show();
        }

        private void btnHinhvuong_Click(object sender, EventArgs e)
        {
            GiaiHinhVuong f = new GiaiHinhVuong();
            f.Show();
        }
    }
}
