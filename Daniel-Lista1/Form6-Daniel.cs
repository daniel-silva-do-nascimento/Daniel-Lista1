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
    public partial class Form6_Daniel : Form
    {
        public Form6_Daniel()
        {
            InitializeComponent();
        }

        private void Form6_Daniel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double raio, volO, alt, volL;

                raio = Convert.ToDouble(textBox1.Text);
                alt = Convert.ToDouble(textBox2.Text);
                volO = 3.14159;

                volL = volO * (raio * raio) * alt;

                label4.Text = volL.ToString();
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
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
