using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Team_Project
{
    public partial class Form4 : Form
    {
        public string VariableFromSecondForm_size { get; set; }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //상대 경로 설정
            string relativePath = "clothes.xlsx";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            // Excel Application 객체 생성
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
            Worksheet excelWorksheet = excelWorkbook.Sheets[1]; // 첫 번째 시트 선택

            for (int row = 1; row <= excelWorksheet.UsedRange.Rows.Count; row++)
            {
                string cellValue_size = excelWorksheet.Cells[row, 1].Value;
                string cellValue_gender = excelWorksheet.Cells[row, 2].Value;
                string cellValue_body = excelWorksheet.Cells[row, 3].Value;
                string cellValue_face = excelWorksheet.Cells[row, 4].Value;
                string cellValue_url = excelWorksheet.Cells[row, 5].Value;
                if ((cellValue_size == VariableFromSecondForm_size) && (cellValue_gender == "Woman") && (cellValue_body == Classify_body()) && (cellValue_face == Classify_face()))
                {
                    // URL 주소가 있는 경우 처리 
                    Form5 diForm = new Form5(cellValue_url);
                    diForm.Show();

                }


            }

            // Excel 객체 해제
            excelWorkbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }

        private String Classify_body()
        {
            if (straightBtn_W.Checked)
                return "straight";
            else if (waveBtn_W.Checked)
                return "wave";
            else
                return "natural";
        }

        private String Classify_face()
        {
            if (ovalBtn_W.Checked)
                return "oval";
            else if (roundBtn_W.Checked)
                return "round";
            else if (squareBtn_W.Checked)
                return "square";
            else
                return "triangle";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }


