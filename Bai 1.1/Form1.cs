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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            EncryptForm encryptForm = new EncryptForm();
            encryptForm.Show();
        }

        private void Bruteforce_button_Click(object sender, EventArgs e)
        {
            BruteForceDecypt bruteForceDecypt = new BruteForceDecypt();
            bruteForceDecypt.Show();
           
        }
    }
}
