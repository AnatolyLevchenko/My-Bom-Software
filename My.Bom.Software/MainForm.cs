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
        }

        private void UcMachines1OnMachineSelected(object sender, int id)
        {
            _ucDetails1.FillOlv(id);
        }
       
    }
}
