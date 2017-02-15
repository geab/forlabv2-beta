﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LQT.Core.UserExceptions;

namespace LQT.GUI
{
    public partial class FrmReportedPeriod : Form
    {
        public int NoPeriod = 0;
        public DateTime _startDate = new DateTime();

        public FrmReportedPeriod(DateTime startdate)
        {
            _startDate = startdate;
            
            InitializeComponent();
            lblstartdate.Text = lblstartdate.Text + " " + _startDate.ToShortDateString();
        }

        public FrmReportedPeriod()
        {
            //_startDate = startdate;

            InitializeComponent();
            lblstartdate.Visible = false;
            rdodown.Visible = false;
            rdoup.Visible = false;
           // lblstartdate.Text = lblstartdate.Text + " " + _startDate.ToShortDateString();
        }

        private void txtPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = e.KeyChar;

            if ((x >= 48 && x <= 57) || (x == 8))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            if (txtPeriod.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Reporting Period Can not be empty", "Reporting Period", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            NoPeriod = int.Parse(txtPeriod.Text);
            Close();
        }

        public string DataFlow()
        {

            //if (rdodown.Checked)
            //    return "Down";
            //else 
            if (rdoup.Checked)
                return "Up";
            else
                return null;
        }

       

       
    }
}
