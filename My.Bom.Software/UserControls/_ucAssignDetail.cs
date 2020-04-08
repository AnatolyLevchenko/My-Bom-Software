using My.Bom.Software.Domain;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace My.Bom.Software.UserControls
{
    public partial class _ucAssignDetail : UserControl
    {
        private readonly DetailMachineRepository _detailMachineRepo = new DetailMachineRepository();
        private readonly DetailsRepository _detailsRepo = new DetailsRepository();
        private readonly MachineRepository _machineRepo = new MachineRepository();

        private Machine SelectedMachine {
            get {
                if (cbMachine.SelectedItem is Machine m)
                    return m;
                return null;
            }
        }

        private Detail SelectedDetail
        {
            get
            {
                if (cbDetails.SelectedItem is Detail d)
                    return d;
                return null;
            }
        }

        private IEnumerable<int> Details { get; set; }


        public _ucAssignDetail(int machineId)
        {
            InitializeComponent();

            var machines = _machineRepo.GetAllAsync().Result.Where(e=>!e.Deleted).OrderBy(c=>c.Name).ToList();
            cbMachine.DataSource = machines;

            if (machines.Any(m => m.Id.Equals(machineId)))
            {
                cbMachine.SelectedItem = _machineRepo.GetByIdAsync(machineId).Result;
            }
        }

        public _ucAssignDetail(IList<int> details)
        {
            InitializeComponent();
            cbDetails.Visible = false;
            lbDetail.Visible = false;
            lbQty.Visible = false;
            nupQty.Visible = false;

            var machines = _machineRepo.GetAllAsync().Result.Where(e => !e.Deleted).OrderBy(c => c.Name).ToList();
            cbMachine.DataSource = machines;
            Details = details;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SelectedMachine == null)
            {
                MessageHelper.DisplayError("Machine is not selected!");
                return;
            }

            if (Details != null && Details.Any())
            {
                _detailMachineRepo.Insert(SelectedMachine.Id,Details);
                this.TryCloseFrom();
                return;
            }

            if (SelectedDetail == null)
            {
                MessageHelper.DisplayError("Detail is not selected");
                return;
            }

            var model = new DetailMachine
            {
                Qty = (int)nupQty.Value,
                MachineId = SelectedMachine.Id,
                DetailId = SelectedDetail.Id
            };

            if (_detailMachineRepo.AlreadyContainsMapping(model))
            {
                MessageHelper.DisplayError("This detail is already mapped for this machine");
                return;
            }
            _detailMachineRepo.Insert(model);

            this.TryCloseFrom();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.TryCloseFrom();
        }

        private void cbMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedMachine != null)
            {
                cbDetails.DataSource = _detailsRepo.GetPossibleDetails(SelectedMachine.Id);
            }
        }
    }
}
