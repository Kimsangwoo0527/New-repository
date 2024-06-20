using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Team_Project
{
    public partial class Form3 : Form
    {
        private string size_value;
        private string gender_value;
        private string body_value;
        private string face_value;
        private bool is_Btn_oval = false;
        private bool is_Btn_square = false;
        private bool is_Btn_round = false;
        private bool is_Btn_triangle = false;
        private bool is_Btn_straight = false;
        private bool is_Btn_wave = false;
        private bool is_Btn_natural = false;
        private bool is_Btn_top = false;
        private bool is_Btn_bottom = false;
        private bool is_Btn_glasses = false;
        private string clothes_url;
        private string accessory_url;
        private string bottom_url;
        private int click_top = 0;
        private int click_bottom = 0;
        private int click_glasses = 0;


        public string VariableFromSecondForm_size { get; set; }
        public Form3()
        {
            InitializeComponent();
            oval_panel.Visible = false;
            square_panel.Visible = false;
            round_panel.Visible = false;
            triangle_panel.Visible = false;
            wave_panel.Visible = false;
            straight_panel.Visible = false;
            natural_panel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < GlobalData.dataset.Clothes.Rows.Count; i++)
            {
                size_value = GlobalData.dataset.Tables["Clothes"].Rows[i]["Size"].ToString();
                gender_value = GlobalData.dataset.Tables["Clothes"].Rows[i]["Gender"].ToString();
                body_value = GlobalData.dataset.Tables["Clothes"].Rows[i]["Body"].ToString();
                face_value = GlobalData.dataset.Tables["Clothes"].Rows[i]["Face"].ToString();
                string clothes_url_value = GlobalData.dataset.Tables["Clothes"].Rows[i]["Url"].ToString();
                if ((size_value == VariableFromSecondForm_size) && (gender_value == "Man") && (body_value == Classify_body()) && (face_value == Classify_face()))
                {
                    clothes_url = clothes_url_value;

                }
            }

            for (int i = 0; i < GlobalData.dataset.Accessory.Rows.Count; i++)
            {
                face_value = GlobalData.dataset.Tables["Accessory"].Rows[i]["Face"].ToString();
                gender_value = GlobalData.dataset.Tables["Accessory"].Rows[i]["Gender"].ToString();
                string accessory_url_value = GlobalData.dataset.Tables["Accessory"].Rows[i]["Url"].ToString();
                if ((gender_value == "Man") && (face_value == Classify_face()))
                {
                    accessory_url = accessory_url_value;
                }
            }

            for (int i = 0; i < GlobalData.dataset.Bottom.Rows.Count; i++)
            {
                size_value = GlobalData.dataset.Tables["Bottom"].Rows[i]["Size"].ToString();
                gender_value = GlobalData.dataset.Tables["Bottom"].Rows[i]["Gender"].ToString();
                body_value = GlobalData.dataset.Tables["Bottom"].Rows[i]["Body"].ToString();
                string bottom_url_value = GlobalData.dataset.Tables["Bottom"].Rows[i]["Url"].ToString();
                if ((size_value == VariableFromSecondForm_size) && (gender_value == "Man") && (body_value == Classify_body()))
                {
                    bottom_url = bottom_url_value;
                }
            }
            if (is_Btn_top==false&&is_Btn_bottom==false&&is_Btn_glasses==false)
            {
                MessageBox.Show("제대로 선택해주세요!", "Error");
            }
            else
            {
                Form5 dForm = new Form5(clothes_url, accessory_url, bottom_url, is_Btn_top, is_Btn_glasses, is_Btn_bottom, this);
                dForm.Show();
            }
        }

        private String Classify_body()
        {
            if (is_Btn_straight)
                return "straight";
            else if (is_Btn_wave)
                return "wave";
            else if (is_Btn_natural)
                return "natural";
            else
                return "fault";
        }

        private String Classify_face()
        {
            if (is_Btn_oval)
                return "oval";
            if (is_Btn_square)
                return "round";
            if (is_Btn_round)
                return "square";
            if (is_Btn_triangle)
                return "triangle";
            else
                return "fault";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Btn_oval 클릭했을 때 이벤트
            is_Btn_oval = true;
            is_Btn_square = false;
            is_Btn_round = false;
            is_Btn_triangle = false;
            oval_panel.Visible = true;
            square_panel.Visible = false;
            round_panel.Visible = false;
            triangle_panel.Visible = false;
        }

        private void Btn_square_Click(object sender, EventArgs e)
        {
            is_Btn_oval = false;
            is_Btn_square = true;
            is_Btn_round = false;
            is_Btn_triangle = false;
            oval_panel.Visible = false;
            square_panel.Visible = true;
            round_panel.Visible = false;
            triangle_panel.Visible = false;
        }

        private void Btn_round_Click(object sender, EventArgs e)
        {
            is_Btn_oval = false;
            is_Btn_square = false;
            is_Btn_round = true;
            is_Btn_triangle = false;
            oval_panel.Visible = false;
            square_panel.Visible = false;
            round_panel.Visible = true;
            triangle_panel.Visible = false;

        }

        private void Btn_triangle_Click(object sender, EventArgs e)
        {
            is_Btn_oval = false;
            is_Btn_square = false;
            is_Btn_round = false;
            is_Btn_triangle = true;
            oval_panel.Visible = false;
            square_panel.Visible = false;
            round_panel.Visible = false;
            triangle_panel.Visible = true;
        }
        private void Btn_natural_Click_1(object sender, EventArgs e)
        {
            is_Btn_straight = false;
            is_Btn_wave = false;
            is_Btn_natural = true;
            wave_panel.Visible = false;
            straight_panel.Visible = false;
            natural_panel.Visible = true;
        }
     
        private void Btn_straight_Click(object sender, EventArgs e)
        {
            is_Btn_straight = true;
            is_Btn_wave = false;
            is_Btn_natural = false;
            wave_panel.Visible = false;
            straight_panel.Visible = true;
            natural_panel.Visible = false;
        }

        private void Btn_wave_Click(object sender, EventArgs e)
        {
            is_Btn_straight = false;
            is_Btn_wave = true;
            is_Btn_natural = false;
            wave_panel.Visible = true;
            straight_panel.Visible = false;
            natural_panel.Visible = false;
        }

        private void Btn_top_Click(object sender, EventArgs e)
        {
            click_top++;
            if (click_top % 2 == 1)
            {
                is_Btn_top = true;
                Btn_top.BackColor = Color.LightBlue;
            }
            else
            {
                is_Btn_top = false;
                Btn_top.BackColor = Color.White;
            }
        }

        private void Btn_bottom_Click(object sender, EventArgs e)
        {
            click_bottom++;
            if (click_bottom % 2 == 1)
            {
                is_Btn_bottom = true;
                Btn_bottom.BackColor = Color.LightBlue;
            }
            else
            {
                is_Btn_bottom = false;
                Btn_bottom.BackColor = Color.White;
            }
        }

        private void Btn_glasses_Click(object sender, EventArgs e)
        {
            click_glasses++;
            if (click_glasses % 2 == 1)
            {
                is_Btn_glasses = true;
                Btn_glasses.BackColor = Color.LightBlue;
            }
            else
            {
                is_Btn_glasses = false;
                Btn_glasses.BackColor = Color.White;
            }
        }

        private void pictureBoxface_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxbody_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Btn_natural_Click(object sender, EventArgs e)
        {

        }

    }
}
