using System;
using System.Collections;

namespace LQT.GUI.MorbidityCalculation
{
    public class BudgetPeriodInfo
    {
        //default value on the excel commented out for now
        //new double[] { 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170 };
        private double[] _defultMonthValue = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; 

        public double[] DefultMonthValue
        {
            get { return _defultMonthValue; }
        }

        public int FirstMonth { get; set; } 
        public int LastMonth { get; set; }
        public int BufferStoks{ get; set; }
        public int BeginsOnmonth { get; set; }
        public int EndOnMonth { get; set; }

        public int NumberofMonthsinBudgetPeriod { get; set; }
        public int WorkingDaysinBudgetPeriod { get; set; }
        public int WeeksinBudgetPeriod { get; set; }
        public int QuartersinBudgetPeriod { get; set; }
        public int NumberofBufferMonthsBeyondForecast { get; set; }
    }
}
