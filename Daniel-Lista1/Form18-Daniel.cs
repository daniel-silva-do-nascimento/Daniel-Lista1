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
    public partial class Form18_Daniel : Form
    {
        public Form18_Daniel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double slB, slL, desc10;

            slB = Convert.ToDouble(textBox1.Text);

            desc10 = slB * (10 / 100);

            slL = desc10 * (5 / 100);

            label6.Text = slL.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
