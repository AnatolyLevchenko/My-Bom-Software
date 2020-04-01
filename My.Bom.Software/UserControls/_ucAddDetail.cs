using My.Bom.Software.Domain;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using System;
using System.Windows.Forms;

namespace My.Bom.Software.UserControls
{
    public partial class _ucAddDetail : UserControl
    {
        private readonly DetailsRepository _detailsRepo=new DetailsRepository();
        private readonly  Detail _editedDetail;

        public _ucAddDetail(Detail d):this()
        {
            _editedDetail = d;

            txtPartNumber.Text = d.PartNumber;
            txtName.Text = d.Name;
            txtId.Text = d.Id.ToString();
            nupPrice.Value = d.Price ?? -1;
        }

        public _ucAddDetail()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPartNumber.Text))
            {
                MessageHelper.DisplayError("Name is required");
                return;
            }

            var detail = new Detail
            {
                Name = txtName.Text,
                PartNumber = txtPartNumber.Text,
                Price = nupPrice.Value
            };
            if (_editedDetail == null)
            {
                await _detailsRepo.InsertAsync(detail);
            }
            else
            {
                detail.Id = _editedDetail.Id;
                await _detailsRepo.UpdateAsync(detail);
            }

            this.TryCloseFrom();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.TryCloseFrom();
        }
    }
}
