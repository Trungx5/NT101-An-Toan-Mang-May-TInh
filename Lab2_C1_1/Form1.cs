using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace Lab2_C1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bit8PrimeButton_Click(object sender, EventArgs e)
        {
            PrimeListBox.Items.Add(GenerateRandomPrime(8));
        }

        private static BigInteger Sqrt(BigInteger number)
        {
            if (number == 0) return 0;
            BigInteger n = (number / 2) + 1;
            BigInteger n1 = (n + (number / n)) / 2;
            while (n1 < n)
            {
                n = n1;
                n1 = (n + (number / n)) / 2;
            }
            return n;
        }

        private static bool IsPrime(BigInteger number)
        {
            if (number < 2) return false;
            for (BigInteger i = 2; i <= Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        private static BigInteger GenerateRandomPrime(int bitLength)
        {
            Random rand = new Random();
            BigInteger prime;
            do
            {
                prime = BigInteger.Pow(2, bitLength - 1) + rand.Next();
            } while (!IsPrime(prime));
            return prime;
        }


        private static BigInteger ModularExponentiation(BigInteger baseNum, BigInteger exponent, BigInteger modulus)
        {
            BigInteger result = 1;
            baseNum = baseNum % modulus;
            while (exponent > 0)
            {
                if ((exponent % 2) == 1)
                {
                    result = (result * baseNum) % modulus;
                }
                exponent = exponent >> 1;
                baseNum = (baseNum * baseNum) % modulus;
            }
            return result;
        }

        private void Bit16PrimeButton_Click_1(object sender, EventArgs e)
        {
            PrimeListBox.Items.Add(GenerateRandomPrime(16));
        }

        private void Bit64PrimeButton_Click_1(object sender, EventArgs e)
        {
            PrimeListBox.Items.Add(GenerateRandomPrime(64));
        }

        private void CheckPrimeButton_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(CheckPrimeTextBox.Text, out int number) && number < 289)
            {
                TrueFalseTextBox.Text = IsPrime(number) ? "True" : "False";
            }
            else
            {
                TrueFalseTextBox.Text = "Invalid input";
            }
        }

        private void GCDCalcButton_Click_1(object sender, EventArgs e)
        {
            if (BigInteger.TryParse(FirstNumberTextBox.Text, out BigInteger num1) &&
                BigInteger.TryParse(SecondNumberTextBox.Text, out BigInteger num2))
            {
                MessageBox.Show($"GCD: {BigInteger.GreatestCommonDivisor(num1, num2)}");
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void ModularCheckButton_Click_1(object sender, EventArgs e)
        {
            if (BigInteger.TryParse(BaseNumberTextBox.Text, out BigInteger baseNum) &&
                BigInteger.TryParse(ExponentTextBox.Text, out BigInteger exponent) &&
                BigInteger.TryParse(ModulusTextBox.Text, out BigInteger modulus))
            {
                ResultModularTextBox.Text = ModularExponentiation(baseNum, exponent, modulus).ToString();
            }
            else
            {
                ResultModularTextBox.Text = "Invalid input";
            }
        }
    }
}
