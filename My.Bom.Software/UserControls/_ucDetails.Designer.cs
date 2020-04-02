namespace My.Bom.Software.UserControls
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
            this.olvSetQty = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvRemark = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvMaterial = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvImage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnAssign = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetails)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.olvDetails, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAssign, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.statusStrip1, 0, 2);
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
            this.olvDetails.AllColumns.Add(this.olvSetQty);
            this.olvDetails.AllColumns.Add(this.olvRemark);
            this.olvDetails.AllColumns.Add(this.olvMaterial);
            this.olvDetails.AllColumns.Add(this.olvImage);
            this.olvDetails.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvDetails.CellEditUseWholeCell = false;
            this.olvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvMachineName,
            this.olvPartNumber,
            this.olvPieces,
            this.olvPrice,
            this.olvSetQty,
            this.olvRemark,
            this.olvMaterial,
            this.olvImage});
            this.olvDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvDetails.FullRowSelect = true;
            this.olvDetails.Location = new System.Drawing.Point(3, 32);
            this.olvDetails.MultiSelect = false;
            this.olvDetails.Name = "olvDetails";
            this.olvDetails.RowHeight = 60;
            this.olvDetails.ShowGroups = false;
            this.olvDetails.Size = new System.Drawing.Size(894, 366);
            this.olvDetails.TabIndex = 1;
            this.olvDetails.UseCompatibleStateImageBehavior = false;
            this.olvDetails.View = System.Windows.Forms.View.Details;
            this.olvDetails.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvDetails_ButtonClick);
            this.olvDetails.CellOver += new System.EventHandler<BrightIdeasSoftware.CellOverEventArgs>(this.olvDetails_CellOver);
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
            // olvRemark
            // 
            this.olvRemark.AspectName = "Remark";
            this.olvRemark.IsEditable = false;
            this.olvRemark.Text = "Remark";
            this.olvRemark.Width = 81;
            // 
            // olvMaterial
            // 
            this.olvMaterial.AspectName = "Material";
            this.olvMaterial.IsEditable = false;
            this.olvMaterial.Text = "Material";
            // 
            // olvImage
            // 
            this.olvImage.AspectName = "Image";
            this.olvImage.IsEditable = false;
            this.olvImage.Text = "Image";
            // 
            // btnAssign
            // 
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Image = global::My.Bom.Software.Properties.Resources.connection;
            this.btnAssign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssign.Location = new System.Drawing.Point(3, 3);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(97, 23);
            this.btnAssign.TabIndex = 5;
            this.btnAssign.Text = "     ASSIGN";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(54, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbTotal
            // 
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(37, 17);
            this.lbTotal.Text = "Total:";
            // 
            // _ucDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "_ucDetails";
            this.Size = new System.Drawing.Size(900, 423);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetails)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private BrightIdeasSoftware.ObjectListView olvDetails;
        private BrightIdeasSoftware.OLVColumn olvMachineName;
        private BrightIdeasSoftware.OLVColumn olvPartNumber;
        private BrightIdeasSoftware.OLVColumn olvPieces;
        private BrightIdeasSoftware.OLVColumn olvPrice;
        private BrightIdeasSoftware.OLVColumn olvSetQty;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbTotal;
        private BrightIdeasSoftware.OLVColumn olvRemark;
        private BrightIdeasSoftware.OLVColumn olvMaterial;
        private BrightIdeasSoftware.OLVColumn olvImage;
    }
}
