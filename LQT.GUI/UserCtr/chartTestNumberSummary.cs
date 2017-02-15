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

namespace LQT.GUI.UserCtr
{
    public partial class chartTestNumberSummary : LQT.GUI.UserCtr.BaseUserControl
    {
        private CD4TestNumber _cd;
        private int _ForecastId;
        private SqlConnection cn = ConnectionManager.GetInstance().GetSqlConnection();
        private DataSet _dataSet;
        private decimal _total;
        private int _siteorCatId;
        private int _typeId;
        private string _chartTitle;

        public chartTestNumberSummary()
        {
            InitializeComponent();
        }

        public chartTestNumberSummary(int _forecastId,int siteorcatid,int typeId)
        {
            _ForecastId = _forecastId;
            _siteorCatId = siteorcatid;
            _typeId = typeId;

            InitializeComponent();
        }

        private void chartTestNumberSummary_Load(object sender, EventArgs e)
        {
            chart1.Series["Series2"].Points.Clear();
            
            GetSummary();

            DataView dv = new DataView(_dataSet.Tables[0]);
          
            foreach (DataRowView rowView in dv)
            {
                DataRow row = rowView.Row;
                _total = _total + (decimal)row["NoofTest"];
            }
        
            for (int i=0;i<dv.Count;i++)
            {
             decimal percentage= decimal.Round(((decimal)dv[i]["NoofTest"]), 4, MidpointRounding.AwayFromZero);
             dv[i]["percentage"] = percentage;
            }

            chart1.Series["Series2"].LegendText ="#VALX , #VALY , (#PERCENT)";
            chart1.Series["Series2"].Points.DataBindXY(dv, "AreaName", dv, "percentage");
            chart1.Series["Series2"]["PieLabelStyle"] = "Disabled";
            chart1.Titles[0].Text = _chartTitle;
        }

        private DataSet GetSummary()
        {
            ForecastInfo _finfo = DataRepository.GetForecastInfoById(_ForecastId);
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            if (_finfo.DatausageEnum == DataUsageEnum.DATA_USAGE1 || _finfo.DatausageEnum == DataUsageEnum.DATA_USAGE2)
            {
                if (_finfo.FMethodologeyEnum == MethodologyEnum.CONSUMPTION)
                {
                    //consumption site
                    cmd.CommandText = "spConsumptionForecastProductSummary";
                    cmd.Parameters.Add("@forecastid", SqlDbType.Int).Value = _ForecastId;
                    cmd.Parameters.Add("@siteid", SqlDbType.Int).Value = _siteorCatId;
                    cmd.Parameters.Add("@protypeid", SqlDbType.Int).Value = _typeId;
                    _dataSet = new DataSet("spConsumptionForecastTotalSummary");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_dataSet, "spConsumptionForecastProductSummary");
                    _chartTitle = "Consumption Statistics Product Usage By Product Type";
                }
                else
                {
                    //service site
                    cmd.CommandText = "spServiceForecastNoofTestSummary";
                    cmd.Parameters.Add("@forecastid", SqlDbType.Int).Value = _ForecastId;
                    cmd.Parameters.Add("@siteid", SqlDbType.Int).Value = _siteorCatId;
                    cmd.Parameters.Add("@testareaId",SqlDbType.Int).Value=_typeId;
                    _dataSet = new DataSet("spServiceForecastNoofTestTotalSummary");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_dataSet, "spServiceForecastNoofTestSummary");
                    _chartTitle = "Service Statistics Test By TestingArea";
                }
            }
            else
            {
                if (_finfo.FMethodologeyEnum == MethodologyEnum.CONSUMPTION)
                {
                    //consumption category
                    cmd.CommandText = "spConsumptionForecastProductSummary";
                    cmd.Parameters.Add("@forecastid", SqlDbType.Int).Value = _ForecastId;
                    cmd.Parameters.Add("@catid", SqlDbType.Int).Value = _siteorCatId;
                    cmd.Parameters.Add("@protypeid", SqlDbType.Int).Value = _typeId;
                    _dataSet = new DataSet("spConsumptionForecastProductSummary");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_dataSet, "spConsumptionForecastProductSummary");
                    _chartTitle = "Consumption Statistics Total Product Usage By Product Type";
                }
                else
                {
                    //service category

                    cmd.CommandText = "spServiceForecastNoofTestSummary";
                    cmd.Parameters.Add("@forecastid", SqlDbType.Int).Value = _ForecastId;
                    cmd.Parameters.Add("@catid", SqlDbType.Int).Value = _siteorCatId;
                    cmd.Parameters.Add("@testareaId", SqlDbType.Int).Value = _typeId;
                    _dataSet = new DataSet("spServiceForecastNoofTestSummary");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_dataSet, "spServiceForecastNoofTestSummary");
                    _chartTitle = "Service Statistics Test By TestingArea";
                }
            }
            return _dataSet;
        }
    }
}
