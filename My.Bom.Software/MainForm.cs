using System.Diagnostics;
using System.Windows.Forms;

namespace My.Bom.Software
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();

            _ucMachines1.FillOlv();
            _ucMachines1.MachineSelected+=UcMachines1OnMachineSelected;
            _ucMachines1.TryActiveFirstMachine();
        }

        private void UcMachines1OnMachineSelected(object sender, int id)
        {
            _ucDetails1.FillOlv(id);
        }

        private void imagesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Process.Start("explorer", "Images");
        }

        private void detailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new DetailsForm().ShowDialog(this);
            _ucMachines1.TryActiveFirstMachine();
        }
    }
}
