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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Vraio, pi, area;
                Vraio = Convert.ToDouble(textBox1.Text);
                pi = 3.14159;

                area = (Vraio*2) * pi;

                label5.Text = area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite o valor do raio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
