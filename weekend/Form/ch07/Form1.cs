using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bringToFront_Click(object sender, EventArgs e)
        {
            button2.BringToFront();
        }

        private void sendToBack_Click(object sender, EventArgs e)
        {
            button2.SendToBack();
        }
    }
}
