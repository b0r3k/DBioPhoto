using DBioPhoto.DataAccess.Data;
using System;
using System.Windows.Forms;

namespace DBioPhoto.Frontend
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OpeningForm());
        }
    }

    static class Global
    {
        public static DBioPhotoContext DbContext { get; set; }
        public static string RootFolder { get; set; }
    }
}
