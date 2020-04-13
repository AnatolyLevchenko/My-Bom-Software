using BrightIdeasSoftware;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using System.Windows.Forms;

namespace My.Bom.Software.UserControls
{
    public partial class _ucPriceHistory : UserControl
    {
        readonly PriceHistoryRepository _phr = new PriceHistoryRepository();
        public _ucPriceHistory()
        {
            InitializeComponent();
            this.SetupStyleForControls();
            txtSearch.SetPlaceHolder("Search....");
        }

        public void FillOlv()
        {
            olvPriceHistory.SetObjects(_phr.GetAll());
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            olvPriceHistory.ModelFilter = new TextMatchFilter(olvPriceHistory, txtSearch.Text);
        }
    }
}
