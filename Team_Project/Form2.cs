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

        private String SetBMI(float bmi)
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

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                float in_height = float.Parse(height.Text);
                float in_weight = float.Parse(weight.Text);
                if (manBtn.Checked)
                {
                    
                    var ThirdForm = new Form3();
                    ThirdForm.VariableFromSecondForm_size = Classify_size(in_height, in_weight, true);
                    ThirdForm.Show();
                }

                if (womanBtn.Checked)
                {
                    var FourthForm = new Form4();
                    FourthForm.VariableFromSecondForm_size = Classify_size(in_height, in_weight, false);
                    FourthForm.Show();
                }
            }
            catch
            {
                MessageBox.Show("키와 몸무게를 제대로 입력해주세요.", "Error");
            }
            
        }

        private string Classify_size(float h, float w, bool M)
        {
            float new_h = h / 100;
            float bmi = w / (new_h * new_h);
            string size;
            if (M)
            {
                if (bmi >= 30)
                {
                    size = "XL";
                    return size;
                }
                else if (bmi >= 24.9 && bmi < 30)
                {
                    size = "L";
                    return size;
                }
                else if (bmi >= 20 && bmi < 24.8)
                {
                    size = "M";
                    return size;
                }
                else
                {
                    size = "S";
                    return size;
                }
            }
            else
            {
                if (bmi >= 30)
                {
                    size = "XL";
                    return size;
                }
                else if (bmi >= 23.9 && bmi < 30)
                {
                    size = "L";
                    return size;
                }
                else if (bmi >= 18.5 && bmi < 23.9)
                {
                    size = "M";
                    return size;
                }
                else
                {
                    size = "S";
                    return size;
                }
            }
        }
    }
}
