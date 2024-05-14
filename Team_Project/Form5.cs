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
    public partial class Form5 : Form
    {
        private string url;
        public Form5(string url)
        {
            InitializeComponent();
            this.url = url;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            picProfile.ImageLocation = url;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
