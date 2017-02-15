namespace LQT.GUI.Asset
{
    partial class InstrumentForm
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
            this.comTestarea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comperiod = new System.Windows.Forms.ComboBox();
            this.txtcontrolamount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lqtToolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.90141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.09859F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 65);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // lqtToolStrip1
            // 
            this.lqtToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lqtToolStrip1.Location = new System.Drawing.Point(6, 8);
            this.lqtToolStrip1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lqtToolStrip1.Name = "lqtToolStrip1";
            this.lqtToolStrip1.Size = new System.Drawing.Size(574, 49);
            this.lqtToolStrip1.TabIndex = 0;
            // 
            // comTestarea
            // 
            this.comTestarea.DisplayMember = "AreaName";
            this.comTestarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTestarea.FormattingEnabled = true;
            this.comTestarea.Location = new System.Drawing.Point(164, 132);
            this.comTestarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comTestarea.Name = "comTestarea";
            this.comTestarea.Size = new System.Drawing.Size(190, 28);
            this.comTestarea.TabIndex = 2;
            this.comTestarea.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Testing Area:";
            // 
            // txtMaxput
            // 
            this.txtMaxput.Location = new System.Drawing.Point(164, 180);
            this.txtMaxput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxput.Name = "txtMaxput";
            this.txtMaxput.Size = new System.Drawing.Size(190, 26);
            this.txtMaxput.TabIndex = 3;
            this.txtMaxput.Text = "0";
            this.txtMaxput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Max Through Put:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 86);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MaxLength = 64;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(391, 26);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Instrument Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(20, 234);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Control Test Needed";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(153, 245);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(405, 3);
            this.label10.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 277);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 60;
            this.label11.Text = "Frequency:";
            // 
            // comperiod
            // 
            this.comperiod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comperiod.FormattingEnabled = true;
            this.comperiod.Location = new System.Drawing.Point(164, 272);
            this.comperiod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comperiod.Name = "comperiod";
            this.comperiod.Size = new System.Drawing.Size(190, 28);
            this.comperiod.TabIndex = 61;
            // 
            // txtcontrolamount
            // 
            this.txtcontrolamount.Location = new System.Drawing.Point(466, 274);
            this.txtcontrolamount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcontrolamount.Name = "txtcontrolamount";
            this.txtcontrolamount.Size = new System.Drawing.Size(90, 26);
            this.txtcontrolamount.TabIndex = 62;
            this.txtcontrolamount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(378, 278);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "# of Run";
            // 
            // InstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 332);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcontrolamount);
            this.Controls.Add(this.comperiod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comTestarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaxput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstrumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Instrument";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserCtr.LqtToolStrip lqtToolStrip1;
        private System.Windows.Forms.ComboBox comTestarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comperiod;
        private System.Windows.Forms.TextBox txtcontrolamount;
        private System.Windows.Forms.Label label12;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}