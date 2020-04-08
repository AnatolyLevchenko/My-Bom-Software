﻿using My.Bom.Software.Domain;
using My.Bom.Software.Helpers;
using My.Bom.Software.Repository;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;

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

        private void olvMachines_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
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
            var machine = new Machine
            {
                Name = "[set machine name]",
                Number = olvMachines.Objects.Cast<Machine>().Any()
                    ? olvMachines.Objects.Cast<Machine>().Last().Number + 1
                    :1
            };


            olvMachines.AddObject(machine);
            try
            {
                olvMachines.EnsureVisible(olvMachines.Items.Count - 1);
            }
            catch (Exception exception)
            {

            }

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
            this.olvMachines.ModelFilter=new TextMatchFilter(olvMachines,txtSearch.Text);
        }
    }
}
