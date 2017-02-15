﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.GUI.MorbidityCalculation
{
    public class MOutputHematology
    {
        private int _month;

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }


        #region viral load Tests Conducted: By Patient Group

        private double _existingAdultPatientsinTreatment;
        private double _existingAdultPatientsinPreArt;
        private double _newAdultPatientstoTreatment;
        private double _newAdultPatientstoPreArt;

        private double _existingPedPatientsinTreatment;
        private double _existingPedPatientsinPreArt;
        private double _newPedPatientstoTreatment;
        private double _newPedPatientstoPreArt;

        public double ExistingAdultPatientsinTreatment
        {
            get { return _existingAdultPatientsinTreatment; }
            set { _existingAdultPatientsinTreatment = value; }
        }
        public double ExistingAdultPatientsinPreArt
        {
            get { return _existingAdultPatientsinPreArt; }
            set { _existingAdultPatientsinPreArt = value; }
        }
        public double NewAdultPatientstoTreatment
        {
            get { return _newAdultPatientstoTreatment; }
            set { _newAdultPatientstoTreatment = value; }
        }
        public double NewAdultPatientstoPreArt
        {
            get { return _newAdultPatientstoPreArt; }
            set { _newAdultPatientstoPreArt = value; }
        }

        public double ExistingPedPatientsinTreatment
        {
            get { return _existingPedPatientsinTreatment; }
            set { _existingPedPatientsinTreatment = value; }
        }
        public double ExistingPedPatientsinPreArt
        {
            get { return _existingPedPatientsinPreArt; }
            set { _existingPedPatientsinPreArt = value; }
        }
        public double NewPedPatientstoTreatment
        {
            get { return _newPedPatientstoTreatment; }
            set { _newPedPatientstoTreatment = value; }
        }
        public double NewPedPatientstoPreArt
        {
            get { return _newPedPatientstoPreArt; }
            set { _newPedPatientstoPreArt = value; }
        }

        public double TestConductedAdultIntreatment()
        {
            return _existingAdultPatientsinTreatment + _newAdultPatientstoTreatment;
        }

        public double TestConductedPedIntreatment()
        {
            return _existingPedPatientsinTreatment + _newPedPatientstoTreatment;
        }
        private double TestConductedAdultInpreArt()
        {
            return _existingAdultPatientsinPreArt + _newAdultPatientstoPreArt;
        }
        public double TestConductedPedInpreArt()
        {
            return _existingPedPatientsinPreArt + _newPedPatientstoPreArt;
        }

        public double ExistingPatientsinTreatment()
        {
            return ExistingAdultPatientsinTreatment + ExistingPedPatientsinTreatment;
        }
        public double ExistingPatientsinPreART()
        {
            return ExistingAdultPatientsinPreArt + ExistingPedPatientsinPreArt;
        }

        public double NewPatientstoTreatment()
        {
            return NewAdultPatientstoTreatment + NewPedPatientstoTreatment;
        }
        public double NewPatientstoPreART()
        {
            return NewAdultPatientstoPreArt + NewPedPatientstoPreArt;
        }

        private double _symptomDirectedTests;
        public double SymptomDirectedTests
        {
            get { return _symptomDirectedTests; }
            set { _symptomDirectedTests = value; }
        }

        public double TestFromProtocols()
        {
            return TestConductedAdultIntreatment() + TestConductedAdultInpreArt() + TestConductedPedIntreatment() + TestConductedPedInpreArt();
        }

        private double _repeatsDuetoClinicianRequest;
        public double RepeatDuetoClinicianRequest
        {
            get { return _repeatsDuetoClinicianRequest; }
            set { _repeatsDuetoClinicianRequest = value; }
        }

        public double TotalTestConducted()
        {
            return TestFromProtocols() + SymptomDirectedTests + RepeatDuetoClinicianRequest;
        }

        private double _testsBasedonProtocols;
        public double TestsBasedonProtocols
        {
            get { return _testsBasedonProtocols; }
            set { _testsBasedonProtocols = value; }
        }

        private double _additionalTestsdueToWastage;
        public double AdditionalTestsdueToWastage
        {
            get { return _additionalTestsdueToWastage; }
            set { _additionalTestsdueToWastage = value; }
        }
        public double TotalTestsBasedonProtocols()
        {
            return TestsBasedonProtocols + AdditionalTestsdueToWastage;
        }

        private double _testsforBufferStock;
        public double TestsforBufferStock
        {
            get { return _testsforBufferStock; }
            set { _testsforBufferStock = value; }
        }

        private double _additionalTestsdueToWastageBuffer;
        public double AdditionalTestsdueToWastageForBuffer
        {
            get { return _additionalTestsdueToWastageBuffer; }
            set { _additionalTestsdueToWastageBuffer = value; }
        }

        public double TotalTestsforBufferStock()
        {
            return TestsforBufferStock + AdditionalTestsdueToWastageForBuffer;
        }

        public double TotalHematologyTestsReferred()
        {
            return TotalTestsBasedonProtocols() + TotalTestsforBufferStock();
        }

        private double _testsReceivedFromReferringSites;
        public double TestsReceivedFromReferringSites
        {
            get { return _testsReceivedFromReferringSites; }
            set { _testsReceivedFromReferringSites = value; }
        }

        private double _testsonInstrumentForecastPeriodFromReferringSites;
        public double TestsonInstrumentForecastPeriodFromReferringSites
        {
            get { return _testsonInstrumentForecastPeriodFromReferringSites; }
            set { _testsonInstrumentForecastPeriodFromReferringSites = value; }
        }

        private double _testsonInstrumentBufferStockFromReferringSites;
        public double TestsonInstrumentBufferStockFromReferringSites
        {
            get { return _testsonInstrumentBufferStockFromReferringSites; ;}
            set { _testsonInstrumentBufferStockFromReferringSites = value; }
        }



        #endregion

    }
}
