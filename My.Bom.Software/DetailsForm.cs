using My.Bom.Software.Domain;
using My.Bom.Software.Repository;
using My.Bom.Software.UserControls;
using System.Windows.Forms;

namespace My.Bom.Software
{
    public partial class DetailsForm : Form
    {
        readonly DetailsRepository _detailsRepo = new DetailsRepository();

        public DetailsForm()
        {
            InitializeComponent();
        }

        private void FillOlv()
        {
            var objects =  _detailsRepo.GetAllAsync().Result;
            olvDetails.SetObjects(objects);
        }

        private  void DetailsForm_Load(object sender, System.EventArgs e)
        {
             FillOlv();
        }

        private void objectListView1_ItemActivate(object sender, System.EventArgs e)
        {
            if (olvDetails.SelectedIndex < 0)
                return;

            if (olvDetails.GetItem(olvDetails.SelectedIndex).RowObject is Detail item)
                using (var df = new DialogForm())
                {
                    df.Text = "Edit detail";
                    using (var proj = new _ucAddDetail(item))
                    {
                        df.mainPanel.Controls.Add(proj);
                        df.ShowDialog();
                    }
                    FillOlv();
                }
        }

        private void btnAddDetail_Click(object sender, System.EventArgs e)
        {
            using (var df = new DialogForm())
            {
                df.Text = "Add detail";

                using (var c = new _ucAddDetail())
                {
                    df.mainPanel.Controls.Add(c);
                    df.ShowDialog();
                }

            }

            FillOlv();
        }
    }
}
