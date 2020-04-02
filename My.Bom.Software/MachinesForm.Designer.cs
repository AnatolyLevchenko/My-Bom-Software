namespace My.Bom.Software
{
    partial class MachinesForm
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
            this.OldId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetails)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvDetails
            // 
            this.olvDetails.AllColumns.Add(this.OldId);
            this.olvDetails.AllColumns.Add(this.olvName);
            this.olvDetails.CellEditUseWholeCell = false;
            this.olvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OldId,
            this.olvName});
            this.olvDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvDetails.FullRowSelect = true;
            this.olvDetails.Location = new System.Drawing.Point(0, 0);
            this.olvDetails.Name = "olvDetails";
            this.olvDetails.ShowGroups = false;
            this.olvDetails.Size = new System.Drawing.Size(800, 450);
            this.olvDetails.TabIndex = 0;
            this.olvDetails.UseCompatibleStateImageBehavior = false;
            this.olvDetails.View = System.Windows.Forms.View.Details;
            this.olvDetails.ItemActivate += new System.EventHandler(this.objectListView1_ItemActivate);
            // 
            // OldId
            // 
            this.OldId.AspectName = "Id";
            this.OldId.IsEditable = false;
            this.OldId.Text = "Id";
            // 
            // olvName
            // 
            this.olvName.AspectName = "Name";
            this.olvName.Text = "Name";
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
            // btnAddDetail
            // 
            this.btnAddDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDetail.Image = global::My.Bom.Software.Properties.Resources.add_icon;
            this.btnAddDetail.Location = new System.Drawing.Point(326, 0);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(58, 23);
            this.btnAddDetail.TabIndex = 1;
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // MachinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.olvDetails);
            this.Name = "MachinesForm";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.MachinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvDetails)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvDetails;
        private BrightIdeasSoftware.OLVColumn OldId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn olvName;
        private System.Windows.Forms.Button btnAddDetail;
    }
}