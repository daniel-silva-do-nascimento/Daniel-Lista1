using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daniel_Lista1
{
    public partial class Form9_Daniel : Form
    {
        public Form9_Daniel()
        {
            InitializeComponent();
        }

        private void Form9_Daniel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, C, D, AmB, AmC, AmD, BmC, BmD, CmD, AxB, AxC, AxD, BxC, BxD, CxD;

            A = Convert.ToDouble(textBox1.Text);
            B = Convert.ToDouble(textBox2.Text);
            C = Convert.ToDouble(textBox3.Text);
            D = Convert.ToDouble(textBox4.Text);

            AmB = A + B;
            AmC = A + C;
            AmD = A + D;
            BmC = B + C;
            BmD = B + D;
            CmD = C + D;

            AxB = A * B;
            AxC = A * C;
            AxD = A * D;
            BxC = B * C;
            BxD = B * D;
            CxD = C * D;

            label6.Text = AmB.ToString();
            label13.Text = AmC.ToString();
            label14.Text = AmD.ToString();
            label16.Text = BmC.ToString();
            label11.Text = BmD.ToString();
            label10.Text = CmD.ToString();
            label22.Text = AxB.ToString();
            label19.Text = AxC.ToString();
            label18.Text = AxD.ToString();
            label28.Text = BxC.ToString();
            label25.Text = BxD.ToString();
            label24.Text = CxD.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            label6.Text = "";
            label13.Text = "";
            label14.Text = "";
            label16.Text = "";
            label11.Text = "";
            label10.Text = "";
            label22.Text = "";
            label19.Text = "";
            label18.Text = "";
            label28.Text = "";
            label25.Text = "";
            label24.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
