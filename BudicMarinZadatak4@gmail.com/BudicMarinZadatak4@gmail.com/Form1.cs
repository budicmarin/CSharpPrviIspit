using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudicMarinZadatak4_gmail.com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonZbroj_Click(object sender, EventArgs e)
        {
            int value1 = 0;
            int value2 = 0;
            
            

            if (int.TryParse(textBoxPrviBroj.Text, out value1))
            {

                if (int.TryParse(textBoxDrugiBroj.Text, out value2))
                {
                    string rezultat = value1 + "+" + value2 + "=" + (value1 + value2);
                    DialogResult result = MessageBox.Show(rezultat," Upotreba Windows formi",MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        textBoxPrviBroj.Text = " ";
                        textBoxDrugiBroj.Text = " ";
                    }
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

        private void ButtonUmnožak_Click(object sender, EventArgs e)
        {
            int value1 = 0;
            int value2 = 0;



            if (int.TryParse(textBoxPrviBroj.Text, out value1))
            {

                if (int.TryParse(textBoxDrugiBroj.Text, out value2))
                {
                    string rezultat = value1 + "*" + value2 + "=" + (value1 *value2);
                    DialogResult result = MessageBox.Show(rezultat, " Upotreba Windows formi", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        textBoxPrviBroj.Text = " ";
                        textBoxDrugiBroj.Text = " ";
                    }
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

        private void ButtonRazlika_Click(object sender, EventArgs e)
        {
            int value1 = 0;
            int value2 = 0;



            if (int.TryParse(textBoxPrviBroj.Text, out value1))
            {

                if (int.TryParse(textBoxDrugiBroj.Text, out value2))
                {
                    string rezultat = value1 + "-" + value2 + "=" + (value1 - value2);
                    DialogResult result = MessageBox.Show(rezultat, " Upotreba Windows formi", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        textBoxPrviBroj.Text = " ";
                        textBoxDrugiBroj.Text = " ";
                    }
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

        private void ButtonKoeficijent_Click(object sender, EventArgs e)
        {
            int value1 = 0;
            int value2 = 0;



            if (int.TryParse(textBoxPrviBroj.Text, out value1))
            {

                if (int.TryParse(textBoxDrugiBroj.Text, out value2))
                {
                    string rezultat = value1 + "/" + value2 + "=" + ((double)value1 /(double) value2);
                    DialogResult result = MessageBox.Show(rezultat, " Upotreba Windows formi", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        textBoxPrviBroj.Text = " ";
                        textBoxDrugiBroj.Text = " ";
                    }
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

        private void TextBoxPrviBroj_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxDrugiBroj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
