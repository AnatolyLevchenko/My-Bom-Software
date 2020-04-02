using BrightIdeasSoftware;
using My.Bom.Software.Domain;
using My.Bom.Software.Repository;
using My.Bom.Software.UserControls;
using My.Bom.Software.ViewModels;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace My.Bom.Software
{
    public partial class mainForm : Form
    {
        private readonly MachineRepository _machineRepository = new MachineRepository();
        private readonly DetailMachineRepository _machineDetailRepo = new DetailMachineRepository();

        private _ucAssignDetail _ucAssignDetail;

        public mainForm()
        {
            InitializeComponent();

            ConfigureDetail();
            var machines = _machineRepository.GetAllAsync().Result.ToArray();
            olvMachines.SetObjects(machines);

            if (machines.Any())
            {
                olvMachines.SelectedIndex = 0;
            }
        }

        private void ConfigureDetail()
        {
            _ucAssignDetail = new _ucAssignDetail
            {
                Dock = DockStyle.Fill
            };
            _ucAssignDetail.ItemChanged += UcAssignDetailOnItemChanged;

            this.tableLayoutPanel1.Controls.Add(_ucAssignDetail, 2, 1);
            tableLayoutPanel1.Invalidate();
        }


        private void FillOlv(int machineId)
        {
            var all = _machineDetailRepo.FilterByMachine(machineId);
            olvDetails.SetObjects(all);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            new DetailsForm().ShowDialog();

            if(olvMachines.SelectedObject is Machine machine)
                FillOlv(machine.Id);
        }

        private void olvMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (olvMachines.SelectedIndex < 0)
                return;

            if (olvMachines.GetItem(olvMachines.SelectedIndex).RowObject is Machine item)
            {
                FillOlv(item.Id);
                _ucAssignDetail.Prepare(item);
            }
        }

        private void UcAssignDetailOnItemChanged(object sender, int machineId)
        {
            FillOlv(machineId);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void olvDetails_ButtonClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            if (e.Column == olvSetQty)
            {
                if (e.Model is MachineDetailsVm row)
                {
                    if (row.Qty < 0)
                        row.Qty = 0;
                    _machineDetailRepo.SetQuantity(row);
                    FillOlv(row.MachineId);
                }

            }
        }

        private async void btnMachines_Click(object sender, EventArgs e)
        {
            var machine = new Machine
            {
                Name = "New_Machine",
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow,

            };
            await _machineRepository.InsertAsync(machine);
            olvMachines.AddObject(machine);
            
        }

        private async void olvMachines_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column == olvName)
            {
                if (e.NewValue.Equals(e.Value) || string.IsNullOrEmpty(e.NewValue.ToString()))
                    e.Cancel = true;
                else
                {
                    var m = e.RowObject as Machine;
                    var value = e.NewValue.ToString();
                    m.Name = value;
                  await  _machineRepository.UpdateAsync(m);
                }
            }
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
