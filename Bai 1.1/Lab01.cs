using Bai_6._1;
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
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void Bai01_button_Click(object sender, EventArgs e)
        {
            Bai01 bai01 = new Bai01();
            bai01.Show();
        }

        private void Bai06_Button_Click(object sender, EventArgs e)
        {
            Bai06 bai06 = new Bai06();
            bai06.Show();
        }
    }
}
