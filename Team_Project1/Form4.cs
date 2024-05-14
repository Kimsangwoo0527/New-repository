using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project
{
    public partial class Form4 : Form
    {
        public string VariableFromSecondForm { get; set; }

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = VariableFromSecondForm;
        }

        private void straightBtn_W_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ovalBtn_W_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void squareBtn_W_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void roundBtn_W_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void triangleBtn_W_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void waveBtn_W_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void naturalBtn_W_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
