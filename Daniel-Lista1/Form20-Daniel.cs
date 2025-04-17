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
    public partial class Form20_Daniel: Form
    {
        public Form20_Daniel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int seme, ano, matri;
                string semeano;

                ano = Convert.ToInt32(textBox1.Text);
                seme = Convert.ToInt32(textBox2.Text);
                matri = Convert.ToInt32(textBox3.Text);

                semeano = ano + " e " + seme;

                label6.Text = semeano;
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite os valores necessários para a apresentação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form20_Daniel_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
