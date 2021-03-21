using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex09._6_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = -1;
        private void Form1_Click(object sender, EventArgs e)
        {
            i = i < 5 ? ++i : 0;
            MessageBox.Show(i.ToString(), "Title", (MessageBoxButtons)i);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
