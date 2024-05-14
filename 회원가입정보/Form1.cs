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
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace team
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 입력된 학번과 비밀번호 가져오기
            string studentID = txtID.Text;
            string password = txtPassword.Text;

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

                // 첫 번째 줄에 ID와 Password 저장
                if (lastRow == 1)
                {
                    worksheet.Cells[1, 1] = "ID";
                    worksheet.Cells[1, 2] = "Password";
                    lastRow++; // 첫 번째 줄에 문구를 저장했으므로 다음 줄부터 데이터 저장
                }

                // 데이터 추가
                worksheet.Cells[lastRow + 1, 1] = studentID;
                worksheet.Cells[lastRow + 1, 2] = password;

                workbook.Save(); // 기존 파일에 추가된 데이터 저장

                MessageBox.Show("회원가입 정보가 저장되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.ToString());
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
