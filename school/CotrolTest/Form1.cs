using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotrolTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = checkBoxFun();
            if (rbMale.Checked)
                label4.Text = "성별: 남";
            else
                label4.Text = "성별: 여";

            string s = "혈액형: BLOOD_";
            if (rbA.Checked)
                label5.Text = s + "A";
            else if (rbB.Checked)
                label5.Text = s + "B";
            else if (rbO.Checked)
                label5.Text = s + "O";
            else if (rbAB.Checked)
                label5.Text = s + "AB";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBoxCar.Checked = false;
            checkBoxHouse.Checked = false;
            rbMale.Checked = true;
            rbA.Checked = true;

            button1_Click(null, null);
        }

        private void checkBoxCar_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = checkBoxFun();
        }

        private void checkBoxHouse_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = checkBoxFun();
        }

        private string checkBoxFun()
        {
            string s = "";

            if (checkBoxCar.Checked)
                s += "자동차 소유, ";
            else
                s += "자동차 없음, ";

            if (checkBoxHouse.Checked)
                s += "집 소유";
            else
                s += "집 없음";

            return s;
        }
    }
}
