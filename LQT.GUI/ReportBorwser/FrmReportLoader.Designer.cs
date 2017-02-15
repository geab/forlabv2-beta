namespace LQT.GUI.Reports
{
    partial class FrmReportLoader
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
            this.comForecastinfo = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLaunchReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlreport = new System.Windows.Forms.Panel();
            this.cbomforecast = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboreport = new System.Windows.Forms.ComboBox();
            this.rdofull = new System.Windows.Forms.RadioButton();
            this.rdosite = new System.Windows.Forms.RadioButton();
            this.comMethodologey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlreport.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forecast No:";
            // 
            // comForecastinfo
            // 
            this.comForecastinfo.DisplayMember = "ForecastNo";
            this.comForecastinfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comForecastinfo.FormattingEnabled = true;
            this.comForecastinfo.Location = new System.Drawing.Point(120, 62);
            this.comForecastinfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comForecastinfo.Name = "comForecastinfo";
            this.comForecastinfo.Size = new System.Drawing.Size(242, 28);
            this.comForecastinfo.TabIndex = 4;
            this.comForecastinfo.ValueMember = "Id";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(410, 185);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(154, 35);
            this.buttonCancel.TabIndex = 46;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonLaunchReport
            // 
            this.buttonLaunchReport.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLaunchReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLaunchReport.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonLaunchReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLaunchReport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLaunchReport.Location = new System.Drawing.Point(245, 185);
            this.buttonLaunchReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLaunchReport.Name = "buttonLaunchReport";
            this.buttonLaunchReport.Size = new System.Drawing.Size(154, 35);
            this.buttonLaunchReport.TabIndex = 47;
            this.buttonLaunchReport.Text = "Display report";
            this.buttonLaunchReport.UseVisualStyleBackColor = false;
            this.buttonLaunchReport.Click += new System.EventHandler(this.buttonLaunchReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlreport);
            this.groupBox1.Controls.Add(this.rdofull);
            this.groupBox1.Controls.Add(this.rdosite);
            this.groupBox1.Controls.Add(this.comMethodologey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comForecastinfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(584, 174);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // pnlreport
            // 
            this.pnlreport.Controls.Add(this.cbomforecast);
            this.pnlreport.Controls.Add(this.label4);
            this.pnlreport.Controls.Add(this.label3);
            this.pnlreport.Controls.Add(this.cboreport);
            this.pnlreport.Location = new System.Drawing.Point(9, 60);
            this.pnlreport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlreport.Name = "pnlreport";
            this.pnlreport.Size = new System.Drawing.Size(567, 91);
            this.pnlreport.TabIndex = 49;
            this.pnlreport.Visible = false;
            // 
            // cbomforecast
            // 
            this.cbomforecast.DisplayMember = "Title";
            this.cbomforecast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomforecast.FormattingEnabled = true;
            this.cbomforecast.Location = new System.Drawing.Point(127, 6);
            this.cbomforecast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbomforecast.Name = "cbomforecast";
            this.cbomforecast.Size = new System.Drawing.Size(420, 28);
            this.cbomforecast.TabIndex = 4;
            this.cbomforecast.ValueMember = "ForecastId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Forecast:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Report:";
            // 
            // cboreport
            // 
            this.cboreport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboreport.FormattingEnabled = true;
            this.cboreport.Items.AddRange(new object[] {
            "Supply Forecast",
            "Supply Procurement",
            "No. of Patient Forecast",
            "No. of CD4 & HIV Rapid Test Forecast",
            "No. of Chemisty and Other Tests Forecast",
            "No. of Hematology and ViralLoad Test Forecast"});
            this.cboreport.Location = new System.Drawing.Point(127, 51);
            this.cboreport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboreport.Name = "cboreport";
            this.cboreport.Size = new System.Drawing.Size(420, 28);
            this.cboreport.TabIndex = 0;
            // 
            // rdofull
            // 
            this.rdofull.AutoSize = true;
            this.rdofull.Location = new System.Drawing.Point(14, 118);
            this.rdofull.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdofull.Name = "rdofull";
            this.rdofull.Size = new System.Drawing.Size(130, 24);
            this.rdofull.TabIndex = 9;
            this.rdofull.Text = "Full Summary";
            this.rdofull.UseVisualStyleBackColor = true;
            // 
            // rdosite
            // 
            this.rdosite.AutoSize = true;
            this.rdosite.Checked = true;
            this.rdosite.Location = new System.Drawing.Point(153, 118);
            this.rdosite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdosite.Name = "rdosite";
            this.rdosite.Size = new System.Drawing.Size(219, 24);
            this.rdosite.TabIndex = 8;
            this.rdosite.TabStop = true;
            this.rdosite.Text = "Grouped By Site/Category";
            this.rdosite.UseVisualStyleBackColor = true;
            // 
            // comMethodologey
            // 
            this.comMethodologey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comMethodologey.FormattingEnabled = true;
            this.comMethodologey.Location = new System.Drawing.Point(136, 22);
            this.comMethodologey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comMethodologey.Name = "comMethodologey";
            this.comMethodologey.Size = new System.Drawing.Size(236, 28);
            this.comMethodologey.TabIndex = 7;
            this.comMethodologey.SelectedIndexChanged += new System.EventHandler(this.comMethodologey_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Methodology";
            // 
            // FrmReportLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 226);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLaunchReport);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportLoader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Parameter";
            this.Load += new System.EventHandler(this.FrmReportLoader_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlreport.ResumeLayout(false);
            this.pnlreport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comForecastinfo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLaunchReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comMethodologey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdofull;
        private System.Windows.Forms.RadioButton rdosite;
        private System.Windows.Forms.Panel pnlreport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboreport;
        private System.Windows.Forms.ComboBox cbomforecast;
        private System.Windows.Forms.Label label4;
    }
}