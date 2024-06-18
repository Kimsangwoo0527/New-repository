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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.Btn_square = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_triangle = new System.Windows.Forms.Button();
            this.Btn_oval = new System.Windows.Forms.Button();
            this.Btn_wave = new System.Windows.Forms.Button();
            this.Btn_natural = new System.Windows.Forms.Button();
            this.Btn_straight = new System.Windows.Forms.Button();
            this.Btn_round = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_face = new System.Windows.Forms.Label();
            this.lbl_body = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeBtn.Location = new System.Drawing.Point(609, 656);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(127, 35);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "이전으로";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_body);
            this.groupBox2.Controls.Add(this.lbl_face);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(854, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 112);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "현재 check 상태 ";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpen.Location = new System.Drawing.Point(324, 656);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(121, 35);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "결과 출력";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_square
            // 
            this.Btn_square.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_square.BackgroundImage")));
            this.Btn_square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_square.Location = new System.Drawing.Point(372, 166);
            this.Btn_square.Name = "Btn_square";
            this.Btn_square.Size = new System.Drawing.Size(166, 209);
            this.Btn_square.TabIndex = 9;
            this.Btn_square.UseVisualStyleBackColor = true;
            this.Btn_square.Click += new System.EventHandler(this.Btn_square_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_triangle
            // 
            this.Btn_triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_triangle.BackgroundImage")));
            this.Btn_triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_triangle.Location = new System.Drawing.Point(797, 166);
            this.Btn_triangle.Name = "Btn_triangle";
            this.Btn_triangle.Size = new System.Drawing.Size(166, 209);
            this.Btn_triangle.TabIndex = 12;
            this.Btn_triangle.UseVisualStyleBackColor = true;
            this.Btn_triangle.Click += new System.EventHandler(this.Btn_triangle_Click);
            // 
            // Btn_oval
            // 
            this.Btn_oval.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_oval.BackgroundImage")));
            this.Btn_oval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_oval.Location = new System.Drawing.Point(169, 166);
            this.Btn_oval.Name = "Btn_oval";
            this.Btn_oval.Size = new System.Drawing.Size(166, 209);
            this.Btn_oval.TabIndex = 13;
            this.Btn_oval.UseVisualStyleBackColor = true;
            this.Btn_oval.Click += new System.EventHandler(this.button4_Click);
            // 
            // Btn_wave
            // 
            this.Btn_wave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_wave.BackgroundImage")));
            this.Btn_wave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_wave.Location = new System.Drawing.Point(253, 403);
            this.Btn_wave.Name = "Btn_wave";
            this.Btn_wave.Size = new System.Drawing.Size(166, 209);
            this.Btn_wave.TabIndex = 14;
            this.Btn_wave.UseVisualStyleBackColor = true;
            this.Btn_wave.Click += new System.EventHandler(this.Btn_wave_Click);
            // 
            // Btn_natural
            // 
            this.Btn_natural.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_natural.BackgroundImage")));
            this.Btn_natural.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_natural.Location = new System.Drawing.Point(665, 403);
            this.Btn_natural.Name = "Btn_natural";
            this.Btn_natural.Size = new System.Drawing.Size(166, 209);
            this.Btn_natural.TabIndex = 15;
            this.Btn_natural.UseVisualStyleBackColor = true;
            this.Btn_natural.Click += new System.EventHandler(this.Btn_natural_Click);
            // 
            // Btn_straight
            // 
            this.Btn_straight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_straight.BackgroundImage")));
            this.Btn_straight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_straight.Location = new System.Drawing.Point(471, 403);
            this.Btn_straight.Name = "Btn_straight";
            this.Btn_straight.Size = new System.Drawing.Size(166, 209);
            this.Btn_straight.TabIndex = 16;
            this.Btn_straight.UseVisualStyleBackColor = true;
            this.Btn_straight.Click += new System.EventHandler(this.Btn_straight_Click);
            // 
            // Btn_round
            // 
            this.Btn_round.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_round.BackgroundImage")));
            this.Btn_round.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_round.Location = new System.Drawing.Point(594, 166);
            this.Btn_round.Name = "Btn_round";
            this.Btn_round.Size = new System.Drawing.Size(166, 209);
            this.Btn_round.TabIndex = 11;
            this.Btn_round.UseVisualStyleBackColor = true;
            this.Btn_round.Click += new System.EventHandler(this.Btn_round_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1090, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(37, 38);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_face
            // 
            this.lbl_face.AutoSize = true;
            this.lbl_face.Location = new System.Drawing.Point(20, 36);
            this.lbl_face.Name = "lbl_face";
            this.lbl_face.Size = new System.Drawing.Size(82, 20);
            this.lbl_face.TabIndex = 0;
            this.lbl_face.Text = "얼굴 상태 :";
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Location = new System.Drawing.Point(20, 67);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(67, 20);
            this.lbl_body.TabIndex = 1;
            this.lbl_body.Text = "몸 상태 :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 772);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.Btn_straight);
            this.Controls.Add(this.Btn_natural);
            this.Controls.Add(this.Btn_wave);
            this.Controls.Add(this.Btn_oval);
            this.Controls.Add(this.Btn_triangle);
            this.Controls.Add(this.Btn_round);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_square);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "코디프로그램";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button Btn_square;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_triangle;
        private System.Windows.Forms.Button Btn_oval;
        private System.Windows.Forms.Button Btn_wave;
        private System.Windows.Forms.Button Btn_natural;
        private System.Windows.Forms.Button Btn_straight;
        private System.Windows.Forms.Button Btn_round;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.Label lbl_face;
    }
}