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
            Text = "도서관 관리";

            label1.Text = "전체 도서의 수: " + DataManager.Books.Count.ToString();
            label2.Text = "사용자 수: " + DataManager.Users.Count.ToString();
            label3.Text = "대출 중인 도서의 수: " + DataManager.Books.Where((x) => x.IsBorrowed).Count().ToString();
            label4.Text = "연체 중인 도서의 수: " + DataManager.Books.Where((x) => { 
                return x.IsBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now; 
            }).Count().ToString();

            dataGridView1.DataSource = DataManager.Books;
            dataGridView2.DataSource = DataManager.Users;
            dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;
            dataGridView2.CurrentCellChanged += DataGridView2_CurrentCellChanged;
        }

        private void DataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
                tbNum.Text = book.Isbn;
                tbName.Text = book.Name;
            }
            catch (Exception err)
            {

            }
        }

        private void DataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                User book = dataGridView2.CurrentRow.DataBoundItem as User;
                tbId.Text = book.Id.ToString();
            }
            catch (Exception err)
            {

            }
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookManage().ShowDialog();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager.Books;
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserManage().ShowDialog();

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = DataManager.Users;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (tbNum.Text.Trim() == "")
                MessageBox.Show("Isbn을 입력해주세요");
            else if (tbId.Text.Trim() == "")
                MessageBox.Show("사용자 Id를 입력해주세요");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == tbNum.Text);
                    if (book.IsBorrowed)
                        MessageBox.Show("이미 대여 중인 도서입니다.");
                    else
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == tbId.Text);
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.IsBorrowed = true;
                        book.BorrowedAt = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Books;
                        DataManager.Save();

                        MessageBox.Show("\"" + book.Name + "\"" + "이/가 \"" + user.Name + "\"" + "님께 대여되었습니다.");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (tbNum.Text.Trim() == "")
                MessageBox.Show("Isbn을 입력해주세요");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == tbNum.Text);
                    if (book.IsBorrowed)
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == book.UserId.ToString());

                        book.UserId = 0;
                        book.UserName = "";
                        book.IsBorrowed = false;
                        book.BorrowedAt = new DateTime();

                        dataGridView1.DataSource = null;
                        dataGridView2.DataSource = DataManager.Books;
                        DataManager.Save();

                        if (book.BorrowedAt.AddDays(7) > DateTime.Now)
                            MessageBox.Show("\"" + book.Name + "\"이/가 연체 상태로 반납되었습니다.");
                        else
                            MessageBox.Show("\"" + book.Name + "\"이/가 반납되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("대여 상태가 아닙니다.");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }
            }
        }
    }
}
