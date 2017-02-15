namespace LQT.GUI.Consumables
{
    partial class FrmConsumables
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
            this.comTest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comTestarea = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPerTest = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNoofTest = new System.Windows.Forms.TextBox();
            this.lsvProductUsageT = new LQT.GUI.LQTListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.butAddT = new System.Windows.Forms.Button();
            this.butRemoveT = new System.Windows.Forms.Button();
            this.comProductT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lsvpanel = new System.Windows.Forms.ListView();
            this.tabPerPeriod = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvProductUsageP = new LQT.GUI.LQTListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comPeriodP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butAddP = new System.Windows.Forms.Button();
            this.butRemoveP = new System.Windows.Forms.Button();
            this.comProductP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPerInstrument = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comPeriodI = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lsvProductUsageI = new LQT.GUI.LQTListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comInstrumentI = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.butAddI = new System.Windows.Forms.Button();
            this.butRemoveI = new System.Windows.Forms.Button();
            this.comProductI = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPerTest.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPerPeriod.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPerInstrument.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lqtToolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(974, 54);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lqtToolStrip1
            // 
            this.lqtToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lqtToolStrip1.Location = new System.Drawing.Point(6, 8);
            this.lqtToolStrip1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lqtToolStrip1.Name = "lqtToolStrip1";
            this.lqtToolStrip1.Size = new System.Drawing.Size(962, 38);
            this.lqtToolStrip1.TabIndex = 8;
            // 
            // comTest
            // 
            this.comTest.DisplayMember = "TestName";
            this.comTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTest.Location = new System.Drawing.Point(111, 58);
            this.comTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comTest.Name = "comTest";
            this.comTest.Size = new System.Drawing.Size(266, 28);
            this.comTest.TabIndex = 2;
            this.comTest.Tag = "";
            this.comTest.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Test:";
            // 
            // comTestarea
            // 
            this.comTestarea.DisplayMember = "AreaName";
            this.comTestarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTestarea.FormattingEnabled = true;
            this.comTestarea.Location = new System.Drawing.Point(111, 22);
            this.comTestarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comTestarea.Name = "comTestarea";
            this.comTestarea.Size = new System.Drawing.Size(266, 28);
            this.comTestarea.TabIndex = 1;
            this.comTestarea.Tag = "";
            this.comTestarea.ValueMember = "Id";
            this.comTestarea.SelectedIndexChanged += new System.EventHandler(this.comTestarea_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Testing Area:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPerTest);
            this.tabControl1.Controls.Add(this.tabPerPeriod);
            this.tabControl1.Controls.Add(this.tabPerInstrument);
            this.tabControl1.Location = new System.Drawing.Point(4, 171);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 560);
            this.tabControl1.TabIndex = 120;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPerTest
            // 
            this.tabPerTest.Controls.Add(this.groupBox1);
            this.tabPerTest.Controls.Add(this.lsvpanel);
            this.tabPerTest.Location = new System.Drawing.Point(4, 29);
            this.tabPerTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPerTest.Name = "tabPerTest";
            this.tabPerTest.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPerTest.Size = new System.Drawing.Size(956, 547);
            this.tabPerTest.TabIndex = 0;
            this.tabPerTest.Text = "Per Test";
            this.tabPerTest.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNoofTest);
            this.groupBox1.Controls.Add(this.lsvProductUsageT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.butAddT);
            this.groupBox1.Controls.Add(this.butRemoveT);
            this.groupBox1.Controls.Add(this.comProductT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(-4, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(948, 488);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Usage Rate";
            // 
            // txtNoofTest
            // 
            this.txtNoofTest.Location = new System.Drawing.Point(111, 31);
            this.txtNoofTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoofTest.Name = "txtNoofTest";
            this.txtNoofTest.Size = new System.Drawing.Size(80, 26);
            this.txtNoofTest.TabIndex = 312;
            this.txtNoofTest.Text = "0";
            this.txtNoofTest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoofTest_KeyPress);
            // 
            // lsvProductUsageT
            // 
            this.lsvProductUsageT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader2});
            this.lsvProductUsageT.FullRowSelect = true;
            this.lsvProductUsageT.GridLines = true;
            this.lsvProductUsageT.Location = new System.Drawing.Point(10, 77);
            this.lsvProductUsageT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvProductUsageT.Name = "lsvProductUsageT";
            this.lsvProductUsageT.Size = new System.Drawing.Size(919, 381);
            this.lsvProductUsageT.TabIndex = 311;
            this.lsvProductUsageT.TabStop = false;
            this.lsvProductUsageT.UseCompatibleStateImageBehavior = false;
            this.lsvProductUsageT.View = System.Windows.Forms.View.Details;
            this.lsvProductUsageT.SubitemTextChanged += new System.EventHandler<LQT.GUI.SubitemTextEventArgs>(this.lsvProductUsageT_OnSubitemTextChanged);
            this.lsvProductUsageT.SelectedIndexChanged += new System.EventHandler(this.lsvProductUsage_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 600;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "# of Test";
            this.columnHeader7.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Usage Rate";
            this.columnHeader2.Width = 197;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "# of Test";
            // 
            // butAddT
            // 
            this.butAddT.Enabled = false;
            this.butAddT.Location = new System.Drawing.Point(759, 26);
            this.butAddT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAddT.Name = "butAddT";
            this.butAddT.Size = new System.Drawing.Size(75, 34);
            this.butAddT.TabIndex = 5;
            this.butAddT.Text = "Add";
            this.butAddT.UseVisualStyleBackColor = true;
            this.butAddT.Click += new System.EventHandler(this.butAddT_Click);
            // 
            // butRemoveT
            // 
            this.butRemoveT.Enabled = false;
            this.butRemoveT.Location = new System.Drawing.Point(842, 26);
            this.butRemoveT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butRemoveT.Name = "butRemoveT";
            this.butRemoveT.Size = new System.Drawing.Size(90, 34);
            this.butRemoveT.TabIndex = 6;
            this.butRemoveT.Text = "Remove";
            this.butRemoveT.UseVisualStyleBackColor = true;
            this.butRemoveT.Click += new System.EventHandler(this.butRemoveT_Click);
            // 
            // comProductT
            // 
            this.comProductT.DisplayMember = "ProductName";
            this.comProductT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comProductT.FormattingEnabled = true;
            this.comProductT.Location = new System.Drawing.Point(320, 29);
            this.comProductT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comProductT.Name = "comProductT";
            this.comProductT.Size = new System.Drawing.Size(427, 28);
            this.comProductT.TabIndex = 4;
            this.comProductT.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Product";
            // 
            // lsvpanel
            // 
            this.lsvpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvpanel.FullRowSelect = true;
            this.lsvpanel.GridLines = true;
            this.lsvpanel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvpanel.Location = new System.Drawing.Point(9, 26);
            this.lsvpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvpanel.MultiSelect = false;
            this.lsvpanel.Name = "lsvpanel";
            this.lsvpanel.Size = new System.Drawing.Size(920, 388);
            this.lsvpanel.TabIndex = 4;
            this.lsvpanel.UseCompatibleStateImageBehavior = false;
            this.lsvpanel.View = System.Windows.Forms.View.Details;
            // 
            // tabPerPeriod
            // 
            this.tabPerPeriod.Controls.Add(this.groupBox2);
            this.tabPerPeriod.Location = new System.Drawing.Point(4, 29);
            this.tabPerPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPerPeriod.Name = "tabPerPeriod";
            this.tabPerPeriod.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPerPeriod.Size = new System.Drawing.Size(956, 527);
            this.tabPerPeriod.TabIndex = 1;
            this.tabPerPeriod.Text = "Per Peroid";
            this.tabPerPeriod.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvProductUsageP);
            this.groupBox2.Controls.Add(this.comPeriodP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.butAddP);
            this.groupBox2.Controls.Add(this.butRemoveP);
            this.groupBox2.Controls.Add(this.comProductP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(-4, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(948, 488);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Usage Rate";
            // 
            // lsvProductUsageP
            // 
            this.lsvProductUsageP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader4});
            this.lsvProductUsageP.FullRowSelect = true;
            this.lsvProductUsageP.GridLines = true;
            this.lsvProductUsageP.Location = new System.Drawing.Point(10, 77);
            this.lsvProductUsageP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvProductUsageP.Name = "lsvProductUsageP";
            this.lsvProductUsageP.Size = new System.Drawing.Size(919, 381);
            this.lsvProductUsageP.TabIndex = 311;
            this.lsvProductUsageP.TabStop = false;
            this.lsvProductUsageP.UseCompatibleStateImageBehavior = false;
            this.lsvProductUsageP.View = System.Windows.Forms.View.Details;
            this.lsvProductUsageP.SubitemTextChanged += new System.EventHandler<LQT.GUI.SubitemTextEventArgs>(this.lsvProductUsageP_OnSubitemTextChanged);
            this.lsvProductUsageP.SelectedIndexChanged += new System.EventHandler(this.lsvProductUsageP_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product";
            this.columnHeader3.Width = 305;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Peroid";
            this.columnHeader8.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Usage Rate";
            this.columnHeader4.Width = 157;
            // 
            // comPeriodP
            // 
            this.comPeriodP.DisplayMember = "Id";
            this.comPeriodP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPeriodP.FormattingEnabled = true;
            this.comPeriodP.Location = new System.Drawing.Point(113, 29);
            this.comPeriodP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comPeriodP.Name = "comPeriodP";
            this.comPeriodP.Size = new System.Drawing.Size(175, 28);
            this.comPeriodP.TabIndex = 3;
            this.comPeriodP.ValueMember = "Id";
            this.comPeriodP.SelectedIndexChanged += new System.EventHandler(this.comPeriodP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Period";
            // 
            // butAddP
            // 
            this.butAddP.Enabled = false;
            this.butAddP.Location = new System.Drawing.Point(754, 27);
            this.butAddP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAddP.Name = "butAddP";
            this.butAddP.Size = new System.Drawing.Size(75, 34);
            this.butAddP.TabIndex = 5;
            this.butAddP.Text = "Add";
            this.butAddP.UseVisualStyleBackColor = true;
            this.butAddP.Click += new System.EventHandler(this.butAddP_Click);
            // 
            // butRemoveP
            // 
            this.butRemoveP.Enabled = false;
            this.butRemoveP.Location = new System.Drawing.Point(837, 27);
            this.butRemoveP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butRemoveP.Name = "butRemoveP";
            this.butRemoveP.Size = new System.Drawing.Size(90, 34);
            this.butRemoveP.TabIndex = 6;
            this.butRemoveP.Text = "Remove";
            this.butRemoveP.UseVisualStyleBackColor = true;
            this.butRemoveP.Click += new System.EventHandler(this.butRemoveP_Click);
            // 
            // comProductP
            // 
            this.comProductP.DisplayMember = "ProductName";
            this.comProductP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comProductP.FormattingEnabled = true;
            this.comProductP.Location = new System.Drawing.Point(433, 31);
            this.comProductP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comProductP.Name = "comProductP";
            this.comProductP.Size = new System.Drawing.Size(301, 28);
            this.comProductP.TabIndex = 4;
            this.comProductP.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Select Product";
            // 
            // tabPerInstrument
            // 
            this.tabPerInstrument.Controls.Add(this.groupBox3);
            this.tabPerInstrument.Location = new System.Drawing.Point(4, 29);
            this.tabPerInstrument.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPerInstrument.Name = "tabPerInstrument";
            this.tabPerInstrument.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPerInstrument.Size = new System.Drawing.Size(956, 547);
            this.tabPerInstrument.TabIndex = 2;
            this.tabPerInstrument.Text = "Per Instrument Per Period";
            this.tabPerInstrument.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comPeriodI);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lsvProductUsageI);
            this.groupBox3.Controls.Add(this.comInstrumentI);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.butAddI);
            this.groupBox3.Controls.Add(this.butRemoveI);
            this.groupBox3.Controls.Add(this.comProductI);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(-4, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(948, 488);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Usage Rate";
            // 
            // comPeriodI
            // 
            this.comPeriodI.DisplayMember = "Id";
            this.comPeriodI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPeriodI.FormattingEnabled = true;
            this.comPeriodI.Location = new System.Drawing.Point(579, 29);
            this.comPeriodI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comPeriodI.Name = "comPeriodI";
            this.comPeriodI.Size = new System.Drawing.Size(301, 28);
            this.comPeriodI.TabIndex = 312;
            this.comPeriodI.ValueMember = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(505, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 313;
            this.label9.Text = "Period";
            // 
            // lsvProductUsageI
            // 
            this.lsvProductUsageI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader10,
            this.columnHeader6});
            this.lsvProductUsageI.FullRowSelect = true;
            this.lsvProductUsageI.GridLines = true;
            this.lsvProductUsageI.Location = new System.Drawing.Point(10, 132);
            this.lsvProductUsageI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvProductUsageI.Name = "lsvProductUsageI";
            this.lsvProductUsageI.Size = new System.Drawing.Size(919, 326);
            this.lsvProductUsageI.TabIndex = 311;
            this.lsvProductUsageI.TabStop = false;
            this.lsvProductUsageI.UseCompatibleStateImageBehavior = false;
            this.lsvProductUsageI.View = System.Windows.Forms.View.Details;
            this.lsvProductUsageI.SubitemTextChanged += new System.EventHandler<LQT.GUI.SubitemTextEventArgs>(this.lsvProductUsageI_OnSubitemTextChanged);
            this.lsvProductUsageI.SelectedIndexChanged += new System.EventHandler(this.lsvProductUsageI_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Product";
            this.columnHeader5.Width = 221;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Period";
            this.columnHeader10.Width = 123;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Usage Rate";
            this.columnHeader6.Width = 116;
            // 
            // comInstrumentI
            // 
            this.comInstrumentI.DisplayMember = "InstrumentName";
            this.comInstrumentI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comInstrumentI.FormattingEnabled = true;
            this.comInstrumentI.Location = new System.Drawing.Point(162, 29);
            this.comInstrumentI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comInstrumentI.Name = "comInstrumentI";
            this.comInstrumentI.Size = new System.Drawing.Size(301, 28);
            this.comInstrumentI.TabIndex = 3;
            this.comInstrumentI.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Select Instrument";
            // 
            // butAddI
            // 
            this.butAddI.Enabled = false;
            this.butAddI.Location = new System.Drawing.Point(712, 70);
            this.butAddI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAddI.Name = "butAddI";
            this.butAddI.Size = new System.Drawing.Size(75, 34);
            this.butAddI.TabIndex = 5;
            this.butAddI.Text = "Add";
            this.butAddI.UseVisualStyleBackColor = true;
            this.butAddI.Click += new System.EventHandler(this.butAddI_Click_1);
            // 
            // butRemoveI
            // 
            this.butRemoveI.Enabled = false;
            this.butRemoveI.Location = new System.Drawing.Point(790, 70);
            this.butRemoveI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butRemoveI.Name = "butRemoveI";
            this.butRemoveI.Size = new System.Drawing.Size(90, 34);
            this.butRemoveI.TabIndex = 6;
            this.butRemoveI.Text = "Remove";
            this.butRemoveI.UseVisualStyleBackColor = true;
            this.butRemoveI.Click += new System.EventHandler(this.butRemoveI_Click);
            // 
            // comProductI
            // 
            this.comProductI.DisplayMember = "ProductName";
            this.comProductI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comProductI.FormattingEnabled = true;
            this.comProductI.Location = new System.Drawing.Point(162, 74);
            this.comProductI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comProductI.Name = "comProductI";
            this.comProductI.Size = new System.Drawing.Size(301, 28);
            this.comProductI.TabIndex = 4;
            this.comProductI.ValueMember = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Select Product";
            // 
            // columnHeader14
            // 
            this.columnHeader14.DisplayIndex = 0;
            this.columnHeader14.Text = "Panel Name";
            this.columnHeader14.Width = 551;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comTest);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.comTestarea);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(958, 98);
            this.groupBox4.TabIndex = 121;
            this.groupBox4.TabStop = false;
            // 
            // FrmConsumables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 749);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsumables";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumables";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPerTest.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPerPeriod.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPerInstrument.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserCtr.LqtToolStrip lqtToolStrip1;
        private System.Windows.Forms.ComboBox comTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comTestarea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPerTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private LQTListView lsvProductUsageT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butAddT;
        private System.Windows.Forms.Button butRemoveT;
        private System.Windows.Forms.ComboBox comProductT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lsvpanel;
        private System.Windows.Forms.TabPage tabPerPeriod;
        private System.Windows.Forms.TabPage tabPerInstrument;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.GroupBox groupBox2;
        private LQTListView lsvProductUsageP;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox comPeriodP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butAddP;
        private System.Windows.Forms.Button butRemoveP;
        private System.Windows.Forms.ComboBox comProductP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private LQTListView lsvProductUsageI;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox comInstrumentI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butAddI;
        private System.Windows.Forms.Button butRemoveI;
        private System.Windows.Forms.ComboBox comProductI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoofTest;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox comPeriodI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupBox4;
        // private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
   
    }
}