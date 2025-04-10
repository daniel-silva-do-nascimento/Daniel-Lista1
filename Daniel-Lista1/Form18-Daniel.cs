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
    public partial class Form18_Daniel : Form
    {
        public Form18_Daniel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                double slB, slL, desc10;
                int div10, div5;

                slB = Convert.ToDouble(textBox1.Text);
                div10 = 10;
                div5 = 5;


                desc10 = slB *  div10 / 100;

                slL = desc10 * div5 / 100;

                label6.Text = slL.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite os valores necessários para o cálculo de desconto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}
