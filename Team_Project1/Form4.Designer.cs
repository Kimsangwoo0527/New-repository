namespace Team_Project
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.picProfile_W2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.straightBtn_W = new System.Windows.Forms.RadioButton();
            this.naturalBtn_W = new System.Windows.Forms.RadioButton();
            this.waveBtn_W = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ovalBtn_W = new System.Windows.Forms.RadioButton();
            this.roundBtn_W = new System.Windows.Forms.RadioButton();
            this.squareBtn_W = new System.Windows.Forms.RadioButton();
            this.triangleBtn_W = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile_W2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picProfile
            // 
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
            this.picProfile.Location = new System.Drawing.Point(70, 12);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(481, 202);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 0;
            this.picProfile.TabStop = false;
            // 
            // picProfile_W2
            // 
            this.picProfile_W2.Image = ((System.Drawing.Image)(resources.GetObject("picProfile_W2.Image")));
            this.picProfile_W2.Location = new System.Drawing.Point(26, 288);
            this.picProfile_W2.Name = "picProfile_W2";
            this.picProfile_W2.Size = new System.Drawing.Size(471, 270);
            this.picProfile_W2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile_W2.TabIndex = 1;
            this.picProfile_W2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.waveBtn_W);
            this.groupBox2.Controls.Add(this.naturalBtn_W);
            this.groupBox2.Controls.Add(this.straightBtn_W);
            this.groupBox2.Location = new System.Drawing.Point(624, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 160);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "체형";
            // 
            // straightBtn_W
            // 
            this.straightBtn_W.AutoSize = true;
            this.straightBtn_W.Location = new System.Drawing.Point(7, 27);
            this.straightBtn_W.Name = "straightBtn_W";
            this.straightBtn_W.Size = new System.Drawing.Size(123, 22);
            this.straightBtn_W.TabIndex = 0;
            this.straightBtn_W.Text = "스트레이트";
            this.straightBtn_W.UseVisualStyleBackColor = true;
            this.straightBtn_W.CheckedChanged += new System.EventHandler(this.straightBtn_W_CheckedChanged);
            // 
            // naturalBtn_W
            // 
            this.naturalBtn_W.AutoSize = true;
            this.naturalBtn_W.Location = new System.Drawing.Point(7, 95);
            this.naturalBtn_W.Name = "naturalBtn_W";
            this.naturalBtn_W.Size = new System.Drawing.Size(87, 22);
            this.naturalBtn_W.TabIndex = 1;
            this.naturalBtn_W.Text = "내추럴";
            this.naturalBtn_W.UseVisualStyleBackColor = true;
            this.naturalBtn_W.CheckedChanged += new System.EventHandler(this.naturalBtn_W_CheckedChanged);
            // 
            // waveBtn_W
            // 
            this.waveBtn_W.AutoSize = true;
            this.waveBtn_W.Location = new System.Drawing.Point(149, 27);
            this.waveBtn_W.Name = "waveBtn_W";
            this.waveBtn_W.Size = new System.Drawing.Size(87, 22);
            this.waveBtn_W.TabIndex = 2;
            this.waveBtn_W.Text = "웨이브";
            this.waveBtn_W.UseVisualStyleBackColor = true;
            this.waveBtn_W.CheckedChanged += new System.EventHandler(this.waveBtn_W_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.triangleBtn_W);
            this.groupBox1.Controls.Add(this.squareBtn_W);
            this.groupBox1.Controls.Add(this.roundBtn_W);
            this.groupBox1.Controls.Add(this.ovalBtn_W);
            this.groupBox1.Location = new System.Drawing.Point(617, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "얼굴형";
            // 
            // ovalBtn_W
            // 
            this.ovalBtn_W.AutoSize = true;
            this.ovalBtn_W.Location = new System.Drawing.Point(7, 28);
            this.ovalBtn_W.Name = "ovalBtn_W";
            this.ovalBtn_W.Size = new System.Drawing.Size(129, 22);
            this.ovalBtn_W.TabIndex = 0;
            this.ovalBtn_W.TabStop = true;
            this.ovalBtn_W.Text = "계란형 얼굴";
            this.ovalBtn_W.UseVisualStyleBackColor = true;
            this.ovalBtn_W.CheckedChanged += new System.EventHandler(this.ovalBtn_W_CheckedChanged);
            // 
            // roundBtn_W
            // 
            this.roundBtn_W.AutoSize = true;
            this.roundBtn_W.Location = new System.Drawing.Point(149, 28);
            this.roundBtn_W.Name = "roundBtn_W";
            this.roundBtn_W.Size = new System.Drawing.Size(111, 22);
            this.roundBtn_W.TabIndex = 1;
            this.roundBtn_W.TabStop = true;
            this.roundBtn_W.Text = "둥근 얼굴";
            this.roundBtn_W.UseVisualStyleBackColor = true;
            this.roundBtn_W.CheckedChanged += new System.EventHandler(this.roundBtn_W_CheckedChanged);
            // 
            // squareBtn_W
            // 
            this.squareBtn_W.AutoSize = true;
            this.squareBtn_W.Location = new System.Drawing.Point(7, 99);
            this.squareBtn_W.Name = "squareBtn_W";
            this.squareBtn_W.Size = new System.Drawing.Size(111, 22);
            this.squareBtn_W.TabIndex = 2;
            this.squareBtn_W.TabStop = true;
            this.squareBtn_W.Text = "각진 얼굴";
            this.squareBtn_W.UseVisualStyleBackColor = true;
            this.squareBtn_W.CheckedChanged += new System.EventHandler(this.squareBtn_W_CheckedChanged);
            // 
            // triangleBtn_W
            // 
            this.triangleBtn_W.AutoSize = true;
            this.triangleBtn_W.Location = new System.Drawing.Point(149, 99);
            this.triangleBtn_W.Name = "triangleBtn_W";
            this.triangleBtn_W.Size = new System.Drawing.Size(147, 22);
            this.triangleBtn_W.TabIndex = 3;
            this.triangleBtn_W.TabStop = true;
            this.triangleBtn_W.Text = "역삼각형 얼굴";
            this.triangleBtn_W.UseVisualStyleBackColor = true;
            this.triangleBtn_W.CheckedChanged += new System.EventHandler(this.triangleBtn_W_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(759, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(759, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "나의 얼굴형: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "나의 체형: ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 594);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picProfile_W2);
            this.Controls.Add(this.picProfile);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile_W2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.PictureBox picProfile_W2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton waveBtn_W;
        private System.Windows.Forms.RadioButton naturalBtn_W;
        private System.Windows.Forms.RadioButton straightBtn_W;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton triangleBtn_W;
        private System.Windows.Forms.RadioButton squareBtn_W;
        private System.Windows.Forms.RadioButton roundBtn_W;
        private System.Windows.Forms.RadioButton ovalBtn_W;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}