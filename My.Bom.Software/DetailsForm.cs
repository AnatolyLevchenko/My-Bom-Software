using BrightIdeasSoftware;
using My.Bom.Software.Domain;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace My.Bom.Software
{
    public partial class DetailsForm : Form
    {
        readonly HashSet<string> _materials = new HashSet<string>();
        readonly DetailsRepository _detailsRepo = new DetailsRepository();

        public DetailsForm()
        {
            InitializeComponent();
            this.SetupStyleForControls();

            olvPrice.AspectToStringConverter = AspectToStringConverter;
            olvImage.ImageGetter += ImageGetter;
            txtSearch.SetPlaceHolder("Type anything for search ...");
        }

        private void FillOlv()
        {
            var objects = _detailsRepo.GetAllAsync().Result.ToList();
            _materials.AddRange(objects.Select(c => c.Material));

            olvDetails.SetObjects(objects);
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            FillOlv();
        }

        private async void olvDetails_CellEditFinishing(object sender, CellEditEventArgs e)
        {
            var model = e.RowObject as Detail;
            if (model == null)
            {
                throw new Exception("Cast is not possible.Wrong model");
            }

            if (e.NewValue.Equals(e.Value))
            {
                e.Cancel = true;
                return;
            }

            if (e.Column == olvName)
            {
                model.Name = e.NewValue.ToString();
                await _detailsRepo.UpdateAsync(model);
            }
            else if (e.Column == olvPartNumber)
            {
                if (string.IsNullOrEmpty(e.NewValue.ToString()))
                    e.Cancel = true;
                else
                {
                    model.PartNumber = e.NewValue.ToString();
                    await _detailsRepo.UpdateAsync(model);
                }
            }
            else if (e.Column == olvPrice)
            {
                model.Price = (decimal)(string.IsNullOrWhiteSpace(e.NewValue.ToString()) ? 0m : e.NewValue);
                await _detailsRepo.UpdateAsync(model);
            }
            else if (e.Column == olvRemark)
            {
                model.Remark = e.NewValue.ToString();
                await _detailsRepo.UpdateAsync(model);
            }
            else if (e.Column == olvMaterial)
            {
                model.Material = e.NewValue.ToString();
                await _detailsRepo.UpdateAsync(model);
            }
            else if (e.Column == olvLength)
            {
                model.Length = (double)e.NewValue;
                await _detailsRepo.UpdateAsync(model);
            }

        }

        private void olvDetails_CellEditStarting(object sender, CellEditEventArgs e)
        {
            if (e.Column == olvPrice)
            {
                var nup = new NumericUpDown
                { Minimum = 0, Maximum = decimal.MaxValue, Value = (decimal)e.Value, Bounds = e.CellBounds, DecimalPlaces = 4 };
                e.Control = nup;
            }

            if (e.Column == olvPartNumber || e.Column == olvName || e.Column == olvRemark || e.Column == olvMaterial)
            {
                var txt = new TextBox
                {
                    Multiline = true,
                    Bounds = e.CellBounds,
                    Text = e.Value == null ? string.Empty : e.Value.ToString(),
                    Height = 33
                };

                if (e.Column == olvRemark)
                    txt.Height *= 2;

                if (e.Column == olvMaterial)
                {
                    var ac = new AutoCompleteStringCollection();
                    ac.AddRange(_materials.ToArray());
                    txt.AutoCompleteCustomSource = ac;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.Multiline = false;
                }
                e.Control = txt;
            }

            if (e.Column == olvLength)
            {
                e.Control.Width += 50;
            }
        }

        private string AspectToStringConverter(object value)
        {
            decimal v = 0;

            if (value != null)
            {
                v = (decimal)value;
            }

            return v.DecimalToMoney();
        }

        private object ImageGetter(object row)
        {
            if (row is Detail model)
            {
                try
                {
                    return Extensions.GetImage(model.PartNumber).Item2;
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            return null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            olvDetails.ModelFilter = new TextMatchFilter(olvDetails, txtSearch.Text);
        }

        private void olvDetails_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.Column == olvImage && e.ClickCount == 2)
            {
                if (e.Model is Detail model)
                {
                    try
                    {
                        var image = Extensions.GetImage(model.PartNumber).Item1;
                        Process.Start(image);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }
}
