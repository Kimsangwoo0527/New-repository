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
            this.btnOpen = new System.Windows.Forms.Button();
            this.pictureBoxface_W = new System.Windows.Forms.PictureBox();
            this.pictureBoxbody_W = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.triangleBtn_W = new System.Windows.Forms.RadioButton();
            this.squareBtn_W = new System.Windows.Forms.RadioButton();
            this.roundBtn_W = new System.Windows.Forms.RadioButton();
            this.ovalBtn_W = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.naturalBtn_W = new System.Windows.Forms.RadioButton();
            this.waveBtn_W = new System.Windows.Forms.RadioButton();
            this.straightBtn_W = new System.Windows.Forms.RadioButton();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxface_W)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbody_W)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(478, 386);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(129, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "결과 출력";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pictureBoxface_W
            // 
            this.pictureBoxface_W.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxface_W.Image")));
            this.pictureBoxface_W.Location = new System.Drawing.Point(23, 24);
            this.pictureBoxface_W.Name = "pictureBoxface_W";
            this.pictureBoxface_W.Size = new System.Drawing.Size(421, 175);
            this.pictureBoxface_W.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxface_W.TabIndex = 1;
            this.pictureBoxface_W.TabStop = false;
            // 
            // pictureBoxbody_W
            // 
            this.pictureBoxbody_W.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxbody_W.Image")));
            this.pictureBoxbody_W.Location = new System.Drawing.Point(23, 224);
            this.pictureBoxbody_W.Name = "pictureBoxbody_W";
            this.pictureBoxbody_W.Size = new System.Drawing.Size(421, 185);
            this.pictureBoxbody_W.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxbody_W.TabIndex = 2;
            this.pictureBoxbody_W.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.triangleBtn_W);
            this.groupBox1.Controls.Add(this.squareBtn_W);
            this.groupBox1.Controls.Add(this.roundBtn_W);
            this.groupBox1.Controls.Add(this.ovalBtn_W);
            this.groupBox1.Location = new System.Drawing.Point(460, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "얼굴형";
            // 
            // triangleBtn_W
            // 
            this.triangleBtn_W.AutoSize = true;
            this.triangleBtn_W.Location = new System.Drawing.Point(163, 97);
            this.triangleBtn_W.Name = "triangleBtn_W";
            this.triangleBtn_W.Size = new System.Drawing.Size(123, 19);
            this.triangleBtn_W.TabIndex = 3;
            this.triangleBtn_W.TabStop = true;
            this.triangleBtn_W.Text = "역삼각형 얼굴";
            this.triangleBtn_W.UseVisualStyleBackColor = true;
            // 
            // squareBtn_W
            // 
            this.squareBtn_W.AutoSize = true;
            this.squareBtn_W.Location = new System.Drawing.Point(28, 97);
            this.squareBtn_W.Name = "squareBtn_W";
            this.squareBtn_W.Size = new System.Drawing.Size(93, 19);
            this.squareBtn_W.TabIndex = 2;
            this.squareBtn_W.TabStop = true;
            this.squareBtn_W.Text = "각진 얼굴";
            this.squareBtn_W.UseVisualStyleBackColor = true;
            // 
            // roundBtn_W
            // 
            this.roundBtn_W.AutoSize = true;
            this.roundBtn_W.Location = new System.Drawing.Point(163, 37);
            this.roundBtn_W.Name = "roundBtn_W";
            this.roundBtn_W.Size = new System.Drawing.Size(93, 19);
            this.roundBtn_W.TabIndex = 1;
            this.roundBtn_W.TabStop = true;
            this.roundBtn_W.Text = "둥근 얼굴";
            this.roundBtn_W.UseVisualStyleBackColor = true;
            // 
            // ovalBtn_W
            // 
            this.ovalBtn_W.AutoSize = true;
            this.ovalBtn_W.Location = new System.Drawing.Point(28, 37);
            this.ovalBtn_W.Name = "ovalBtn_W";
            this.ovalBtn_W.Size = new System.Drawing.Size(108, 19);
            this.ovalBtn_W.TabIndex = 0;
            this.ovalBtn_W.TabStop = true;
            this.ovalBtn_W.Text = "계란형 얼굴";
            this.ovalBtn_W.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.naturalBtn_W);
            this.groupBox2.Controls.Add(this.waveBtn_W);
            this.groupBox2.Controls.Add(this.straightBtn_W);
            this.groupBox2.Location = new System.Drawing.Point(460, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 135);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "체형";
            // 
            // naturalBtn_W
            // 
            this.naturalBtn_W.AutoSize = true;
            this.naturalBtn_W.Location = new System.Drawing.Point(28, 90);
            this.naturalBtn_W.Name = "naturalBtn_W";
            this.naturalBtn_W.Size = new System.Drawing.Size(73, 19);
            this.naturalBtn_W.TabIndex = 2;
            this.naturalBtn_W.TabStop = true;
            this.naturalBtn_W.Text = "내추럴";
            this.naturalBtn_W.UseVisualStyleBackColor = true;
            // 
            // waveBtn_W
            // 
            this.waveBtn_W.AutoSize = true;
            this.waveBtn_W.Location = new System.Drawing.Point(163, 36);
            this.waveBtn_W.Name = "waveBtn_W";
            this.waveBtn_W.Size = new System.Drawing.Size(73, 19);
            this.waveBtn_W.TabIndex = 1;
            this.waveBtn_W.TabStop = true;
            this.waveBtn_W.Text = "웨이브";
            this.waveBtn_W.UseVisualStyleBackColor = true;
            // 
            // straightBtn_W
            // 
            this.straightBtn_W.AutoSize = true;
            this.straightBtn_W.Location = new System.Drawing.Point(28, 36);
            this.straightBtn_W.Name = "straightBtn_W";
            this.straightBtn_W.Size = new System.Drawing.Size(103, 19);
            this.straightBtn_W.TabIndex = 0;
            this.straightBtn_W.TabStop = true;
            this.straightBtn_W.Text = "스트레이트";
            this.straightBtn_W.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(623, 386);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(129, 23);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "이전으로";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxbody_W);
            this.Controls.Add(this.pictureBoxface_W);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form4";
            this.Text = "코디프로그램";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxface_W)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbody_W)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBoxface_W;
        private System.Windows.Forms.PictureBox pictureBoxbody_W;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton triangleBtn_W;
        private System.Windows.Forms.RadioButton squareBtn_W;
        private System.Windows.Forms.RadioButton roundBtn_W;
        private System.Windows.Forms.RadioButton ovalBtn_W;
        private System.Windows.Forms.RadioButton naturalBtn_W;
        private System.Windows.Forms.RadioButton waveBtn_W;
        private System.Windows.Forms.RadioButton straightBtn_W;
        private System.Windows.Forms.Button closeBtn;
    }
}