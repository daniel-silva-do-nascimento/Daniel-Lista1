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
    public partial class Form14_Daniel: Form
    {
        public Form14_Daniel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Val1, Val2;
                double Media;

                Val1 = Convert.ToInt32(textBox1.Text);
                Val2 = Convert.ToInt32(textBox2.Text);

                Media = (Val1 + Val2) / 2;

                label6.Text = Media.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite os valores necessários para a média", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
