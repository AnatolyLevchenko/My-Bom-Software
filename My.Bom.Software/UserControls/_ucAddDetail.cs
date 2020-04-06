using My.Bom.Software.Domain;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace My.Bom.Software.UserControls
{
    public partial class _ucAddDetail : UserControl
    {
        private readonly DetailsRepository _detailsRepo = new DetailsRepository();

        public _ucAddDetail(HashSet<string> materials)
        {
            InitializeComponent();

            var ac = new AutoCompleteStringCollection();
            ac.AddRange(materials.ToArray());
            txtMaterial.AutoCompleteCustomSource = ac;
            txtMaterial.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtMaterial.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPartNumber.Text))
            {
                MessageHelper.DisplayError("Part number is required");
                txtPartNumber.Focus();
                return;
            }

            var detail = new Detail
            {
                Name = txtName.Text,
                PartNumber = txtPartNumber.Text,
                Price = nupPrice.Value,
                Remark = txtRemark.Text,
                Material = txtMaterial.Text,
                Length = (double) nupLength.Value
                
            };

            await _detailsRepo.InsertAsync(detail);


            this.TryCloseFrom();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.TryCloseFrom();
        }
    }
}
