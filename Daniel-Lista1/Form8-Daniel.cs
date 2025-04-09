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
    public partial class Form8_Daniel : Form
    {
        public Form8_Daniel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            label6.Text = "";
            label7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double vl1, vl2, troca1, troca2;

                vl1 = Convert.ToDouble(textBox1.Text);
                vl2 = Convert.ToDouble(textBox2.Text);

                troca1 = vl2;
                troca2 = vl1;

                vl2 = troca2;
                vl1 = troca1;

                label6.Text = vl1.ToString();
                label7.Text = vl2.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite os valores necessários para o cálculo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
