using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Team_Project
{
    public partial class Form5 : Form
    {
        private string url_clothes;
        private string url_accessory;
        private string url_bottom;
        private bool is_clothes = false;
        private bool is_accessory = false;
        private bool is_bottom = false;
        private int form_width;
        private int form_height;
        private Form previousForm;

        public Form5(string url_clothes, string url_accessory, string url_bottom,bool is_clothes_input, bool is_accessory_input, bool is_bottom_input, Form previous_Form)
        {
            InitializeComponent();
            this.url_clothes = url_clothes;
            this.url_accessory = url_accessory;
            this.url_bottom = url_bottom;
            this.is_clothes = is_clothes_input;
            this.is_accessory = is_accessory_input;
            this.is_bottom = is_bottom_input;
            form_width = this.Size.Width;
            form_height = this.Size.Height;
            previousForm = previous_Form;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                Draw_pictureBox(url_clothes, url_accessory, url_bottom, is_clothes, is_accessory, is_bottom);
                previousForm.Close();
            }
            catch
            {
                MessageBox.Show("제대로 선택해주세요!", "Error");
                this.Close();
            }
        }

        private void Draw_pictureBox(string url_clothes, string url_accessory, string url_bottom, bool is_clothes, bool is_accessory, bool is_bottom)
        {
            Dictionary<string, bool> data = new Dictionary<string, bool>
            {
                {url_clothes,is_clothes }, {url_bottom,is_bottom}, {url_accessory,is_accessory}
            };
            Dictionary<string, bool> which_UrlTrue = new Dictionary<string, bool>();

            int trueCount = CountTrueValues(data, out which_UrlTrue);
            if (trueCount == 1)
            {
               
                KeyValuePair<string, bool> true_element = GetElementAt(which_UrlTrue, 0);
                picProfile.SizeMode = PictureBoxSizeMode.AutoSize;
                picProfile.ImageLocation = true_element.Key;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
            else if (trueCount == 2)
            {
                KeyValuePair<string, bool> true_element1 = GetElementAt(which_UrlTrue, 0);
                KeyValuePair<string, bool> true_element2 = GetElementAt(which_UrlTrue, 1);
                pictureBox1.Size= new System.Drawing.Size(form_width/2, form_height);
                pictureBox2.Size = new System.Drawing.Size(form_width / 2, form_height);
                pictureBox1.Location = new System.Drawing.Point(0, 0);
                pictureBox2.Location = new System.Drawing.Point(form_width / 2, 0);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = true_element1.Key;
                pictureBox2.ImageLocation = true_element2.Key;
                picProfile.Visible = false;
            }
            else if (trueCount == 3)
            {
                
                KeyValuePair<string, bool> true_element1 = GetElementAt(which_UrlTrue, 0);
                KeyValuePair<string, bool> true_element2 = GetElementAt(which_UrlTrue, 1);
                KeyValuePair<string, bool> true_element3= GetElementAt(which_UrlTrue, 2);
                picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                picProfile.ImageLocation = true_element1.Key;
                pictureBox1.ImageLocation = true_element2.Key;
                pictureBox2.ImageLocation = true_element3.Key;
                picProfile.Size = new System.Drawing.Size(form_width / 3, form_height);
                picProfile.Location = new System.Drawing.Point(0, 0);
                pictureBox1.Size = new System.Drawing.Size(form_width /3, form_height);
                pictureBox2.Size = new System.Drawing.Size(form_width / 3, form_height);
                pictureBox1.Location = new System.Drawing.Point(form_width / 3, 0);
                pictureBox2.Location = new System.Drawing.Point((form_width / 3)*2, 0);    
            }
        }

        private int CountTrueValues(Dictionary<string, bool> dictionary, out Dictionary<string, bool> trueDictionary)
        {
            int count = 0;
            trueDictionary = new Dictionary<string, bool>();

            foreach (var entry in dictionary)
            {
                if (entry.Value)
                {
                    count++;
                    trueDictionary.Add(entry.Key, entry.Value);
                }
            }

            return count;
        }

        private KeyValuePair<string, bool> GetElementAt(Dictionary<string, bool> dictionary, int index)
        {
            int currentIndex = 0;
            foreach (var entry in dictionary)
            {
                if (currentIndex == index)
                {
                    return entry;
                }
                currentIndex++;
            }

            throw new IndexOutOfRangeException("Index was out of range.");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
