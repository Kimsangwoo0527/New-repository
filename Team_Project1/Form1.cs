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
    public partial class Form1 : Form
    {
        private string Input_id="1";
        private string Input_password="2";



        public Form1()
        {
            InitializeComponent();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string userId = id.Text;
            string userPassword = password.Text;

            if (userId.Equals(Input_id) && userPassword.Equals(Input_password))
            {
                MessageBox.Show("로그인에 성공했습니다.", "로그인");
                Form2 form2 = new Form2();
                form2.Show();
            }

            else
            {
                MessageBox.Show("로그인에 실패했습니다.", "로그인");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
