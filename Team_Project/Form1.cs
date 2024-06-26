﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Team_Project
{
    public partial class Form1 : Form
    {
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
            if (CheckLogin(userId, userPassword))
            {
                MessageBox.Show("로그인에 성공했습니다.", "Login");
                Form2 form2 = new Form2();
                form2.Show();
            }

            else
            {
                MessageBox.Show("로그인에 실패했습니다.", "Login");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //상대 경로 설정
            string relativePath = "clothes.xlsx";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

<<<<<<< HEAD
            string relativePath1 = "accessory.xlsx";
            string filePath1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath1);

            string relativePath2 = "하의 2.xlsx";
            string filePath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath2);

=======
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
            // Excel Application 객체 생성
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
            Worksheet excelWorksheet = excelWorkbook.Sheets[1]; // 첫 번째 시트 선택

<<<<<<< HEAD
            Microsoft.Office.Interop.Excel.Application excelApp1 = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook1 = excelApp1.Workbooks.Open(filePath1);
            Worksheet excelWorksheet1 = excelWorkbook1.Sheets[1];

            Microsoft.Office.Interop.Excel.Application excelApp2 = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook2 = excelApp2.Workbooks.Open(filePath2);
            Worksheet excelWorksheet2 = excelWorkbook2.Sheets[1];

            for (int row = 2; row <= excelWorksheet.UsedRange.Rows.Count; row++)
            {
=======
            for (int row = 2; row <= excelWorksheet.UsedRange.Rows.Count; row++)
            {

>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
                string cellValue_size = excelWorksheet.Cells[row, 1].Value;
                string cellValue_gender = excelWorksheet.Cells[row, 2].Value;
                string cellValue_body = excelWorksheet.Cells[row, 3].Value;
                string cellValue_face = excelWorksheet.Cells[row, 4].Value;
                string cellValue_url = excelWorksheet.Cells[row, 5].Value;
                GlobalData.dataset.Tables["Clothes"].Rows.Add(new object[] { row-1, cellValue_size, cellValue_gender, cellValue_body, cellValue_face, cellValue_url });
            }

<<<<<<< HEAD
            for (int row = 2; row <= excelWorksheet1.UsedRange.Rows.Count; row++)
            {
                string cellValue_face1 = excelWorksheet1.Cells[row, 1].Value;
                string cellValue_gender1 = excelWorksheet1.Cells[row, 2].Value;
                string cellValue_url1 = excelWorksheet1.Cells[row, 3].Value;
                GlobalData.dataset.Tables["Accessory"].Rows.Add(new object[] { cellValue_face1, cellValue_gender1, cellValue_url1 });
            }

            for (int row = 2; row <= excelWorksheet2.UsedRange.Rows.Count; row++)
            {
                string cellValue_size2 = excelWorksheet1.Cells[row, 1].Value;
                string cellValue_gender2 = excelWorksheet1.Cells[row, 2].Value;
                string cellValue_body2 = excelWorksheet1.Cells[row, 3].Value;
                string cellValue_url2 = excelWorksheet1.Cells[row, 4].Value;
                GlobalData.dataset.Tables["Bottom"].Rows.Add(new object[] { cellValue_size2, cellValue_gender2, cellValue_body2 ,cellValue_url2 });
            }

=======
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
            // Excel 객체 해제
            excelWorkbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
<<<<<<< HEAD

            excelWorkbook1.Close();
            excelApp1.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp1);

            excelWorkbook2.Close();
            excelApp2.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp2);
=======
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
            //dataset 뭐 있는지 출력
            //foreach (DataRow row in GlobalData.dataset.Clothes.Rows)
            //{
            //    foreach (DataColumn col in GlobalData.dataset.Clothes.Columns)
            //    {
            //        Console.Write($"{col.ColumnName}: {row[col]} \t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            Form6 joinForm = new Form6();
            joinForm.Show();
        }

        private bool CheckLogin(string studentID, string password)
        {
            // 엑셀 파일 경로 설정
            string relativePath = "회원가입정보.xlsx";
            string excelFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Open(excelFilePath);
                worksheet = workbook.Sheets[1];

                // 마지막 행 번호 찾기
                int lastRow = worksheet.Cells[worksheet.Rows.Count, 1].End[Excel.XlDirection.xlUp].Row;

                // 회원가입 정보 확인
                for (int row = 2; row <= lastRow; row++)
                {
                    object cellValueID = worksheet.Cells[row, 1].Value;
                    object cellValuePassword = worksheet.Cells[row, 2].Value;

                    string savedID = cellValueID != null ? cellValueID.ToString() : "";
                    string savedPassword = cellValuePassword != null ? cellValuePassword.ToString() : "";

                    if (studentID == savedID && password == savedPassword)
                    {
                        return true; // 로그인 성공
                    }
                }

                return false; // 일치하는 정보가 없는 경우
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.ToString());
                return false;
            }
            finally
            {
                // 객체 해제
                if (worksheet != null)
                    Marshal.ReleaseComObject(worksheet);
                if (workbook != null)
                {
                    workbook.Close();
                    Marshal.ReleaseComObject(workbook);
                }
                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
