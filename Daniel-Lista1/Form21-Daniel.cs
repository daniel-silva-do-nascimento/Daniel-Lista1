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
    public partial class Form21_Daniel: Form
    {
        public Form21_Daniel()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label7.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, sobre, nomComp;

                nome = Convert.ToString(textBox1.Text);
                sobre = Convert.ToString(textBox2.Text);

                nomComp = nome + " " + sobre;

                label7.Text = nomComp.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite o nome e/ou sobrenome faltante", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form21_Daniel_Load(object sender, EventArgs e)
        {

        }
    }
}
