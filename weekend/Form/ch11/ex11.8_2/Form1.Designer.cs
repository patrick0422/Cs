namespace ex11._8_2
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
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("워드");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("파워포인트");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("엑셀");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("비지오");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("아웃룩");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("오피스", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("메모장");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("그림판");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("계산기");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("보조 프로그램", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("내 컴퓨터", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode21});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode12.Name = "노드3";
            treeNode12.Text = "워드";
            treeNode13.Name = "노드4";
            treeNode13.Text = "파워포인트";
            treeNode14.Name = "노드5";
            treeNode14.Text = "엑셀";
            treeNode15.Name = "노드6";
            treeNode15.Text = "비지오";
            treeNode16.Name = "노드7";
            treeNode16.Text = "아웃룩";
            treeNode17.Name = "노드1";
            treeNode17.Text = "오피스";
            treeNode18.Name = "노드8";
            treeNode18.Text = "메모장";
            treeNode19.Name = "노드9";
            treeNode19.Text = "그림판";
            treeNode20.Name = "노드10";
            treeNode20.Text = "계산기";
            treeNode21.Name = "노드2";
            treeNode21.Text = "보조 프로그램";
            treeNode22.Name = "노드0";
            treeNode22.Text = "내 컴퓨터";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22});
            this.treeView1.Size = new System.Drawing.Size(147, 264);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(165, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(269, 264);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 288);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
    }
}

