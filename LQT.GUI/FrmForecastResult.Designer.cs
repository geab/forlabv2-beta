namespace LQT.GUI
{
    partial class FrmForecastResult
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabResult = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabMax = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabmape = new System.Windows.Forms.TabPage();
            this.lqtChart2 = new LQT.GUI.LQTChart();
            this.tabPagemaperesult = new System.Windows.Forms.TabPage();
            this.lnkexporttoexcel = new System.Windows.Forms.LinkLabel();
            this.gdvmeapresult = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAddby = new System.Windows.Forms.Label();
            this.lblWestage = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblRegression = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbmapeinfo = new System.Windows.Forms.GroupBox();
            this.lblgray = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmeapindicator3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblindicator2info = new System.Windows.Forms.Label();
            this.lblindicator2 = new System.Windows.Forms.Label();
            this.lblindicator1info = new System.Windows.Forms.Label();
            this.lblindicator1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabResult.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabMax.SuspendLayout();
            this.tabmape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lqtChart2)).BeginInit();
            this.tabPagemaperesult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvmeapresult)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grbmapeinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.tabPage1);
            this.tabResult.Controls.Add(this.tabMax);
            this.tabResult.Controls.Add(this.tabmape);
            this.tabResult.Controls.Add(this.tabPagemaperesult);
            this.tabResult.Location = new System.Drawing.Point(18, 268);
            this.tabResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResult.Name = "tabResult";
            this.tabResult.SelectedIndex = 0;
            this.tabResult.Size = new System.Drawing.Size(878, 428);
            this.tabResult.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(870, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Message";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(4, 5);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(862, 385);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabMax
            // 
            this.tabMax.Controls.Add(this.listView1);
            this.tabMax.Location = new System.Drawing.Point(4, 29);
            this.tabMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMax.Name = "tabMax";
            this.tabMax.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMax.Size = new System.Drawing.Size(870, 395);
            this.tabMax.TabIndex = 1;
            this.tabMax.Text = "Max-Through Put";
            this.tabMax.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(4, 5);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(862, 385);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Site Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Test Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Duration";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Test to be Perform";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ins. Max T.P";
            this.columnHeader5.Width = 80;
            // 
            // tabmape
            // 
            this.tabmape.Controls.Add(this.lqtChart2);
            this.tabmape.Location = new System.Drawing.Point(4, 29);
            this.tabmape.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabmape.Name = "tabmape";
            this.tabmape.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabmape.Size = new System.Drawing.Size(870, 395);
            this.tabmape.TabIndex = 2;
            this.tabmape.Text = "MAPE Chart";
            this.tabmape.UseVisualStyleBackColor = true;
            // 
            // lqtChart2
            // 
            this.lqtChart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            this.lqtChart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.lqtChart2.BorderlineColor = System.Drawing.Color.DarkRed;
            this.lqtChart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.lqtChart2.BorderlineWidth = 2;
            this.lqtChart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.Format = "MMM yyyy";
            chartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 8F);
            chartArea2.AxisY.LabelStyle.Format = "P";
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "ChartArea1";
            this.lqtChart2.ChartAreas.Add(chartArea2);
            this.lqtChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.lqtChart2.Legends.Add(legend2);
            this.lqtChart2.Location = new System.Drawing.Point(4, 5);
            this.lqtChart2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lqtChart2.Name = "lqtChart2";
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.EmptyPointStyle.Color = System.Drawing.Color.Red;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "mape";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.lqtChart2.Series.Add(series2);
            this.lqtChart2.Size = new System.Drawing.Size(862, 385);
            this.lqtChart2.TabIndex = 10;
            this.lqtChart2.Text = "lqtChart2";
            // 
            // tabPagemaperesult
            // 
            this.tabPagemaperesult.Controls.Add(this.lnkexporttoexcel);
            this.tabPagemaperesult.Controls.Add(this.gdvmeapresult);
            this.tabPagemaperesult.Location = new System.Drawing.Point(4, 29);
            this.tabPagemaperesult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPagemaperesult.Name = "tabPagemaperesult";
            this.tabPagemaperesult.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPagemaperesult.Size = new System.Drawing.Size(870, 395);
            this.tabPagemaperesult.TabIndex = 3;
            this.tabPagemaperesult.Text = "MAPE Result";
            this.tabPagemaperesult.UseVisualStyleBackColor = true;
            // 
            // lnkexporttoexcel
            // 
            this.lnkexporttoexcel.AutoSize = true;
            this.lnkexporttoexcel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lnkexporttoexcel.LinkColor = System.Drawing.Color.Black;
            this.lnkexporttoexcel.Location = new System.Drawing.Point(704, 6);
            this.lnkexporttoexcel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkexporttoexcel.Name = "lnkexporttoexcel";
            this.lnkexporttoexcel.Size = new System.Drawing.Size(125, 19);
            this.lnkexporttoexcel.TabIndex = 2;
            this.lnkexporttoexcel.TabStop = true;
            this.lnkexporttoexcel.Text = "Export to Excel";
            this.lnkexporttoexcel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkexporttoexcel_LinkClicked);
            // 
            // gdvmeapresult
            // 
            this.gdvmeapresult.AllowUserToAddRows = false;
            this.gdvmeapresult.AllowUserToDeleteRows = false;
            this.gdvmeapresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvmeapresult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gdvmeapresult.Location = new System.Drawing.Point(9, 37);
            this.gdvmeapresult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdvmeapresult.Name = "gdvmeapresult";
            this.gdvmeapresult.Size = new System.Drawing.Size(848, 342);
            this.gdvmeapresult.TabIndex = 1;
            this.gdvmeapresult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gdvmeapresult_CellFormatting);
            this.gdvmeapresult.SelectionChanged += new System.EventHandler(this.gdvmeapresult_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAddby);
            this.groupBox2.Controls.Add(this.lblWestage);
            this.groupBox2.Controls.Add(this.lblOrder);
            this.groupBox2.Controls.Add(this.lblExtension);
            this.groupBox2.Controls.Add(this.lblRegression);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(464, 240);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forecasting Parameters";
            // 
            // lblAddby
            // 
            this.lblAddby.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddby.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddby.Location = new System.Drawing.Point(165, 189);
            this.lblAddby.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddby.Name = "lblAddby";
            this.lblAddby.Size = new System.Drawing.Size(282, 33);
            this.lblAddby.TabIndex = 28;
            this.lblAddby.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWestage
            // 
            this.lblWestage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWestage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWestage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWestage.Location = new System.Drawing.Point(165, 149);
            this.lblWestage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWestage.Name = "lblWestage";
            this.lblWestage.Size = new System.Drawing.Size(282, 33);
            this.lblWestage.TabIndex = 27;
            this.lblWestage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrder
            // 
            this.lblOrder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(165, 109);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(282, 33);
            this.lblOrder.TabIndex = 25;
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExtension
            // 
            this.lblExtension.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExtension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExtension.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.Location = new System.Drawing.Point(165, 29);
            this.lblExtension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(282, 33);
            this.lblExtension.TabIndex = 24;
            this.lblExtension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRegression
            // 
            this.lblRegression.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegression.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegression.Location = new System.Drawing.Point(165, 69);
            this.lblRegression.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegression.Name = "lblRegression";
            this.lblRegression.Size = new System.Drawing.Size(282, 33);
            this.lblRegression.TabIndex = 23;
            this.lblRegression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 197);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 19);
            this.label15.TabIndex = 14;
            this.label15.Text = "Scale-up Rate (%):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 157);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Westage %:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Projection Method:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Order:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Forecast Period:";
            // 
            // grbmapeinfo
            // 
            this.grbmapeinfo.Controls.Add(this.lblgray);
            this.grbmapeinfo.Controls.Add(this.label2);
            this.grbmapeinfo.Controls.Add(this.lblmeapindicator3);
            this.grbmapeinfo.Controls.Add(this.label1);
            this.grbmapeinfo.Controls.Add(this.lblindicator2info);
            this.grbmapeinfo.Controls.Add(this.lblindicator2);
            this.grbmapeinfo.Controls.Add(this.lblindicator1info);
            this.grbmapeinfo.Controls.Add(this.lblindicator1);
            this.grbmapeinfo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.grbmapeinfo.Location = new System.Drawing.Point(506, 18);
            this.grbmapeinfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbmapeinfo.Name = "grbmapeinfo";
            this.grbmapeinfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbmapeinfo.Size = new System.Drawing.Size(388, 237);
            this.grbmapeinfo.TabIndex = 28;
            this.grbmapeinfo.TabStop = false;
            this.grbmapeinfo.Text = "MAPE Indicator";
            // 
            // lblgray
            // 
            this.lblgray.AutoSize = true;
            this.lblgray.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblgray.Location = new System.Drawing.Point(68, 177);
            this.lblgray.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgray.Name = "lblgray";
            this.lblgray.Size = new System.Drawing.Size(0, 19);
            this.lblgray.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(9, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "........";
            // 
            // lblmeapindicator3
            // 
            this.lblmeapindicator3.AutoSize = true;
            this.lblmeapindicator3.Location = new System.Drawing.Point(68, 122);
            this.lblmeapindicator3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmeapindicator3.Name = "lblmeapindicator3";
            this.lblmeapindicator3.Size = new System.Drawing.Size(0, 19);
            this.lblmeapindicator3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "........";
            // 
            // lblindicator2info
            // 
            this.lblindicator2info.AutoSize = true;
            this.lblindicator2info.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblindicator2info.Location = new System.Drawing.Point(64, 78);
            this.lblindicator2info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblindicator2info.Name = "lblindicator2info";
            this.lblindicator2info.Size = new System.Drawing.Size(272, 19);
            this.lblindicator2info.TabIndex = 3;
            this.lblindicator2info.Text = "Represents overforecasts (<-25%),";
            // 
            // lblindicator2
            // 
            this.lblindicator2.AutoSize = true;
            this.lblindicator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(154)))), ((int)(((byte)(210)))));
            this.lblindicator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(154)))), ((int)(((byte)(210)))));
            this.lblindicator2.Location = new System.Drawing.Point(9, 80);
            this.lblindicator2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblindicator2.Name = "lblindicator2";
            this.lblindicator2.Size = new System.Drawing.Size(41, 19);
            this.lblindicator2.TabIndex = 2;
            this.lblindicator2.Text = "........";
            // 
            // lblindicator1info
            // 
            this.lblindicator1info.AutoSize = true;
            this.lblindicator1info.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblindicator1info.Location = new System.Drawing.Point(64, 37);
            this.lblindicator1info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblindicator1info.Name = "lblindicator1info";
            this.lblindicator1info.Size = new System.Drawing.Size(269, 19);
            this.lblindicator1info.TabIndex = 1;
            this.lblindicator1info.Text = "Represent underforecasts (>25%),";
            // 
            // lblindicator1
            // 
            this.lblindicator1.AutoSize = true;
            this.lblindicator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblindicator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblindicator1.Location = new System.Drawing.Point(9, 37);
            this.lblindicator1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblindicator1.Name = "lblindicator1";
            this.lblindicator1.Size = new System.Drawing.Size(41, 19);
            this.lblindicator1.TabIndex = 0;
            this.lblindicator1.Text = "........";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Execl files (*.xls)|*.xls";
            this.saveFileDialog1.Title = "Specify Destination Filename";
            // 
            // FrmForecastResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 711);
            this.Controls.Add(this.grbmapeinfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabResult);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmForecastResult";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Forecast Result";
            this.tabResult.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabMax.ResumeLayout(false);
            this.tabmape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lqtChart2)).EndInit();
            this.tabPagemaperesult.ResumeLayout(false);
            this.tabPagemaperesult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvmeapresult)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbmapeinfo.ResumeLayout(false);
            this.grbmapeinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabResult;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabMax;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAddby;
        private System.Windows.Forms.Label lblWestage;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblRegression;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabPage tabmape;
        private LQTChart lqtChart2;
        private System.Windows.Forms.TabPage tabPagemaperesult;
        private System.Windows.Forms.GroupBox grbmapeinfo;
        private System.Windows.Forms.Label lblindicator1info;
        private System.Windows.Forms.Label lblindicator1;
        private System.Windows.Forms.Label lblindicator2info;
        private System.Windows.Forms.Label lblindicator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmeapindicator3;
        private System.Windows.Forms.DataGridView gdvmeapresult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgray;
        private System.Windows.Forms.LinkLabel lnkexporttoexcel;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}