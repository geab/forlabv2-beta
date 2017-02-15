﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LQT.Core.Util;
using LQT.Core.Domain;
using System.Collections;
using System.Data.SqlClient;
using System.IO;
using LQT.Core;
using LQT.GUI.Reports;
using Microsoft.Reporting.WinForms;

namespace LQT.GUI.ReportParameterUserCtr
{
    public partial class MorbidityNoPatientReportParam : LQT.GUI.ReportParameterUserCtr.RptBaseUserControl
    {
        public MorbidityNoPatientReportParam()
        {
            InitializeComponent();
            PopForecastInfo();
        }

        private void PopForecastInfo()
        {
         
            IList demographyForecastInfo = DataRepository.GetAllMorbidityForecast().ToList();
            ReportRepository.AddItem(demographyForecastInfo, typeof(MorbidityForecast), "Id", "Title", "< Select Option >");
            cobdemography.DataSource = demographyForecastInfo;

           
        }

        public override string GetControlTitle
        {
            get
            {
                return "Morbidity Forecast No. of Patient Summary Report";
            }
        }

        private void btnviewreport_Click(object sender, EventArgs e)
        {

           
            int DforecastId = 0;

          
            if (cobdemography.SelectedValue.ToString() != "-1")
                DforecastId = int.Parse(cobdemography.SelectedValue.ToString());


            ReportParameter pDForecastId = new ReportParameter("ForecastId", DforecastId.ToString());

          
            param.Add(pDForecastId);
            

            SqlParameter rpMForecastId = new SqlParameter();
            rpMForecastId.ParameterName = "ForecastId";
            rpMForecastId.Value = DforecastId;

            

            sqlParams.Clear();
            sqlParams.Add(rpMForecastId);


            DataSet _rDataSet = ReportRepository.GetDataSet(sqlConnection, sqlParams, "spGetForecastNoofPatientSummary");
            filinfo = new FileInfo(Path.Combine(AppSettings.GetReportPath, String.Format("{0}.rdlc", OReports.forcastpatientsummarywithgraph)));

            FrmReportViewer frmRV = new FrmReportViewer(filinfo, _rDataSet, param);
            frmRV.Dock = DockStyle.Fill;
            frmRV.ShowDialog();
        }

        
    }
}
