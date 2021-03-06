﻿using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

        public static void SetupStyleForControls(this Control uc)
        {
            foreach (var control in GetAll(uc, typeof(ObjectListView)))
            {
                var view = (ObjectListView)control;
                view.AlternateRowBackColor = Color.Honeydew;
                view.UseAlternatingBackColors = true;

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
                var control = (StatusStrip)c;
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

        public static Tuple<string, Image> GetImage(string partNumber)
        {
            var path = Directory.GetFiles("Images", $"{partNumber}.*").FirstOrDefault();
            if (path == null)
                return null;

            try
            {
                var bitmap = Image.FromFile(path);
                var thumb = bitmap.GetThumbnailImage(200, 50, null, IntPtr.Zero);
                return new Tuple<string, Image>(path, thumb);
            }
            catch
            {
                return null;
            }
        }

        public static string DecimalToMoney(this decimal d)
        {
            return d.ToString("c", new CultureInfo("nl-BE"));
        }

        public static bool AddRange<T>(this HashSet<T> source, IEnumerable<T> items)
        {
            bool allAdded = true;
            foreach (T item in items)
            {
                allAdded &= source.Add(item);
            }
            return allAdded;
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public static void SetPlaceHolder(this TextBox t, string text)
        {
            SendMessage(t.Handle, 0x1501, 0, text);
        }
    }
}
