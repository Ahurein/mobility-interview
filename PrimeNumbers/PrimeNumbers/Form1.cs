using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbers
{
    public partial class Prime : Form
    {
        public Prime()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxTwo.Text, out int inputTwo))
            {
                MessageBox.Show("Please enter a digit!");
            }
            var data = GeneratePrime(inputTwo);
            listTwo.DataSource = data;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBoxOne.Text, out int inputOne))
            {
                MessageBox.Show("Please enter a digit!");
            }
            var data = GeneratePrime(inputOne);
            listOne.DataSource = data;

        }

        private List<int> GeneratePrime(int number)
        {
            List<int> primes = new List<int>();
            bool[] isComposite = new bool[number + 1];

            for (int i = 2; i <= number; i++)
            {
                if (!isComposite[i])
                {
                    primes.Add(i);

                    for (int j = i * 2; j <= number; j += i)
                    {
                        isComposite[j] = true;
                    }
                }
            }
            return primes;
        }
    }
}