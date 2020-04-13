using My.Bom.Software.UserControls;
using System.Diagnostics;
using System.Windows.Forms;

namespace My.Bom.Software
{
    public partial class mainForm : Form
    {
        private readonly _ucDetails _ucDetails = new _ucDetails { Dock = DockStyle.Fill, AutoSize = true, Visible = false };
        private readonly _ucPriceHistory _ucPriceHistory = new _ucPriceHistory { Dock = DockStyle.Fill, AutoSize = true, Visible = false };


        public mainForm()
        {
            InitializeComponent();

            _ucMachines1.FillOlv();
            _ucMachines1.MachineSelected += UcMachines1OnMachineSelected;
            _ucMachines1.TryActiveFirstMachine();

            Controls.Add(_ucDetails);
            Controls.Add(_ucPriceHistory);

        }

        private void UcMachines1OnMachineSelected(object sender, int id)
        {
            _ucAssignment.FillOlv(id);
        }

        private void imagesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Process.Start("explorer", "Images");
        }

        private void detailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_ucDetails.Visible)
                return;
            Switcher(sender);
            this._ucDetails.FillOlv();
        }

        private void machineToolStripMenu_Click(object sender, System.EventArgs e)
        {
            if (_ucMachines1.Visible)
                return;
            Switcher(sender);
            _ucMachines1.TryActiveFirstMachine();
        }

        private void priceHistoryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_ucPriceHistory.Visible)
                return;
            Switcher(sender);
            _ucPriceHistory.FillOlv();
        }


        private void Switcher(object sender)
        {
            if (sender == detailsToolStripMenuItem)
            {
                _ucDetails.Visible = true;
                _ucMachines1.Visible = _ucPriceHistory.Visible = false;
                _ucDetails.BringToFront();
            }

            else if (sender == machineToolStripMenu)
            {
                tableLayoutPanel1.BringToFront();
                _ucDetails.Visible = _ucPriceHistory.Visible = false;
                _ucMachines1.Visible = true;
            }
            else if (sender == priceHistoryToolStripMenuItem)
            {
                _ucPriceHistory.Visible = true;
                _ucMachines1.Visible = _ucDetails.Visible = false;
                _ucPriceHistory.BringToFront();
            }
        }


    }
}
