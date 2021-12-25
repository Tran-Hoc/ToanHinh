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
    public partial class Tamgiac : Form
    {
        public Tamgiac()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

     

      

        private void btnGiaiDT1_Click(object sender, EventArgs e)
        {
            GiaiTamGiac tg = new GiaiTamGiac();
            tg.tentamgiac = tentamgiac.Text;
            tg.tencanhday = tencanhday.Text;
            tg.tenduongcao = tenduongcao.Text;
            tg.dodaiduongcao = Double.Parse(txtDaiCao.Text);
            tg.dodaicanhday = Double.Parse(txtDaiDay.Text);
            var str = string.Format("\nCho tam giác {0}\n Có đường cao {1} và độ dài là {2} cm \nCó cạnh đáy {3} và độ dài là{4} cm \nDiện tích là {5} cm2", tg.tentamgiac, tg.tenduongcao, tg.dodaiduongcao, tg.tencanhday, tg.dodaicanhday, tg.dienTichCaoDay());
            textBox1.Text = str;
            // ljkdhflafhaldhalsk
        }

        private void Tamgiac_Load(object sender, EventArgs e)
        {

        }
    }
}
