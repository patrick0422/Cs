using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex10._06_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e) 
        {
            Graphics g = e.Graphics;

            g.DrawRectangle(new Pen(ForeColor), rect);
        }


        public bool dragging;

        Rectangle rect = new Rectangle();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            rect.X = e.X;
            rect.Y = e.Y;
            rect.Width = 0;
            rect.Height = 0;


            Invalidate();
            Text = $"X: {rect.X}, Y: {rect.Y}, Width: {rect.Width}, Height: {rect.Height}";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                rect.Width = e.X - rect.X;
                rect.Height = e.Y - rect.Y;

                Text = $"X: {rect.X}, Y: {rect.Y}, Width: {rect.Width}, Height: {rect.Height}";


                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

            rect.Width = e.X - rect.X;
            rect.Height = e.Y - rect.Y;

            Text = $"X: {rect.X}, Y: {rect.Y}, Width: {rect.Width}, Height: {rect.Height}";

            this.CreateGraphics().DrawRectangle(new Pen(ForeColor), rect);
        }
    }
}
