using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace My.Bom.Software.Helpers
{
    public static class Extensions
    {
        public static void TryCloseFrom(this UserControl uc)
        {
            Form tmp = uc.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        public static string GetConnection()
        {
           return ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
        }

        public static void SetupUserControls(this UserControl uc)
        {
            foreach (var control in GetAll(uc,typeof(ObjectListView)))
            {
                var view = (ObjectListView) control;
                foreach (var column in view.AllColumns)
                {
                    column.HeaderFont = Constants.BoldHeaderFont;
                    column.Width = 150;
                }
            }

            foreach (var control in GetAll(uc, typeof(Button)))
            {
                control.Font = Constants.BoldHeaderFont;
                control.AutoSize = true;
            }



            foreach (var c in GetAll(uc, typeof(StatusStrip)))
            {
                var control = (StatusStrip) c;
                foreach (var item in control.Items.OfType<ToolStripLabel>())
                {
                    item.Font = Constants.BoldHeaderFont;
                    control.AutoSize = true;
                }
            }
        }


        public static IEnumerable<Control> GetAll(this Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }

        public static Tuple<string,Image> GetImage(string partNumber)
        {
            var path = Directory.GetFiles("Images", $"{partNumber}.*").FirstOrDefault();

            try
            {
                var bitmap = Image.FromFile(path);
                var thumb=bitmap.GetThumbnailImage(200, 50, null, IntPtr.Zero);
                return new Tuple<string, Image>(path,thumb);
            }
            catch
            {
                return null;
            }
        }
    }
}
