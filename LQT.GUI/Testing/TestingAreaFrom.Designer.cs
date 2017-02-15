namespace LQT.GUI.Testing
{
    partial class TestingAreaFrom
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
            this.cobCategory = new System.Windows.Forms.ComboBox();
            this.lblcategory = new System.Windows.Forms.Label();
            this.chkuseindemograph = new System.Windows.Forms.CheckBox();
            this.txtAreaname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07266F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.92734F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lqtToolStrip1
            // 
            this.lqtToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lqtToolStrip1.Location = new System.Drawing.Point(6, 8);
            this.lqtToolStrip1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lqtToolStrip1.Name = "lqtToolStrip1";
            this.lqtToolStrip1.Size = new System.Drawing.Size(614, 30);
            this.lqtToolStrip1.TabIndex = 7;
            // 
            // cobCategory
            // 
            this.cobCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCategory.Enabled = false;
            this.cobCategory.FormattingEnabled = true;
            this.cobCategory.Location = new System.Drawing.Point(183, 73);
            this.cobCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobCategory.Name = "cobCategory";
            this.cobCategory.Size = new System.Drawing.Size(237, 28);
            this.cobCategory.TabIndex = 2;
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(8, 76);
            this.lblcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(163, 20);
            this.lblcategory.TabIndex = 29;
            this.lblcategory.Text = "Associated ART Test:";
            // 
            // chkuseindemograph
            // 
            this.chkuseindemograph.AutoSize = true;
            this.chkuseindemograph.Location = new System.Drawing.Point(440, 9);
            this.chkuseindemograph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkuseindemograph.Name = "chkuseindemograph";
            this.chkuseindemograph.Size = new System.Drawing.Size(174, 64);
            this.chkuseindemograph.TabIndex = 1;
            this.chkuseindemograph.Text = "\r\nUse In Demograph \r\nMethodology";
            this.chkuseindemograph.UseVisualStyleBackColor = true;
            this.chkuseindemograph.CheckedChanged += new System.EventHandler(this.chkuseindemograph_CheckedChanged);
            // 
            // txtAreaname
            // 
            this.txtAreaname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAreaname.Location = new System.Drawing.Point(183, 26);
            this.txtAreaname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAreaname.Name = "txtAreaname";
            this.txtAreaname.Size = new System.Drawing.Size(237, 26);
            this.txtAreaname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Testing Area Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkuseindemograph);
            this.groupBox1.Controls.Add(this.cobCategory);
            this.groupBox1.Controls.Add(this.lblcategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAreaname);
            this.groupBox1.Location = new System.Drawing.Point(6, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 149);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // TestingAreaFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 215);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestingAreaFrom";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testing Area";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserCtr.LqtToolStrip lqtToolStrip1;
        private System.Windows.Forms.ComboBox cobCategory;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.CheckBox chkuseindemograph;
        private System.Windows.Forms.TextBox txtAreaname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        //   private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    }
}