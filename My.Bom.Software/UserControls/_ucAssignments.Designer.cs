﻿namespace My.Bom.Software.UserControls
{
    partial class _ucAssignments
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.olvDetails = new BrightIdeasSoftware.ObjectListView();
            this.olvMachineName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPartNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPieces = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvRemark = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvMaterial = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvUnsign = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvImage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbShowImages = new My.Bom.Software.Custom.ComboStripCheckbox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAssign = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetails)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.olvDetails, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(900, 423);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // olvDetails
            // 
            this.olvDetails.AllColumns.Add(this.olvMachineName);
            this.olvDetails.AllColumns.Add(this.olvPartNumber);
            this.olvDetails.AllColumns.Add(this.olvPieces);
            this.olvDetails.AllColumns.Add(this.olvPrice);
            this.olvDetails.AllColumns.Add(this.olvRemark);
            this.olvDetails.AllColumns.Add(this.olvMaterial);
            this.olvDetails.AllColumns.Add(this.olvUnsign);
            this.olvDetails.AllColumns.Add(this.olvImage);
            this.olvDetails.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvDetails.CellEditUseWholeCell = false;
            this.olvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvMachineName,
            this.olvPartNumber,
            this.olvPieces,
            this.olvPrice,
            this.olvRemark,
            this.olvMaterial,
            this.olvUnsign,
            this.olvImage});
            this.olvDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvDetails.FullRowSelect = true;
            this.olvDetails.Location = new System.Drawing.Point(3, 34);
            this.olvDetails.MultiSelect = false;
            this.olvDetails.Name = "olvDetails";
            this.olvDetails.RowHeight = 60;
            this.olvDetails.ShowGroups = false;
            this.olvDetails.Size = new System.Drawing.Size(894, 363);
            this.olvDetails.TabIndex = 1;
            this.olvDetails.UseCellFormatEvents = true;
            this.olvDetails.UseCompatibleStateImageBehavior = false;
            this.olvDetails.UseFilterIndicator = true;
            this.olvDetails.UseFiltering = true;
            this.olvDetails.View = System.Windows.Forms.View.Details;
            this.olvDetails.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvDetails_ButtonClick);
            this.olvDetails.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.olvDetails_CellEditFinishing);
            this.olvDetails.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvDetails_CellClick);
            this.olvDetails.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvDetails_FormatCell);
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
            this.olvPrice.Text = "Price";
            // 
            // olvRemark
            // 
            this.olvRemark.AspectName = "Remark";
            this.olvRemark.Text = "Remark";
            this.olvRemark.Width = 81;
            // 
            // olvMaterial
            // 
            this.olvMaterial.AspectName = "Material";
            this.olvMaterial.Text = "Material";
            // 
            // olvUnsign
            // 
            this.olvUnsign.AspectName = "UnSign";
            this.olvUnsign.IsButton = true;
            this.olvUnsign.IsEditable = false;
            this.olvUnsign.Text = "Remove";
            // 
            // olvImage
            // 
            this.olvImage.AspectName = "Image";
            this.olvImage.IsEditable = false;
            this.olvImage.Text = "Image";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbTotal,
            this.toolStripSpacer,
            this.cbShowImages});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 23);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbTotal
            // 
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(37, 18);
            this.lbTotal.Text = "Total:";
            // 
            // toolStripSpacer
            // 
            this.toolStripSpacer.Name = "toolStripSpacer";
            this.toolStripSpacer.Size = new System.Drawing.Size(727, 18);
            this.toolStripSpacer.Spring = true;
            // 
            // cbShowImages
            // 
            this.cbShowImages.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbShowImages.Checked = true;
            this.cbShowImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbShowImages.Name = "cbShowImages";
            this.cbShowImages.Size = new System.Drawing.Size(121, 21);
            this.cbShowImages.Text = "Show Images";
            this.cbShowImages.CheckedChanged += new System.EventHandler<bool>(this.cbShowImages_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAssign,
            this.txtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 1, 3);
            this.toolStrip1.Size = new System.Drawing.Size(900, 31);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAssign
            // 
            this.btnAssign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAssign.Image = global::My.Bom.Software.Properties.Resources.connection;
            this.btnAssign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(23, 20);
            this.btnAssign.Text = "Assign";
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 23);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // _ucAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "_ucAssignments";
            this.Size = new System.Drawing.Size(900, 423);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetails)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private BrightIdeasSoftware.ObjectListView olvDetails;
        private BrightIdeasSoftware.OLVColumn olvMachineName;
        private BrightIdeasSoftware.OLVColumn olvPartNumber;
        private BrightIdeasSoftware.OLVColumn olvPieces;
        private BrightIdeasSoftware.OLVColumn olvPrice;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbTotal;
        private BrightIdeasSoftware.OLVColumn olvRemark;
        private BrightIdeasSoftware.OLVColumn olvMaterial;
        private BrightIdeasSoftware.OLVColumn olvImage;
        private BrightIdeasSoftware.OLVColumn olvUnsign;
        private Custom.ComboStripCheckbox cbShowImages;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSpacer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnAssign;
    }
}
