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

namespace 로그인
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool CheckLogin(string studentID, string password)
        {
            // 엑셀 파일 경로 설정
            string excelFilePath = "회원가입정보.xlsx";

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string studentID = txtID.Text;
            string userPassword = txtPassword.Text;

            if (CheckLogin(studentID, userPassword))
            {
                MessageBox.Show("로그인에 성공했습니다.", "로그인");
                // 로그인 성공 시 다음 동작 수행
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.", "로그인");
            }
        }
    }
}
