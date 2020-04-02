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
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnMachines = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.olvDetails = new BrightIdeasSoftware.ObjectListView();
            this.olvMachineName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPartNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPieces = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSetQty = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvMachines)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.olvMachines, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDetails, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMachines, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 450);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.olvMachines.Location = new System.Drawing.Point(3, 84);
            this.olvMachines.MultiSelect = false;
            this.olvMachines.Name = "olvMachines";
            this.olvMachines.ShowGroups = false;
            this.olvMachines.Size = new System.Drawing.Size(190, 363);
            this.olvMachines.TabIndex = 0;
            this.olvMachines.UseCompatibleStateImageBehavior = false;
            this.olvMachines.View = System.Windows.Forms.View.Details;
            this.olvMachines.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.olvMachines_CellEditFinishing);
            this.olvMachines.SelectedIndexChanged += new System.EventHandler(this.olvMachines_SelectedIndexChanged);
            // 
            // olvName
            // 
            this.olvName.AspectName = "Name";
            this.olvName.FillsFreeSpace = true;
            this.olvName.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvName.Text = "Machines";
            // 
            // btnDetails
            // 
            this.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Image = global::My.Bom.Software.Properties.Resources.cogs;
            this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.Location = new System.Drawing.Point(199, 3);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(118, 47);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Open Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnMachines
            // 
            this.btnMachines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMachines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachines.Image = global::My.Bom.Software.Properties.Resources.machine;
            this.btnMachines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMachines.Location = new System.Drawing.Point(3, 3);
            this.btnMachines.Name = "btnMachines";
            this.btnMachines.Size = new System.Drawing.Size(111, 47);
            this.btnMachines.TabIndex = 3;
            this.btnMachines.Text = "      Add machine";
            this.btnMachines.UseVisualStyleBackColor = true;
            this.btnMachines.Click += new System.EventHandler(this.btnMachines_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbTotal, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.olvDetails, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(199, 84);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(584, 363);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotal.Location = new System.Drawing.Point(3, 343);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(578, 20);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "Totalsdfsdfdsfsd";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // olvDetails
            // 
            this.olvDetails.AllColumns.Add(this.olvMachineName);
            this.olvDetails.AllColumns.Add(this.olvPartNumber);
            this.olvDetails.AllColumns.Add(this.olvPieces);
            this.olvDetails.AllColumns.Add(this.olvPrice);
            this.olvDetails.AllColumns.Add(this.olvSetQty);
            this.olvDetails.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvDetails.CellEditUseWholeCell = false;
            this.olvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvMachineName,
            this.olvPartNumber,
            this.olvPieces,
            this.olvPrice,
            this.olvSetQty});
            this.olvDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvDetails.FullRowSelect = true;
            this.olvDetails.Location = new System.Drawing.Point(3, 3);
            this.olvDetails.MultiSelect = false;
            this.olvDetails.Name = "olvDetails";
            this.olvDetails.RowHeight = 45;
            this.olvDetails.ShowGroups = false;
            this.olvDetails.Size = new System.Drawing.Size(578, 337);
            this.olvDetails.TabIndex = 1;
            this.olvDetails.UseCompatibleStateImageBehavior = false;
            this.olvDetails.View = System.Windows.Forms.View.Details;
            this.olvDetails.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvDetails_ButtonClick);
            this.olvDetails.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvDetails_FormatRow);
            // 
            // olvMachineName
            // 
            this.olvMachineName.AspectName = "Machine";
            this.olvMachineName.IsEditable = false;
            this.olvMachineName.Text = "Machine";
            this.olvMachineName.Width = 90;
            // 
            // olvPartNumber
            // 
            this.olvPartNumber.AspectName = "Detail";
            this.olvPartNumber.IsEditable = false;
            this.olvPartNumber.Text = "Part Number";
            this.olvPartNumber.Width = 100;
            // 
            // olvPieces
            // 
            this.olvPieces.AspectName = "Qty";
            this.olvPieces.Text = "Pieces";
            this.olvPieces.Width = 115;
            // 
            // olvPrice
            // 
            this.olvPrice.AspectName = "PriceStr";
            this.olvPrice.IsEditable = false;
            this.olvPrice.Text = "Price";
            // 
            // olvSetQty
            // 
            this.olvSetQty.AspectName = "BtnQty";
            this.olvSetQty.IsButton = true;
            this.olvSetQty.Text = "Set Qty";
            this.olvSetQty.Width = 91;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvMachines)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private BrightIdeasSoftware.OLVColumn olvSetQty;
        private System.Windows.Forms.Button btnMachines;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbTotal;
    }
}

