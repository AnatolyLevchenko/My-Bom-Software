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
    public partial class _ucDetails : UserControl
    {
        readonly HashSet<string> _materials = new HashSet<string>();
        readonly DetailsRepository _detailsRepo = new DetailsRepository();

        public _ucDetails()
        {
            InitializeComponent();
            this.SetupStyleForControls();

            olvPrice.AspectToStringConverter = AspectToStringConverter;
            olvImage.ImageGetter += ImageGetter;
            txtSearch.TextBox.SetPlaceHolder("Type anything for search ...");
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
            if(e.Cancel)
                return;

            var model = e.RowObject as Detail;
            if (model == null)
            {
                throw new Exception("Cast is not possible.Wrong model");
            }


            if (e.NewValue.Equals(e.Value))
            {
                e.Cancel = true;
                olvDetails.RemoveObjects(olvDetails.Objects.Cast<Detail>().Where(c => c.Id == 0).ToArray());
                return;
            }

            if (e.Column == olvName)
            {
                model.Name = e.NewValue.ToString();
            }
            else if (e.Column == olvPartNumber)
            {
                if (string.IsNullOrEmpty(e.NewValue.ToString()))
                    e.Cancel = true;
                else
                {
                    model.PartNumber = e.NewValue.ToString();
                }
            }
            else if (e.Column == olvPrice)
            {
                model.Price = (decimal)(string.IsNullOrWhiteSpace(e.NewValue.ToString()) ? 0m : e.NewValue);
            }
            else if (e.Column == olvRemark)
            {
                model.Remark = e.NewValue.ToString();
            }
            else if (e.Column == olvMaterial)
            {
                model.Material = e.NewValue.ToString();
                _materials.Add(model.Material);
            }
            else if (e.Column == olvLength)
            {
                model.Length = (double)e.NewValue;

            }

            if (model.Id != 0)
                await _detailsRepo.UpdateAsync(model);
            else
                await _detailsRepo.InsertAsync(model);
        }

        private void olvDetails_CellEditStarting(object sender, CellEditEventArgs e)
        {
            if (e.Column == olvPrice)
            {
                var nup = new NumericUpDown
                { Minimum = 0, Maximum = decimal.MaxValue, Value = (decimal?)e.Value ?? 0, Bounds = e.CellBounds, DecimalPlaces = 4 };
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
                    //var ac = new AutoCompleteStringCollection();
                    //ac.AddRange(_materials.ToArray());
                    //txt.AutoCompleteCustomSource = ac;
                    //txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    //txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    //txt.Multiline = false;

                    //TODO:autocomplete sometimes crash process. Cant reproduce anymore!!!

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
                if (model.Id == 0)
                    return null;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var detail = new Detail { PartNumber = "[set part number]" };
            olvDetails.AddObject(detail);
            try
            {
                olvDetails.EnsureVisible(olvDetails.Items.Count - 1);
            }
            catch (Exception exception)
            {

            }

            olvDetails.EditModel(detail);

        }

    }
}
