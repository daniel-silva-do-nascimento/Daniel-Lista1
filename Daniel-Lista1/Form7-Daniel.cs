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
    public partial class Form7_Daniel : Form
    {
        public Form7_Daniel()
        {
            InitializeComponent();
        }
        double vViagem, tViagem, dViagem, luViagem;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
            label7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vViagem = Convert.ToDouble(textBox1.Text);
                tViagem = Convert.ToDouble(textBox2.Text);

                dViagem = vViagem * tViagem;

                label4.Text = dViagem.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite os valores necessários para o cálculo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            luViagem = dViagem / 12;
            label7.Text = luViagem.ToString();
        }
    }
}
