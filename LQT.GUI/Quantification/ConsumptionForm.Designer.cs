namespace LQT.GUI.Quantification
{
    partial class ConsumptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsumptionForm));
            this.panel4 = new System.Windows.Forms.Panel();
            this.butSave = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comslowmovingperiod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboscope = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtScope = new System.Windows.Forms.TextBox();
            this.dtplastmodifieddate = new System.Windows.Forms.DateTimePicker();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comPeriod = new System.Windows.Forms.ComboBox();
            this.dtpForecastDate = new System.Windows.Forms.DateTimePicker();
            this.txtForecastNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDatausage = new System.Windows.Forms.GroupBox();
            this.rdbUsage3 = new System.Windows.Forms.RadioButton();
            this.rdbUsage2 = new System.Windows.Forms.RadioButton();
            this.rdbUsage1 = new System.Windows.Forms.RadioButton();
            this.txtDatausage = new System.Windows.Forms.TextBox();
            this.tabConsumption = new System.Windows.Forms.TabPage();
            this.dtpstart = new LQT.GUI.DurationPicker();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbDatausage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.butSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1285, 45);
            this.panel4.TabIndex = 1;
            // 
            // butSave
            // 
            this.butSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.butSave.Location = new System.Drawing.Point(1085, 0);
            this.butSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(198, 43);
            this.butSave.TabIndex = 0;
            this.butSave.Text = "Save Forecast Info";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(4, 50);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1285, 5);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabConsumption);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(4, 55);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1285, 997);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.splitContainer1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 29);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGeneral.Size = new System.Drawing.Size(1277, 964);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Tag = "GENERAL";
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(4, 5);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbDatausage);
            this.splitContainer1.Size = new System.Drawing.Size(1269, 954);
            this.splitContainer1.SplitterDistance = 837;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(696, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(573, 837);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consumption Forecasting Methodology";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(30, 37);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(516, 561);
            this.textBox8.TabIndex = 3;
            this.textBox8.Text = resources.GetString("textBox8.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comslowmovingperiod);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboscope);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtScope);
            this.groupBox1.Controls.Add(this.dtplastmodifieddate);
            this.groupBox1.Controls.Add(this.dtpstart);
            this.groupBox1.Controls.Add(this.txtExtension);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comPeriod);
            this.groupBox1.Controls.Add(this.dtpForecastDate);
            this.groupBox1.Controls.Add(this.txtForecastNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(588, 837);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forecast Infromation";
            // 
            // comslowmovingperiod
            // 
            this.comslowmovingperiod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comslowmovingperiod.FormattingEnabled = true;
            this.comslowmovingperiod.Location = new System.Drawing.Point(214, 445);
            this.comslowmovingperiod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comslowmovingperiod.Name = "comslowmovingperiod";
            this.comslowmovingperiod.Size = new System.Drawing.Size(338, 28);
            this.comslowmovingperiod.TabIndex = 19;
            this.comslowmovingperiod.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 420);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(376, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Reporting Period For Slow Moving Products";
            this.label8.Visible = false;
            // 
            // cboscope
            // 
            this.cboscope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboscope.FormattingEnabled = true;
            this.cboscope.Items.AddRange(new object[] {
            "CUSTOM",
            "NATIONAL",
            "GLOBAL"});
            this.cboscope.Location = new System.Drawing.Point(214, 94);
            this.cboscope.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboscope.Name = "cboscope";
            this.cboscope.Size = new System.Drawing.Size(180, 28);
            this.cboscope.TabIndex = 16;
            this.cboscope.SelectedIndexChanged += new System.EventHandler(this.cboscope_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 377);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Last Modified Date:";
            // 
            // txtScope
            // 
            this.txtScope.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScope.Location = new System.Drawing.Point(405, 97);
            this.txtScope.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScope.Name = "txtScope";
            this.txtScope.Size = new System.Drawing.Size(148, 26);
            this.txtScope.TabIndex = 6;
            this.txtScope.Visible = false;
            // 
            // dtplastmodifieddate
            // 
            this.dtplastmodifieddate.Enabled = false;
            this.dtplastmodifieddate.Location = new System.Drawing.Point(214, 371);
            this.dtplastmodifieddate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtplastmodifieddate.Name = "dtplastmodifieddate";
            this.dtplastmodifieddate.Size = new System.Drawing.Size(343, 26);
            this.dtplastmodifieddate.TabIndex = 14;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(214, 262);
            this.txtExtension.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(148, 26);
            this.txtExtension.TabIndex = 12;
            this.txtExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtension_KeyPress_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Reporting Period:";
            // 
            // comPeriod
            // 
            this.comPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPeriod.FormattingEnabled = true;
            this.comPeriod.Location = new System.Drawing.Point(214, 148);
            this.comPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comPeriod.Name = "comPeriod";
            this.comPeriod.Size = new System.Drawing.Size(343, 28);
            this.comPeriod.TabIndex = 10;
            this.comPeriod.SelectedIndexChanged += new System.EventHandler(this.comPeriod_SelectedIndexChanged);
            // 
            // dtpForecastDate
            // 
            this.dtpForecastDate.Enabled = false;
            this.dtpForecastDate.Location = new System.Drawing.Point(214, 317);
            this.dtpForecastDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpForecastDate.Name = "dtpForecastDate";
            this.dtpForecastDate.Size = new System.Drawing.Size(343, 26);
            this.dtpForecastDate.TabIndex = 7;
            // 
            // txtForecastNo
            // 
            this.txtForecastNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForecastNo.Location = new System.Drawing.Point(214, 42);
            this.txtForecastNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtForecastNo.Name = "txtForecastNo";
            this.txtForecastNo.Size = new System.Drawing.Size(343, 26);
            this.txtForecastNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Forecasting Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Forecast Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scope of the Forecast:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forecast ID:";
            // 
            // grbDatausage
            // 
            this.grbDatausage.Controls.Add(this.rdbUsage3);
            this.grbDatausage.Controls.Add(this.rdbUsage2);
            this.grbDatausage.Controls.Add(this.rdbUsage1);
            this.grbDatausage.Controls.Add(this.txtDatausage);
            this.grbDatausage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbDatausage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatausage.Location = new System.Drawing.Point(0, -43);
            this.grbDatausage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDatausage.Name = "grbDatausage";
            this.grbDatausage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDatausage.Size = new System.Drawing.Size(1269, 154);
            this.grbDatausage.TabIndex = 6;
            this.grbDatausage.TabStop = false;
            this.grbDatausage.Text = "Consumption Data Usage";
            // 
            // rdbUsage3
            // 
            this.rdbUsage3.AutoSize = true;
            this.rdbUsage3.Location = new System.Drawing.Point(18, 108);
            this.rdbUsage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbUsage3.Name = "rdbUsage3";
            this.rdbUsage3.Size = new System.Drawing.Size(409, 24);
            this.rdbUsage3.TabIndex = 8;
            this.rdbUsage3.Text = "Consumption data available for site category";
            this.rdbUsage3.UseVisualStyleBackColor = true;
            this.rdbUsage3.CheckedChanged += new System.EventHandler(this.rdbUsage3_CheckedChanged);
            // 
            // rdbUsage2
            // 
            this.rdbUsage2.AutoSize = true;
            this.rdbUsage2.Location = new System.Drawing.Point(18, 72);
            this.rdbUsage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbUsage2.Name = "rdbUsage2";
            this.rdbUsage2.Size = new System.Drawing.Size(417, 24);
            this.rdbUsage2.TabIndex = 7;
            this.rdbUsage2.Text = "Consumption data available for reported sites";
            this.rdbUsage2.UseVisualStyleBackColor = true;
            this.rdbUsage2.CheckedChanged += new System.EventHandler(this.rdbUsage2_CheckedChanged);
            // 
            // rdbUsage1
            // 
            this.rdbUsage1.AutoSize = true;
            this.rdbUsage1.Checked = true;
            this.rdbUsage1.Location = new System.Drawing.Point(18, 37);
            this.rdbUsage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbUsage1.Name = "rdbUsage1";
            this.rdbUsage1.Size = new System.Drawing.Size(367, 24);
            this.rdbUsage1.TabIndex = 6;
            this.rdbUsage1.TabStop = true;
            this.rdbUsage1.Text = "Consumption data available for all sites";
            this.rdbUsage1.UseVisualStyleBackColor = true;
            this.rdbUsage1.CheckedChanged += new System.EventHandler(this.rdbUsage1_CheckedChanged);
            // 
            // txtDatausage
            // 
            this.txtDatausage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDatausage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatausage.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatausage.ForeColor = System.Drawing.Color.Navy;
            this.txtDatausage.Location = new System.Drawing.Point(456, 29);
            this.txtDatausage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDatausage.Multiline = true;
            this.txtDatausage.Name = "txtDatausage";
            this.txtDatausage.ReadOnly = true;
            this.txtDatausage.Size = new System.Drawing.Size(774, 104);
            this.txtDatausage.TabIndex = 5;
            // 
            // tabConsumption
            // 
            this.tabConsumption.Location = new System.Drawing.Point(4, 29);
            this.tabConsumption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabConsumption.Name = "tabConsumption";
            this.tabConsumption.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabConsumption.Size = new System.Drawing.Size(1277, 964);
            this.tabConsumption.TabIndex = 1;
            this.tabConsumption.Tag = "CONSUMPTION";
            this.tabConsumption.Text = "Consumption Data";
            this.tabConsumption.UseVisualStyleBackColor = true;
            // 
            // dtpstart
            // 
            this.dtpstart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtpstart.Location = new System.Drawing.Point(214, 203);
            this.dtpstart.Margin = new System.Windows.Forms.Padding(0);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(342, 36);
            this.dtpstart.TabIndex = 13;
            // 
            // ConsumptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 1057);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsumptionForm";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quantification Process";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsumptionForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsumptionForm_FormClosed);
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbDatausage.ResumeLayout(false);
            this.grbDatausage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comPeriod;
        private System.Windows.Forms.DateTimePicker dtpForecastDate;
        private System.Windows.Forms.TextBox txtScope;
        private System.Windows.Forms.TextBox txtForecastNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabConsumption;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbDatausage;
        private System.Windows.Forms.RadioButton rdbUsage3;
        private System.Windows.Forms.RadioButton rdbUsage2;
        private System.Windows.Forms.RadioButton rdbUsage1;
        private System.Windows.Forms.TextBox txtDatausage;
        private LQT.GUI.DurationPicker dtpstart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtplastmodifieddate;
        private System.Windows.Forms.ComboBox cboscope;
        private System.Windows.Forms.ComboBox comslowmovingperiod;
        private System.Windows.Forms.Label label8;
    }
}