namespace LQT.GUI.Asset
{
    partial class ProductTypeForm
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkuseindemograph = new System.Windows.Forms.CheckBox();
            this.butDeletepro = new System.Windows.Forms.Button();
            this.butEditpro = new System.Windows.Forms.Button();
            this.butNewpro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lsvGroups = new System.Windows.Forms.ListView();
            this.cobCategory = new System.Windows.Forms.ComboBox();
            this.lblcategory = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.47541F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.52459F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 69);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lqtToolStrip1
            // 
            this.lqtToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lqtToolStrip1.Location = new System.Drawing.Point(6, 8);
            this.lqtToolStrip1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lqtToolStrip1.Name = "lqtToolStrip1";
            this.lqtToolStrip1.Size = new System.Drawing.Size(810, 53);
            this.lqtToolStrip1.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(127, 198);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(554, 78);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Visible = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Basic Unit";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Specification";
            this.columnHeader1.Width = 134;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Description:";
            this.label4.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(186, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 26);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Type Name:";
            // 
            // colName
            // 
            this.colName.Text = "Product Name";
            this.colName.Width = 328;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Serial No";
            this.columnHeader3.Width = 106;
            // 
            // chkuseindemograph
            // 
            this.chkuseindemograph.AutoSize = true;
            this.chkuseindemograph.Location = new System.Drawing.Point(437, 26);
            this.chkuseindemograph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkuseindemograph.Name = "chkuseindemograph";
            this.chkuseindemograph.Size = new System.Drawing.Size(244, 24);
            this.chkuseindemograph.TabIndex = 3;
            this.chkuseindemograph.Text = "Use In Morbidity Methodology";
            this.chkuseindemograph.UseVisualStyleBackColor = true;
            this.chkuseindemograph.CheckedChanged += new System.EventHandler(this.chkuseindemograph_CheckedChanged);
            // 
            // butDeletepro
            // 
            this.butDeletepro.Enabled = false;
            this.butDeletepro.Location = new System.Drawing.Point(673, 15);
            this.butDeletepro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDeletepro.Name = "butDeletepro";
            this.butDeletepro.Size = new System.Drawing.Size(112, 35);
            this.butDeletepro.TabIndex = 7;
            this.butDeletepro.Text = "Delete";
            this.butDeletepro.UseVisualStyleBackColor = true;
            this.butDeletepro.Click += new System.EventHandler(this.butDeletepro_Click);
            // 
            // butEditpro
            // 
            this.butEditpro.Enabled = false;
            this.butEditpro.Location = new System.Drawing.Point(553, 15);
            this.butEditpro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butEditpro.Name = "butEditpro";
            this.butEditpro.Size = new System.Drawing.Size(112, 35);
            this.butEditpro.TabIndex = 6;
            this.butEditpro.Text = "Edit...";
            this.butEditpro.UseVisualStyleBackColor = true;
            this.butEditpro.Click += new System.EventHandler(this.butEditpro_Click);
            // 
            // butNewpro
            // 
            this.butNewpro.Location = new System.Drawing.Point(433, 15);
            this.butNewpro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butNewpro.Name = "butNewpro";
            this.butNewpro.Size = new System.Drawing.Size(112, 35);
            this.butNewpro.TabIndex = 5;
            this.butNewpro.Text = "New...";
            this.butNewpro.UseVisualStyleBackColor = true;
            this.butNewpro.Click += new System.EventHandler(this.butNewpro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(13, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Products";
            // 
            // lsvGroups
            // 
            this.lsvGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lsvGroups.FullRowSelect = true;
            this.lsvGroups.GridLines = true;
            this.lsvGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvGroups.Location = new System.Drawing.Point(13, 222);
            this.lsvGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvGroups.MultiSelect = false;
            this.lsvGroups.Name = "lsvGroups";
            this.lsvGroups.Size = new System.Drawing.Size(796, 336);
            this.lsvGroups.TabIndex = 30;
            this.lsvGroups.UseCompatibleStateImageBehavior = false;
            this.lsvGroups.View = System.Windows.Forms.View.Details;
            this.lsvGroups.SelectedIndexChanged += new System.EventHandler(this.lsvGroups_SelectedIndexChanged);
            // 
            // cobCategory
            // 
            this.cobCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCategory.FormattingEnabled = true;
            this.cobCategory.Location = new System.Drawing.Point(186, 63);
            this.cobCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobCategory.Name = "cobCategory";
            this.cobCategory.Size = new System.Drawing.Size(243, 28);
            this.cobCategory.TabIndex = 4;
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(19, 66);
            this.lblcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(159, 20);
            this.lblcategory.TabIndex = 39;
            this.lblcategory.Text = "Associated ART Test";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cobCategory);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkuseindemograph);
            this.groupBox1.Controls.Add(this.lblcategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(13, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 113);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butNewpro);
            this.groupBox2.Controls.Add(this.butEditpro);
            this.groupBox2.Controls.Add(this.butDeletepro);
            this.groupBox2.Location = new System.Drawing.Point(17, 553);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 58);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // ProductTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvGroups);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(844, 678);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(844, 678);
            this.Name = "ProductTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Type";
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
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.CheckBox chkuseindemograph;
        private System.Windows.Forms.Button butDeletepro;
        private System.Windows.Forms.Button butEditpro;
        private System.Windows.Forms.Button butNewpro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lsvGroups;
        private System.Windows.Forms.ComboBox cobCategory;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        //  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}