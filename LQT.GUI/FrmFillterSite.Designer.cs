namespace LQT.GUI
{
    partial class FrmFillterSite
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comRegion = new System.Windows.Forms.ComboBox();
            this.comSite = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Region/District/Province :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Site Name:";
            // 
            // comRegion
            // 
            this.comRegion.DisplayMember = "RegionName";
            this.comRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comRegion.FormattingEnabled = true;
            this.comRegion.Location = new System.Drawing.Point(222, 18);
            this.comRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comRegion.Name = "comRegion";
            this.comRegion.Size = new System.Drawing.Size(266, 28);
            this.comRegion.TabIndex = 2;
            this.comRegion.ValueMember = "Id";
            this.comRegion.SelectedIndexChanged += new System.EventHandler(this.comRegion_SelectedIndexChanged);
            // 
            // comSite
            // 
            this.comSite.DisplayMember = "SiteName";
            this.comSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comSite.FormattingEnabled = true;
            this.comSite.Location = new System.Drawing.Point(222, 60);
            this.comSite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comSite.Name = "comSite";
            this.comSite.Size = new System.Drawing.Size(266, 28);
            this.comSite.TabIndex = 3;
            this.comSite.ValueMember = "Id";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(378, 100);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 35);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmFillterSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 135);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.comSite);
            this.Controls.Add(this.comRegion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFillterSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Site";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comRegion;
        private System.Windows.Forms.ComboBox comSite;
        private System.Windows.Forms.Button btnOk;
    }
}