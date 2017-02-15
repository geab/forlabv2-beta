﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.GUI.MorbidityCalculation
{
    public class MOutputRapidTest
    {
        private int _month;
        public MOutputRapidTest(int month)
        {
            this._month = month;
        }
        public int Month
        {
            get { return _month; }
        }

        public double HIVAdultsThatDonotFollowup { get; set; }
        public double HIVPediatrcisThatDonotFollowup { get; set; }
        public double PrevalenceOfAdultTestingPop{get;set;}
        public double PrevalenceOfPediatricTestingPop{get;set;}


        public double AdultsEnteringTreatment {
            get; 
            set; 
        }
        public double PediatricsEnteringTreatment { get; set; }
        
        public double AdultsEnteringPreART { get; set; }
        public double PediatricsEnteringPreART { get; set; }

        public double AdultsGoingIntoPreARTorART
        {
            get { return AdultsEnteringTreatment + AdultsEnteringPreART; }
        }
        public double PediatricsGoingIntoPreARTorART
        {
            get { return PediatricsEnteringTreatment + PediatricsEnteringPreART; }
        }
        public double AdultsDepartAfterPositiveDiagnosis 
        {
            get { return AdultsGoingIntoPreARTorART / (1 - HIVAdultsThatDonotFollowup) * HIVAdultsThatDonotFollowup; }
        }
        public double PediatricsDepartAfterPositiveDiagnosis 
        {
            get { return PediatricsGoingIntoPreARTorART / (1 - HIVPediatrcisThatDonotFollowup) * HIVPediatrcisThatDonotFollowup; }
        }

        public double AdultsPositiveDiagnoses
        {
            get { return AdultsEnteringTreatment + AdultsEnteringPreART + AdultsDepartAfterPositiveDiagnosis; }
        }
        public double PediatricsPositiveDiagnoses
        {
            get { return PediatricsEnteringTreatment + PediatricsEnteringPreART + PediatricsDepartAfterPositiveDiagnosis; }
        }

        public double AdultsNegativeDiagnoses
        {
            get { return ((1 - PrevalenceOfAdultTestingPop) * AdultsPositiveDiagnoses) / PrevalenceOfAdultTestingPop; }
        }

        public double PediatricsNegativeDiagnoses
        {
            get { return ((1 - PrevalenceOfPediatricTestingPop) * PediatricsPositiveDiagnoses) / PrevalenceOfPediatricTestingPop; }
        }

        public double TotalAdultsTested
        {
            get { return AdultsPositiveDiagnoses + AdultsNegativeDiagnoses; }
        }
        public double TotalPediatricsTested
        {
            get { return PediatricsPositiveDiagnoses + PediatricsNegativeDiagnoses; }
        }

        public double TotalPatientsToScreen
        {
            get { 

                //return TotalAdultsTested + TotalPediatricsTested;  on may 16
                return (Double.NaN.Equals(TotalAdultsTested) ? 0 : TotalAdultsTested) + (Double.NaN.Equals(TotalPediatricsTested) ? 0 : TotalPediatricsTested);
            }
        }
        public double HIVPositivePopulation
        {
            get{return AdultsPositiveDiagnoses +PediatricsPositiveDiagnoses;}
        }
        public double HIVNegativePopulation
        {
            get { return AdultsNegativeDiagnoses + PediatricsNegativeDiagnoses; }
        }

    }
}
