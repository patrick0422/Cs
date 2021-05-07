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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = double.Parse(textBox1.Text.Trim());
            double weight = double.Parse(textBox2.Text.Trim());

            double result = weight / (height * height);

            labelResult.Text = "당신의 BMI는 " + result.ToString() + "입니다.";
        }
    }
}
