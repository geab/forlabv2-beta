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
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace LQT.GUI.UserCtr
{
    public partial class chartServiceTestNumberbyduration : LQT.GUI.UserCtr.BaseUserControl
    {
        private CD4TestNumber _cd;
        private int _ForecastId;
        private SqlConnection cn = ConnectionManager.GetInstance().GetSqlConnection();
        private DataSet _dataSet;
        private decimal _total;
        private IList<ForecastSummaryData> _fSummaryData;
        private int _siteorCatId;
        private string _chartTitle;

        public chartServiceTestNumberbyduration()
        {
            InitializeComponent();
        }

        public chartServiceTestNumberbyduration(int _forecastId,int siteorcatid)
        {
            _ForecastId = _forecastId;
            _siteorCatId = siteorcatid;

            InitializeComponent();
        }

        private void chartServiceTestNumberbyduration_Load(object sender, EventArgs e)
        {
            
            GetSummary();
            GetForecastSummaryData(_dataSet);

            lqtChart2.Series.Clear();
           

            IList<string> UniqueTestingAreas=new List<string>();
            foreach (ForecastSummaryData fsd in _fSummaryData)
            {
                if(!UniqueTestingAreas.Contains(fsd.TestingArea))
                    UniqueTestingAreas.Add(fsd.TestingArea);
            }
            foreach (string ta in UniqueTestingAreas)
            {
                Series series = new Series(ta);
                series.ChartType = SeriesChartType.Line;
                series.IsValueShownAsLabel = chkshowlabel.Checked;
                
                lqtChart2.Series.Add(series);
                
                IList<ForecastSummaryData> currentSummary = GetForecastSummaryByTA(ta);
                foreach (ForecastSummaryData fsd in currentSummary)
                {
                    lqtChart2.Series[ta].Points.AddXY(fsd.DurationDateTime, fsd.NoOfTest);
                }
            }
            lqtChart2.Titles[0].Text = _chartTitle;
        }

        

        private DataSet GetSummary()
        {
           
            ///
            ForecastInfo _finfo = DataRepository.GetForecastInfoById(_ForecastId);
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            if (_finfo.DatausageEnum == DataUsageEnum.DATA_USAGE1 || _finfo.DatausageEnum == DataUsageEnum.DATA_USAGE2)
            {
                if (_finfo.FMethodologeyEnum == MethodologyEnum.CONSUMPTION)
                {
                    //consumption site
                    cmd.CommandText = "spConsumptionForecastbyduration";
                    cmd.Parameters.Add("@forecastid", SqlDbType.Int).Value = _ForecastId;
                    cmd.Parameters.Add("@siteid", SqlDbType.Int).Value = _siteorCatId;
                    _dataSet = new DataSet("spConsumptionForecastbyduration");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_dataSet, "spConsumptionForecastbyduration");
                    _chartTitle = "Consumption Statistics Total Product Usage";
                }
                else
                {
                    //service site
                    cmd.CommandText = "spServiceForecastNoofTestbyduration";
                    cmd.Parameters.Add("@forecastid", SqlDbType.Int).Value = _ForecastId;
                    cmd.Parameters.Add("@siteid", SqlDbType.Int).Value = _siteorCatId;
                    _dataSet = new DataSet("spServiceForecastNoofTestbyduration");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_dataSet, "spServiceForecastNoofTestbyduration");
                    _chartTitle = "Service Statistics Total Test";
                }
            }
            else
            {
                if (_finfo.FMethodologeyEnum == MethodologyEnum.CONSUMPTION)
                {
                    //consumption category
                    cmd.CommandText = "spConsumptionForecastbyduration";
                    cmd.Parameters.Add("@forecastid", SqlDbType.Int).Value = _ForecastId;
                    cmd.Parameters.Add("@catid", SqlDbType.Int).Value = _siteorCatId;
                    _dataSet = new DataSet("spConsumptionForecastbyduration");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_dataSet, "spConsumptionForecastbyduration");
                    _chartTitle = "Consumption Statistics Total Product Usage";
                }
                else
                {
                    //service category
                  
                    cmd.CommandText = "spServiceForecastNoofTestbyduration";
                    cmd.Parameters.Add("@forecastid", SqlDbType.Int).Value = _ForecastId;
                    cmd.Parameters.Add("@catid", SqlDbType.Int).Value = _siteorCatId;
                    _dataSet = new DataSet("spServiceForecastNoofTestbyduration");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_dataSet, "spServiceForecastNoofTestbyduration");
                    _chartTitle = "Service Statistics Total Test";

                }
            }
            return _dataSet;
        }

        private IList<ForecastSummaryData> GetForecastSummaryData(DataSet ds)
        {
            int rowno = 0;
            _fSummaryData = new List<ForecastSummaryData>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rowno++;
                ForecastSummaryData rd = new ForecastSummaryData(Convert.ToDecimal(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToDateTime(dr[3]));
               _fSummaryData.Add(rd);
            }
            return _fSummaryData;
        }

        private IList<ForecastSummaryData> GetForecastSummaryByTA(string testingArea)
        {
            IList<ForecastSummaryData> FSummaryByTA=new List<ForecastSummaryData>();
            foreach (ForecastSummaryData fsd in _fSummaryData)
            {
                if (fsd.TestingArea == testingArea)
                    FSummaryByTA.Add(fsd);
            }
           //FSummaryByTA.OrderBy()
            return FSummaryByTA;
        }

        private void chkshowlabel_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Series series in lqtChart2.Series)
            {
                series.IsValueShownAsLabel = chkshowlabel.Checked;
            }
            lqtChart2.Invalidate();
        }
    }
}
