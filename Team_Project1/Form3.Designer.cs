namespace Team_Project
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxbody = new System.Windows.Forms.PictureBox();
            this.pictureBoxface = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.triangleBtn_M = new System.Windows.Forms.RadioButton();
            this.roundBtn_M = new System.Windows.Forms.RadioButton();
            this.squareBtn_M = new System.Windows.Forms.RadioButton();
            this.ovalBtn_M = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.waveBtn_M = new System.Windows.Forms.RadioButton();
            this.naturalBtn_M = new System.Windows.Forms.RadioButton();
            this.straightBtn_M = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxface)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(883, 264);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxbody
            // 
            this.pictureBoxbody.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxbody.Image")));
            this.pictureBoxbody.Location = new System.Drawing.Point(36, 267);
            this.pictureBoxbody.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxbody.Name = "pictureBoxbody";
            this.pictureBoxbody.Size = new System.Drawing.Size(498, 254);
            this.pictureBoxbody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxbody.TabIndex = 2;
            this.pictureBoxbody.TabStop = false;
            // 
            // pictureBoxface
            // 
            this.pictureBoxface.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxface.Image")));
            this.pictureBoxface.Location = new System.Drawing.Point(36, 13);
            this.pictureBoxface.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxface.Name = "pictureBoxface";
            this.pictureBoxface.Size = new System.Drawing.Size(498, 203);
            this.pictureBoxface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxface.TabIndex = 3;
            this.pictureBoxface.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.triangleBtn_M);
            this.groupBox1.Controls.Add(this.roundBtn_M);
            this.groupBox1.Controls.Add(this.squareBtn_M);
            this.groupBox1.Controls.Add(this.ovalBtn_M);
            this.groupBox1.Location = new System.Drawing.Point(611, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(326, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "얼굴형";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // triangleBtn_M
            // 
            this.triangleBtn_M.AutoSize = true;
            this.triangleBtn_M.Location = new System.Drawing.Point(169, 113);
            this.triangleBtn_M.Margin = new System.Windows.Forms.Padding(4);
            this.triangleBtn_M.Name = "triangleBtn_M";
            this.triangleBtn_M.Size = new System.Drawing.Size(147, 22);
            this.triangleBtn_M.TabIndex = 3;
            this.triangleBtn_M.TabStop = true;
            this.triangleBtn_M.Text = "역삼각형 얼굴";
            this.triangleBtn_M.UseVisualStyleBackColor = true;
            this.triangleBtn_M.CheckedChanged += new System.EventHandler(this.triangleBtn_M_CheckedChanged);
            // 
            // roundBtn_M
            // 
            this.roundBtn_M.AutoSize = true;
            this.roundBtn_M.Location = new System.Drawing.Point(169, 48);
            this.roundBtn_M.Margin = new System.Windows.Forms.Padding(4);
            this.roundBtn_M.Name = "roundBtn_M";
            this.roundBtn_M.Size = new System.Drawing.Size(111, 22);
            this.roundBtn_M.TabIndex = 2;
            this.roundBtn_M.TabStop = true;
            this.roundBtn_M.Text = "둥근 얼굴";
            this.roundBtn_M.UseVisualStyleBackColor = true;
            this.roundBtn_M.CheckedChanged += new System.EventHandler(this.roundBtn_M_CheckedChanged);
            // 
            // squareBtn_M
            // 
            this.squareBtn_M.AutoSize = true;
            this.squareBtn_M.Location = new System.Drawing.Point(22, 113);
            this.squareBtn_M.Margin = new System.Windows.Forms.Padding(4);
            this.squareBtn_M.Name = "squareBtn_M";
            this.squareBtn_M.Size = new System.Drawing.Size(111, 22);
            this.squareBtn_M.TabIndex = 1;
            this.squareBtn_M.TabStop = true;
            this.squareBtn_M.Text = "각진 얼굴";
            this.squareBtn_M.UseVisualStyleBackColor = true;
            this.squareBtn_M.CheckedChanged += new System.EventHandler(this.squareBtn_M_CheckedChanged);
            // 
            // ovalBtn_M
            // 
            this.ovalBtn_M.AutoSize = true;
            this.ovalBtn_M.Location = new System.Drawing.Point(22, 48);
            this.ovalBtn_M.Margin = new System.Windows.Forms.Padding(4);
            this.ovalBtn_M.Name = "ovalBtn_M";
            this.ovalBtn_M.Size = new System.Drawing.Size(129, 22);
            this.ovalBtn_M.TabIndex = 0;
            this.ovalBtn_M.TabStop = true;
            this.ovalBtn_M.Text = "계란형 얼굴";
            this.ovalBtn_M.UseVisualStyleBackColor = true;
            this.ovalBtn_M.CheckedChanged += new System.EventHandler(this.ovalBtn_M_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.waveBtn_M);
            this.groupBox2.Controls.Add(this.naturalBtn_M);
            this.groupBox2.Controls.Add(this.straightBtn_M);
            this.groupBox2.Location = new System.Drawing.Point(611, 351);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(328, 170);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "체형";
            // 
            // waveBtn_M
            // 
            this.waveBtn_M.AutoSize = true;
            this.waveBtn_M.Location = new System.Drawing.Point(169, 48);
            this.waveBtn_M.Margin = new System.Windows.Forms.Padding(4);
            this.waveBtn_M.Name = "waveBtn_M";
            this.waveBtn_M.Size = new System.Drawing.Size(87, 22);
            this.waveBtn_M.TabIndex = 2;
            this.waveBtn_M.TabStop = true;
            this.waveBtn_M.Text = "웨이브";
            this.waveBtn_M.UseVisualStyleBackColor = true;
            this.waveBtn_M.CheckedChanged += new System.EventHandler(this.waveBtn_M_CheckedChanged);
            // 
            // naturalBtn_M
            // 
            this.naturalBtn_M.AutoSize = true;
            this.naturalBtn_M.Location = new System.Drawing.Point(22, 113);
            this.naturalBtn_M.Margin = new System.Windows.Forms.Padding(4);
            this.naturalBtn_M.Name = "naturalBtn_M";
            this.naturalBtn_M.Size = new System.Drawing.Size(87, 22);
            this.naturalBtn_M.TabIndex = 1;
            this.naturalBtn_M.TabStop = true;
            this.naturalBtn_M.Text = "내추럴";
            this.naturalBtn_M.UseVisualStyleBackColor = true;
            this.naturalBtn_M.CheckedChanged += new System.EventHandler(this.naturalBtn_M_CheckedChanged);
            // 
            // straightBtn_M
            // 
            this.straightBtn_M.AutoSize = true;
            this.straightBtn_M.Location = new System.Drawing.Point(22, 48);
            this.straightBtn_M.Margin = new System.Windows.Forms.Padding(4);
            this.straightBtn_M.Name = "straightBtn_M";
            this.straightBtn_M.Size = new System.Drawing.Size(123, 22);
            this.straightBtn_M.TabIndex = 0;
            this.straightBtn_M.TabStop = true;
            this.straightBtn_M.Text = "스트레이트";
            this.straightBtn_M.UseVisualStyleBackColor = true;
            this.straightBtn_M.CheckedChanged += new System.EventHandler(this.straightBtn_M_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(761, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(761, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "나의 얼굴형: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "나의 체형: ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 572);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxface);
            this.Controls.Add(this.pictureBoxbody);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxface)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxbody;
        private System.Windows.Forms.PictureBox pictureBoxface;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton triangleBtn_M;
        private System.Windows.Forms.RadioButton roundBtn_M;
        private System.Windows.Forms.RadioButton squareBtn_M;
        private System.Windows.Forms.RadioButton ovalBtn_M;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton waveBtn_M;
        private System.Windows.Forms.RadioButton naturalBtn_M;
        private System.Windows.Forms.RadioButton straightBtn_M;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}