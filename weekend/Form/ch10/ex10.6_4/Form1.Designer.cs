namespace ex10._6_4
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
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonPurple = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.radioButtonBlack.Checked = true;
            this.radioButtonBlack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonBlack.Location = new System.Drawing.Point(12, 12);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(59, 16);
            this.radioButtonBlack.TabIndex = 0;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "검정색";
            this.radioButtonBlack.UseVisualStyleBackColor = false;
            this.radioButtonBlack.CheckedChanged += new System.EventHandler(this.radioButtonBlack_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.BackColor = System.Drawing.Color.Red;
            this.radioButtonRed.Location = new System.Drawing.Point(110, 12);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(59, 16);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.Text = "빨강색";
            this.radioButtonRed.UseVisualStyleBackColor = false;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButtonPurple
            // 
            this.radioButtonPurple.AutoSize = true;
            this.radioButtonPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButtonPurple.Location = new System.Drawing.Point(208, 12);
            this.radioButtonPurple.Name = "radioButtonPurple";
            this.radioButtonPurple.Size = new System.Drawing.Size(59, 16);
            this.radioButtonPurple.TabIndex = 0;
            this.radioButtonPurple.Text = "보라색";
            this.radioButtonPurple.UseVisualStyleBackColor = false;
            this.radioButtonPurple.CheckedChanged += new System.EventHandler(this.radioButtonPurple_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButtonGreen.Location = new System.Drawing.Point(306, 12);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(47, 16);
            this.radioButtonGreen.TabIndex = 0;
            this.radioButtonGreen.Text = "녹색";
            this.radioButtonGreen.UseVisualStyleBackColor = false;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 502);
            this.Controls.Add(this.radioButtonGreen);
            this.Controls.Add(this.radioButtonPurple);
            this.Controls.Add(this.radioButtonRed);
            this.Controls.Add(this.radioButtonBlack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonPurple;
        private System.Windows.Forms.RadioButton radioButtonGreen;
    }
}

