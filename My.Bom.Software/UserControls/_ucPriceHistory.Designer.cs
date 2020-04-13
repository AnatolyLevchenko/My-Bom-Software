namespace My.Bom.Software.UserControls
{
    partial class _ucPriceHistory
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.olvPriceHistory = new BrightIdeasSoftware.ObjectListView();
            this.olvId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDetail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvOperation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPriceHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.olvPriceHistory, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 310);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(573, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // olvPriceHistory
            // 
            this.olvPriceHistory.AllColumns.Add(this.olvId);
            this.olvPriceHistory.AllColumns.Add(this.olvDetail);
            this.olvPriceHistory.AllColumns.Add(this.olvPrice);
            this.olvPriceHistory.AllColumns.Add(this.olvOperation);
            this.olvPriceHistory.AllColumns.Add(this.olvDate);
            this.olvPriceHistory.CellEditUseWholeCell = false;
            this.olvPriceHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvId,
            this.olvDetail,
            this.olvPrice,
            this.olvOperation,
            this.olvDate});
            this.olvPriceHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPriceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvPriceHistory.FullRowSelect = true;
            this.olvPriceHistory.Location = new System.Drawing.Point(3, 29);
            this.olvPriceHistory.Name = "olvPriceHistory";
            this.olvPriceHistory.ShowGroups = false;
            this.olvPriceHistory.Size = new System.Drawing.Size(573, 278);
            this.olvPriceHistory.TabIndex = 1;
            this.olvPriceHistory.UseCompatibleStateImageBehavior = false;
            this.olvPriceHistory.UseFilterIndicator = true;
            this.olvPriceHistory.UseFiltering = true;
            this.olvPriceHistory.View = System.Windows.Forms.View.Details;
            // 
            // olvId
            // 
            this.olvId.AspectName = "Id";
            this.olvId.Text = "Id";
            // 
            // olvDetail
            // 
            this.olvDetail.AspectName = "PartNumber";
            this.olvDetail.Text = "Detail";
            // 
            // olvPrice
            // 
            this.olvPrice.AspectName = "PriceStr";
            this.olvPrice.Text = "Price";
            // 
            // olvOperation
            // 
            this.olvOperation.AspectName = "OperationValue";
            this.olvOperation.Text = "Operation";
            // 
            // olvDate
            // 
            this.olvDate.AspectName = "Date";
            this.olvDate.Text = "Date";
            // 
            // _ucPriceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "_ucPriceHistory";
            this.Size = new System.Drawing.Size(579, 310);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPriceHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtSearch;
        private BrightIdeasSoftware.ObjectListView olvPriceHistory;
        private BrightIdeasSoftware.OLVColumn olvId;
        private BrightIdeasSoftware.OLVColumn olvDetail;
        private BrightIdeasSoftware.OLVColumn olvPrice;
        private BrightIdeasSoftware.OLVColumn olvOperation;
        private BrightIdeasSoftware.OLVColumn olvDate;
    }
}
