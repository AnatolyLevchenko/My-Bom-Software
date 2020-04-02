using My.Bom.Software.Helpers;
using System;
using System.IO;
using System.Windows.Forms;

namespace My.Bom.Software
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Directory.Exists("Images"))
            {
                try
                {
                    Directory.CreateDirectory("Images");
                }
                catch (Exception e)
                {
                   MessageHelper.DisplayError(e.Message);
                }
            }

            Application.Run(new mainForm());
        }
    }
}
