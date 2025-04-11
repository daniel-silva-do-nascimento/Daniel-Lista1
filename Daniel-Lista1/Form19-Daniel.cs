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
    public partial class Form19_Daniel: Form
    {
        public Form19_Daniel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dd, mm, aa;
                string aammdd;

                dd = Convert.ToInt32(textBox1.Text);
                mm = Convert.ToInt32(textBox2.Text);
                aa = Convert.ToInt32(textBox3.Text);

                aammdd = aa + "/" + mm + "/" + dd;

                label6.Text = aammdd.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite as datas necessárias para a conversão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
