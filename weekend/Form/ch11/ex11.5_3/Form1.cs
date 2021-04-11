using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex11._5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString();

            changeColor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar2.Value.ToString();

            changeColor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar3.Value.ToString();

            changeColor();
        }

        private void changeColor()
        {
            label1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value); 
        }
    }
}
