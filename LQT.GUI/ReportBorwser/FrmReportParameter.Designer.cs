namespace LQT.GUI.ReportBorwser
{
    partial class FrmReportParameter
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
            this.lblforecastno = new System.Windows.Forms.Label();
            this.lblreporttype = new System.Windows.Forms.Label();
            this.cobforecast = new System.Windows.Forms.ComboBox();
            this.cobreporttype = new System.Windows.Forms.ComboBox();
            this.btnviewreport = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblforecastno
            // 
            this.lblforecastno.AutoSize = true;
            this.lblforecastno.Location = new System.Drawing.Point(3, 16);
            this.lblforecastno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblforecastno.Name = "lblforecastno";
            this.lblforecastno.Size = new System.Drawing.Size(125, 20);
            this.lblforecastno.TabIndex = 0;
            this.lblforecastno.Text = "Select Forecast:";
            // 
            // lblreporttype
            // 
            this.lblreporttype.AutoSize = true;
            this.lblreporttype.Location = new System.Drawing.Point(3, 57);
            this.lblreporttype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblreporttype.Name = "lblreporttype";
            this.lblreporttype.Size = new System.Drawing.Size(111, 20);
            this.lblreporttype.TabIndex = 1;
            this.lblreporttype.Text = "Select Report:";
            // 
            // cobforecast
            // 
            this.cobforecast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobforecast.FormattingEnabled = true;
            this.cobforecast.Location = new System.Drawing.Point(126, 13);
            this.cobforecast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobforecast.Name = "cobforecast";
            this.cobforecast.Size = new System.Drawing.Size(257, 28);
            this.cobforecast.TabIndex = 2;
            // 
            // cobreporttype
            // 
            this.cobreporttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobreporttype.FormattingEnabled = true;
            this.cobreporttype.Items.AddRange(new object[] {
            "Full Aggregate Summary",
            "Grouped By Site/Category"});
            this.cobreporttype.Location = new System.Drawing.Point(126, 54);
            this.cobreporttype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobreporttype.Name = "cobreporttype";
            this.cobreporttype.Size = new System.Drawing.Size(437, 28);
            this.cobreporttype.TabIndex = 3;
            // 
            // btnviewreport
            // 
            this.btnviewreport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnviewreport.Location = new System.Drawing.Point(126, 104);
            this.btnviewreport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnviewreport.Name = "btnviewreport";
            this.btnviewreport.Size = new System.Drawing.Size(112, 35);
            this.btnviewreport.TabIndex = 4;
            this.btnviewreport.Text = "View Report";
            this.btnviewreport.UseVisualStyleBackColor = false;
            this.btnviewreport.Click += new System.EventHandler(this.btnviewreport_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnclose.Location = new System.Drawing.Point(247, 104);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(112, 35);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btnviewreport);
            this.groupBox1.Controls.Add(this.cobreporttype);
            this.groupBox1.Controls.Add(this.cobforecast);
            this.groupBox1.Controls.Add(this.lblreporttype);
            this.groupBox1.Controls.Add(this.lblforecastno);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 141);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // FrmReportParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 168);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReportParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Parameter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblforecastno;
        private System.Windows.Forms.Label lblreporttype;
        private System.Windows.Forms.ComboBox cobforecast;
        private System.Windows.Forms.ComboBox cobreporttype;
        private System.Windows.Forms.Button btnviewreport;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}