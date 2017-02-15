namespace LQT.GUI.Location
{
    partial class SiteCategoryForm
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
            this.lsvCategory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.butAddnew = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butRemove = new System.Windows.Forms.Button();
            this.butCancle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvCategory
            // 
            this.lsvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lsvCategory.FullRowSelect = true;
            this.lsvCategory.GridLines = true;
            this.lsvCategory.Location = new System.Drawing.Point(0, 67);
            this.lsvCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvCategory.Name = "lsvCategory";
            this.lsvCategory.Size = new System.Drawing.Size(962, 346);
            this.lsvCategory.TabIndex = 0;
            this.lsvCategory.UseCompatibleStateImageBehavior = false;
            this.lsvCategory.View = System.Windows.Forms.View.Details;
            this.lsvCategory.SelectedIndexChanged += new System.EventHandler(this.lsvCategory_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 563;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 57);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site Category";
            // 
            // butAddnew
            // 
            this.butAddnew.Location = new System.Drawing.Point(443, 27);
            this.butAddnew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAddnew.Name = "butAddnew";
            this.butAddnew.Size = new System.Drawing.Size(112, 35);
            this.butAddnew.TabIndex = 2;
            this.butAddnew.Text = "Add...";
            this.butAddnew.UseVisualStyleBackColor = true;
            this.butAddnew.Click += new System.EventHandler(this.butAddnew_Click);
            // 
            // butEdit
            // 
            this.butEdit.Enabled = false;
            this.butEdit.Location = new System.Drawing.Point(563, 27);
            this.butEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(112, 35);
            this.butEdit.TabIndex = 3;
            this.butEdit.Text = "Edit...";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butRemove
            // 
            this.butRemove.Enabled = false;
            this.butRemove.Location = new System.Drawing.Point(683, 27);
            this.butRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(112, 35);
            this.butRemove.TabIndex = 4;
            this.butRemove.Text = "Remove";
            this.butRemove.UseVisualStyleBackColor = true;
            this.butRemove.Click += new System.EventHandler(this.butRemove_Click);
            // 
            // butCancle
            // 
            this.butCancle.Location = new System.Drawing.Point(803, 27);
            this.butCancle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCancle.Name = "butCancle";
            this.butCancle.Size = new System.Drawing.Size(112, 35);
            this.butCancle.TabIndex = 5;
            this.butCancle.Text = "Cancel";
            this.butCancle.UseVisualStyleBackColor = true;
            this.butCancle.Click += new System.EventHandler(this.butCancle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butAddnew);
            this.groupBox1.Controls.Add(this.butCancle);
            this.groupBox1.Controls.Add(this.butEdit);
            this.groupBox1.Controls.Add(this.butRemove);
            this.groupBox1.Location = new System.Drawing.Point(0, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // SiteCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SiteCategoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Site Category";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvCategory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butAddnew;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butRemove;
        private System.Windows.Forms.Button butCancle;
        private System.Windows.Forms.GroupBox groupBox1;



    }
}