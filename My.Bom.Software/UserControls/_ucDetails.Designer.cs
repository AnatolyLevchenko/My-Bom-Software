﻿namespace My.Bom.Software
{
    partial class _ucDetails
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
            this.components = new System.ComponentModel.Container();
            this.olvDetails = new BrightIdeasSoftware.ObjectListView();
            this.olvEmptyHandleBug = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OldId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPartNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvLength = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvRemark = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvMaterial = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvImage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnAssignselected = new System.Windows.Forms.ToolStripButton();
            this.btnShowImages = new System.Windows.Forms.ToolStripButton();
            this.btnUncheck = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetails)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvDetails
            // 
            this.olvDetails.AllColumns.Add(this.olvEmptyHandleBug);
            this.olvDetails.AllColumns.Add(this.olvState);
            this.olvDetails.AllColumns.Add(this.OldId);
            this.olvDetails.AllColumns.Add(this.olvPartNumber);
            this.olvDetails.AllColumns.Add(this.olvName);
            this.olvDetails.AllColumns.Add(this.olvLength);
            this.olvDetails.AllColumns.Add(this.olvPrice);
            this.olvDetails.AllColumns.Add(this.olvRemark);
            this.olvDetails.AllColumns.Add(this.olvMaterial);
            this.olvDetails.AllColumns.Add(this.olvImage);
            this.olvDetails.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvDetails.CellEditUseWholeCell = false;
            this.olvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvEmptyHandleBug,
            this.olvState,
            this.OldId,
            this.olvPartNumber,
            this.olvName,
            this.olvLength,
            this.olvPrice,
            this.olvRemark,
            this.olvMaterial,
            this.olvImage});
            this.olvDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvDetails.FullRowSelect = true;
            this.olvDetails.Location = new System.Drawing.Point(3, 28);
            this.olvDetails.MultiSelect = false;
            this.olvDetails.Name = "olvDetails";
            this.olvDetails.RowHeight = 50;
            this.olvDetails.ShowGroups = false;
            this.olvDetails.Size = new System.Drawing.Size(1178, 419);
            this.olvDetails.TabIndex = 0;
            this.olvDetails.UseCompatibleStateImageBehavior = false;
            this.olvDetails.UseFiltering = true;
            this.olvDetails.View = System.Windows.Forms.View.Details;
            this.olvDetails.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.olvDetails_CellEditFinishing);
            this.olvDetails.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.olvDetails_CellEditStarting);
            this.olvDetails.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvDetails_CellClick);
            // 
            // olvEmptyHandleBug
            // 
            this.olvEmptyHandleBug.IsEditable = false;
            this.olvEmptyHandleBug.MaximumWidth = 10;
            this.olvEmptyHandleBug.Width = 10;
            // 
            // olvState
            // 
            this.olvState.AspectName = "Checked";
            this.olvState.CheckBoxes = true;
            this.olvState.MaximumWidth = 30;
            this.olvState.Text = " ";
            this.olvState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvState.Width = 30;
            // 
            // OldId
            // 
            this.OldId.AspectName = "Id";
            this.OldId.IsEditable = false;
            this.OldId.MaximumWidth = 30;
            this.OldId.Text = "Id";
            this.OldId.Width = 10;
            // 
            // olvPartNumber
            // 
            this.olvPartNumber.AspectName = "PartNumber";
            this.olvPartNumber.Text = "Part Number";
            this.olvPartNumber.Width = 122;
            // 
            // olvName
            // 
            this.olvName.AspectName = "Name";
            this.olvName.Text = "Name";
            // 
            // olvLength
            // 
            this.olvLength.AspectName = "Length";
            this.olvLength.Text = "L, mm";
            // 
            // olvPrice
            // 
            this.olvPrice.AspectName = "Price";
            this.olvPrice.Text = "Price";
            // 
            // olvRemark
            // 
            this.olvRemark.AspectName = "Remark";
            this.olvRemark.Text = "Remark";
            this.olvRemark.Width = 79;
            // 
            // olvMaterial
            // 
            this.olvMaterial.AspectName = "Material";
            this.olvMaterial.Text = "Material";
            this.olvMaterial.Width = 83;
            // 
            // olvImage
            // 
            this.olvImage.AspectName = "Image";
            this.olvImage.IsEditable = false;
            this.olvImage.Text = "Image";
            this.olvImage.Width = 220;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.addNewToolStripMenuItem.Text = "Add new";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.olvDetails, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnAssignselected,
            this.btnShowImages,
            this.btnUncheck,
            this.txtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::My.Bom.Software.Properties.Resources.add_icon;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Add detail";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAssignselected
            // 
            this.btnAssignselected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAssignselected.Image = global::My.Bom.Software.Properties.Resources.connection;
            this.btnAssignselected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAssignselected.Name = "btnAssignselected";
            this.btnAssignselected.Size = new System.Drawing.Size(23, 22);
            this.btnAssignselected.Text = "Assign selected";
            this.btnAssignselected.Click += new System.EventHandler(this.btnAssignselected_Click);
            // 
            // btnShowImages
            // 
            this.btnShowImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowImages.Image = global::My.Bom.Software.Properties.Resources.eye;
            this.btnShowImages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowImages.Name = "btnShowImages";
            this.btnShowImages.Size = new System.Drawing.Size(23, 22);
            this.btnShowImages.Text = "Show/Hide images";
            this.btnShowImages.Click += new System.EventHandler(this.btnShowImages_Click);
            // 
            // btnUncheck
            // 
            this.btnUncheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUncheck.Image = global::My.Bom.Software.Properties.Resources.checkbox;
            this.btnUncheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUncheck.Name = "btnUncheck";
            this.btnUncheck.Size = new System.Drawing.Size(23, 22);
            this.btnUncheck.Text = "Uncheck all";
            this.btnUncheck.Click += new System.EventHandler(this.btnUncheck_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // _ucDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "_ucDetails";
            this.Size = new System.Drawing.Size(1184, 450);
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvDetails)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvDetails;
        private BrightIdeasSoftware.OLVColumn OldId;
        private BrightIdeasSoftware.OLVColumn olvPartNumber;
        private BrightIdeasSoftware.OLVColumn olvPrice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn olvName;
        private BrightIdeasSoftware.OLVColumn olvRemark;
        private BrightIdeasSoftware.OLVColumn olvMaterial;
        private BrightIdeasSoftware.OLVColumn olvImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BrightIdeasSoftware.OLVColumn olvLength;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnShowImages;
        private System.Windows.Forms.ToolStripButton btnAssignselected;
        private System.Windows.Forms.ToolStripButton btnUncheck;
        private BrightIdeasSoftware.OLVColumn olvState;
        private BrightIdeasSoftware.OLVColumn olvEmptyHandleBug;
    }
}