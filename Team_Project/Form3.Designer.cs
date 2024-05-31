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
            this.closeBtn = new System.Windows.Forms.Button();
            this.pictureBoxbody = new System.Windows.Forms.PictureBox();
            this.pictureBoxface = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.triangleBtn = new System.Windows.Forms.RadioButton();
            this.roundBtn = new System.Windows.Forms.RadioButton();
            this.squareBtn = new System.Windows.Forms.RadioButton();
            this.ovalBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.waveBtn = new System.Windows.Forms.RadioButton();
            this.naturalBtn = new System.Windows.Forms.RadioButton();
            this.straightBtn = new System.Windows.Forms.RadioButton();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxface)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(656, 404);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(127, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "이전으로";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxbody
            // 
            this.pictureBoxbody.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxbody.Image")));
            this.pictureBoxbody.Location = new System.Drawing.Point(29, 195);
            this.pictureBoxbody.Name = "pictureBoxbody";
            this.pictureBoxbody.Size = new System.Drawing.Size(463, 232);
            this.pictureBoxbody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxbody.TabIndex = 2;
            this.pictureBoxbody.TabStop = false;
            // 
            // pictureBoxface
            // 
            this.pictureBoxface.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxface.Image")));
            this.pictureBoxface.Location = new System.Drawing.Point(29, 21);
            this.pictureBoxface.Name = "pictureBoxface";
            this.pictureBoxface.Size = new System.Drawing.Size(463, 148);
            this.pictureBoxface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxface.TabIndex = 3;
            this.pictureBoxface.TabStop = false;
            this.pictureBoxface.Click += new System.EventHandler(this.pictureBoxface_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.triangleBtn);
            this.groupBox1.Controls.Add(this.roundBtn);
            this.groupBox1.Controls.Add(this.squareBtn);
            this.groupBox1.Controls.Add(this.ovalBtn);
            this.groupBox1.Location = new System.Drawing.Point(521, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 142);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "얼굴형";
            // 
            // triangleBtn
            // 
            this.triangleBtn.AutoSize = true;
            this.triangleBtn.Location = new System.Drawing.Point(135, 94);
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(123, 19);
            this.triangleBtn.TabIndex = 3;
            this.triangleBtn.TabStop = true;
            this.triangleBtn.Text = "역삼각형 얼굴";
            this.triangleBtn.UseVisualStyleBackColor = true;
            // 
            // roundBtn
            // 
            this.roundBtn.AutoSize = true;
            this.roundBtn.Location = new System.Drawing.Point(135, 40);
            this.roundBtn.Name = "roundBtn";
            this.roundBtn.Size = new System.Drawing.Size(93, 19);
            this.roundBtn.TabIndex = 2;
            this.roundBtn.TabStop = true;
            this.roundBtn.Text = "둥근 얼굴";
            this.roundBtn.UseVisualStyleBackColor = true;
            // 
            // squareBtn
            // 
            this.squareBtn.AutoSize = true;
            this.squareBtn.Location = new System.Drawing.Point(18, 94);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(93, 19);
            this.squareBtn.TabIndex = 1;
            this.squareBtn.TabStop = true;
            this.squareBtn.Text = "각진 얼굴";
            this.squareBtn.UseVisualStyleBackColor = true;
            // 
            // ovalBtn
            // 
            this.ovalBtn.AutoSize = true;
<<<<<<< HEAD
            this.ovalBtn.Image = ((System.Drawing.Image)(resources.GetObject("ovalBtn.Image")));
            this.ovalBtn.Location = new System.Drawing.Point(18, 40);
            this.ovalBtn.Name = "ovalBtn";
            this.ovalBtn.Size = new System.Drawing.Size(383, 37);
=======
            this.ovalBtn.Location = new System.Drawing.Point(18, 40);
            this.ovalBtn.Name = "ovalBtn";
            this.ovalBtn.Size = new System.Drawing.Size(108, 19);
>>>>>>> ce2ea5bbf4292b2c09ba31ea5ccf380d8600ee40
            this.ovalBtn.TabIndex = 0;
            this.ovalBtn.TabStop = true;
            this.ovalBtn.Text = "계란형 얼굴";
            this.ovalBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.waveBtn);
            this.groupBox2.Controls.Add(this.naturalBtn);
            this.groupBox2.Controls.Add(this.straightBtn);
            this.groupBox2.Location = new System.Drawing.Point(521, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 142);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "체형";
            // 
            // waveBtn
            // 
            this.waveBtn.AutoSize = true;
            this.waveBtn.Location = new System.Drawing.Point(135, 40);
            this.waveBtn.Name = "waveBtn";
            this.waveBtn.Size = new System.Drawing.Size(73, 19);
            this.waveBtn.TabIndex = 2;
            this.waveBtn.TabStop = true;
            this.waveBtn.Text = "웨이브";
            this.waveBtn.UseVisualStyleBackColor = true;
            // 
            // naturalBtn
            // 
            this.naturalBtn.AutoSize = true;
            this.naturalBtn.Location = new System.Drawing.Point(18, 94);
            this.naturalBtn.Name = "naturalBtn";
            this.naturalBtn.Size = new System.Drawing.Size(73, 19);
            this.naturalBtn.TabIndex = 1;
            this.naturalBtn.TabStop = true;
            this.naturalBtn.Text = "내추럴";
            this.naturalBtn.UseVisualStyleBackColor = true;
            // 
            // straightBtn
            // 
            this.straightBtn.AutoSize = true;
            this.straightBtn.Location = new System.Drawing.Point(18, 40);
            this.straightBtn.Name = "straightBtn";
            this.straightBtn.Size = new System.Drawing.Size(103, 19);
            this.straightBtn.TabIndex = 0;
            this.straightBtn.TabStop = true;
            this.straightBtn.Text = "스트레이트";
            this.straightBtn.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(521, 404);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(121, 23);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "결과 출력";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 477);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxface);
            this.Controls.Add(this.pictureBoxbody);
            this.Controls.Add(this.closeBtn);
            this.Name = "Form3";
            this.Text = "코디프로그램";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxface)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBoxbody;
        private System.Windows.Forms.PictureBox pictureBoxface;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton triangleBtn;
        private System.Windows.Forms.RadioButton roundBtn;
        private System.Windows.Forms.RadioButton squareBtn;
        private System.Windows.Forms.RadioButton ovalBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton waveBtn;
        private System.Windows.Forms.RadioButton naturalBtn;
        private System.Windows.Forms.RadioButton straightBtn;
        private System.Windows.Forms.Button btnOpen;
    }
}