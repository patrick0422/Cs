using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex08._7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String result = "";
            int temp = Int32.Parse(textBox1.Text);

            result += temp;

            /*while (temp >= 0)
            {
                result += (temp % 2).ToString();
                temp /= 2;
            }*/

            textBox2.Text = result;
        }
    }
}
