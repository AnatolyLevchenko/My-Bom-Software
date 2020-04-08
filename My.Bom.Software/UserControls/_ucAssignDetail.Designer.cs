namespace My.Bom.Software.UserControls
{
    partial class _ucAssignDetail
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
            this.cbDetails = new System.Windows.Forms.ComboBox();
            this.nupQty = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbMachine = new System.Windows.Forms.Label();
            this.lbDetail = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbMachine = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupQty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDetails
            // 
            this.cbDetails.DisplayMember = "PartNumber";
            this.cbDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDetails.FormattingEnabled = true;
            this.cbDetails.Location = new System.Drawing.Point(105, 42);
            this.cbDetails.Name = "cbDetails";
            this.cbDetails.Size = new System.Drawing.Size(95, 21);
            this.cbDetails.TabIndex = 0;
            this.cbDetails.ValueMember = "Id";
            // 
            // nupQty
            // 
            this.nupQty.Location = new System.Drawing.Point(105, 76);
            this.nupQty.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nupQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupQty.Name = "nupQty";
            this.nupQty.Size = new System.Drawing.Size(95, 20);
            this.nupQty.TabIndex = 4;
            this.nupQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(191)))), ((int)(((byte)(25)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(23, 119);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 37);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Assign";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbMachine
            // 
            this.lbMachine.AutoSize = true;
            this.lbMachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbMachine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMachine.Location = new System.Drawing.Point(30, 16);
            this.lbMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMachine.Name = "lbMachine";
            this.lbMachine.Size = new System.Drawing.Size(48, 13);
            this.lbMachine.TabIndex = 40;
            this.lbMachine.Text = "Machine";
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbDetail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDetail.Location = new System.Drawing.Point(30, 42);
            this.lbDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(34, 13);
            this.lbDetail.TabIndex = 42;
            this.lbDetail.Text = "Detail";
            // 
            // lbQty
            // 
            this.lbQty.AutoSize = true;
            this.lbQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbQty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbQty.Location = new System.Drawing.Point(33, 76);
            this.lbQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(23, 13);
            this.lbQty.TabIndex = 43;
            this.lbQty.Text = "Qty";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.cbMachine);
            this.groupBox1.Controls.Add(this.lbMachine);
            this.groupBox1.Controls.Add(this.lbQty);
            this.groupBox1.Controls.Add(this.cbDetails);
            this.groupBox1.Controls.Add(this.lbDetail);
            this.groupBox1.Controls.Add(this.nupQty);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 186);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(148, 119);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 37);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbMachine
            // 
            this.cbMachine.DisplayMember = "Name";
            this.cbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMachine.FormattingEnabled = true;
            this.cbMachine.Location = new System.Drawing.Point(105, 13);
            this.cbMachine.Name = "cbMachine";
            this.cbMachine.Size = new System.Drawing.Size(95, 21);
            this.cbMachine.TabIndex = 44;
            this.cbMachine.ValueMember = "Id";
            this.cbMachine.SelectedIndexChanged += new System.EventHandler(this.cbMachine_SelectedIndexChanged);
            // 
            // _ucAssignDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "_ucAssignDetail";
            this.Size = new System.Drawing.Size(319, 242);
            ((System.ComponentModel.ISupportInitialize)(this.nupQty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDetails;
        private System.Windows.Forms.NumericUpDown nupQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbMachine;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMachine;
        private System.Windows.Forms.Button btnCancel;
    }
}
