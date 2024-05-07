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
            this.manBtn = new System.Windows.Forms.RadioButton();
            this.womanBtn = new System.Windows.Forms.RadioButton();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clsBtn
            // 
            this.clsBtn.Location = new System.Drawing.Point(625, 344);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(75, 23);
            this.clsBtn.TabIndex = 0;
            this.clsBtn.Text = "button1";
            this.clsBtn.UseVisualStyleBackColor = true;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.womanBtn);
            this.groupBox1.Controls.Add(this.manBtn);
            this.groupBox1.Location = new System.Drawing.Point(275, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
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
            // height
            // 
            this.height.Location = new System.Drawing.Point(275, 95);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(234, 25);
            this.height.TabIndex = 2;
            this.height.Text = "키";
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(275, 186);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(234, 25);
            this.weight.TabIndex = 3;
            this.weight.Text = "몸무게";
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clsBtn);
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
    }
}