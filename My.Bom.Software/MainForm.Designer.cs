namespace My.Bom.Software
{
    partial class mainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.olvMachines = new BrightIdeasSoftware.ObjectListView();
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDetails = new BrightIdeasSoftware.ObjectListView();
            this.olvMachineName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPieces = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPartNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnDetails = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.olvMachines, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.olvDetails, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDetails, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // olvMachines
            // 
            this.olvMachines.AllColumns.Add(this.olvName);
            this.olvMachines.CellEditUseWholeCell = false;
            this.olvMachines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvName});
            this.olvMachines.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvMachines.FullRowSelect = true;
            this.olvMachines.Location = new System.Drawing.Point(3, 48);
            this.olvMachines.MultiSelect = false;
            this.olvMachines.Name = "olvMachines";
            this.olvMachines.ShowGroups = false;
            this.olvMachines.Size = new System.Drawing.Size(154, 399);
            this.olvMachines.TabIndex = 0;
            this.olvMachines.UseCompatibleStateImageBehavior = false;
            this.olvMachines.View = System.Windows.Forms.View.Details;
            this.olvMachines.SelectedIndexChanged += new System.EventHandler(this.olvMachines_SelectedIndexChanged);
            // 
            // olvName
            // 
            this.olvName.AspectName = "Name";
            this.olvName.FillsFreeSpace = true;
            this.olvName.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvName.Text = "Machines";
            // 
            // olvDetails
            // 
            this.olvDetails.AllColumns.Add(this.olvMachineName);
            this.olvDetails.AllColumns.Add(this.olvPartNumber);
            this.olvDetails.AllColumns.Add(this.olvPieces);
            this.olvDetails.AllColumns.Add(this.olvPrice);
            this.olvDetails.CellEditUseWholeCell = false;
            this.olvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvMachineName,
            this.olvPartNumber,
            this.olvPieces,
            this.olvPrice});
            this.olvDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvDetails.FullRowSelect = true;
            this.olvDetails.Location = new System.Drawing.Point(163, 48);
            this.olvDetails.MultiSelect = false;
            this.olvDetails.Name = "olvDetails";
            this.olvDetails.ShowGroups = false;
            this.olvDetails.Size = new System.Drawing.Size(394, 399);
            this.olvDetails.TabIndex = 1;
            this.olvDetails.UseCompatibleStateImageBehavior = false;
            this.olvDetails.View = System.Windows.Forms.View.Details;
            // 
            // olvMachineName
            // 
            this.olvMachineName.AspectName = "Machine";
            this.olvMachineName.Text = "Machine";
            this.olvMachineName.Width = 90;
            // 
            // olvPieces
            // 
            this.olvPieces.AspectName = "Qty";
            this.olvPieces.Text = "Pieces";
            this.olvPieces.Width = 115;
            // 
            // olvPartNumber
            // 
            this.olvPartNumber.AspectName = "Detail";
            this.olvPartNumber.Text = "Part Number";
            this.olvPartNumber.Width = 100;
            // 
            // olvPrice
            // 
            this.olvPrice.AspectName = "PriceStr";
            this.olvPrice.Text = "Price";
            // 
            // btnDetails
            // 
            this.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Image = global::My.Bom.Software.Properties.Resources.cogs;
            this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.Location = new System.Drawing.Point(163, 3);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(88, 29);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BrightIdeasSoftware.ObjectListView olvMachines;
        private BrightIdeasSoftware.OLVColumn olvName;
        private BrightIdeasSoftware.ObjectListView olvDetails;
        private BrightIdeasSoftware.OLVColumn olvMachineName;
        private BrightIdeasSoftware.OLVColumn olvPieces;
        private BrightIdeasSoftware.OLVColumn olvPartNumber;
        private BrightIdeasSoftware.OLVColumn olvPrice;
        private System.Windows.Forms.Button btnDetails;

    }
}

