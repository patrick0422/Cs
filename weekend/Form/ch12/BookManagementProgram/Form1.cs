using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementProgram
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            new Book();
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookManage().Show();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserManage().Show();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Borrow();
            MessageBox.Show("뭐시기가 대여되었습니다");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Return();
            MessageBox.Show("뭐시기가 반납되었습니다");
        }




        private void Borrow()
        {
            throw new NotImplementedException();
        }

        private void Return()
        {
            throw new NotImplementedException();
        }
    }
}
