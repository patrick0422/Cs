using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex08._7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font("굴림", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font("굴림", 9F, FontStyle.Underline, GraphicsUnit.Point, ((byte)(129)));
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font("굴림", 9F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(129)));
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font("굴림", 9F, FontStyle.Strikeout, GraphicsUnit.Point, ((byte)(129)));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        }
    }
}
