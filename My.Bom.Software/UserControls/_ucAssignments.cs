using BrightIdeasSoftware;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using My.Bom.Software.ViewModels;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace My.Bom.Software.UserControls
{
    public partial class _ucAssignments : UserControl
    {
        private readonly DetailMachineRepository _dmr;
        private readonly DetailsRepository _dr;
        private int MachineId { get; set; }

        public _ucAssignments()
        {
            InitializeComponent();
            this.SetupStyleForControls();
            try
            {
                _dmr = new DetailMachineRepository();
                _dr=new DetailsRepository();
            }
            catch (Exception)
            {

            }

            this.olvImage.ImageGetter += ImageGetter;
            olvUnsign.ButtonPadding=new Size(10,10);
            txtSearch.TextBox.SetPlaceHolder("Search...");

            olvDetails.CellEditStarting += OlvDetails_CellEditStarting;
        }

       

        public void FillOlv(int machineId)
        {
            var objects = _dmr.FilterByMachine(machineId).ToList();
            olvDetails.SetObjects(objects);
            MachineId = machineId;

            if (!objects.Any())
            {
                olvDetails_FormatRow(this, null);
            }
        }

        private void olvDetails_FormatRow(object sender, FormatRowEventArgs e)
        {
            decimal total = 0;
            int details = 0;
            foreach (OLVListItem item in olvDetails.Items)
            {
                if (item.RowObject is MachineDetailsVm obj)
                {
                    total += obj.TotalPrice;
                    details++;
                }
            }

            lbTotal.Text = $"Details: {details} Total: {total.DecimalToMoney()}";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            using (var df = new DialogForm())
            {
                df.Text = "Assign Detail";

                using (var c = new _ucAssignDetail(MachineId))
                {
                    df.mainPanel.Controls.Add(c);
                    df.ShowDialog();
                    FillOlv(MachineId);
                }

            }

        }

        private void olvDetails_ButtonClick(object sender, CellClickEventArgs e)
        {
            if (e.Column == olvUnsign)
            {
                if (e.Model is MachineDetailsVm model)
                {
                    if (MessageHelper.AskForConfirmation($"Remove {model.Detail} from  {model.Machine} machine") == DialogResult.OK)
                    {
                        _dmr.Delete(model);
                        FillOlv(MachineId);
                    }
                  
                }
            }
        }

        private object ImageGetter(object rowobject)
        {
            if (rowobject is MachineDetailsVm model)
            {
                try
                {
                    var image = Extensions.GetImage(model.Detail);
                    if(image!=null)
                        return image.Item2;
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            return null;
        }

        private void olvDetails_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.Column == olvImage && e.ClickCount == 2)
            {
                if (e.Model is MachineDetailsVm model)
                {
                    try
                    {
                        var image = Extensions.GetImage(model.Detail);
                        if(image!=null)
                            Process.Start(image.Item1);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
           
        }
        private void OlvDetails_CellEditStarting(object sender, CellEditEventArgs e)
        {
            if (e.Column == olvPrice && e.RowObject is MachineDetailsVm model)
            {
                var nup = new NumericUpDown
                    { Minimum = 0, Maximum = decimal.MaxValue, Value = model.Price, Bounds = e.CellBounds, DecimalPlaces = 4 };
                e.Control = nup;
            }
        }

        private async void olvDetails_CellEditFinishing(object sender, CellEditEventArgs e)
        {
            if (e.Cancel)
                return;


            if (e.RowObject is MachineDetailsVm row)
            {
                if (e.Column == olvPieces)
                {
                    row.Qty = (int)e.NewValue;

                    if (row.Qty < 0)
                        row.Qty = 0;
                    _dmr.SetQuantity(row);
                }
                else if (e.Column == olvMaterial)
                {
                    var detail = await _dr.GetByIdAsync(row.DetailId);
                    detail.Material = e.NewValue.ToString();
                    await _dr.UpdateAsync(detail);
                }
                else if (e.Column == olvPrice)
                {
                    var detail=await _dr.GetByIdAsync(row.DetailId);
                    detail.Price = (decimal)(string.IsNullOrWhiteSpace(e.NewValue.ToString()) ? 0m : e.NewValue);
                    await _dr.UpdateAsync(detail);
                }
                else if (e.Column == olvRemark)
                {
                    var detail = await _dr.GetByIdAsync(row.DetailId);
                    detail.Remark = e.NewValue.ToString();
                    await _dr.UpdateAsync(detail);
                }
                FillOlv(row.MachineId);
            }

        }

        private void olvDetails_FormatCell(object sender, FormatCellEventArgs e)
        {
            if (e.Column == olvUnsign)
            {
                e.SubItem.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold | FontStyle.Underline);
                e.SubItem.ForeColor=Color.Gray;
            }
        }

        private void cbShowImages_CheckedChanged(object sender, bool e)
        {
            if (e && olvImage.ImageGetter==null)
            {
                olvImage.ImageGetter += ImageGetter;
            }
            else 
            {
                olvImage.ImageGetter -= ImageGetter;
            }

            FillOlv(MachineId);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            olvDetails.ModelFilter=new TextMatchFilter(olvDetails,txtSearch.Text);
        }
    }
}
