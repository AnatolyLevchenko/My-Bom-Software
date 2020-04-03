using My.Bom.Software.Domain;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
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

            var d = new DapperBase<BaseEntity>();
            if (!d.TryOpenConenction())
            {
                MessageHelper.DisplayError("Can't connect to database");
                return;
            }

            Application.Run(new DetailsForm());
        }
    }
}
