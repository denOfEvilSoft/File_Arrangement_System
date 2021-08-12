
namespace File_Arrangement_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.t_fileName = new System.Windows.Forms.TextBox();
            this.b_ready = new System.Windows.Forms.Button();
            this.b_start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_targetLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_location = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_locationButton = new System.Windows.Forms.Button();
            this.b_targetLocationButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_fileName
            // 
            this.t_fileName.Location = new System.Drawing.Point(12, 123);
            this.t_fileName.Name = "t_fileName";
            this.t_fileName.Size = new System.Drawing.Size(559, 21);
            this.t_fileName.TabIndex = 6;
            // 
            // b_ready
            // 
            this.b_ready.Location = new System.Drawing.Point(12, 150);
            this.b_ready.Name = "b_ready";
            this.b_ready.Size = new System.Drawing.Size(75, 23);
            this.b_ready.TabIndex = 7;
            this.b_ready.Text = "이동 준비";
            this.b_ready.UseVisualStyleBackColor = true;
            this.b_ready.Click += new System.EventHandler(this.b_ready_Click);
            // 
            // b_start
            // 
            this.b_start.Enabled = false;
            this.b_start.Location = new System.Drawing.Point(93, 150);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(478, 23);
            this.b_start.TabIndex = 8;
            this.b_start.Text = "이동";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(561, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "탐색 위치의 파일들 중 파일 이름에 아래의 텍스트가 포함되어 있으면 이동 위치로 파일을 이동시킵니다";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 27);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(10, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "파일 정리 : denofevil.soft@gmail.com";
            // 
            // t_targetLocation
            // 
            this.t_targetLocation.Enabled = false;
            this.t_targetLocation.Location = new System.Drawing.Point(81, 41);
            this.t_targetLocation.Name = "t_targetLocation";
            this.t_targetLocation.Size = new System.Drawing.Size(391, 21);
            this.t_targetLocation.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "이동 위치  :";
            // 
            // t_location
            // 
            this.t_location.Enabled = false;
            this.t_location.Location = new System.Drawing.Point(81, 14);
            this.t_location.Name = "t_location";
            this.t_location.Size = new System.Drawing.Size(391, 21);
            this.t_location.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "탐색 위치 : ";
            // 
            // b_locationButton
            // 
            this.b_locationButton.Location = new System.Drawing.Point(478, 14);
            this.b_locationButton.Name = "b_locationButton";
            this.b_locationButton.Size = new System.Drawing.Size(75, 23);
            this.b_locationButton.TabIndex = 4;
            this.b_locationButton.Text = "폴더 찾기";
            this.b_locationButton.UseVisualStyleBackColor = true;
            this.b_locationButton.Click += new System.EventHandler(this.b_locationButton_Click);
            // 
            // b_targetLocationButton
            // 
            this.b_targetLocationButton.Location = new System.Drawing.Point(477, 39);
            this.b_targetLocationButton.Name = "b_targetLocationButton";
            this.b_targetLocationButton.Size = new System.Drawing.Size(75, 23);
            this.b_targetLocationButton.TabIndex = 5;
            this.b_targetLocationButton.Text = "폴더 찾기";
            this.b_targetLocationButton.UseVisualStyleBackColor = true;
            this.b_targetLocationButton.Click += new System.EventHandler(this.b_targetLocationButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_targetLocationButton);
            this.groupBox1.Controls.Add(this.b_locationButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.t_location);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.t_targetLocation);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일 경로";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(558, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(541, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "_";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 185);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.b_ready);
            this.Controls.Add(this.t_fileName);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox t_fileName;
        private System.Windows.Forms.Button b_ready;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_targetLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_locationButton;
        private System.Windows.Forms.Button b_targetLocationButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

