using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex09._6_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowApply = checkBox1.Checked ? true : false;
            fontDialog1.ShowColor = checkBox2.Checked ? true : false;

            fontDialog1.ShowDialog();
        }
    }
}
