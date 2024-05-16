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
    }
}
