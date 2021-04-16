using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace guessinggame
{
    public partial class GuessingGame : Form
    {
        public GuessingGame()
        {
            InitializeComponent();
        }

        private void GuessingGame_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GuessBox_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(GuessBox.Text);

            Random rnd = new Random();
            int number = rnd.Next(100);
            if (guess > number)
            {

            }
            else if (guess < number)
            {

            }

            else if (guess == number)
            {
                // Correct
            }

            else
            {
               // error, unknown number
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
