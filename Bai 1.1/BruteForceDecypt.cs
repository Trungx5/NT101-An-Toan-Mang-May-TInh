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
    public partial class BruteForceDecypt : Form
    {
        public BruteForceDecypt()
        {
            InitializeComponent();
        }
        
        private string CaesarCipherDecrypt(string cipherText, int shift)
        {
            string plainText = "";
            foreach (char c in cipherText)
            {
                if (char.IsLetter(c))
                {
                    char d = char.IsUpper(c) ? 'A' : 'a';
                    plainText += (char)((((c - shift) - d + 26) % 26) + d);
                }
                else
                {
                    plainText += c;
                }
            }
            return plainText;
        }

        private void Bruteforce_button_Click(object sender, EventArgs e)
        {
            string cipherText = EncryptedTextBox.Text;
            string plainText = "";
            for(int i = 0; i < 26; i++)
            {
                plainText = CaesarCipherDecrypt(cipherText, i);
                AllPlainTextBox.Items.Add(plainText);

            }
        }

        private void AllPlainTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AllPlainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(AllPlainTextBox.SelectedItem.ToString());
            }
        }
    }
}
