namespace LQT.GUI.ReportParameterUserCtr
{
    partial class InstrumentListParam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewreport = new System.Windows.Forms.Button();
            this.comTestarea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkcontroltest = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewreport
            // 
            this.btnViewreport.Location = new System.Drawing.Point(118, 92);
            this.btnViewreport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewreport.Name = "btnViewreport";
            this.btnViewreport.Size = new System.Drawing.Size(112, 35);
            this.btnViewreport.TabIndex = 13;
            this.btnViewreport.Text = "View Report";
            this.btnViewreport.UseVisualStyleBackColor = true;
            this.btnViewreport.Click += new System.EventHandler(this.btnViewreport_Click);
            // 
            // comTestarea
            // 
            this.comTestarea.DisplayMember = "AreaName";
            this.comTestarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTestarea.FormattingEnabled = true;
            this.comTestarea.Location = new System.Drawing.Point(118, 13);
            this.comTestarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comTestarea.Name = "comTestarea";
            this.comTestarea.Size = new System.Drawing.Size(272, 28);
            this.comTestarea.TabIndex = 15;
            this.comTestarea.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Testing Area:";
            // 
            // chkcontroltest
            // 
            this.chkcontroltest.AutoSize = true;
            this.chkcontroltest.Location = new System.Drawing.Point(118, 51);
            this.chkcontroltest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkcontroltest.Name = "chkcontroltest";
            this.chkcontroltest.Size = new System.Drawing.Size(238, 24);
            this.chkcontroltest.TabIndex = 16;
            this.chkcontroltest.Text = "Include Control Testing Days";
            this.chkcontroltest.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkcontroltest);
            this.groupBox1.Controls.Add(this.comTestarea);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnViewreport);
            this.groupBox1.Location = new System.Drawing.Point(10, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 154);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // InstrumentListParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InstrumentListParam";
            this.Size = new System.Drawing.Size(446, 185);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewreport;
        private System.Windows.Forms.ComboBox comTestarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkcontroltest;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
