﻿namespace My.Bom.Software.UserControls
{
    partial class _ucMachines
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.olvMachines = new BrightIdeasSoftware.ObjectListView();
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvMachines)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvMachines
            // 
            this.olvMachines.AllColumns.Add(this.olvName);
            this.olvMachines.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvMachines.CellEditUseWholeCell = false;
            this.olvMachines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvName});
            this.olvMachines.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvMachines.FullRowSelect = true;
            this.olvMachines.Location = new System.Drawing.Point(3, 32);
            this.olvMachines.MultiSelect = false;
            this.olvMachines.Name = "olvMachines";
            this.olvMachines.ShowGroups = false;
            this.olvMachines.Size = new System.Drawing.Size(262, 364);
            this.olvMachines.TabIndex = 1;
            this.olvMachines.UseCompatibleStateImageBehavior = false;
            this.olvMachines.View = System.Windows.Forms.View.Details;
            this.olvMachines.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.olvMachines_CellEditFinishing);
            this.olvMachines.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvMachines_FormatRow);
            this.olvMachines.SelectedIndexChanged += new System.EventHandler(this.olvMachines_SelectedIndexChanged);
            // 
            // olvName
            // 
            this.olvName.AspectName = "Name";
            this.olvName.FillsFreeSpace = true;
            this.olvName.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvName.Text = "Machines";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.olvMachines, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCreate, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 421);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(54, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbTotal
            // 
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(37, 17);
            this.lbTotal.Text = "Total:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Image = global::My.Bom.Software.Properties.Resources.add_icon;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "   ADD";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // _ucMachines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "_ucMachines";
            this.Size = new System.Drawing.Size(268, 421);
            ((System.ComponentModel.ISupportInitialize)(this.olvMachines)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BrightIdeasSoftware.OLVColumn olvName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbTotal;
        public BrightIdeasSoftware.ObjectListView olvMachines;
        private System.Windows.Forms.Button btnCreate;
    }
}