﻿namespace LQT.GUI.Location
{
    partial class FrmSearchSite
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butFind = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butAll = new System.Windows.Forms.Button();
            this.butNone = new System.Windows.Forms.Button();
            this.lsvRegion = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSitename = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbRegion = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lsvSite = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butFind);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 354);
            this.panel1.TabIndex = 1;
            // 
            // butFind
            // 
            this.butFind.Location = new System.Drawing.Point(708, 28);
            this.butFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(136, 35);
            this.butFind.TabIndex = 1;
            this.butFind.Text = "Search Now";
            this.butFind.UseVisualStyleBackColor = true;
            this.butFind.Click += new System.EventHandler(this.butFind_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.butAll);
            this.panel2.Controls.Add(this.butNone);
            this.panel2.Controls.Add(this.lsvRegion);
            this.panel2.Controls.Add(this.txtSitename);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 328);
            this.panel2.TabIndex = 0;
            // 
            // butAll
            // 
            this.butAll.Enabled = false;
            this.butAll.Location = new System.Drawing.Point(540, 272);
            this.butAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAll.Name = "butAll";
            this.butAll.Size = new System.Drawing.Size(112, 35);
            this.butAll.TabIndex = 11;
            this.butAll.Text = "All";
            this.butAll.UseVisualStyleBackColor = true;
            this.butAll.Click += new System.EventHandler(this.butAll_Click);
            // 
            // butNone
            // 
            this.butNone.Enabled = false;
            this.butNone.Location = new System.Drawing.Point(418, 272);
            this.butNone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butNone.Name = "butNone";
            this.butNone.Size = new System.Drawing.Size(112, 35);
            this.butNone.TabIndex = 10;
            this.butNone.Text = "None";
            this.butNone.UseVisualStyleBackColor = true;
            this.butNone.Click += new System.EventHandler(this.butNone_Click);
            // 
            // lsvRegion
            // 
            this.lsvRegion.CheckBoxes = true;
            this.lsvRegion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lsvRegion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvRegion.Location = new System.Drawing.Point(321, 65);
            this.lsvRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvRegion.Name = "lsvRegion";
            this.lsvRegion.Size = new System.Drawing.Size(356, 196);
            this.lsvRegion.TabIndex = 9;
            this.lsvRegion.UseCompatibleStateImageBehavior = false;
            this.lsvRegion.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Region Name";
            this.columnHeader6.Width = 225;
            // 
            // txtSitename
            // 
            this.txtSitename.Location = new System.Drawing.Point(188, 12);
            this.txtSitename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSitename.Name = "txtSitename";
            this.txtSitename.Size = new System.Drawing.Size(490, 26);
            this.txtSitename.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbRegion);
            this.groupBox2.Controls.Add(this.rdbAll);
            this.groupBox2.Location = new System.Drawing.Point(16, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(302, 209);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // rdbRegion
            // 
            this.rdbRegion.AutoSize = true;
            this.rdbRegion.Location = new System.Drawing.Point(9, 65);
            this.rdbRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbRegion.Name = "rdbRegion";
            this.rdbRegion.Size = new System.Drawing.Size(274, 24);
            this.rdbRegion.TabIndex = 1;
            this.rdbRegion.Text = "These Regions/Districts/Provinces";
            this.rdbRegion.UseVisualStyleBackColor = true;
            this.rdbRegion.CheckedChanged += new System.EventHandler(this.rdbRegion_CheckedChanged);
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Checked = true;
            this.rdbAll.Location = new System.Drawing.Point(9, 29);
            this.rdbAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(83, 24);
            this.rdbAll.TabIndex = 0;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "All Site";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search for Site Name:";
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 354);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(862, 4);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // lsvSite
            // 
            this.lsvSite.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lsvSite.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvSite.FullRowSelect = true;
            this.lsvSite.GridLines = true;
            this.lsvSite.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvSite.Location = new System.Drawing.Point(0, 358);
            this.lsvSite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvSite.MultiSelect = false;
            this.lsvSite.Name = "lsvSite";
            this.lsvSite.Size = new System.Drawing.Size(862, 368);
            this.lsvSite.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvSite.TabIndex = 3;
            this.lsvSite.UseCompatibleStateImageBehavior = false;
            this.lsvSite.View = System.Windows.Forms.View.Details;
            this.lsvSite.DoubleClick += new System.EventHandler(this.lsvSite_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Site Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Region/District/Province ";
            this.columnHeader5.Width = 187;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            // 
            // FrmSearchSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 726);
            this.Controls.Add(this.lsvSite);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearchSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FrmSearchSite_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butAll;
        private System.Windows.Forms.Button butNone;
        private System.Windows.Forms.ListView lsvRegion;
        private System.Windows.Forms.TextBox txtSitename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbRegion;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView lsvSite;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;

    }
}