
namespace ControlTest2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbox = new System.Windows.Forms.ComboBox();
            this.btn_add1 = new System.Windows.Forms.Button();
            this.btn_remove1 = new System.Windows.Forms.Button();
            this.btn_add2 = new System.Windows.Forms.Button();
            this.btn_remove2 = new System.Windows.Forms.Button();
            this.lbox_1 = new System.Windows.Forms.ListBox();
            this.btn_summary = new System.Windows.Forms.Button();
            this.lbox_2 = new System.Windows.Forms.ListBox();
            this.btn_add3 = new System.Windows.Forms.Button();
            this.btn_remove3 = new System.Windows.Forms.Button();
            this.lb_msg = new System.Windows.Forms.Label();
            this.tbox_1 = new System.Windows.Forms.TextBox();
            this.chbox = new System.Windows.Forms.CheckedListBox();
            this.tbox_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbox
            // 
            this.cbox.FormattingEnabled = true;
            this.cbox.Location = new System.Drawing.Point(28, 36);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(106, 20);
            this.cbox.TabIndex = 0;
            // 
            // btn_add1
            // 
            this.btn_add1.Location = new System.Drawing.Point(159, 36);
            this.btn_add1.Name = "btn_add1";
            this.btn_add1.Size = new System.Drawing.Size(68, 20);
            this.btn_add1.TabIndex = 1;
            this.btn_add1.Text = "추가";
            this.btn_add1.UseVisualStyleBackColor = true;
            this.btn_add1.Click += new System.EventHandler(this.btn_add1_Click);
            // 
            // btn_remove1
            // 
            this.btn_remove1.Location = new System.Drawing.Point(159, 62);
            this.btn_remove1.Name = "btn_remove1";
            this.btn_remove1.Size = new System.Drawing.Size(68, 20);
            this.btn_remove1.TabIndex = 1;
            this.btn_remove1.Text = "삭제";
            this.btn_remove1.UseVisualStyleBackColor = true;
            this.btn_remove1.Click += new System.EventHandler(this.btn_remove1_Click);
            // 
            // btn_add2
            // 
            this.btn_add2.Location = new System.Drawing.Point(159, 158);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(68, 20);
            this.btn_add2.TabIndex = 1;
            this.btn_add2.Text = "추가";
            this.btn_add2.UseVisualStyleBackColor = true;
            this.btn_add2.Click += new System.EventHandler(this.btn_add2_Click);
            // 
            // btn_remove2
            // 
            this.btn_remove2.Location = new System.Drawing.Point(159, 184);
            this.btn_remove2.Name = "btn_remove2";
            this.btn_remove2.Size = new System.Drawing.Size(68, 20);
            this.btn_remove2.TabIndex = 1;
            this.btn_remove2.Text = "삭제";
            this.btn_remove2.UseVisualStyleBackColor = true;
            this.btn_remove2.Click += new System.EventHandler(this.btn_remove2_Click);
            // 
            // lbox_1
            // 
            this.lbox_1.FormattingEnabled = true;
            this.lbox_1.ItemHeight = 12;
            this.lbox_1.Location = new System.Drawing.Point(28, 184);
            this.lbox_1.Name = "lbox_1";
            this.lbox_1.Size = new System.Drawing.Size(106, 136);
            this.lbox_1.TabIndex = 2;
            this.lbox_1.SelectedIndexChanged += new System.EventHandler(this.lbox_1_SelectedIndexChanged);
            // 
            // btn_summary
            // 
            this.btn_summary.Location = new System.Drawing.Point(242, 157);
            this.btn_summary.Name = "btn_summary";
            this.btn_summary.Size = new System.Drawing.Size(68, 20);
            this.btn_summary.TabIndex = 1;
            this.btn_summary.Text = "요약";
            this.btn_summary.UseVisualStyleBackColor = true;
            this.btn_summary.Click += new System.EventHandler(this.btn_summary_Click);
            // 
            // lbox_2
            // 
            this.lbox_2.FormattingEnabled = true;
            this.lbox_2.ItemHeight = 12;
            this.lbox_2.Location = new System.Drawing.Point(242, 183);
            this.lbox_2.Name = "lbox_2";
            this.lbox_2.Size = new System.Drawing.Size(199, 136);
            this.lbox_2.TabIndex = 2;
            // 
            // btn_add3
            // 
            this.btn_add3.Location = new System.Drawing.Point(373, 36);
            this.btn_add3.Name = "btn_add3";
            this.btn_add3.Size = new System.Drawing.Size(68, 20);
            this.btn_add3.TabIndex = 1;
            this.btn_add3.Text = "추가";
            this.btn_add3.UseVisualStyleBackColor = true;
            this.btn_add3.Click += new System.EventHandler(this.btn_add3_Click);
            // 
            // btn_remove3
            // 
            this.btn_remove3.Location = new System.Drawing.Point(373, 62);
            this.btn_remove3.Name = "btn_remove3";
            this.btn_remove3.Size = new System.Drawing.Size(68, 20);
            this.btn_remove3.TabIndex = 1;
            this.btn_remove3.Text = "삭제";
            this.btn_remove3.UseVisualStyleBackColor = true;
            this.btn_remove3.Click += new System.EventHandler(this.btn_remove3_Click);
            // 
            // lb_msg
            // 
            this.lb_msg.AutoSize = true;
            this.lb_msg.Location = new System.Drawing.Point(26, 332);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(42, 12);
            this.lb_msg.TabIndex = 3;
            this.lb_msg.Text = "[msg]";
            // 
            // tbox_1
            // 
            this.tbox_1.Location = new System.Drawing.Point(28, 156);
            this.tbox_1.Name = "tbox_1";
            this.tbox_1.Size = new System.Drawing.Size(106, 21);
            this.tbox_1.TabIndex = 4;
            // 
            // chbox
            // 
            this.chbox.FormattingEnabled = true;
            this.chbox.Location = new System.Drawing.Point(242, 62);
            this.chbox.Name = "chbox";
            this.chbox.Size = new System.Drawing.Size(106, 84);
            this.chbox.TabIndex = 5;
            this.chbox.SelectedIndexChanged += new System.EventHandler(this.chbox_SelectedIndexChanged);
            // 
            // tbox_2
            // 
            this.tbox_2.Location = new System.Drawing.Point(242, 35);
            this.tbox_2.Name = "tbox_2";
            this.tbox_2.Size = new System.Drawing.Size(106, 21);
            this.tbox_2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 353);
            this.Controls.Add(this.chbox);
            this.Controls.Add(this.tbox_2);
            this.Controls.Add(this.tbox_1);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.lbox_2);
            this.Controls.Add(this.lbox_1);
            this.Controls.Add(this.btn_remove2);
            this.Controls.Add(this.btn_summary);
            this.Controls.Add(this.btn_add2);
            this.Controls.Add(this.btn_remove3);
            this.Controls.Add(this.btn_remove1);
            this.Controls.Add(this.btn_add3);
            this.Controls.Add(this.btn_add1);
            this.Controls.Add(this.cbox);
            this.Name = "Form1";
            this.Text = "Ex ComboBox,ListBox,CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.Button btn_add1;
        private System.Windows.Forms.Button btn_remove1;
        private System.Windows.Forms.Button btn_add2;
        private System.Windows.Forms.Button btn_remove2;
        private System.Windows.Forms.ListBox lbox_1;
        private System.Windows.Forms.Button btn_summary;
        private System.Windows.Forms.ListBox lbox_2;
        private System.Windows.Forms.Button btn_add3;
        private System.Windows.Forms.Button btn_remove3;
        private System.Windows.Forms.Label lb_msg;
        private System.Windows.Forms.TextBox tbox_1;
        private System.Windows.Forms.CheckedListBox chbox;
        private System.Windows.Forms.TextBox tbox_2;
    }
}

