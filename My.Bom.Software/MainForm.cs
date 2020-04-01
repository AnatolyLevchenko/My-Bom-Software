using My.Bom.Software.Domain;
using My.Bom.Software.Repository;
using My.Bom.Software.UserControls;
using System;
using System.Windows.Forms;

namespace My.Bom.Software
{
    public partial class mainForm : Form
    {
        private readonly MachineRepository _machineRepository = new MachineRepository();
        private readonly DetailMachineRepository _machineDetailRepo = new DetailMachineRepository();

        private readonly _ucAssignDetail _ucAssignDetail;

        public mainForm()
        {
            InitializeComponent();
            olvMachines.SetObjects(_machineRepository.GetAllAsync().Result);

            _ucAssignDetail = new _ucAssignDetail
            {
                Dock = DockStyle.Fill
            };
            _ucAssignDetail.ItemChanged+=UcAssignDetailOnItemChanged;

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


    }
}
