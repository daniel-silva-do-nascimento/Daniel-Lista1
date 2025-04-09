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
    public partial class Form16_Daniel : Form
    {
        public Form16_Daniel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double kmh, ms;

                kmh = Convert.ToDouble(textBox1.Text);

                ms = kmh / 3.6;

                label6.Text = ms.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite os valores necessários para a conversão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
