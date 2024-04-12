using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        private string wordToGuess = "computer";
        private StringBuilder wrongG = new StringBuilder();

        public frmGuessWord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guess = textBox2.Text.ToLower();
            if (guess == wordToGuess)

            {
                label1.Text = "Correct answer: " + wordToGuess;
                MessageBox.Show("Correct guess!");
            }
            else
            {
                listBox1.Items.Add(guess);
                MessageBox.Show(" Wrong guess! \n Try again.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "c??????r";
            textBox1.Focus();
        }
    }
}
