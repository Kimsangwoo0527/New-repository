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

namespace Team_Project
{
    public partial class Form3 : Form
    {
        private string size_value;
        private string gender_value;
        private string body_value;
        private string face_value;
        private string url_value;
        private bool is_Btn_oval = false;
        private bool is_Btn_square = false;
        private bool is_Btn_round = false;
        private bool is_Btn_triangle = false;
        private bool is_Btn_straight = false;
        private bool is_Btn_wave = false;
        private bool is_Btn_natural = false;

        public string VariableFromSecondForm_size { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //string sizeValue = GlobalData.dataset.Tables["Clothes"].Rows[0]["Size"].ToString();
            //Console.WriteLine(sizeValue);
            ////상대 경로 설정
            //string relativePath = "clothes.xlsx";
            //string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            //// Excel Application 객체 생성
            //Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
            //Worksheet excelWorksheet = excelWorkbook.Sheets[1]; // 첫 번째 시트 선택

            //for (int row = 1; row <= excelWorksheet.UsedRange.Rows.Count; row++)
            //{

            //    string cellValue_size = excelWorksheet.Cells[row, 1].Value;
            //    string cellValue_gender = excelWorksheet.Cells[row, 2].Value;
            //    string cellValue_body = excelWorksheet.Cells[row, 3].Value;
            //    string cellValue_face = excelWorksheet.Cells[row, 4].Value;
            //    string cellValue_url = excelWorksheet.Cells[row, 5].Value;

            //    if ((cellValue_size == VariableFromSecondForm_size) && (cellValue_gender == "Man") && (cellValue_body == Classify_body()) && (cellValue_face == Classify_face()))
            //    {
            //        // URL 주소가 있는 경우 처리                    
            //        Form5 dForm = new Form5(cellValue_url);
            //        dForm.Show();

            //    }


            //}

            //// Excel 객체 해제
            //excelWorkbook.Close();
            //excelApp.Quit();
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            for (int i = 0; i < GlobalData.dataset.Clothes.Rows.Count; i++)
            {
                size_value = GlobalData.dataset.Tables["Clothes"].Rows[i]["Size"].ToString();
                gender_value = GlobalData.dataset.Tables["Clothes"].Rows[i]["Gender"].ToString();
                body_value = GlobalData.dataset.Tables["Clothes"].Rows[i]["Body"].ToString();
                face_value = GlobalData.dataset.Tables["Clothes"].Rows[i]["Face"].ToString();
                url_value = GlobalData.dataset.Tables["Clothes"].Rows[i]["Url"].ToString();
                if ((size_value == VariableFromSecondForm_size) && (gender_value == "Man") && (body_value == Classify_body()) && (face_value == Classify_face()))
                {
                    // URL 주소가 있는 경우 처리                    
                    Form5 dForm = new Form5(url_value);
                    dForm.Show();

                }
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
            lbl_face.Text = "얼굴 상태 : 계란형 얼굴";
        }

        private void Btn_square_Click(object sender, EventArgs e)
        {
            is_Btn_oval = false;
            is_Btn_square = true;
            is_Btn_round = false;
            is_Btn_triangle = false;
            lbl_face.Text = "얼굴 상태 : 각진 얼굴";
        }

        private void Btn_round_Click(object sender, EventArgs e)
        {
            is_Btn_oval = false;
            is_Btn_square = false;
            is_Btn_round = true;
            is_Btn_triangle = false;
            lbl_face.Text = "얼굴 상태 : 둥근 얼굴";
        }

        private void Btn_triangle_Click(object sender, EventArgs e)
        {
            is_Btn_oval = false;
            is_Btn_square = false;
            is_Btn_round = false;
            is_Btn_triangle = true;
            lbl_face.Text = "얼굴 상태 : 역삼각형 얼굴";
        }

        private void Btn_natural_Click(object sender, EventArgs e)
        {
            is_Btn_straight = false;
            is_Btn_wave = false;
            is_Btn_natural = true;
            lbl_body.Text = "몸 상태 : 내추럴";
        }
        private void Btn_straight_Click(object sender, EventArgs e)
        {
            is_Btn_straight = true;
            is_Btn_wave = false;
            is_Btn_natural = false;
            lbl_body.Text = "몸 상태 : 스트레이트";
        }

        private void Btn_wave_Click(object sender, EventArgs e)
        {
            is_Btn_straight = false;
            is_Btn_wave = true;
            is_Btn_natural = false;
            lbl_body.Text = "몸 상태 : 웨이브";
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
    }
}
