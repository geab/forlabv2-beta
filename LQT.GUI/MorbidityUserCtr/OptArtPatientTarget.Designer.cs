﻿namespace LQT.GUI.MorbidityUserCtr
{
    partial class OptArtPatientTarget
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chbSitegrowth = new LQT.GUI.MorbidityUserCtr.LQTCheckBox();
            this.chbNationaltarget = new LQT.GUI.MorbidityUserCtr.LQTCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chbAllsite = new LQT.GUI.MorbidityUserCtr.LQTCheckBox();
            this.chbSelectsite = new LQT.GUI.MorbidityUserCtr.LQTCheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "2-Enter National Targets\r\n    But grow some sites at a different rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.label2, "Thes options are recommended when data is available for some sites\r\nor when new s" +
                    "ites may see faster growth than mature sites");
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "1-Enter National Targets\r\n   Simply apply equal linear growth to all sites";
            this.toolTip1.SetToolTip(this.label1, "This option is recommended when no site-level data is available");
            // 
            // chbSitegrowth
            // 
            this.chbSitegrowth.BackColor = System.Drawing.Color.Transparent;
            this.chbSitegrowth.Checked = false;
            this.chbSitegrowth.Location = new System.Drawing.Point(80, 81);
            this.chbSitegrowth.Margin = new System.Windows.Forms.Padding(0);
            this.chbSitegrowth.Name = "chbSitegrowth";
            this.chbSitegrowth.Size = new System.Drawing.Size(33, 33);
            this.chbSitegrowth.TabIndex = 5;
            this.chbSitegrowth.Tag = "2";
            this.toolTip1.SetToolTip(this.chbSitegrowth, "Thes options are recommended when data is available for some sites\r\nor when new s" +
                    "ites may see faster growth than mature sites");
            // 
            // chbNationaltarget
            // 
            this.chbNationaltarget.BackColor = System.Drawing.Color.Transparent;
            this.chbNationaltarget.Checked = false;
            this.chbNationaltarget.Location = new System.Drawing.Point(80, 26);
            this.chbNationaltarget.Margin = new System.Windows.Forms.Padding(0);
            this.chbNationaltarget.Name = "chbNationaltarget";
            this.chbNationaltarget.Size = new System.Drawing.Size(33, 33);
            this.chbNationaltarget.TabIndex = 4;
            this.chbNationaltarget.Tag = "1";
            this.toolTip1.SetToolTip(this.chbNationaltarget, "This option is recommended when no site-level data is available");
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "4-Enter specific targets for each site";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.label3, "This option is recommended when specific data is available for all sites");
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "3-Enter National Targets\r\n    But enter specific targets for some sites";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.label4, "Thes options are recommended when data is available for some sites\r\nor when new s" +
                    "ites may see faster growth than mature sites");
            // 
            // chbAllsite
            // 
            this.chbAllsite.BackColor = System.Drawing.Color.Transparent;
            this.chbAllsite.Checked = false;
            this.chbAllsite.Location = new System.Drawing.Point(79, 187);
            this.chbAllsite.Margin = new System.Windows.Forms.Padding(0);
            this.chbAllsite.Name = "chbAllsite";
            this.chbAllsite.Size = new System.Drawing.Size(33, 33);
            this.chbAllsite.TabIndex = 9;
            this.chbAllsite.Tag = "4";
            this.toolTip1.SetToolTip(this.chbAllsite, "This option is recommended when specific data is available for all sites");
            // 
            // chbSelectsite
            // 
            this.chbSelectsite.BackColor = System.Drawing.Color.Transparent;
            this.chbSelectsite.Checked = false;
            this.chbSelectsite.Location = new System.Drawing.Point(79, 134);
            this.chbSelectsite.Margin = new System.Windows.Forms.Padding(0);
            this.chbSelectsite.Name = "chbSelectsite";
            this.chbSelectsite.Size = new System.Drawing.Size(33, 33);
            this.chbSelectsite.TabIndex = 8;
            this.chbSelectsite.Tag = "3";
            this.toolTip1.SetToolTip(this.chbSelectsite, "Thes options are recommended when data is available for some sites\r\nor when new s" +
                    "ites may see faster growth than mature sites");
            // 
            // OptArtPatientTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbAllsite);
            this.Controls.Add(this.chbSelectsite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbSitegrowth);
            this.Controls.Add(this.chbNationaltarget);
            this.Name = "OptArtPatientTarget";
            this.Size = new System.Drawing.Size(535, 321);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LQTCheckBox chbSitegrowth;
        private LQTCheckBox chbNationaltarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private LQTCheckBox chbAllsite;
        private LQTCheckBox chbSelectsite;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
