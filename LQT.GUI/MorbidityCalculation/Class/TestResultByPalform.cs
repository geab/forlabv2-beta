using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.GUI.MorbidityCalculation
{
    public class TestResultByPalform
    {
        public int InstrumentId { get; set; }
        public double Tests { get; set; }
        public double TotalControls { get; set; }
        public double ControlsPerTests { get; set; }
        public double DailyControls { get; set; }
        public double WeeklyControls { get; set; }
        public double MonthlyControls { get; set; }
        public double QuarterlyControls { get; set; }
        public double NoOfInstruments { get; set; }
        public double ReferringSiteTests { get; set; }
        public double ReferringSiteTotalControls { get; set; }
        public double ReferringSiteControlsPerTests { get; set; }

    }
}
