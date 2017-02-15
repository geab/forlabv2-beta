namespace LQT.GUI.MorbidityUserCtr
{
    partial class FrmImportCPN
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
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.lvImport = new System.Windows.Forms.ListView();
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butImport = new System.Windows.Forms.Button();
            this.butBrowse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butClear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilename
            // 
            this.txtFilename.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilename.Location = new System.Drawing.Point(10, 23);
            this.txtFilename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilename.MinimumSize = new System.Drawing.Size(374, 25);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(1235, 26);
            this.txtFilename.TabIndex = 0;
            this.txtFilename.WordWrap = false;
            // 
            // butSave
            // 
            this.butSave.Enabled = false;
            this.butSave.Location = new System.Drawing.Point(1592, 12);
            this.butSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(98, 46);
            this.butSave.TabIndex = 4;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // lvImport
            // 
            this.lvImport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colRegion,
            this.colSite,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader1,
            this.columnHeader2});
            this.lvImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvImport.FullRowSelect = true;
            this.lvImport.GridLines = true;
            this.lvImport.Location = new System.Drawing.Point(0, 68);
            this.lvImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvImport.Name = "lvImport";
            this.lvImport.Size = new System.Drawing.Size(2253, 986);
            this.lvImport.TabIndex = 5;
            this.lvImport.UseCompatibleStateImageBehavior = false;
            this.lvImport.View = System.Windows.Forms.View.Details;
            // 
            // colNo
            // 
            this.colNo.Text = "No";
            this.colNo.Width = 37;
            // 
            // colRegion
            // 
            this.colRegion.Text = "Category/Region";
            this.colRegion.Width = 158;
            // 
            // colSite
            // 
            this.colSite.Text = "ART Sites";
            this.colSite.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Current Patient on Treatment ";
            this.columnHeader4.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Current Patient Pre-treatment";
            this.columnHeader3.Width = 245;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ever started - Treatment";
            this.columnHeader12.Width = 209;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Ever Started - Pre-treatment";
            this.columnHeader13.Width = 236;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "VCT";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CD4";
            this.columnHeader6.Width = 62;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Chemistry";
            this.columnHeader7.Width = 94;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hematology";
            this.columnHeader8.Width = 108;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Viral Load";
            this.columnHeader9.Width = 93;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Other Tests";
            this.columnHeader10.Width = 107;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Consummables";
            this.columnHeader11.Width = 137;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Exist";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 53;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Remarks";
            this.columnHeader2.Width = 294;
            // 
            // butImport
            // 
            this.butImport.Location = new System.Drawing.Point(1377, 12);
            this.butImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butImport.Name = "butImport";
            this.butImport.Size = new System.Drawing.Size(92, 46);
            this.butImport.TabIndex = 2;
            this.butImport.Text = "Import";
            this.butImport.UseVisualStyleBackColor = true;
            this.butImport.Click += new System.EventHandler(this.butImport_Click);
            // 
            // butBrowse
            // 
            this.butBrowse.Location = new System.Drawing.Point(1270, 12);
            this.butBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(92, 46);
            this.butBrowse.TabIndex = 1;
            this.butBrowse.Text = "Browse...";
            this.butBrowse.UseVisualStyleBackColor = true;
            this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
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
            this.panel2.Size = new System.Drawing.Size(2253, 68);
            this.panel2.TabIndex = 35;
            // 
            // butClear
            // 
            this.butClear.Enabled = false;
            this.butClear.Location = new System.Drawing.Point(1483, 12);
            this.butClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(92, 46);
            this.butClear.TabIndex = 3;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xls";
            this.openFileDialog1.Filter = "Excel files|*.xls";
            // 
            // FrmImportCPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2253, 1054);
            this.Controls.Add(this.lvImport);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImportCPN";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Current Patient Numbers, EVER STARTED Patient Numbers and Forecast supply " +
                "for the site";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.ListView lvImport;
        private System.Windows.Forms.ColumnHeader colNo;
        private System.Windows.Forms.ColumnHeader colRegion;
        private System.Windows.Forms.ColumnHeader colSite;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button butImport;
        private System.Windows.Forms.Button butBrowse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}