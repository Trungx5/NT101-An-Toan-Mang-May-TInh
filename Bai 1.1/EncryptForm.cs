using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1._1
{
    public partial class EncryptForm : Form
    {
        public EncryptForm()
        {
            InitializeComponent();
        }
        private string CaesarCipherEncrypt(string plainText, int shift)
        {
            string cipherText = "";
            foreach (char c in plainText)
            {
                if (char.IsLetter(c))
                {
                    char d = char.IsUpper(c) ? 'A' : 'a';
                    cipherText += (char)((((c + shift) - d) % 26) + d);
                }
                else
                {
                    cipherText += c;
                }
            }
            return cipherText;
        }
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string plainText = PlainTextTextBox.Text;
            int Key = int.Parse(KeyTextBox.Text);
            ResultTextBox.Text = CaesarCipherEncrypt(plainText, Key);
        }
    }
}
