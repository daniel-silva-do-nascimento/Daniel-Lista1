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
    public partial class Form3_Daniel : Form
    {
        public Form3_Daniel()
        {
            InitializeComponent();
        }

        private void Form3_Daniel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valorHora, valorDesconto, totalDesconto, salarioLiquido, salarioBruto, horasTrabalho;

                horasTrabalho = Convert.ToDouble(textBox3.Text);
                valorHora = Convert.ToDouble(textBox1.Text);
                valorDesconto = Convert.ToDouble(textBox2.Text);

                salarioBruto = horasTrabalho * valorHora;
                totalDesconto = (valorDesconto / 100) * salarioBruto;
                salarioLiquido = salarioBruto - totalDesconto;

                salarioLiquido = Math.Round(salarioLiquido, 2);
                salarioBruto = Math.Round(salarioBruto, 2);
                totalDesconto = Math.Round(totalDesconto, 2);



                label11.Text = "R$" + salarioBruto.ToString();
                label12.Text = "R$" + salarioLiquido.ToString();
                label13.Text = "R$" + totalDesconto.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite os valores necessários para a conversão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
