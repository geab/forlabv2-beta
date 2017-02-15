namespace LQT.GUI.ReportParameterUserCtr
{
    partial class ComparisionReportParam
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cobconsumption = new System.Windows.Forms.ComboBox();
            this.cobdemography = new System.Windows.Forms.ComboBox();
            this.cobservice = new System.Windows.Forms.ComboBox();
            this.btnviewreport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Demographic Methodology";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service Statistic Methodology";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consumption Methodology";
            // 
            // cobconsumption
            // 
            this.cobconsumption.DisplayMember = "ForecastNo";
            this.cobconsumption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobconsumption.FormattingEnabled = true;
            this.cobconsumption.Location = new System.Drawing.Point(250, 5);
            this.cobconsumption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobconsumption.Name = "cobconsumption";
            this.cobconsumption.Size = new System.Drawing.Size(422, 28);
            this.cobconsumption.TabIndex = 3;
            this.cobconsumption.ValueMember = "Id";
            // 
            // cobdemography
            // 
            this.cobdemography.DisplayMember = "Title";
            this.cobdemography.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobdemography.FormattingEnabled = true;
            this.cobdemography.Location = new System.Drawing.Point(250, 90);
            this.cobdemography.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobdemography.Name = "cobdemography";
            this.cobdemography.Size = new System.Drawing.Size(422, 28);
            this.cobdemography.TabIndex = 4;
            this.cobdemography.ValueMember = "Id";
            // 
            // cobservice
            // 
            this.cobservice.DisplayMember = "ForecastNo";
            this.cobservice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobservice.FormattingEnabled = true;
            this.cobservice.Location = new System.Drawing.Point(250, 47);
            this.cobservice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobservice.Name = "cobservice";
            this.cobservice.Size = new System.Drawing.Size(422, 28);
            this.cobservice.TabIndex = 5;
            this.cobservice.ValueMember = "Id";
            // 
            // btnviewreport
            // 
            this.btnviewreport.Location = new System.Drawing.Point(14, 157);
            this.btnviewreport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnviewreport.Name = "btnviewreport";
            this.btnviewreport.Size = new System.Drawing.Size(112, 35);
            this.btnviewreport.TabIndex = 6;
            this.btnviewreport.Text = "View Report";
            this.btnviewreport.UseVisualStyleBackColor = true;
            this.btnviewreport.Click += new System.EventHandler(this.btnviewreport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnviewreport);
            this.groupBox1.Controls.Add(this.cobservice);
            this.groupBox1.Controls.Add(this.cobdemography);
            this.groupBox1.Controls.Add(this.cobconsumption);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 206);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // ComparisionReportParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ComparisionReportParam";
            this.Size = new System.Drawing.Size(722, 240);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobconsumption;
        private System.Windows.Forms.ComboBox cobdemography;
        private System.Windows.Forms.ComboBox cobservice;
        private System.Windows.Forms.Button btnviewreport;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
