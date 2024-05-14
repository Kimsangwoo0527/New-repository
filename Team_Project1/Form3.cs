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
    public partial class Form3 : Form
    {
        public string VariableFromSecondForm { get; set; }
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = VariableFromSecondForm;
            Get_faceresult();
        }

        void Get_faceresult()
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ovalBtn_M_CheckedChanged(object sender, EventArgs e)
        {
            if (ovalBtn_M.Checked)
            {
                label2.Text = "계란형 얼굴";
            }
        }

        private void roundBtn_M_CheckedChanged(object sender, EventArgs e)
        {
            if (ovalBtn_M.Checked)
            {
                label2.Text = "둥근 얼굴";
            }
        }

        private void squareBtn_M_CheckedChanged(object sender, EventArgs e)
        {
            if (squareBtn_M.Checked)
            {
                label2.Text = "각진 얼굴";
            }
        }

        private void triangleBtn_M_CheckedChanged(object sender, EventArgs e)
        {
            if (triangleBtn_M.Checked)
            {
                label2.Text = "역삼각형 얼굴";
            }
        }

        private void straightBtn_M_CheckedChanged(object sender, EventArgs e)
        {
            if (straightBtn_M.Checked)
            {
                label3.Text = "스트레이트 체형";
            }
        }

        private void waveBtn_M_CheckedChanged(object sender, EventArgs e)
        {
            if (waveBtn_M.Checked)
            {
                label3.Text = "웨이브 체형";
            }
        }

        private void naturalBtn_M_CheckedChanged(object sender, EventArgs e)
        {
            if (naturalBtn_M.Checked)
            {
                label3.Text = "내추럴 체형";
            }
        }
    }
}
