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
    public partial class Form11_Daniel: Form
    {
        public Form11_Daniel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valor, quad, cub;

                valor = Convert.ToDouble(textBox1.Text);

                quad = valor * valor;
                cub = valor * (valor * valor);

                label6.Text = quad.ToString();
                label7.Text = cub.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite os valores necessários para o cálculo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label6.Text = "";
            label7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form11_Daniel_Load(object sender, EventArgs e)
        {

        }
    }
}
