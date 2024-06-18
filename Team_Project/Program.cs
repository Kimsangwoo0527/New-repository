using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project
{
    public static class GlobalData
    {
        public static DataSet1 dataset = new DataSet1();
    }
<<<<<<< HEAD

=======
>>>>>>> 40498b5f6727fecb8f46576cc5b5ffd8e71845bd
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
