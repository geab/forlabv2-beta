namespace LQT.GUI.Testing
{
    partial class FrmImportProUsage
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
            this.lvImport = new System.Windows.Forms.ListView();
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.test = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instrument = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usagerate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsForControl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UseForBoth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butClear = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butImport = new System.Windows.Forms.Button();
            this.butBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvImport
            // 
            this.lvImport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.test,
            this.instrument,
            this.product,
            this.usagerate,
            this.IsForControl,
            this.UseForBoth,
            this.exist,
            this.Description});
            this.lvImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvImport.GridLines = true;
            this.lvImport.Location = new System.Drawing.Point(0, 68);
            this.lvImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvImport.Name = "lvImport";
            this.lvImport.Size = new System.Drawing.Size(2174, 1003);
            this.lvImport.TabIndex = 32;
            this.lvImport.UseCompatibleStateImageBehavior = false;
            this.lvImport.View = System.Windows.Forms.View.Details;
            // 
            // colNo
            // 
            this.colNo.Text = "No";
            this.colNo.Width = 44;
            // 
            // test
            // 
            this.test.Text = "Test Name";
            this.test.Width = 155;
            // 
            // instrument
            // 
            this.instrument.Text = "Instrument";
            this.instrument.Width = 303;
            // 
            // product
            // 
            this.product.Text = "Product";
            this.product.Width = 543;
            // 
            // usagerate
            // 
            this.usagerate.Text = "Usage Rate";
            this.usagerate.Width = 119;
            // 
            // IsForControl
            // 
            this.IsForControl.Text = "Is For Control";
            this.IsForControl.Width = 135;
            // 
            // UseForBoth
            // 
            this.UseForBoth.Text = "Use For Both";
            this.UseForBoth.Width = 150;
            // 
            // exist
            // 
            this.exist.Text = "Exist";
            this.exist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exist.Width = 91;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 559;
            // 
            // butClear
            // 
            this.butClear.Enabled = false;
            this.butClear.Location = new System.Drawing.Point(607, 5);
            this.butClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 46);
            this.butClear.TabIndex = 5;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilename.Location = new System.Drawing.Point(10, 12);
            this.txtFilename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilename.MinimumSize = new System.Drawing.Size(374, 25);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(404, 26);
            this.txtFilename.TabIndex = 0;
            this.txtFilename.WordWrap = false;
            // 
            // butSave
            // 
            this.butSave.Enabled = false;
            this.butSave.Location = new System.Drawing.Point(686, 5);
            this.butSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 46);
            this.butSave.TabIndex = 4;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.butClear);
            this.panel2.Controls.Add(this.txtFilename);
            this.panel2.Controls.Add(this.butSave);
            this.panel2.Controls.Add(this.butImport);
            this.panel2.Controls.Add(this.butBrowse);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2174, 68);
            this.panel2.TabIndex = 31;
            // 
            // butImport
            // 
            this.butImport.Location = new System.Drawing.Point(529, 5);
            this.butImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butImport.Name = "butImport";
            this.butImport.Size = new System.Drawing.Size(75, 46);
            this.butImport.TabIndex = 2;
            this.butImport.Text = "Import";
            this.butImport.UseVisualStyleBackColor = true;
            this.butImport.Click += new System.EventHandler(this.butImport_Click);
            // 
            // butBrowse
            // 
            this.butBrowse.Location = new System.Drawing.Point(434, 5);
            this.butBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(92, 46);
            this.butBrowse.TabIndex = 1;
            this.butBrowse.Text = "Browse...";
            this.butBrowse.UseVisualStyleBackColor = true;
            this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xls";
            this.openFileDialog1.Filter = "Excel files|*.xls";
            // 
            // FrmImportProUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2174, 1071);
            this.Controls.Add(this.lvImport);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImportProUsage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Test Product Usage Rate";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvImport;
        private System.Windows.Forms.ColumnHeader colNo;
        private System.Windows.Forms.ColumnHeader test;
        private System.Windows.Forms.ColumnHeader instrument;
        private System.Windows.Forms.ColumnHeader product;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butImport;
        private System.Windows.Forms.Button butBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader usagerate;
        private System.Windows.Forms.ColumnHeader exist;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader IsForControl;
        private System.Windows.Forms.ColumnHeader UseForBoth;
    }
}