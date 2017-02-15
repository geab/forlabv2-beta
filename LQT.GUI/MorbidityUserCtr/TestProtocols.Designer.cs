namespace LQT.GUI.MorbidityUserCtr
{
    partial class TestProtocols
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
            this.tabCD4 = new System.Windows.Forms.TabPage();
            this.tabChem = new System.Windows.Forms.TabPage();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txttestsrepeated = new System.Windows.Forms.TextBox();
            this.txtsymptomdirected = new System.Windows.Forms.TextBox();
            this.txtprotocolcategory = new System.Windows.Forms.TextBox();
            this.lblsystemdirected = new System.Windows.Forms.Label();
            this.lsvpanel = new System.Windows.Forms.ListView();
            this.tabPanels = new System.Windows.Forms.TabPage();
            this.butDeletepanel = new System.Windows.Forms.Button();
            this.butNewpanel = new System.Windows.Forms.Button();
            this.butEditpanel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.tabPanels.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCD4
            // 
            this.tabCD4.Location = new System.Drawing.Point(4, 22);
            this.tabCD4.Name = "tabCD4";
            this.tabCD4.Padding = new System.Windows.Forms.Padding(3);
            this.tabCD4.Size = new System.Drawing.Size(1000, 217);
            this.tabCD4.TabIndex = 1;
            this.tabCD4.Text = "Patient protocol as number of blood samples drawn for CD4 tests in a given month " +
    "(after the initial CD4 test)";
            this.tabCD4.UseVisualStyleBackColor = true;
            // 
            // tabChem
            // 
            this.tabChem.Location = new System.Drawing.Point(4, 22);
            this.tabChem.Name = "tabChem";
            this.tabChem.Padding = new System.Windows.Forms.Padding(3);
            this.tabChem.Size = new System.Drawing.Size(941, 217);
            this.tabChem.TabIndex = 2;
            this.tabChem.Text = "% Total patients requiring 1 symptom-directed test/year";
            this.tabChem.UseVisualStyleBackColor = true;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Panel Name";
            this.columnHeader14.Width = 409;
            // 
            // txtdescription
            // 
            this.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescription.Location = new System.Drawing.Point(83, 36);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(545, 50);
            this.txtdescription.TabIndex = 123;
            // 
            // txttestsrepeated
            // 
            this.txttestsrepeated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttestsrepeated.Location = new System.Drawing.Point(523, 9);
            this.txttestsrepeated.Name = "txttestsrepeated";
            this.txttestsrepeated.Size = new System.Drawing.Size(105, 20);
            this.txttestsrepeated.TabIndex = 121;
            this.txttestsrepeated.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttestsrepeated_KeyPress);
            // 
            // txtsymptomdirected
            // 
            this.txtsymptomdirected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsymptomdirected.Location = new System.Drawing.Point(522, 92);
            this.txtsymptomdirected.Name = "txtsymptomdirected";
            this.txtsymptomdirected.Size = new System.Drawing.Size(106, 20);
            this.txtsymptomdirected.TabIndex = 124;
            this.txtsymptomdirected.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttestsrepeated_KeyPress);
            // 
            // txtprotocolcategory
            // 
            this.txtprotocolcategory.BackColor = System.Drawing.SystemColors.Info;
            this.txtprotocolcategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprotocolcategory.Location = new System.Drawing.Point(83, 9);
            this.txtprotocolcategory.MaxLength = 64;
            this.txtprotocolcategory.Name = "txtprotocolcategory";
            this.txtprotocolcategory.ReadOnly = true;
            this.txtprotocolcategory.Size = new System.Drawing.Size(210, 20);
            this.txtprotocolcategory.TabIndex = 120;
            // 
            // lblsystemdirected
            // 
            this.lblsystemdirected.AutoSize = true;
            this.lblsystemdirected.Location = new System.Drawing.Point(341, 95);
            this.lblsystemdirected.Name = "lblsystemdirected";
            this.lblsystemdirected.Size = new System.Drawing.Size(166, 13);
            this.lblsystemdirected.TabIndex = 128;
            this.lblsystemdirected.Text = "% Symptom-Directed Tests /Year:";
            // 
            // lsvpanel
            // 
            this.lsvpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvpanel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14});
            this.lsvpanel.FullRowSelect = true;
            this.lsvpanel.GridLines = true;
            this.lsvpanel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvpanel.Location = new System.Drawing.Point(5, 5);
            this.lsvpanel.MultiSelect = false;
            this.lsvpanel.Name = "lsvpanel";
            this.lsvpanel.Size = new System.Drawing.Size(825, 172);
            this.lsvpanel.TabIndex = 4;
            this.lsvpanel.UseCompatibleStateImageBehavior = false;
            this.lsvpanel.View = System.Windows.Forms.View.Details;
            this.lsvpanel.SelectedIndexChanged += new System.EventHandler(this.lsvpanel_SelectedIndexChanged);
            // 
            // tabPanels
            // 
            this.tabPanels.Controls.Add(this.lsvpanel);
            this.tabPanels.Controls.Add(this.butDeletepanel);
            this.tabPanels.Controls.Add(this.butNewpanel);
            this.tabPanels.Controls.Add(this.butEditpanel);
            this.tabPanels.Location = new System.Drawing.Point(4, 22);
            this.tabPanels.Name = "tabPanels";
            this.tabPanels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPanels.Size = new System.Drawing.Size(941, 217);
            this.tabPanels.TabIndex = 0;
            this.tabPanels.Text = "Panel";
            this.tabPanels.UseVisualStyleBackColor = true;
            // 
            // butDeletepanel
            // 
            this.butDeletepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butDeletepanel.Enabled = false;
            this.butDeletepanel.Location = new System.Drawing.Point(836, 107);
            this.butDeletepanel.Name = "butDeletepanel";
            this.butDeletepanel.Size = new System.Drawing.Size(75, 33);
            this.butDeletepanel.TabIndex = 7;
            this.butDeletepanel.Text = "Delete";
            this.butDeletepanel.UseVisualStyleBackColor = true;
            this.butDeletepanel.Click += new System.EventHandler(this.butDeletepanel_Click);
            // 
            // butNewpanel
            // 
            this.butNewpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butNewpanel.Location = new System.Drawing.Point(836, 29);
            this.butNewpanel.Name = "butNewpanel";
            this.butNewpanel.Size = new System.Drawing.Size(75, 33);
            this.butNewpanel.TabIndex = 5;
            this.butNewpanel.Text = "New...";
            this.butNewpanel.UseVisualStyleBackColor = true;
            this.butNewpanel.Click += new System.EventHandler(this.butNewpanel_Click);
            // 
            // butEditpanel
            // 
            this.butEditpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butEditpanel.Enabled = false;
            this.butEditpanel.Location = new System.Drawing.Point(836, 68);
            this.butEditpanel.Name = "butEditpanel";
            this.butEditpanel.Size = new System.Drawing.Size(75, 33);
            this.butEditpanel.TabIndex = 6;
            this.butEditpanel.Text = "Edit...";
            this.butEditpanel.UseVisualStyleBackColor = true;
            this.butEditpanel.Click += new System.EventHandler(this.butEditpanel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPanels);
            this.tabControl1.Controls.Add(this.tabCD4);
            this.tabControl1.Controls.Add(this.tabChem);
            this.tabControl1.Controls.Add(this.tabOther);
            this.tabControl1.Location = new System.Drawing.Point(2, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 243);
            this.tabControl1.TabIndex = 129;
            // 
            // tabOther
            // 
            this.tabOther.Location = new System.Drawing.Point(4, 22);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(941, 217);
            this.tabOther.TabIndex = 3;
            this.tabOther.Text = "% Total patients requiring 1 symptom-directed test/year";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 127;
            this.label3.Text = "Protocol Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "% of tests repeated :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "Description:";
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(83, 95);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(104, 30);
            this.butSave.TabIndex = 130;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // TestProtocols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txttestsrepeated);
            this.Controls.Add(this.txtsymptomdirected);
            this.Controls.Add(this.txtprotocolcategory);
            this.Controls.Add(this.lblsystemdirected);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestProtocols";
            this.Size = new System.Drawing.Size(1017, 530);
            this.tabPanels.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabCD4;
        private System.Windows.Forms.TabPage tabChem;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txttestsrepeated;
        private System.Windows.Forms.TextBox txtsymptomdirected;
        private System.Windows.Forms.TextBox txtprotocolcategory;
        private System.Windows.Forms.Label lblsystemdirected;
        private System.Windows.Forms.ListView lsvpanel;
        private System.Windows.Forms.TabPage tabPanels;
        private System.Windows.Forms.Button butDeletepanel;
        private System.Windows.Forms.Button butNewpanel;
        private System.Windows.Forms.Button butEditpanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butSave;
    }
}
