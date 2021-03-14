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
        bool bold, underLine, italic, strikeOut;

        public Form1()
        {
            InitializeComponent();

            bold = underLine = italic = strikeOut = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Font font = new Font(label3.Font, label3.Font.Style | FontStyle.Bold);
                label3.Font = font;
            }
            else
            {
                Font font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Bold);
                label3.Font = font;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Font font = new Font(label3.Font, label3.Font.Style | FontStyle.Underline);
                label3.Font = font;
            }
            else
            {
                Font font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Underline);
                label3.Font = font;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Font font = new Font(label3.Font, label3.Font.Style | FontStyle.Italic);
                label3.Font = font;
            }
            else
            {
                Font font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Italic);
                label3.Font = font;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Font font = new Font(label3.Font, label3.Font.Style | FontStyle.Strikeout);
                label3.Font = font;
            }
            else
            {
                Font font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Strikeout);
                label3.Font = font;
            }
        }
        private void changeFont()
        {
            label3.Font = new Font("굴림", 9F, 
                (bold ? FontStyle.Bold : FontStyle.Regular) |
                (underLine ? FontStyle.Underline : FontStyle.Regular) |
                (italic ? FontStyle.Italic : FontStyle.Regular) |
                (strikeOut ? FontStyle.Strikeout : FontStyle.Regular),

                GraphicsUnit.Point, (byte)129);
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
