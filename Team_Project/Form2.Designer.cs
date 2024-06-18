namespace Team_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.clsBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.womanBtn = new System.Windows.Forms.RadioButton();
            this.manBtn = new System.Windows.Forms.RadioButton();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.topButton = new System.Windows.Forms.RadioButton();
            this.bottomButton = new System.Windows.Forms.RadioButton();
            this.glassesButton = new System.Windows.Forms.RadioButton();
=======
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clsBtn
            // 
            this.clsBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
<<<<<<< HEAD
            this.clsBtn.Location = new System.Drawing.Point(35, 492);
=======
            this.clsBtn.Location = new System.Drawing.Point(35, 490);
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(199, 30);
            this.clsBtn.TabIndex = 0;
            this.clsBtn.Text = "이전으로";
            this.clsBtn.UseVisualStyleBackColor = true;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.womanBtn);
            this.groupBox1.Controls.Add(this.manBtn);
<<<<<<< HEAD
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(125, 325);
=======
            this.groupBox1.Location = new System.Drawing.Point(128, 376);
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // womanBtn
            // 
            this.womanBtn.AutoSize = true;
            this.womanBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.womanBtn.Location = new System.Drawing.Point(135, 34);
            this.womanBtn.Name = "womanBtn";
            this.womanBtn.Size = new System.Drawing.Size(83, 24);
            this.womanBtn.TabIndex = 1;
            this.womanBtn.TabStop = true;
            this.womanBtn.Text = "Woman";
            this.womanBtn.UseVisualStyleBackColor = true;
            this.womanBtn.CheckedChanged += new System.EventHandler(this.womanBtn_CheckedChanged);
            // 
            // manBtn
            // 
            this.manBtn.AutoSize = true;
            this.manBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.manBtn.Location = new System.Drawing.Point(28, 34);
            this.manBtn.Name = "manBtn";
            this.manBtn.Size = new System.Drawing.Size(61, 24);
            this.manBtn.TabIndex = 0;
            this.manBtn.TabStop = true;
            this.manBtn.Text = "Man";
            this.manBtn.UseVisualStyleBackColor = true;
            this.manBtn.CheckedChanged += new System.EventHandler(this.manBtn_CheckedChanged);
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.height.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.height.Location = new System.Drawing.Point(153, 228);
=======
            this.height.Location = new System.Drawing.Point(128, 275);
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(175, 27);
            this.height.TabIndex = 2;
            this.height.Text = "키";
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.weight.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.weight.Location = new System.Drawing.Point(153, 272);
=======
            this.weight.Location = new System.Drawing.Point(128, 334);
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(175, 27);
            this.weight.TabIndex = 3;
            this.weight.Text = "몸무게";
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
<<<<<<< HEAD
            this.btn_next.Location = new System.Drawing.Point(263, 492);
=======
            this.btn_next.Location = new System.Drawing.Point(263, 490);
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(197, 30);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "다음 장으로";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
<<<<<<< HEAD
            this.pictureBox1.Location = new System.Drawing.Point(128, 27);
=======
            this.pictureBox1.Location = new System.Drawing.Point(112, 40);
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(463, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(37, 38);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
<<<<<<< HEAD
            // 
            // topButton
            // 
            this.topButton.AutoSize = true;
            this.topButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.topButton.Location = new System.Drawing.Point(112, 434);
            this.topButton.Name = "topButton";
            this.topButton.Size = new System.Drawing.Size(60, 24);
            this.topButton.TabIndex = 2;
            this.topButton.TabStop = true;
            this.topButton.Text = "상의";
            this.topButton.UseVisualStyleBackColor = true;
            // 
            // bottomButton
            // 
            this.bottomButton.AutoSize = true;
            this.bottomButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bottomButton.Location = new System.Drawing.Point(216, 434);
            this.bottomButton.Name = "bottomButton";
            this.bottomButton.Size = new System.Drawing.Size(60, 24);
            this.bottomButton.TabIndex = 9;
            this.bottomButton.TabStop = true;
            this.bottomButton.Text = "하의";
            this.bottomButton.UseVisualStyleBackColor = true;
            // 
            // glassesButton
            // 
            this.glassesButton.AutoSize = true;
            this.glassesButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.glassesButton.Location = new System.Drawing.Point(319, 434);
            this.glassesButton.Name = "glassesButton";
            this.glassesButton.Size = new System.Drawing.Size(60, 24);
            this.glassesButton.TabIndex = 10;
            this.glassesButton.TabStop = true;
            this.glassesButton.Text = "안경";
            this.glassesButton.UseVisualStyleBackColor = true;
=======
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 568);
<<<<<<< HEAD
            this.Controls.Add(this.glassesButton);
            this.Controls.Add(this.bottomButton);
            this.Controls.Add(this.topButton);
=======
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "코디프로그램";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clsBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton womanBtn;
        private System.Windows.Forms.RadioButton manBtn;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Button btn_next;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_close;
<<<<<<< HEAD
        private System.Windows.Forms.RadioButton topButton;
        private System.Windows.Forms.RadioButton bottomButton;
        private System.Windows.Forms.RadioButton glassesButton;
=======
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
    }
}