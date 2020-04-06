namespace My.Bom.Software.UserControls
{
    partial class _ucAddDetail
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
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.lbPartNumber = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.lbMaterial = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lbRemark = new System.Windows.Forms.Label();
            this.nupLength = new System.Windows.Forms.NumericUpDown();
            this.lbLength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(93, 9);
            this.txtPartNumber.Margin = new System.Windows.Forms.Padding(9);
            this.txtPartNumber.MaxLength = 149;
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(190, 20);
            this.txtPartNumber.TabIndex = 28;
            // 
            // lbPartNumber
            // 
            this.lbPartNumber.AutoSize = true;
            this.lbPartNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbPartNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPartNumber.Location = new System.Drawing.Point(13, 12);
            this.lbPartNumber.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbPartNumber.Name = "lbPartNumber";
            this.lbPartNumber.Size = new System.Drawing.Size(66, 13);
            this.lbPartNumber.TabIndex = 27;
            this.lbPartNumber.Text = "Part Number";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPrice.Location = new System.Drawing.Point(13, 209);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 29;
            this.lbPrice.Text = "Price";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(150, 350);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 41);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(191)))), ((int)(((byte)(25)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(16, 350);
            this.btnSave.Margin = new System.Windows.Forms.Padding(9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 41);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nupPrice
            // 
            this.nupPrice.DecimalPlaces = 2;
            this.nupPrice.Location = new System.Drawing.Point(93, 207);
            this.nupPrice.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nupPrice.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.nupPrice.Name = "nupPrice";
            this.nupPrice.Size = new System.Drawing.Size(76, 20);
            this.nupPrice.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 101);
            this.txtName.Margin = new System.Windows.Forms.Padding(9);
            this.txtName.MaxLength = 149;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 43;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbName.Location = new System.Drawing.Point(13, 104);
            this.lbName.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 42;
            this.lbName.Text = "Name";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(93, 37);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(9);
            this.txtMaterial.MaxLength = 149;
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(190, 20);
            this.txtMaterial.TabIndex = 45;
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbMaterial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMaterial.Location = new System.Drawing.Point(13, 37);
            this.lbMaterial.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(44, 13);
            this.lbMaterial.TabIndex = 44;
            this.lbMaterial.Text = "Material";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(93, 128);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(9);
            this.txtRemark.MaxLength = 149;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(190, 67);
            this.txtRemark.TabIndex = 47;
            // 
            // lbRemark
            // 
            this.lbRemark.AutoSize = true;
            this.lbRemark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbRemark.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbRemark.Location = new System.Drawing.Point(13, 128);
            this.lbRemark.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbRemark.Name = "lbRemark";
            this.lbRemark.Size = new System.Drawing.Size(44, 13);
            this.lbRemark.TabIndex = 46;
            this.lbRemark.Text = "Remark";
            // 
            // nupLength
            // 
            this.nupLength.DecimalPlaces = 2;
            this.nupLength.Location = new System.Drawing.Point(93, 69);
            this.nupLength.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupLength.Name = "nupLength";
            this.nupLength.Size = new System.Drawing.Size(190, 20);
            this.nupLength.TabIndex = 48;
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbLength.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbLength.Location = new System.Drawing.Point(13, 71);
            this.lbLength.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(40, 13);
            this.lbLength.TabIndex = 49;
            this.lbLength.Text = "Length";
            // 
            // _ucAddDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbLength);
            this.Controls.Add(this.nupLength);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lbRemark);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.lbMaterial);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.nupPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.lbPartNumber);
            this.Name = "_ucAddDetail";
            this.Size = new System.Drawing.Size(301, 444);
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Label lbPartNumber;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nupPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lbRemark;
        private System.Windows.Forms.NumericUpDown nupLength;
        private System.Windows.Forms.Label lbLength;
    }
}
