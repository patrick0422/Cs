using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Font = new Font("맑은고딕", 12f, FontStyle.Bold);
        }

        bool a = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (a)
            {
                label1.Text = "Hello World!";
                label1.ForeColor = Color.Blue;
                label1.BackColor = Color.Red;
                a = !a;
            }
            else
            {
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.Transparent;
                a = !a;
            }
        }
    }
}
