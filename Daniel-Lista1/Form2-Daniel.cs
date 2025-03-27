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
    public partial class Form2_Daniel : Form
    {
        public Form2_Daniel()
        {
            InitializeComponent();
        }

        private void Form2_Daniel_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1, n2, result;

                n1 = Convert.ToInt32(textBox1.Text);
                n2 = Convert.ToInt32(textBox2.Text);

                result = n1 + n2;

                label4.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite os valores necessários", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
