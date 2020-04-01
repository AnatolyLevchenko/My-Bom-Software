using My.Bom.Software.Domain;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using System;
using System.Windows.Forms;

namespace My.Bom.Software.UserControls
{
    public partial class _ucAssignDetail : UserControl
    {
        public event EventHandler<int> ItemChanged;

        private Machine _machine;

        private readonly DetailMachineRepository _detailMachineRepo = new DetailMachineRepository();
        private readonly DetailsRepository _detailsRepo = new DetailsRepository();

        public _ucAssignDetail()
        {
            InitializeComponent();
            cbDetails.ValueMember = "Id";

            Detail d;
            cbDetails.DisplayMember = nameof(d.PartNumber);
        }

        public void Prepare(Machine machine)
        {
            _machine = machine;
            lbMachineName.Text = machine.Name;

            cbDetails.DataSource = _detailsRepo.GetAllAsync().Result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_machine == null || cbDetails.SelectedItem == null)
            {
                MessageHelper.DisplayError("Choose machine and detail!");
                return;
            }

            var model = new DetailMachine
            {
                Qty = (int)numericUpDown1.Value,
                MachineId = _machine.Id,
                DetailId = ((Detail)cbDetails.SelectedItem).Id
            };

            if (_detailMachineRepo.AlreadyContainsMapping(model))
            {
                MessageHelper.DisplayError("You already added this details for that machine");
                return;
            }
            _detailMachineRepo.Insert(model);

            ItemChanged?.Invoke(this, model.MachineId);
        }
    }
}
