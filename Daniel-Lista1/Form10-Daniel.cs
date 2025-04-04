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
    public partial class Form10_Daniel : Form
    {
        public Form10_Daniel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alt, larg, comp, vol;

            alt = Convert.ToDouble(textBox1.Text);
            larg = Convert.ToDouble(textBox2.Text);
            comp = Convert.ToDouble(textBox3.Text);

            vol = alt * larg * comp;

            label6.Text = vol.ToString();
        }
    }
}
