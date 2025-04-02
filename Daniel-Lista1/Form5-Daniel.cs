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
    public partial class Form5_Daniel : Form
    {
        public Form5_Daniel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            double vF, vC;

                vF = Convert.ToDouble(textBox1.Text);

                vC = (9 * vF + 160) / 5;

                label4.Text = vC.ToString();
            } catch (FormatException)
            {
                MessageBox.Show("Digite os valores necessários para a conversão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
