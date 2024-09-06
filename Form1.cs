using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetRandomNumber();
        }

        public int RandomNumber{ get; set; }

        private void GetRandomNumber()
        {
            Random rnd = new Random();
            RandomNumber = rnd.Next(11, 89);
            start_textbox.Text = RandomNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox2.Text) == RandomNumber - 10 && Convert.ToInt32(textBox4.Text) == RandomNumber + 10 && Convert.ToInt32(textBox3.Text) == RandomNumber + 1 && Convert.ToInt32(textBox5.Text) == RandomNumber - 1)
            {
                MessageBox.Show("Tillykke du har klaret spillet");
            }
            else
            {
                MessageBox.Show("Du har tabt");
            }

            RestartGame();
        }

        private void RestartGame()
        {
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;

            GetRandomNumber();
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
