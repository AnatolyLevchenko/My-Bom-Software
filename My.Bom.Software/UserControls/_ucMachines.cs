﻿using BrightIdeasSoftware;
using My.Bom.Software.Domain;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using OfficeOpenXml;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace My.Bom.Software.UserControls
{
    public partial class _ucMachines : UserControl
    {
        public event EventHandler<int> MachineSelected;
        private readonly MachineRepository _machineRepo;

        private int counter = 0;
        public _ucMachines()
        {
            InitializeComponent();
            this.SetupStyleForControls();

            olvMachines.Dock = DockStyle.Fill;
            olvNumber.DisplayIndex = 0;
            olvNumber.Width = 30;
            olvName.DisplayIndex = 1;

            txtSearch.TextBox.SetPlaceHolder("Search ...");
            try
            {
                _machineRepo = new MachineRepository();
            }
            catch (Exception)
            {
                //ignore WinForms designer errors
            }
        }

        private void olvMachines_FormatRow(object sender, FormatRowEventArgs e)
        {
            if (e.Model is Machine model && model.Deleted)
            {
                e.Item.BackColor = Color.Chocolate;
            }



            var total = olvMachines.Items.Count;
            lbTotal.Text = $"Total  :  {total}" + new string(' ', 8);
        }

        public void FillOlv()
        {
            var machines = _machineRepo.GetAllAsync().Result.ToList();
            if (!cbShowDeleted.Checked)
            {
                machines = machines.Where(c => !c.Deleted).ToList();
            }

            counter = 0;
            foreach (var m in machines)
            {
                m.Number = ++counter;
            }

            olvMachines.SetObjects(machines);
            TryActiveFirstMachine();
        }

        public void TryActiveFirstMachine()
        {
            if (olvMachines.Items.GetEnumerator().MoveNext())
                olvMachines.SelectedIndex = 0;
        }


        private void olvMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (olvMachines.SelectedIndex < 0)
                return;

            if (olvMachines.SelectedObject is Machine obj)
                MachineSelected?.Invoke(this, obj.Id);
        }

        private async void olvMachines_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Cancel)
                return;

            if (e.NewValue.Equals(e.Value))
            {
                e.Cancel = true;
                olvMachines.RemoveObjects(olvMachines.Objects.Cast<Machine>().Where(c => c.Id == 0).ToArray());
                return;
            }

            if (e.Column == olvName)
            {
                if (string.IsNullOrEmpty(e.NewValue.ToString()))
                    e.Cancel = true;
                else
                {
                    var m = e.RowObject as Machine;
                    var value = e.NewValue.ToString();
                    m.Name = value;
                    if (m.Id != 0)
                    {
                        m.UpdatedOnUtc = DateTime.UtcNow;
                        await _machineRepo.UpdateAsync(m);
                    }

                    else
                    {
                        m.CreatedOnUtc = m.UpdatedOnUtc = DateTime.UtcNow;
                        await _machineRepo.InsertAsync(m);
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var machines = olvMachines.Objects.Cast<Machine>().ToArray();
            var placeholder = "[set machine name]";

            var machine = new Machine
            {
                Name = placeholder,
                Number = machines.Any() ? machines.Last().Number + 1 : 1
            };

            if (machines.Any(c => c.Name.Equals(placeholder)))
            {
                olvMachines.CancelCellEdit();
                olvMachines.RemoveObject(machine);
                return;
            }

            olvMachines.AddObject(machine);

            if (olvMachines.Items.Count > 0)
                olvMachines.EnsureVisible(olvMachines.Items.Count - 1);

            olvMachines.EditModel(machine);
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            if (olvMachines.SelectedObject is Machine m)
            {
                if (MessageHelper.AskForConfirmation("Remove machine?", m.Name) == DialogResult.OK)
                {
                    m.Deleted = true;
                    await _machineRepo.UpdateAsync(m);
                    FillOlv();

                }

            }
        }

        private void cbShowDeleted_CheckedChanged(object sender, bool e)
        {
            FillOlv();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.olvMachines.ModelFilter = new TextMatchFilter(olvMachines, txtSearch.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (olvMachines.SelectedObject is Machine m)
            {
                var save = new SaveFileDialog
                {
                    FileName = $"{m.Name}_" + $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss-fff}",
                    Filter = "xlsx files (*.xlsx)|*.xlsx"
                };
                try
                {
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        using (var p = new ExcelPackage(new FileInfo(save.FileName)))
                        {
                            var ws = p.Workbook.Worksheets.Add("Details");
                            ws.Cells["A1"].LoadFromDataTable(GetDataTable(m.Id), true);
                            p.Save();

                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageHelper.DisplayError(exception.Message);
                }
                finally
                {
                    save.Dispose();
                }
            }

        }

        private DataTable GetDataTable(int machineId)
        {
            var dmr = new DetailMachineRepository();

            var dt = new DataTable { TableName = "Details" };

            dt.Columns.Add("PartNumber", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("Length", typeof(double));
            dt.Columns.Add("Ps", typeof(double));
            dt.Columns.Add("Machine", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Remark", typeof(string));


            foreach (var model in dmr.FilterByMachine(machineId))
            {
                dt.Rows.Add(model.Detail, model.Material, model.Length, model.Qty, model.Machine, model.Price, model.Remark);
            }

            return dt;
        }
    }
}
