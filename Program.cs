using System;
using System.IO;
using System.Windows.Forms;

namespace CLIS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                chkexpiry();
            }
            catch
            {
                MessageBox.Show("This Product is not activated !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            string liscencepath = @"C:\SystemData\lib.txt";

            if (File.Exists(liscencepath))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("This Product is not activated !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static string exprdt;

        private static void chkexpiry()
        {
            if (!Directory.Exists(@"C:\SystemData"))
            {
                Directory.CreateDirectory(@"C:\SystemData");
            }

            string expirydatepath = @"C:\SystemData\lib.txt";

            exprdt = File.ReadAllText(expirydatepath);

            DateTime currrentdate = DateTime.Now.Date;

            DateTime expirydate = DateTime.Parse(exprdt);

            string liscencepathh = @"C:\SystemData\lib.txt";

            if (expirydate <= currrentdate)
            {
                File.Delete(liscencepathh);
            }
        }
    }
}
