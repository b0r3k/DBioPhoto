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
        public static string RootFolder { get; set; }
        public static string DbFilePath { get; set; }
        public static void ShowOnButtonForTwoSecs(string textToShow, string textToShowThen, Button button)
        {
            // Show textToShow on the button, after 2 s show textToShowThen
            button.Text = textToShow;
            Timer timer = new Timer()
            {
                Interval = 2000,
                Enabled = true
            };
            timer.Tick += (sender, e) =>
            {
                button.Text = textToShowThen;
                timer.Dispose();
            };
        }
    }
}
