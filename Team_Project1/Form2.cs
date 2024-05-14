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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String SetBMI_M(float bmi)
        {
            float bmiIndex = bmi;

            if (bmiIndex <= 20)
            {
                return "BMI : " + bmiIndex.ToString()+" 저체중";
            }
            else if (bmiIndex <= 24.9)
            {
                return "BMI : " + bmiIndex.ToString() + " 적정 체중";
            }
            else
            {
                return "BMI : " + bmiIndex.ToString() + " 과체중";
            }
        }

        private String SetBMI_W(float bmi)
        {
            float bmiIndex = bmi;

            if (bmiIndex <= 18.5)
            {
                return "BMI : " + bmiIndex.ToString() + " 저체중";
            }
            else if (bmiIndex <= 23.9)
            {
                return "BMI : " + bmiIndex.ToString() + " 적정 체중";
            }
            else
            {
                return "BMI : " + bmiIndex.ToString() + " 과체중";
            }
        }

        private void manBtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void womanBtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void height_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (manBtn.Checked)
            {
                float in_height = float.Parse(height.Text) / 100;
                float in_weight = float.Parse(weight.Text);
                float bmi = in_weight / (in_height * in_height);
                var ThirdForm = new Form3();
                ThirdForm.VariableFromSecondForm = SetBMI_M(bmi);
                ThirdForm.Show();
            }
            else if (womanBtn.Checked)
            {
                float in_height = float.Parse(height.Text) / 100;
                float in_weight = float.Parse(weight.Text);
                float bmi = in_weight / (in_height * in_height);
                var FourthForm = new Form4();
                FourthForm.VariableFromSecondForm = SetBMI_W(bmi);
                FourthForm.Show();
            }
        }
    }
}
