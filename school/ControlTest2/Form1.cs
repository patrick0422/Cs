using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add1_Click(object sender, EventArgs e)
        {
            cbox.Items.Add(cbox.Text);

            lb_msg.Text = $"콤보 박스 항목 추가 {cbox.Text}";

            cbox.Text = "";
        }

        private void btn_remove1_Click(object sender, EventArgs e)
        {
            if (cbox.SelectedIndex == -1)
                return;

            string msg = $"체크 박스 - 삭제된 항목의 인덱스: {cbox.SelectedIndex} " + $" Text:{cbox.SelectedItem.ToString()}";

            cbox.Items.RemoveAt(cbox.SelectedIndex);
            lb_msg.Text = msg;
            cbox.Text = "";
        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            //1. 텍스트박스내용을 리스트박스에 내용을 추가한다.
            lbox_1.Items.Add(tbox_1.Text);
            //2. 메세지를 출력한다.
            lb_msg.Text = $"리스트 박스 항목 추가 {tbox_1.Text}";
            //3. 텍스트박스를 빈공간으로 만들어준다.
            tbox_1.Text = "";
        }

        private void btn_remove2_Click(object sender, EventArgs e)
        {
            //1선택항목이 없으면 삭제하지 않음.
            if (lbox_1.SelectedIndex == -1)
            {
                return;
            }

            //2. 선택 항목을 저장한다.-> 삭제하기 전에 표시할 수 없기 때문.
            string msg = $"리스트 박스 항목 삭제 인덱스:{lbox_1.SelectedIndex} " +
                $" Text:{lbox_1.SelectedIndex.ToString()}";

            //3. 선택항목을 삭제한다.
            cbox.Items.RemoveAt(lbox_1.SelectedIndex);

            lb_msg.Text = msg;
            //4. combobox를 빈공간으로 만들어준다.
            cbox.Text = "";
        }

        private void lbox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg;
            //선택 항목이 없을 때.
            if (lbox_1.SelectedIndex == -1)
            {
                msg = string.Format("리스트 박스 선택 항목이 없습니다.");
            }
            else
            {
                //변경된 항목 출력               
                msg = $"리스트 박스 선택 항목 변경 인덱스: {lbox_1.SelectedIndex} " + 
                    $" Text: { lbox_1.SelectedItem.ToString()}";
            }
            lb_msg.Text = msg;
        }

        private void btn_add3_Click(object sender, EventArgs e)
        {
            //1. 체크리스트에 내용을 추가한다.
            chbox.Items.Add(tbox_2.Text);
            //2. 메세지를 출력한다.
            lb_msg.Text = $"체크 리스트 박스 항목 추가 {tbox_2.Text}";
            //3. 텍스트박스를 빈공간으로 만들어준다.
            tbox_2.Text = "";

        }

        private void btn_remove3_Click(object sender, EventArgs e)
        {
            //1. 체크리스트에 항목이 없다면 아무런 행동을 하지 않는다. 
            if (chbox.SelectedIndex == -1)
            {
                return;
            }
            //2. 항목과 내용 출력
            string msg = $"체크 리스트 박스 선택 항목 삭제, 인덱스:{chbox.SelectedIndex} Text:{chbox.SelectedItem.ToString()}";
            //3. 항목 삭제
            chbox.Items.RemoveAt(chbox.SelectedIndex);
            lb_msg.Text = msg;
        }

        private void chbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.아무것도 선택되지 않았을때
            string msg;
            if (cbox.SelectedIndex == -1)
            {
                msg = string.Format("체크 박스 선택 항목이 없습니다.");
            }
            else
            {
                //2. 내용이 선택되었을때 
                msg = $"체크 박스 선택 항목 변경, 인덱스:{cbox.SelectedIndex} Text:{cbox.SelectedItem.ToString()}";

            }
            lb_msg.Text = msg;
        }

        private void btn_summary_Click(object sender, EventArgs e)
        {
            //리스트 박스 비워준다.
            lbox_2.Items.Clear();
            string str;

            str = $"콤보 박스 항목 개수:{cbox.Items.Count}";
            lbox_2.Items.Add(str);

            str = $"콤보 박스 선택 항목:{cbox.SelectedIndex}";
            lbox_2.Items.Add(str);

            str = $"리스트 박스 항목 개수:{lbox_1.Items.Count}";
            lbox_2.Items.Add(str);

            str = $"리스트 박스 선택 항목:{lbox_1.SelectedIndex}";
            lbox_2.Items.Add(str);

            str = $"체크 리스트 박스 항목 개수:{chbox.Items.Count}";
            lbox_2.Items.Add(str);

            str = $"체크 리스트 박스 선택 항목:{chbox.SelectedIndex}";
            lbox_2.Items.Add(str);

            str = $"체크 리스트 박스 체크 상태 목록";
            lbox_2.Items.Add(str);

            foreach (object obj in chbox.CheckedItems)
            {
                lbox_2.Items.Add(obj);
            }
        }
    }
}
