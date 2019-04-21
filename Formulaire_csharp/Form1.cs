using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      private void label2_Click(object sender, EventArgs e)
        {

        }  

        private void nomber1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Somme deux nombres";
            this.BackColor = Color.Green;
            this.Size = new Size(300, 300);
            this.Location = new Point(300, 300);
            this.MaximizeBox = true;
            radio_multiplication.Checked = true;

        }

        private void textBox_num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void somme_Click(object sender, EventArgs e)
        {

        }

        private void textBox_somme_TextChanged(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                int boxone = Convert.ToInt32(textBox_num1.Text);
            }
           

            catch (Exception)
            {
                MessageBox.Show("verfier le champ 1 ");
            }
            try
            {
                int boxtwo = Convert.ToInt32(textBox_num2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("verfier le champ 2 ");
            }
            if (radio_multiplication.Checked == true)
            {
                textBox_somme.Text = (Convert.ToInt32(textBox_num1.Text) * Convert.ToInt32(textBox_num2.Text)).ToString();
            }
            else if (radio_soustractions.Checked == true)
            {
                textBox_somme.Text = (Convert.ToInt32(textBox_num1.Text) - Convert.ToInt32(textBox_num2.Text)).ToString();
            }
            else if (radio_division.Checked == true)
            {
                try
                {
                    textBox_somme.Text = (Convert.ToInt32(textBox_num1.Text) / Convert.ToInt32(textBox_num2.Text)).ToString();

                }
                catch (Exception)
                {
                    MessageBox.Show("en ne devise pas sur zero");
                }
            }
            else
            {
                textBox_somme.Text = (Convert.ToInt32(textBox_num1.Text) + Convert.ToInt32(textBox_num2.Text)).ToString();

            }
        }

        private void effacer_Click(object sender, EventArgs e)
        {
            textBox_num1.Clear();
            textBox_num2.Clear();
            textBox_somme.Clear();
            radio_multiplication.Checked = true;

        }

        private void quitter_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void radio_soustractions_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_multiplication_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radio_division_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_sommation_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
