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
    public partial class Form12_Daniel: Form
    {
        public Form12_Daniel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vl1, vl2, quadSom;

            vl1 = Convert.ToDouble(textBox1.Text);
            vl2 = Convert.ToDouble(textBox2.Text);

            quadSom = Math.Pow((vl1 + vl2), 2);
            label6.Text = quadSom.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
