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
        public static string DbFilePath { get; set; }
        public static void ShowOnButtonForThreeSecs(string textToShow, Button button)
        {
            // Show textToShow on the button, after 3 s show original again
            string oldText = button.Text;
            button.Text = textToShow;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer()
            {
                Interval = 3000,
                Enabled = true
            };
            timer.Tick += (sender, e) =>
            {
                button.Text = oldText;
                timer.Dispose();
            };
        }
    }
}
