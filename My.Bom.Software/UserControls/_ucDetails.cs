﻿using BrightIdeasSoftware;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using My.Bom.Software.ViewModels;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace My.Bom.Software.UserControls
{
    public partial class _ucDetails : UserControl
    {
        private readonly DetailMachineRepository _dmr;
        private int MachineId { get; set; }

        public _ucDetails()
        {
            InitializeComponent();
            this.SetupUserControls();
            try
            {
                _dmr=new DetailMachineRepository();
            }
            catch (Exception)
            {
               
            }

            this.olvImage.ImageGetter+=ImageGetter;
        }

        

        public void FillOlv(int machineId)
        {
            olvDetails.SetObjects(_dmr.FilterByMachine(machineId));
            MachineId = machineId;
        }

        private void olvDetails_FormatRow(object sender, FormatRowEventArgs e)
        {
            decimal total = 0;
            int details = 0;
            foreach (OLVListItem item in olvDetails.Items)
            {
                if (item.RowObject is MachineDetailsVm obj)
                {
                    total += obj.TotalPrice;
                    details++;
                }
            }

            lbTotal.Text = $"Details: {details} Total: {total.ToString("c", new CultureInfo("nl-BE"))}";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            using (var df = new DialogForm())
            {
                df.Text = "Assign Detail";

                using (var c = new _ucAssignDetail(MachineId))
                {
                    df.mainPanel.Controls.Add(c);
                    df.ShowDialog();
                    FillOlv(MachineId);
                }

            }

        }

        private void olvDetails_ButtonClick(object sender, CellClickEventArgs e)
        {
            if (e.Column == olvSetQty)
            {
                if (e.Model is MachineDetailsVm row)
                {
                    if (row.Qty < 0)
                        row.Qty = 0;
                    _dmr.SetQuantity(row);
                    FillOlv(row.MachineId);
                }
            }
        }

        private object ImageGetter(object rowobject)
        {
            if (rowobject is MachineDetailsVm model)
            {
              var image=  Directory.GetFiles("Images", $"{model.Detail}.*").FirstOrDefault();

              try
              {
                  var b= Image.FromFile(image);
                  return b.GetThumbnailImage(200, 50, null, IntPtr.Zero);
              }
              catch (Exception e)
              {
               
              }
            }

            return null;
        }

        private void olvDetails_CellOver(object sender, CellOverEventArgs e)
        {
            if (e.Column == olvImage)
            {
                MessageBox.Show("1");
            }
        }
    }
}