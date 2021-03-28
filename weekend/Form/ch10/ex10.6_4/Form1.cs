using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex10._6_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pen pen = new Pen(DefaultForeColor);

        private void radioButtonBlack_CheckedChanged(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void radioButtonPurple_CheckedChanged(object sender, EventArgs e)
        {
            pen.Color = Color.Purple;
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
        }

        bool drawing = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }
    }
}
