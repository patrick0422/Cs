﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex09._6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = -256;
        private void Form1_Click(object sender, EventArgs e)
        {
            i = i < 512 ? i += 256 : 0;
            MessageBox.Show(
                "MessageBoxDefaultButton", 
                "Title Bar", 
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                (MessageBoxDefaultButton)i);
        }
    }
}