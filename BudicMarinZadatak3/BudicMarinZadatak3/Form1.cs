using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudicMarinZadatak3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonZbir_Click(object sender, EventArgs e)
        {
            int value1=0;
            int value2 = 0;

            if (int.TryParse(textBox1.Text, out value1))
            {

                if (int.TryParse(textBox2.Text, out value2))
                {
                    MessageBox.Show("Zbroj je "+(value1+value2));
                }
                else
                {
                    MessageBox.Show("Nisi upisao broj");
                }
            }
            else
            {
                MessageBox.Show("Nisi upisao broj");
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
