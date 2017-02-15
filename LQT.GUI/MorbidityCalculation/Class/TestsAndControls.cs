using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.GUI.MorbidityCalculation
{
    public class TestsAndControls
    {
        private TestsAndControls()
        {
        }

        public TestsAndControls(int month)
        {
            Month = month;
        }

        public int Month { get; private set; }

        public double TestsonInstrumentForecastPeriod { get; set; }
        public double TestsonInstrumentBufferStock { get; set; }
        public double SampleReferredTestsForecastPeriod { get; set; }
        public double SampleReferredTestsBufferStock { get; set; }

        public double ControlsPerNoOfTests { get; set; }
        public double ControlsPerDay { get; set; }
        public double ControlsPerWeek { get; set; }
        public double ControlsPerMonth { get; set; }
        public double ControlsPerQuarter { get; set; }

        public double ControlsPerNoOfTestsBuffer { get; set; }
        public double ControlsPerDayBuffer { get; set; }
        public double ControlsPerWeekBuffer { get; set; }
        public double ControlsPerMonthBuffer { get; set; }
        public double ControlsPerQuarterBuffer { get; set; }

        public double TotalControls
        {
            get
            {
                double result = ControlsPerNoOfTests + ControlsPerNoOfTestsBuffer;
                result += ControlsPerDay + ControlsPerDayBuffer;
                result += ControlsPerMonth + ControlsPerMonthBuffer;
                result += ControlsPerQuarter + ControlsPerQuarterBuffer;
                result += ControlsPerWeek + ControlsPerWeekBuffer;
                return result;
            }
        }
        public double TotalControlsFP
        {
            get
            {
                double result = ControlsPerNoOfTests;
                result += ControlsPerDay;
                result += ControlsPerMonth;
                result += ControlsPerQuarter;
                result += ControlsPerWeek;
                return result;
            }
        }
        public double TotalControlsBS
        {
            get
            {
                double result = ControlsPerNoOfTestsBuffer + ControlsPerDayBuffer;
                result += ControlsPerMonthBuffer + ControlsPerQuarterBuffer + ControlsPerWeekBuffer;
                return result;
            }
        }

        public double SampleReferredControlsPerNoOfTests { get; set; }
        public double SampleReferredControlsPerNoOfTestsBuffer { get; set; }
        public double SampleReferredTotalControls
        {
            get { return SampleReferredControlsPerNoOfTests + SampleReferredControlsPerNoOfTestsBuffer; }
        }

    }
}
