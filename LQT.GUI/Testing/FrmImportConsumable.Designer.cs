namespace LQT.GUI.Testing
{
    partial class FrmImportConsumable
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
            this.period = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noOfTest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usagerate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isPerTest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isPerPeriod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isPerInstrument = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.period,
            this.noOfTest,
            this.usagerate,
            this.isPerTest,
            this.isPerPeriod,
            this.isPerInstrument,
            this.exist,
            this.description});
            this.lvImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvImport.GridLines = true;
            this.lvImport.Location = new System.Drawing.Point(0, 44);
            this.lvImport.Name = "lvImport";
            this.lvImport.Size = new System.Drawing.Size(916, 453);
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
            this.test.Width = 98;
            // 
            // instrument
            // 
            this.instrument.Text = "Instrument";
            this.instrument.Width = 106;
            // 
            // product
            // 
            this.product.Text = "Product";
            this.product.Width = 115;
            // 
            // period
            // 
            this.period.Text = "Period";
            // 
            // noOfTest
            // 
            this.noOfTest.Text = "No Of Test";
            // 
            // usagerate
            // 
            this.usagerate.Text = "Usage Rate";
            this.usagerate.Width = 119;
            // 
            // isPerTest
            // 
            this.isPerTest.Text = "Per Test";
            // 
            // isPerPeriod
            // 
            this.isPerPeriod.Text = "Per Period";
            this.isPerPeriod.Width = 135;
            // 
            // isPerInstrument
            // 
            this.isPerInstrument.Text = "Per Instrument";
            this.isPerInstrument.Width = 98;
            // 
            // exist
            // 
            this.exist.Text = "Exist";
            this.exist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exist.Width = 91;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 559;
            // 
            // butClear
            // 
            this.butClear.Enabled = false;
            this.butClear.Location = new System.Drawing.Point(405, 3);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(50, 30);
            this.butClear.TabIndex = 5;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilename.Location = new System.Drawing.Point(7, 8);
            this.txtFilename.MinimumSize = new System.Drawing.Size(250, 25);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(270, 20);
            this.txtFilename.TabIndex = 0;
            this.txtFilename.WordWrap = false;
            // 
            // butSave
            // 
            this.butSave.Enabled = false;
            this.butSave.Location = new System.Drawing.Point(457, 3);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(50, 30);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 44);
            this.panel2.TabIndex = 31;
            // 
            // butImport
            // 
            this.butImport.Location = new System.Drawing.Point(353, 3);
            this.butImport.Name = "butImport";
            this.butImport.Size = new System.Drawing.Size(50, 30);
            this.butImport.TabIndex = 2;
            this.butImport.Text = "Import";
            this.butImport.UseVisualStyleBackColor = true;
            this.butImport.Click += new System.EventHandler(this.butImport_Click);
            // 
            // butBrowse
            // 
            this.butBrowse.Location = new System.Drawing.Point(289, 3);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(61, 30);
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
            // FrmImportConsumable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 497);
            this.Controls.Add(this.lvImport);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImportConsumable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Consumable Usage Rate";
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
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader isPerPeriod;
        private System.Windows.Forms.ColumnHeader isPerInstrument;
        private System.Windows.Forms.ColumnHeader isPerTest;
        private System.Windows.Forms.ColumnHeader noOfTest;
        private System.Windows.Forms.ColumnHeader period;
    }
}