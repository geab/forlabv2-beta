namespace LQT.GUI.Location
{
    partial class RegionForm
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
            this.lqtToolStrip1 = new LQT.GUI.UserCtr.LqtToolStrip();
            this.butNewsite = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butDeletesite = new System.Windows.Forms.Button();
            this.butEditsite = new System.Windows.Forms.Button();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvGroups = new System.Windows.Forms.ListView();
            this.txtShortname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSites = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lqtToolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.631728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.36827F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 46);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lqtToolStrip1
            // 
            this.lqtToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lqtToolStrip1.Location = new System.Drawing.Point(6, 8);
            this.lqtToolStrip1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lqtToolStrip1.Name = "lqtToolStrip1";
            this.lqtToolStrip1.Size = new System.Drawing.Size(932, 30);
            this.lqtToolStrip1.TabIndex = 1;
            // 
            // butNewsite
            // 
            this.butNewsite.Location = new System.Drawing.Point(542, 17);
            this.butNewsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butNewsite.Name = "butNewsite";
            this.butNewsite.Size = new System.Drawing.Size(112, 35);
            this.butNewsite.TabIndex = 27;
            this.butNewsite.Text = "New...";
            this.butNewsite.UseVisualStyleBackColor = true;
            this.butNewsite.Click += new System.EventHandler(this.butNewsite_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Currently Open";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Opening Date";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Closing Date";
            this.columnHeader3.Width = 103;
            // 
            // butDeletesite
            // 
            this.butDeletesite.Enabled = false;
            this.butDeletesite.Location = new System.Drawing.Point(786, 17);
            this.butDeletesite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDeletesite.Name = "butDeletesite";
            this.butDeletesite.Size = new System.Drawing.Size(112, 35);
            this.butDeletesite.TabIndex = 29;
            this.butDeletesite.Text = "Delete";
            this.butDeletesite.UseVisualStyleBackColor = true;
            this.butDeletesite.Click += new System.EventHandler(this.butDeletesite_Click);
            // 
            // butEditsite
            // 
            this.butEditsite.Enabled = false;
            this.butEditsite.Location = new System.Drawing.Point(663, 17);
            this.butEditsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butEditsite.Name = "butEditsite";
            this.butEditsite.Size = new System.Drawing.Size(112, 35);
            this.butEditsite.TabIndex = 28;
            this.butEditsite.Text = "Edit...";
            this.butEditsite.UseVisualStyleBackColor = true;
            this.butEditsite.Click += new System.EventHandler(this.butEditsite_Click);
            // 
            // colName
            // 
            this.colName.Text = "Site Name";
            this.colName.Width = 272;
            // 
            // lsvGroups
            // 
            this.lsvGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvGroups.FullRowSelect = true;
            this.lsvGroups.GridLines = true;
            this.lsvGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvGroups.Location = new System.Drawing.Point(25, 183);
            this.lsvGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvGroups.MultiSelect = false;
            this.lsvGroups.Name = "lsvGroups";
            this.lsvGroups.Size = new System.Drawing.Size(905, 302);
            this.lsvGroups.TabIndex = 26;
            this.lsvGroups.UseCompatibleStateImageBehavior = false;
            this.lsvGroups.View = System.Windows.Forms.View.Details;
            this.lsvGroups.SelectedIndexChanged += new System.EventHandler(this.lsvGroups_SelectedIndexChanged);
            // 
            // txtShortname
            // 
            this.txtShortname.Location = new System.Drawing.Point(655, 31);
            this.txtShortname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShortname.MaxLength = 8;
            this.txtShortname.Name = "txtShortname";
            this.txtShortname.Size = new System.Drawing.Size(148, 26);
            this.txtShortname.TabIndex = 24;
            this.txtShortname.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 29);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MaxLength = 64;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(373, 26);
            this.txtName.TabIndex = 23;
            // 
            // lblSites
            // 
            this.lblSites.AutoSize = true;
            this.lblSites.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSites.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSites.Location = new System.Drawing.Point(21, 149);
            this.lblSites.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSites.Name = "lblSites";
            this.lblSites.Size = new System.Drawing.Size(52, 20);
            this.lblSites.TabIndex = 22;
            this.lblSites.Text = "Sites";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Short Name:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Region:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtShortname);
            this.groupBox1.Location = new System.Drawing.Point(25, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 83);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butNewsite);
            this.groupBox2.Controls.Add(this.butEditsite);
            this.groupBox2.Controls.Add(this.butDeletesite);
            this.groupBox2.Location = new System.Drawing.Point(25, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 60);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // RegionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsvGroups);
            this.Controls.Add(this.lblSites);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Region/District/Province";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserCtr.LqtToolStrip lqtToolStrip1;
        private System.Windows.Forms.Button butNewsite;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button butDeletesite;
        private System.Windows.Forms.Button butEditsite;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ListView lsvGroups;
        private System.Windows.Forms.TextBox txtShortname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSites;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
      //  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}