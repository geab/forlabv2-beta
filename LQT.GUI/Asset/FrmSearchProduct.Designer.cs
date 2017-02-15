namespace LQT.GUI.Asset
{
    partial class FrmSearchProduct
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butFind = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butAll = new System.Windows.Forms.Button();
            this.butNone = new System.Windows.Forms.Button();
            this.lsvCategory = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbCategory = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvProduct = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 354);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(801, 4);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butFind);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 354);
            this.panel1.TabIndex = 3;
            // 
            // butFind
            // 
            this.butFind.Location = new System.Drawing.Point(660, 28);
            this.butFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(112, 35);
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
            this.panel2.Controls.Add(this.lsvCategory);
            this.panel2.Controls.Add(this.txtProductname);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 328);
            this.panel2.TabIndex = 0;
            // 
            // butAll
            // 
            this.butAll.Enabled = false;
            this.butAll.Location = new System.Drawing.Point(480, 272);
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
            this.butNone.Location = new System.Drawing.Point(358, 272);
            this.butNone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butNone.Name = "butNone";
            this.butNone.Size = new System.Drawing.Size(112, 35);
            this.butNone.TabIndex = 10;
            this.butNone.Text = "None";
            this.butNone.UseVisualStyleBackColor = true;
            this.butNone.Click += new System.EventHandler(this.butNone_Click);
            // 
            // lsvCategory
            // 
            this.lsvCategory.CheckBoxes = true;
            this.lsvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lsvCategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvCategory.Location = new System.Drawing.Point(238, 65);
            this.lsvCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvCategory.Name = "lsvCategory";
            this.lsvCategory.Size = new System.Drawing.Size(352, 196);
            this.lsvCategory.TabIndex = 9;
            this.lsvCategory.UseCompatibleStateImageBehavior = false;
            this.lsvCategory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Region Name";
            this.columnHeader6.Width = 225;
            // 
            // txtProductname
            // 
            this.txtProductname.Location = new System.Drawing.Point(216, 12);
            this.txtProductname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(374, 26);
            this.txtProductname.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbCategory);
            this.groupBox2.Controls.Add(this.rdbAll);
            this.groupBox2.Location = new System.Drawing.Point(16, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(213, 209);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // rdbCategory
            // 
            this.rdbCategory.AutoSize = true;
            this.rdbCategory.Location = new System.Drawing.Point(9, 65);
            this.rdbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbCategory.Name = "rdbCategory";
            this.rdbCategory.Size = new System.Drawing.Size(194, 24);
            this.rdbCategory.TabIndex = 1;
            this.rdbCategory.Text = "Only These Categories";
            this.rdbCategory.UseVisualStyleBackColor = true;
            this.rdbCategory.CheckedChanged += new System.EventHandler(this.rdbCategory_CheckedChanged);
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
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search for Product Name:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Site Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Region";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Closing Date";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Currently Open";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Opening Date";
            this.columnHeader3.Width = 100;
            // 
            // lsvProduct
            // 
            this.lsvProduct.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lsvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lsvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvProduct.FullRowSelect = true;
            this.lsvProduct.GridLines = true;
            this.lsvProduct.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvProduct.Location = new System.Drawing.Point(0, 358);
            this.lsvProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvProduct.MultiSelect = false;
            this.lsvProduct.Name = "lsvProduct";
            this.lsvProduct.Size = new System.Drawing.Size(801, 353);
            this.lsvProduct.TabIndex = 5;
            this.lsvProduct.UseCompatibleStateImageBehavior = false;
            this.lsvProduct.View = System.Windows.Forms.View.Details;
            this.lsvProduct.DoubleClick += new System.EventHandler(this.lsvProduct_DoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Product Name";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Category";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Serial No";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Basic Unit";
            this.columnHeader10.Width = 100;
            // 
            // FrmSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 711);
            this.Controls.Add(this.lsvProduct);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FrmSearchProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butAll;
        private System.Windows.Forms.Button butNone;
        private System.Windows.Forms.ListView lsvCategory;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbCategory;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lsvProduct;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}