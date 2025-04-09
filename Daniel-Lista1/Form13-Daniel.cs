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
    public partial class Form13_Daniel: Form
    {
        public Form13_Daniel()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double vl1, vl2, somQuad;

                vl1 = Convert.ToDouble(textBox1.Text);
                vl2 = Convert.ToDouble(textBox2.Text);

                somQuad = Math.Pow(vl1, 2) + Math.Pow(vl2, 2);

                label6.Text = somQuad.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite os valores necessários para a soma dos quadrados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
