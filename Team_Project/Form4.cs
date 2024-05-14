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

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //경로 설정
            string filePath = @"C:\Users\고재성\Desktop\clothes.xlsx";

            // Excel Application 객체 생성
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
            Worksheet excelWorksheet = excelWorkbook.Sheets[1]; // 첫 번째 시트 선택

            //// 엑셀 시트의 행과 열 반복
            //for (int row = 1; row <= excelWorksheet.UsedRange.Rows.Count; row++)
            //{
            //    for (int col = 1; col <= excelWorksheet.UsedRange.Columns.Count; col++)
            //    {
            //        Range cell = excelWorksheet.Cells[row, col];
            //        string cellValue = (cell.Value2 != null) ? cell.Value2.ToString() : "";

            //        // URL 패턴인지 확인 (여기서는 간단히 "http://" 또는 "https://"로 시작하는 것으로 가정)
            //        if (cellValue.StartsWith("http://") || cellValue.StartsWith("https://"))
            //        {
            //            // URL 주소가 있는 경우 처리 (여기서는 간단히 콘솔에 출력)
            //            Console.WriteLine("URL 주소: " + cellValue);
            //            Form5 dForm = new Form5(cellValue);
            //            dForm.Show();

            //        }
            //    }
            //}

            for (int row = 1; row <= excelWorksheet.UsedRange.Rows.Count; row++)
            {
                string cellValue = excelWorksheet.Cells[row, 5].Value;
                if (cellValue.StartsWith("http://") || cellValue.StartsWith("https://"))
                {
                    // URL 주소가 있는 경우 처리 (여기서는 간단히 콘솔에 출력)
                    Console.WriteLine("URL 주소: " + cellValue);
                    Form5 dForm = new Form5(cellValue);
                    dForm.Show();

                }
            }
            // Excel 객체 해제
            excelWorkbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }
    }
 }


