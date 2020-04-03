using My.Bom.Software.Domain;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using System;
using System.Windows.Forms;

namespace My.Bom.Software.UserControls
{
    public partial class _ucMachines : UserControl
    {
        public event EventHandler<int> MachineSelected;
        private readonly MachineRepository _machineRepo;

        public _ucMachines()
        {
            InitializeComponent();
            this.SetupStyleForControls();
            try
            {
                _machineRepo = new MachineRepository();
            }
            catch (Exception)
            {
              //ignore WinForms designer errors
            }
                

        }

        private void olvMachines_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            var total = olvMachines.Items.Count;
            lbTotal.Text = $"Total  :  {total}";
        }

        public void FillOlv()
        {
            var machines = _machineRepo.GetAllAsync().Result;
            olvMachines.SetObjects(machines);
        }

        public void TryActiveFirstMachine()
        {
            if (olvMachines.Items.GetEnumerator().MoveNext())
                olvMachines.SelectedIndex = 0;
        }


        private void olvMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (olvMachines.SelectedIndex < 0)
                return;

            if(olvMachines.SelectedObject is Machine obj)
                MachineSelected?.Invoke(this, obj.Id);
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
                    await _machineRepo.UpdateAsync(m);
                }
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            var machine = new Machine
            {
                Name = "New_Machine",
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow,

            };
            await _machineRepo.InsertAsync(machine);
            olvMachines.AddObject(machine);
        }
    }
}
