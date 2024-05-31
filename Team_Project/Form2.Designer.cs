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
<<<<<<< HEAD
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
=======
>>>>>>> ce2ea5bbf4292b2c09ba31ea5ccf380d8600ee40
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clsBtn
            // 
<<<<<<< HEAD
            this.clsBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clsBtn.Location = new System.Drawing.Point(77, 479);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(183, 45);
            this.clsBtn.TabIndex = 0;
            this.clsBtn.Text = "Before";
=======
            this.clsBtn.Location = new System.Drawing.Point(125, 366);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(234, 23);
            this.clsBtn.TabIndex = 0;
            this.clsBtn.Text = "이전으로";
>>>>>>> ce2ea5bbf4292b2c09ba31ea5ccf380d8600ee40
            this.clsBtn.UseVisualStyleBackColor = true;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.womanBtn);
            this.groupBox1.Controls.Add(this.manBtn);
            this.groupBox1.Location = new System.Drawing.Point(174, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // womanBtn
            // 
            this.womanBtn.AutoSize = true;
            this.womanBtn.Location = new System.Drawing.Point(135, 36);
            this.womanBtn.Name = "womanBtn";
            this.womanBtn.Size = new System.Drawing.Size(78, 19);
            this.womanBtn.TabIndex = 1;
            this.womanBtn.TabStop = true;
            this.womanBtn.Text = "Woman";
            this.womanBtn.UseVisualStyleBackColor = true;
            this.womanBtn.CheckedChanged += new System.EventHandler(this.womanBtn_CheckedChanged);
            // 
            // manBtn
            // 
            this.manBtn.AutoSize = true;
            this.manBtn.Location = new System.Drawing.Point(28, 36);
            this.manBtn.Name = "manBtn";
            this.manBtn.Size = new System.Drawing.Size(56, 19);
            this.manBtn.TabIndex = 0;
            this.manBtn.TabStop = true;
            this.manBtn.Text = "Man";
            this.manBtn.UseVisualStyleBackColor = true;
            this.manBtn.CheckedChanged += new System.EventHandler(this.manBtn_CheckedChanged);
            // 
            // height
            // 
            this.height.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.height.Location = new System.Drawing.Point(174, 270);
=======
            this.height.Location = new System.Drawing.Point(275, 95);
>>>>>>> ce2ea5bbf4292b2c09ba31ea5ccf380d8600ee40
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(234, 25);
            this.height.TabIndex = 2;
            this.height.Text = "키";
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // weight
            // 
            this.weight.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.weight.Location = new System.Drawing.Point(174, 321);
=======
            this.weight.Location = new System.Drawing.Point(275, 186);
>>>>>>> ce2ea5bbf4292b2c09ba31ea5ccf380d8600ee40
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(234, 25);
            this.weight.TabIndex = 3;
            this.weight.Text = "몸무게";
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // btn_next
            // 
<<<<<<< HEAD
            this.btn_next.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_next.Location = new System.Drawing.Point(312, 479);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(183, 45);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
=======
            this.btn_next.Location = new System.Drawing.Point(410, 366);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(234, 23);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "다음 장으로";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
>>>>>>> ce2ea5bbf4292b2c09ba31ea5ccf380d8600ee40
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 577);
            this.Controls.Add(this.pictureBox1);
=======
            this.ClientSize = new System.Drawing.Size(800, 450);
>>>>>>> ce2ea5bbf4292b2c09ba31ea5ccf380d8600ee40
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
<<<<<<< HEAD
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
=======
>>>>>>> ce2ea5bbf4292b2c09ba31ea5ccf380d8600ee40
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
<<<<<<< HEAD
        private System.Windows.Forms.PictureBox pictureBox1;
=======
>>>>>>> ce2ea5bbf4292b2c09ba31ea5ccf380d8600ee40
    }
}