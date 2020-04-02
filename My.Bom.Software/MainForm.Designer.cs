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
            this._ucMachines1 = new My.Bom.Software.UserControls._ucMachines();
            this._ucDetails1 = new My.Bom.Software.UserControls._ucDetails();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this._ucMachines1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._ucDetails1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _ucMachines1
            // 
            this._ucMachines1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucMachines1.Location = new System.Drawing.Point(3, 3);
            this._ucMachines1.Name = "_ucMachines1";
            this._ucMachines1.Size = new System.Drawing.Size(349, 444);
            this._ucMachines1.TabIndex = 0;
            // 
            // _ucDetails1
            // 
            this._ucDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucDetails1.Location = new System.Drawing.Point(358, 3);
            this._ucDetails1.Name = "_ucDetails1";
            this._ucDetails1.Size = new System.Drawing.Size(623, 444);
            this._ucDetails1.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControls._ucMachines _ucMachines1;
        private UserControls._ucDetails _ucDetails1;
    }
}

