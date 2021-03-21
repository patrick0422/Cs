using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEventApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateEventLabels("(ListBox)DoubleClick", e.X, e.Y, e);
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            UpdateEventLabels("(ListBox)DoubleClick", mousePoint.X, mousePoint.Y, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateEventLabels(string msg, int x, int y, MouseEventArgs e)
        {
            string message = string.Format($"{msg} X:{x}, Y:{y}");
            string eventMsg = DateTime.Now.ToShortDateString();
            eventMsg += " " + message;
            listBox1.Items.Insert(0, eventMsg);
            listBox1.TopIndex = 0;

            string mouseInfo;
            if (e != null)
            {
                mouseInfo = string.Format($"Clicks: {e.Clicks}, Delta: {e.Delta}, Buttons: {e.Button}");
            } 
            else
            {
                mouseInfo = string.Format($"Clicks: {msg}");
            }
            label1.Text = mouseInfo;
        }
    }
}
