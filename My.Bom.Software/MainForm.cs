using System.Diagnostics;
using System.Windows.Forms;

namespace My.Bom.Software
{
    public partial class mainForm : Form
    {
        private readonly _ucDetails _details=new _ucDetails {Dock = DockStyle.Fill,AutoSize = true,Visible = false};
       

        public mainForm()
        {
            InitializeComponent();

            _ucMachines1.FillOlv();
            _ucMachines1.MachineSelected+=UcMachines1OnMachineSelected;
            _ucMachines1.TryActiveFirstMachine();

            Controls.Add(_details);

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
            if(_details.Visible)
                return;
            Switcher();
            this._details.FillOlv();
        }

        private void machineToolStripMenu_Click(object sender, System.EventArgs e)
        {
            if(_ucMachines1.Visible)
                return;
            Switcher();
            _ucMachines1.TryActiveFirstMachine();
        }
        private void Switcher()
        {
            _ucMachines1.Visible = !_ucMachines1.Visible;
            _ucAssignment.Visible = !_ucAssignment.Visible;


            if (!_ucMachines1.Visible)
            {
                _details.Visible = true;
                _details.BringToFront();
            }

            if (_ucMachines1.Visible)
            {
                tableLayoutPanel1.BringToFront();
                _details.Visible = false;
            }
        }

       
    }
}
