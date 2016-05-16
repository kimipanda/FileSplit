namespace FileSplit
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
            this.components = new System.ComponentModel.Container();
            this.lstExtension = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.FD = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstExtension
            // 
            this.lstExtension.FormattingEnabled = true;
            this.lstExtension.ItemHeight = 12;
            this.lstExtension.Location = new System.Drawing.Point(5, 5);
            this.lstExtension.Name = "lstExtension";
            this.lstExtension.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstExtension.Size = new System.Drawing.Size(157, 112);
            this.lstExtension.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtInterval);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtExtension);
            this.panel2.Location = new System.Drawing.Point(165, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 113);
            this.panel2.TabIndex = 2;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(68, 59);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(74, 21);
            this.txtInterval.TabIndex = 4;
            this.txtInterval.Text = "3";
            this.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "몇 초마다?";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 86);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(2, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(3, 4);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(140, 21);
            this.txtExtension.TabIndex = 0;
            this.txtExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtension_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(5, 121);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(303, 21);
            this.txtPath.TabIndex = 3;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(5, 149);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(302, 23);
            this.btnPath.TabIndex = 4;
            this.btnPath.Text = "경로설정";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 174);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lstExtension);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "FileSplit";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstExtension;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.FolderBrowserDialog FD;
    }
}

