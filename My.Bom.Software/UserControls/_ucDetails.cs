using BrightIdeasSoftware;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using My.Bom.Software.ViewModels;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace My.Bom.Software.UserControls
{
    public partial class _ucDetails : UserControl
    {
        private readonly DetailMachineRepository _dmr;
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
        }

        public void FillOlv(int machineId)
        {
            olvDetails.SetObjects(_dmr.FilterByMachine(machineId));
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
    }
}
