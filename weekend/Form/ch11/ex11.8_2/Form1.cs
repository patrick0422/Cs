using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex11._8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll(); 
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            TreeNodeCollection items = treeView1.SelectedNode.Nodes; 
            if (items != null)
            {
                foreach (TreeNode item in items)
                {
                    listView1.Items.Add(item.Text + "\r\n");
                }
            }
        }
    }
}
