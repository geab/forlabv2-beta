using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.GUI.MorbidityCalculation
{
    public class MOutputConsumable
    {
        private int _month;

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        public double AdultArtExistingPatientBloodDraws { get; set; }
        public double AdultArtNewPatientBloodDraws { get; set; }
        public double AdultPreArtExistingPatientBloodDraws { get; set; }
        public double AdultPreArtNewPatientBloodDraws { get; set; }

        public double PediatricArtExistingPatientBloodDraws { get; set; }
        public double PediatricArtNewPatientBloodDraws { get; set; }
        public double PediatricPreArtExistingPatientBloodDraws { get; set; }
        public double PediatricPreArtNewPatientBloodDraws { get; set; }
        public double TotalAdultBloodDraws { get; set; }
        public double TotalPediatricBloodDraws { get; set; }

        public double TotalAdultBloodDrawsBeyondForecastPeriod { get; set; }
        public double TotalPediatricBloodDrawsBeyondForecastPeriod { get; set; }
        public double TotalBloodDrawsBeyondForecastPeriod { get; set; }

        public double GetSumOfAdultBloodDraws()
        {
            return AdultArtExistingPatientBloodDraws + AdultArtNewPatientBloodDraws + AdultPreArtExistingPatientBloodDraws + AdultPreArtNewPatientBloodDraws;
        }

        public double GetSumOfPediatricBloodDraws()
        {
            return PediatricArtExistingPatientBloodDraws + PediatricArtNewPatientBloodDraws + PediatricPreArtExistingPatientBloodDraws + PediatricPreArtNewPatientBloodDraws;
        }

        public double TotalBloodDraws
        {
            get
            {
                return TotalAdultBloodDraws + TotalPediatricBloodDraws;
            }
        }

        public double PositiveDiagnoses { get; set; }
        public double PositiveDiagnosesToReceiveCD4 { get; set; }
        public double PositiveDiagnosesBufferStock { get; set; }
        public double PositiveDiagnosesToReceiveCD4BufferStock { get; set; }
    }
}
