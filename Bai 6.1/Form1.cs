using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //made Affine Cipher Encrypt
        private void Affine_Cipher()
        {
            string plainText = PlainText_TextBox.Text;
            int a = int.Parse(Key1_TextBox.Text);
            int b = int.Parse(Key2_TextBox.Text);
            string cipherText = "";
            foreach (char c in plainText)
            {
                if (char.IsLetter(c))
                {
                    char ch = char.ToUpper(c);
                    ch = (char)(((a * (ch - 'A') + b) % 26) + 'A');
                    cipherText += ch;
                }
                else
                {
                    cipherText += c;
                }
            }
            CipherText_TextBox.Text = cipherText;
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            Affine_Cipher();
        }
    }
}
