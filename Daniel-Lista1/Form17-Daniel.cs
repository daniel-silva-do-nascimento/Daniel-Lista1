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
    public partial class Form17_Daniel : Form
    {
        public Form17_Daniel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int int1, int2;
                double resto, quo;

                int1 = Convert.ToInt32(textBox1.Text);
                int2 = Convert.ToInt32(textBox2.Text);

                quo = int1 / int2;
                resto = int1 % int2;

                label6.Text = quo.ToString();
                label4.Text = resto.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite os valores necessários para a conversão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label6.Text = "";
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
