using My.Bom.Software.Domain;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using System;
using System.Linq;
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
            if(e.Cancel)
                return;

            if (e.NewValue.Equals(e.Value))
            {
                e.Cancel = true;
                olvMachines.RemoveObjects(olvMachines.Objects.Cast<Machine>().Where(c => c.Id == 0).ToArray());
                return;
            }

            if (e.Column == olvName)
            {
                if (string.IsNullOrEmpty(e.NewValue.ToString()))
                    e.Cancel = true;
                else
                {
                    var m = e.RowObject as Machine;
                    var value = e.NewValue.ToString();
                    m.Name = value;
                    if (m.Id != 0)
                        await _machineRepo.UpdateAsync(m);
                    else await _machineRepo.InsertAsync(m);
                }
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            var machine = new Machine { Name = "[set machine name]" };
            olvMachines.AddObject(machine);
            try
            {
                olvMachines.EnsureVisible(olvMachines.Items.Count - 1);
            }
            catch (Exception exception)
            {

            }

            olvMachines.EditModel(machine);



            //var machine = new Machine
            //{
            //    Name = "New_Machine",
            //    CreatedOnUtc = DateTime.UtcNow,
            //    UpdatedOnUtc = DateTime.UtcNow,

            //};
            //await _machineRepo.InsertAsync(machine);
            //olvMachines.AddObject(machine);
        }
    }
}
