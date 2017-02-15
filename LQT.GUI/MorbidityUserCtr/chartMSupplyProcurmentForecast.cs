using System;
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
    public partial class chartMSupplyProcurmentForecast : LQT.GUI.UserCtr.BaseUserControl
    {
        private IList<MorbiditySupplyProcurement> _morbiditySP;
        private int _ForecastId;
       

        public chartMSupplyProcurmentForecast(int _forecastId)
        {
            _ForecastId = _forecastId;
          

            InitializeComponent();
        }

        private void chartSiteCategory_Load(object sender, EventArgs e)
        {

            _morbiditySP = DataRepository.GetMorbiditySPByForecastId(_ForecastId);
            chart1.Titles[0].Text = " Supply Procurement Forecast";
            ClassOfMorbidityTestEnum[] platforms = LqtUtil.EnumToArray<ClassOfMorbidityTestEnum>();

            double[] yval = new double[platforms.Length];
            string[] xval = new string[platforms.Length];
          
            int i = 0;
            foreach (ClassOfMorbidityTestEnum m in platforms)
            {
                xval[i] = m.ToString();

                foreach (MorbiditySupplyProcurement mp in _morbiditySP)
                {
                    if (m == mp.PlatformEnum)
                    {
                        yval[i] = mp.TotalCost + yval[i];
                    }
                }
                i++;
            }


            chart1.Series["morbiditySP"].Points.DataBindXY(xval, yval);
           
     


        }
    }
}
