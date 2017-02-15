﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LQT.Core.Domain;
using LQT.Core.UserExceptions;
using LQT.Core.Util;

namespace LQT.GUI.MorbidityUserCtr
{
    public partial class chartMHematologyTest : LQT.GUI.UserCtr.BaseUserControl
    {
        private HemaandViralNumberofTest _h;
        private int _ForecastId;
        private int _type;

        public chartMHematologyTest()
        {
            InitializeComponent();
        }

        public chartMHematologyTest(int _forecastId,int type)
        {
            _ForecastId = _forecastId;
            _type = type;
            InitializeComponent();
        }

        private void chartMHematologyTest_Load(object sender, EventArgs e)
        {
            if (_type == 3)//hematology
            {
                chart1.Titles[0].Text = "Hematology Test Distribution";
                _h = DataRepository.GetHematologySummary(_ForecastId);
                if (_h != null)
                {
                    double total = _h.TestBasedOnProtocols + _h.SymptomDirectedTests + _h.RepeatedDuetoClinicalReq + _h.InvalidTestandWastage;

                    double[] yval = { (_h.TestBasedOnProtocols / total), (_h.SymptomDirectedTests / total), (_h.RepeatedDuetoClinicalReq / total), (_h.InvalidTestandWastage / total) };
                    string[] xval = { "Tests Based On Protocols", "Symptom-Directed Tests", "Repeated Due to Clinical Req.", "Invalid Test and Wastage" };


                    chart1.Series["Series2"].Points.DataBindXY(xval, yval);
                }
            }
            if (_type == 4)//viral
            {
                chart1.Titles[0].Text = "ViralLoad Test Distribution";
                _h = DataRepository.GetViralLoadSummary(_ForecastId);
                if (_h != null)
                {
                    double total = _h.TestBasedOnProtocols + _h.SymptomDirectedTests + _h.RepeatedDuetoClinicalReq + _h.InvalidTestandWastage;

                    double[] yval = { (_h.TestBasedOnProtocols / total), (_h.SymptomDirectedTests / total), (_h.RepeatedDuetoClinicalReq / total), (_h.InvalidTestandWastage / total) };
                    string[] xval = { "Tests Based On Protocols", "Symptom-Directed Tests", "Repeated Due to Clinical Req.", "Invalid Test and Wastage" };


                    chart1.Series["Series2"].Points.DataBindXY(xval, yval);
                }
            }

            
        }
    }
}
