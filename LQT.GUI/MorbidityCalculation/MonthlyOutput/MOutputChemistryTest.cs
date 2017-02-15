﻿using System;
using System.Collections.Generic;
using System.Linq;
using LQT.Core.Util;

namespace LQT.GUI.MorbidityCalculation
{
    public class MOutputChemistryTest
    {
        private int _month;

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        private IList<ChemistryTestByPannel> _chemTestbyPanel;
        public IList<ChemistryTestByPannel> ChemTestByPanel
        {
            get
            {
                if (_chemTestbyPanel == null)
                    _chemTestbyPanel = new List<ChemistryTestByPannel>();
                return _chemTestbyPanel;
            }
        }

        public ChemistryTestByPannel GetChemTestByPanelId(int panelid)
        {
            foreach (ChemistryTestByPannel c in _chemTestbyPanel)
            {
                if (c.PanelId == panelid)
                    return c;
            }
            return null;
        }

        private IList<ChemistrySymptomDirectedTest> _chemSymptom;
        public IList<ChemistrySymptomDirectedTest> ChemSymptomDirectedTest
        {
            get
            {
                if (_chemSymptom == null)
                    _chemSymptom = new List<ChemistrySymptomDirectedTest>();
                return _chemSymptom;
            }
        }

        public ChemistrySymptomDirectedTest GetChemSymptomDirectedTestById(int testid)
        {
            foreach (ChemistrySymptomDirectedTest c in ChemSymptomDirectedTest)
            {
                if (c.TestId == testid)
                    return c;
            }
            return null;
        }

        public double GetSumOfChemTest(int testId)
        {
            double result =0d;
            foreach (ChemistryTestByPannel c in ChemTestByPanel)
            {
                result += c.GetChemTestValue(testId);
            }
            return result;
        }

        private IList<ChemistryTestOnInstrument> _testsOnInstrument;
        public IList<ChemistryTestOnInstrument> TestsOnInstrument
        {
            get { return _testsOnInstrument; }
            set { _testsOnInstrument = value; }
        }

        private double _totalSampleForecastPeriodRecivedFromReferrSites = 0d;
        public double TotalSampleForecastPeriodRecivedFromReferrSites
        {
            get { return _totalSampleForecastPeriodRecivedFromReferrSites; }
            set { _totalSampleForecastPeriodRecivedFromReferrSites = value; }
        }

        private double _totalSampleBufferStockRecivedFromReferrSites = 0d;
        public double TotalSampleBufferStockRecivedFromReferrSites
        {
            get { return _totalSampleBufferStockRecivedFromReferrSites; }
            set { _totalSampleBufferStockRecivedFromReferrSites = value; }
        }

        public double GetSumOfTotalChemistrySamples()
        {
            double result = 0d;
            foreach (ChemistryTestByPannel c in ChemTestByPanel)
            {
                result += c.TotalTestsForRegimen();
            }

            double maxAdult = 0;
            double maxPreAdult = 0;
            double maxPed = 0;
            double maxPrePed = 0;
            double maxRepeat = 0;

            foreach (ChemistrySymptomDirectedTest c in ChemSymptomDirectedTest)
            {
                if (c.AdultSymptomDirectTest> maxAdult)
                    maxAdult = c.AdultSymptomDirectTest;
                if (c.PreArtAdultSymptomDirectTest > maxPreAdult)
                    maxPreAdult = c.PreArtAdultSymptomDirectTest;
                if (c.PedSymptomDirectTest > maxPed)
                    maxPed = c.PedSymptomDirectTest;
                if (c.PreArtPedSymptomDirectTest > maxPrePed)
                    maxPrePed = c.PreArtPedSymptomDirectTest;
                if (c.RepeatedDuetoClinicianRequest() > maxRepeat)
                    maxRepeat = c.RepeatedDuetoClinicianRequest();
            }

            result += (maxAdult + maxPed + maxPreAdult + maxPrePed + maxRepeat);
            return result;
        }

        public double TotalChemistrySamplesWithinForecastPeriod{get;set;}
        public double TotalChemistrySamplesWithinBufferStock{get;set;}
        public double TotalChemistrySamples
        {
            get
            {
                return TotalChemistrySamplesWithinForecastPeriod + TotalChemistrySamplesWithinBufferStock;
            }
        }

    }

    public class ChemistryTestByPannel
    {
        private double _existingAdultPatientsinTreatment;
        private double _existingAdultPatientsinPreArt;
        private double _newAdultPatientstoTreatment;
        private double _newAdultPatientstoPreArt;

        private double _existingPedPatientsinTreatment;
        private double _existingPedPatientsinPreArt;
        private double _newPedPatientstoTreatment;
        private double _newPedPatientstoPreArt;

        private int _panelId;
        private IDictionary<int, double> _testValues = new Dictionary<int, double>();
        public int PanelId
        {
            get { return _panelId; }
            set { _panelId = value; }
        }

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

        public double TotalTestAdultIntreatment()
        {
            return _existingAdultPatientsinTreatment + _newAdultPatientstoTreatment;
        }

        public double TotalTestPedIntreatment()
        {
            return _existingPedPatientsinTreatment + _newPedPatientstoTreatment;
        }
        private double TotalTestAdultInpreArt()
        {
            return _existingAdultPatientsinPreArt + _newAdultPatientstoPreArt;
        }
        public double TotalTestPedInpreArt()
        {
            return _existingPedPatientsinPreArt + _newPedPatientstoPreArt;
        }

        public double TotalTestsForRegimen()
        {
            return TotalTestAdultIntreatment() + TotalTestAdultInpreArt() + TotalTestPedIntreatment() + TotalTestPedInpreArt();
        }

        public void SetChemTestValue(int testId, double value)
        {
            if (_testValues.ContainsKey(testId))
                _testValues[testId] = value;
            else
                _testValues.Add(testId, value);
        }

        public double GetChemTestValue(int testId)
        {
            if (_testValues.ContainsKey(testId))
                return _testValues[testId];
            return 0d;
        }
    }

    public class ChemistrySymptomDirectedTest
    {
        //private ChemistryTestNameEnum _testName;
        private int _testId;
        private double _adultSymptomDirectTest = 0d;
        private double _pedSymptomDirectTest = 0d;
        private double _preArtAdultSymptomDirectTest = 0d;
        private double _preArtPedSymptomDirectTest = 0d;

        private double _testConducted = 0d;
        private double _repeatPercent = 0d;
        private double _testBasedonProtocol = 0d;        
        private double _testsforBufferStock = 0d;        
        private double _additionalTestsdueToWastage = 0d;
        private double _additionalTestsdueToWastageBeyondForecast = 0d;
        
        private  double _testsonInstrumentForecastPeriodFromReferringSites = 0d;
        private double _testsonInstrumentBufferStockFromReferringSites = 0d;

        public int TestId
        {
            get { return _testId; }
            set { _testId = value; }
        }

        public double AdultSymptomDirectTest
        {
            get { return _adultSymptomDirectTest; }
            set { _adultSymptomDirectTest = value; }
        }

        public double PedSymptomDirectTest
        {
            get { return _pedSymptomDirectTest; }
            set { _pedSymptomDirectTest = value; }
        }

        public double PreArtAdultSymptomDirectTest
        {
            get { return _preArtAdultSymptomDirectTest; }
            set { _preArtAdultSymptomDirectTest = value; }
        }

        public double PreArtPedSymptomDirectTest
        {
            get { return _preArtPedSymptomDirectTest; }
            set { _preArtPedSymptomDirectTest = value; }
        }

        public double TestConducted
        {
            get { return _testConducted; }
            set { _testConducted = value; }
        }

        public double RepeatPercent
        {
            get { return _repeatPercent; }
            set { _repeatPercent = value; }
        }

        public double RepeatedDuetoClinicianRequest()
        {
            return TestConducted * RepeatPercent;
        }

        public double TotalSymptomDirectTest()
        {
            return AdultSymptomDirectTest + PedSymptomDirectTest + PreArtAdultSymptomDirectTest + PreArtPedSymptomDirectTest;
        }

        public double SumOfSymptomDirectTestAndRDClinicianRequest()
        {
            return TotalSymptomDirectTest() + RepeatedDuetoClinicianRequest();
        }
        public double TestBasedonProtocol
        {
            get { return _testBasedonProtocol; }
            set { _testBasedonProtocol = value; }
        }

        public double TestsforBufferStock
        {
            get { return _testsforBufferStock; }
            set { _testsforBufferStock = value; }
        }

        public double GetCalculatedTotalTest()
        {
            return TestConducted + TotalSymptomDirectTest() + RepeatedDuetoClinicianRequest();
        }

        public double AdditionalTestsdueToWastage
        {
            get { return _additionalTestsdueToWastage; }
            set { _additionalTestsdueToWastage = value; }
        }
  
        public double AdditionalTestsdueToWastageBeyondForecast
        {
            get { return _additionalTestsdueToWastageBeyondForecast; }
            set { _additionalTestsdueToWastageBeyondForecast = value; }
        }
   
        public double SubtotalOfTestBasedonProtocol
        {
            get { return TestBasedonProtocol + AdditionalTestsdueToWastage; }
        }

        public double SubtotalOfTestForBufferStock
        {
            get { return TestsforBufferStock + AdditionalTestsdueToWastageBeyondForecast; }
        }

        public double TestsReferredtoAnotherFacility
        {
            get { return SubtotalOfTestBasedonProtocol + SubtotalOfTestForBufferStock; }
        }

        public double TestsonInstrumentForecastPeriodFromReferringSites
        {
            get { return _testsonInstrumentForecastPeriodFromReferringSites; }
            set { _testsonInstrumentForecastPeriodFromReferringSites = value; }
        }

        public double TestsonInstrumentBufferStockFromReferringSites
        {
            get { return _testsonInstrumentBufferStockFromReferringSites; }
            set { _testsonInstrumentBufferStockFromReferringSites = value; }
        }
    }

    public class ChemistryPlatformTests
    {
        private IDictionary<int, ChemistryTestsAndControls> _testsAndControls = new Dictionary<int, ChemistryTestsAndControls>();
        public int InstrumentId { get; set; }
        public int Quantity { get; set; }

        public void AddTestAndControl(ChemistryTestsAndControls ctc)
        {
            _testsAndControls.Add(ctc.Month, ctc);
        }

        public ChemistryTestsAndControls GetTestAndControl(int month)
        {
            return _testsAndControls[month];
        }

        public double TotalTestsOnInstrument(int testId)
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                ChemistryTestOnInstrument ctOnIns = _testsAndControls[i].GetTestOnInstrument(testId);
                result += ctOnIns.TestsonInstrumentForecastPeriod + ctOnIns.TestsonInstrumentBufferStock + _testsAndControls[i].TotalControls;
            }

            return result;
        }

        public double SumOfTestForecastPeriod(int testId)
        {
            double result = 0;
            for (int i = 1; i <= 12; i++)
            {
                result += _testsAndControls[i].GetTestOnInstrument(testId).TestsonInstrumentForecastPeriod;
            }

            return result;
        }
        public double SumOfTestBufferStock(int testId)
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].GetTestOnInstrument(testId).TestsonInstrumentBufferStock;
            }

            return result;
        }

        public double SumOfSampleReferredTestForecastPeriod(int testId)
        {
            double result = 0;
            for (int i = 1; i <= 12; i++)
            {
                result += _testsAndControls[i].GetTestOnInstrument(testId).SampleReferredTestsForecastPeriod;
            }

            return result;
        }
        public double SumOfSampleReferredTestBufferStock(int testId)
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].GetTestOnInstrument(testId).SampleReferredTestsBufferStock;
            }

            return result;
        }

        public double TotalSmaples()
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].TotalSamplesFP + _testsAndControls[i].TotalSamplesBS;
            }

            return result;
        }
        public double TotalSmaplesFP()
        {
            double result = 0;
            for (int i = 1; i <= 12; i++)
            {
                result += _testsAndControls[i].TotalSamplesFP;
            }

            return result;
        }
        public double TotalSmaplesBS()
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].TotalSamplesBS;
            }

            return result;
        }

        public double SampleReferredTotalSmaplesFP()
        {
            double result = 0;
            for (int i = 1; i <= 12; i++)
            {
                result += _testsAndControls[i].SampleReferredTotalSamplesFP;
            }

            return result;
        }
        public double SampleReferredTotalSmaplesBS()
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].SampleReferredTotalSamplesBS;
            }

            return result;
        }

        public double TotalControls()
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].TotalControls;
            }

            return result;
        }
        public double TotalControlsFP()
        {
            double result = 0;
            for (int i = 1; i <= 12; i++)
            {
                result += _testsAndControls[i].TotalControlsFP;
            }

            return result;
        }
        public double TotalControlsBP()
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].TotalControlsBS;
            }

            return result;
        }

        public double SampleReferredTotalControlsFP()
        {
            double result = 0;
            for (int i = 1; i <= 12; i++)
            {
                result += _testsAndControls[i].SampleReferredControlsPerNoOfTests;
            }

            return result;
        }
        public double SampleReferredTotalControlsBP()
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].SampleReferredControlsPerNoOfTestsBuffer;
            }

            return result;
        }

        public double SumOfControlsPerNoOfTests()
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].ControlsPerNoOfTests + _testsAndControls[i].ControlsPerNoOfTestsBuffer;
            }

            return result;
        }
        public double SumOfControlsPerDay()
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].ControlsPerDay + _testsAndControls[i].ControlsPerDayBuffer;
            }

            return result;
        }
        public double SumOfControlsPerWeek()
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].ControlsPerWeek + _testsAndControls[i].ControlsPerWeekBuffer;
            }

            return result;
        }
        public double SumOfControlsPerMonth()
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].ControlsPerMonth + _testsAndControls[i].ControlsPerMonthBuffer;
            }

            return result;
        }
        public double SumOfControlsPerQuarter()
        {
            double result = 0;
            for (int i = 1; i <= 13; i++)
            {
                result += _testsAndControls[i].ControlsPerQuarter + _testsAndControls[i].ControlsPerQuarterBuffer;
            }

            return result;
        }

        public double GetSumOfControlsByDuration(TestingDurationEnum duration)
        {
            if (TestingDurationEnum.Daily == duration)
                return SumOfControlsPerDay();
            if (TestingDurationEnum.Monthly == duration)
                return SumOfControlsPerMonth();
            if (TestingDurationEnum.PerTest == duration)
                return SumOfControlsPerNoOfTests();
            if (TestingDurationEnum.Quarterly == duration)
                return SumOfControlsPerQuarter();
            if (TestingDurationEnum.Weekly == duration)
                return SumOfControlsPerWeek();
            if (TestingDurationEnum.TotalControl == duration)
                return TotalSmaples();
            return 0;
        }
    }

    public class ChemistryTestOnInstrument
    {
        public int TestId { get; set; }
        public double TestsonInstrumentForecastPeriod { get; set; }
        public double TestsonInstrumentBufferStock { get; set; }
        public double SampleReferredTestsForecastPeriod { get; set; }
        public double SampleReferredTestsBufferStock { get; set; }
    }

    public class ChemistryTestsAndControls
    {
        private IList<ChemistryTestOnInstrument> _chemTestOnInst = new List<ChemistryTestOnInstrument>();

        private ChemistryTestsAndControls()
        {
        }

        public ChemistryTestsAndControls(int month)
        {
            Month = month;
        }

        public IList<ChemistryTestOnInstrument> ChemTestsOnInstrument
        {
            get { return _chemTestOnInst; }
            set { _chemTestOnInst = value; }
        }
        public int Month { get; private set; }

        public double TotalSamplesFP { get; set; }
        public double TotalSamplesBS { get; set; }
        public double SampleReferredTotalSamplesFP { get; set; }
        public double SampleReferredTotalSamplesBS { get; set; }

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

        public ChemistryTestOnInstrument GetTestOnInstrument(int testId)
        {
            foreach (ChemistryTestOnInstrument ct in _chemTestOnInst)
            {
                if (ct.TestId == testId)
                    return ct;
            }
            return null;
        }
    }

    public class ClassOfChemistryTests
    {
        private double _totalSamples = 0d;
        private IDictionary<int, double> _testValues = new Dictionary<int, double>();

        public ClassOfChemistryTests()
        {           
        }

        public double TotalSamples
        {
            get { return _totalSamples; }
            set { _totalSamples = value; }
        }

        public void SetChemTestValue(int testId, double value)
        {
            if (_testValues.ContainsKey(testId))
                _testValues[testId] = value;
            else
                _testValues.Add(testId, value);
        }

        public double GetChemTestValue(int testId)
        {
            if (_testValues.ContainsKey(testId))
                return _testValues[testId];
            return 0d;
        }
    }
}
