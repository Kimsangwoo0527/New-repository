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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clsBtn
            // 
            this.clsBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clsBtn.FlatAppearance.BorderSize = 2;
            this.clsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.clsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.clsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clsBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clsBtn.Location = new System.Drawing.Point(34, 469);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(193, 33);
            this.clsBtn.TabIndex = 0;
            this.clsBtn.Text = "이전으로";
            this.clsBtn.UseVisualStyleBackColor = false;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.womanBtn);
            this.groupBox1.Controls.Add(this.manBtn);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(118, 376);
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
            this.height.BackColor = System.Drawing.Color.WhiteSmoke;
            this.height.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.height.ForeColor = System.Drawing.Color.DarkGray;
            this.height.Location = new System.Drawing.Point(153, 283);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(175, 27);
            this.height.TabIndex = 2;
            this.height.Text = "키";
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // weight
            // 
            this.weight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weight.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.weight.ForeColor = System.Drawing.Color.Gray;
            this.weight.Location = new System.Drawing.Point(153, 328);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(175, 27);
            this.weight.TabIndex = 3;
            this.weight.Text = "몸무게";
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_next.FlatAppearance.BorderSize = 2;
            this.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_next.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_next.Location = new System.Drawing.Point(266, 469);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(193, 33);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "다음 장으로";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 48);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(-1, 520);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 48);
            this.panel2.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clsBtn);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}