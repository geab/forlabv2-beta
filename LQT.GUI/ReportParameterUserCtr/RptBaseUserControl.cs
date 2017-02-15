using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LQT.Core.Util;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace LQT.GUI.ReportParameterUserCtr
{
    public partial class RptBaseUserControl :System.Windows.Forms.UserControl
    {
        public FileInfo filinfo = null;
        private LqtMainWindowForm _mdiparent;
        public SqlConnection sqlConnection=ConnectionManager.GetInstance().GetSqlConnection();
        public List<ReportParameter> param = new List<ReportParameter>();
        public List<SqlParameter> sqlParams = new List<SqlParameter>();
        private int _DefaultReportId = 0;

        public RptBaseUserControl()
        {
            InitializeComponent();
        }
                
        public LqtMainWindowForm MdiParentForm
        {
            get { return _mdiparent; }
            set { _mdiparent = value; }
        }

        public virtual int DefaultReportId
        {
            get { return _DefaultReportId; }
            set { _DefaultReportId = value; }
        }
                
        public virtual string GetControlTitle
        {
            get { return ""; }
        }

        public void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
    }
}
