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
            this.clsBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.womanBtn = new System.Windows.Forms.RadioButton();
            this.manBtn = new System.Windows.Forms.RadioButton();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clsBtn
            // 
            this.clsBtn.Location = new System.Drawing.Point(781, 413);
            this.clsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(94, 28);
            this.clsBtn.TabIndex = 0;
            this.clsBtn.Text = "button1";
            this.clsBtn.UseVisualStyleBackColor = true;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.womanBtn);
            this.groupBox1.Controls.Add(this.manBtn);
            this.groupBox1.Location = new System.Drawing.Point(344, 306);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(292, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // womanBtn
            // 
            this.womanBtn.AutoSize = true;
            this.womanBtn.Location = new System.Drawing.Point(169, 43);
            this.womanBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.womanBtn.Name = "womanBtn";
            this.womanBtn.Size = new System.Drawing.Size(94, 22);
            this.womanBtn.TabIndex = 1;
            this.womanBtn.TabStop = true;
            this.womanBtn.Text = "Woman";
            this.womanBtn.UseVisualStyleBackColor = true;
            this.womanBtn.CheckedChanged += new System.EventHandler(this.womanBtn_CheckedChanged);
            // 
            // manBtn
            // 
            this.manBtn.AutoSize = true;
            this.manBtn.Location = new System.Drawing.Point(35, 43);
            this.manBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manBtn.Name = "manBtn";
            this.manBtn.Size = new System.Drawing.Size(68, 22);
            this.manBtn.TabIndex = 0;
            this.manBtn.TabStop = true;
            this.manBtn.Text = "Man";
            this.manBtn.UseVisualStyleBackColor = true;
            this.manBtn.CheckedChanged += new System.EventHandler(this.manBtn_CheckedChanged);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(344, 114);
            this.height.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(292, 28);
            this.height.TabIndex = 2;
            this.height.Text = "키";
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(344, 223);
            this.weight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(292, 28);
            this.weight.TabIndex = 3;
            this.weight.Text = "몸무게";
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(361, 435);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(236, 36);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "다음 화면으로";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clsBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button nextBtn;
    }
}