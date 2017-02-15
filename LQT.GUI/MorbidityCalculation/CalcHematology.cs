﻿using System;
using System.Collections.Generic;

using LQT.Core.Domain;
using LQT.Core.Util;

namespace LQT.GUI.MorbidityCalculation
{
    public class CalcHematology : BaseCalc
    {
        private double _hemPatientsRequiringOneSymptomDirectedTest;
        private double _hemRepeatsduetoClinicianRequest;
        private double _hemAdditionalTestsDuetoWastage;

        private double _hemTestsReceivedFromReferringSitesBeyondForecast = 0;
       
        private IDictionary<int, MOutputHematology> _hemMonthlyOutputs = new Dictionary<int,MOutputHematology>();
        private IList<PlatformTestsAndControls> _hemPlatformTests = new List<PlatformTestsAndControls>();
        //private PlatformQuantifyObject _platformObject;
        private TestingArea _testingArea;


        public CalcHematology(ARTSite site, MorbidityForecast forecast, BudgetPeriodInfo periodinfo, int target)
            : base(site, forecast, periodinfo, target)
        {
            _lstPrimaryQuanReagents = new ListOfPrimeryQR(ClassOfMorbidityTestEnum.Hematology);
        }
        
        public Dictionary<int, CalculatedSitePatientNumber> CalculatedPatientNos { get; set; }
        public TestingArea TestingArea
        {
            set { _testingArea = value; }
        }

        public IDictionary<int, MOutputHematology> GetHematologyTestOutputs
        {
            get { return _hemMonthlyOutputs; }
        }

        public void DoCalculation()
        {
            CalcInstrumentDetailsAndControls();
            DoQuantification();
        }

        public void CalculateTestConducted()
        {
            CalculateHematologyTestConducted();
        }

        private void CalculateHematologyTestConducted()
        {
            _hemPatientsRequiringOneSymptomDirectedTest = (HemTestProtocol.SymptomDirectedAmt / 100d);
            _hemRepeatsduetoClinicianRequest = (HemTestProtocol.TestReapeated / 100d);
            _hemAdditionalTestsDuetoWastage = (InvAssumption.Himatology / 100d);
            
            for (int i = 1; i <= 12; i++)
            {
                MOutputHematology hemout = new MOutputHematology();
                hemout.Month = i;
                foreach (ProtocolPanel panel in HemTestProtocol.ProtocolPanels)
                {

                    hemout.ExistingAdultPatientsinTreatment +=CalculatedPatientNos[i].ArtAdultPreExistingPatients * panel.AdultInTreatmentDistribution;
                    hemout.ExistingPedPatientsinTreatment += CalculatedPatientNos[i].ArtPediatricPreExistingPatients * panel.PediatricInTreatmentDistribution; // ((pediatricsinTreatment / 12)*preExistingPatientsonPanel);
                    hemout.ExistingAdultPatientsinPreArt += CalculatedPatientNos[i].PreArtAdultPreExistingPatients * panel.AdultPreARTDistribution;  // ((adultspreART / 12)*preExistingPatientsonPanel);
                    hemout.ExistingPedPatientsinTreatment += CalculatedPatientNos[i].PreArtPediatricPreExistingPatients * panel.PediatricPreARTDistribution; // ((pediatricspreART / 12)*preExistingPatientsonPanel);

                    for (int x = 1; x <= i; x++)
                    {
                        hemout.NewAdultPatientstoTreatment += CalculatedPatientNos[i].GetArtAdultPatientsEntering(x) * panel.AdultArtTestGivenInMonth((i - x) + 1) * (panel.AITNewPatient/100d);
                        hemout.NewPedPatientstoTreatment += CalculatedPatientNos[i].GetArtPediatricPatientsEntering(x) * panel.PediatricArtTestGivenInMonth((i - x) + 1) * (panel.PITNewPatient/100d);
                        hemout.NewAdultPatientstoPreArt += CalculatedPatientNos[i].GetPreArtAdultPatientsEntering(x) * panel.AdultPreArtTestGivenInMonth((i - x) + 1) * (panel.APARTNewPatient/100d);
                        hemout.NewPedPatientstoPreArt += CalculatedPatientNos[i].GetPreArtPediatricPatientsEntering(x) * panel.PediatricPreArtTestGivenInMonth((i - x) + 1) * (panel.PPARTNewPatient/100d);
                    }
                }
                _hemMonthlyOutputs.Add(i, hemout);
            }
            double patientEnterPerMonth = 0;
            double symptomDirectedTestsAtstartYear = CurrentAdultinTreatment + CurrentPediatricinTreatment + CurrentAdultinPreArt + CurrentPediatricinPreArt;
            symptomDirectedTestsAtstartYear = (symptomDirectedTestsAtstartYear * _hemPatientsRequiringOneSymptomDirectedTest) / 12d;

            int pmonth, buffmonth;           
            for (int i = 1; i <= 12; i++)
            {
                patientEnterPerMonth = CalculatedPatientNos[i].GetArtAdultPatientsEntering(i) + CalculatedPatientNos[i].GetArtPediatricPatientsEntering(i);
                patientEnterPerMonth += CalculatedPatientNos[i].GetPreArtAdultPatientsEntering(i) + CalculatedPatientNos[i].GetPreArtPediatricPatientsEntering(i);
                patientEnterPerMonth = (patientEnterPerMonth * _hemPatientsRequiringOneSymptomDirectedTest) / 12d;

                _hemMonthlyOutputs[i].SymptomDirectedTests += symptomDirectedTestsAtstartYear + patientEnterPerMonth;

                for (int x = i + 1; x <= 12; x++)
                {
                    _hemMonthlyOutputs[x].SymptomDirectedTests += patientEnterPerMonth;
                }

                _hemMonthlyOutputs[i].RepeatDuetoClinicianRequest = (_hemMonthlyOutputs[i].TestFromProtocols() * _hemRepeatsduetoClinicianRequest) + (_hemMonthlyOutputs[i].SymptomDirectedTests * _hemRepeatsduetoClinicianRequest);

                pmonth = buffmonth = 0;
                if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                    pmonth = 1;
                if (i >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                    buffmonth = 1;

                _hemMonthlyOutputs[i].TestsBasedonProtocols = _hemMonthlyOutputs[i].TotalTestConducted() * pmonth;
                _hemMonthlyOutputs[i].TestsforBufferStock = _hemMonthlyOutputs[i].TotalTestConducted() * buffmonth;

                _hemMonthlyOutputs[i].AdditionalTestsdueToWastage = (_hemMonthlyOutputs[i].TestsBasedonProtocols / (1 - _hemAdditionalTestsDuetoWastage)) - _hemMonthlyOutputs[i].TestsBasedonProtocols;
                _hemMonthlyOutputs[i].AdditionalTestsdueToWastageForBuffer = (_hemMonthlyOutputs[i].TestsforBufferStock / (1 - _hemAdditionalTestsDuetoWastage)) - _hemMonthlyOutputs[i].TestsforBufferStock;
            }
        }

        /// <summary>
        /// sample referral
        /// </summary>
        /// <param name="result"></param>
        public void SetTestsReceivedFromReferringSites(double[] result)
        {
            int pmonth, buffmonth;
            for (int i = 1; i <= 12; i++)
            {
                _hemMonthlyOutputs[i].TestsReceivedFromReferringSites = result[i - 1];
                pmonth = buffmonth = 0;
                if ((i + 1) < PeriodInfo.BeginsOnmonth)
                    pmonth = 1;
                if ((i + 1) >= PeriodInfo.BeginsOnmonth && (i + 1) <= PeriodInfo.EndOnMonth)
                    buffmonth = 1;

                _hemMonthlyOutputs[i].TestsonInstrumentForecastPeriodFromReferringSites = result[i - 1] * pmonth;
                _hemMonthlyOutputs[i].TestsonInstrumentBufferStockFromReferringSites = result[i - 1] * buffmonth;
            }

            _hemTestsReceivedFromReferringSitesBeyondForecast = result[12];
        }

        private void CalcInstrumentDetailsAndControls()
        {
            int noofControls;
            int noofTestdays = ArtSite.Site.HematologyTestingDaysPerMonth;
            double testRunpercent;
            double controlTest = 0;

            foreach (SiteInstrument ins in ArtSite.Site.GetInstrumentByPlatform(ClassOfMorbidityTestEnum.Hematology))
            {
                PlatformTestsAndControls hemPlat = new PlatformTestsAndControls();
                hemPlat.InstrumentId = ins.Instrument.Id;
                hemPlat.Quantity = ins.Quantity;
                testRunpercent = Convert.ToDouble(ins.TestRunPercentage) / 100d;

                int currentQuarter = PeriodInfo.FirstMonth;

                for (int i = 1; i <= 12; i++)
                {
                    TestsAndControls ctc = new TestsAndControls(i);

                    ctc.TestsonInstrumentForecastPeriod = _hemMonthlyOutputs[i].TestsBasedonProtocols * testRunpercent;
                    ctc.TestsonInstrumentBufferStock = _hemMonthlyOutputs[i].TestsforBufferStock * testRunpercent;

                    noofControls = ins.Instrument.MaxTestBeforeCtrlTest;
                    if (noofControls > 0)
                    {
                        ctc.ControlsPerNoOfTests = (ctc.TestsonInstrumentForecastPeriod / noofControls);
                        ctc.ControlsPerNoOfTestsBuffer = (ctc.TestsonInstrumentBufferStock / noofControls);
                    }

                    noofControls = ins.Instrument.DailyCtrlTest;
                    controlTest = ((noofControls / (1d - _hemAdditionalTestsDuetoWastage)) * ins.Quantity) * noofTestdays;
                    if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                        ctc.ControlsPerDay = controlTest;
                    if (i >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                        ctc.ControlsPerDayBuffer = controlTest;

                    noofControls = ins.Instrument.WeeklyCtrlTest;
                    controlTest = ((noofControls / (1 - _hemAdditionalTestsDuetoWastage)) * ins.Quantity) * 4;
                    if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                        ctc.ControlsPerWeek = controlTest;
                    if (i >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                        ctc.ControlsPerWeekBuffer = controlTest;

                    noofControls = ins.Instrument.MonthlyCtrlTest;
                    controlTest = ((noofControls / (1 - _hemAdditionalTestsDuetoWastage)) * ins.Quantity) * 1;
                    if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                        ctc.ControlsPerMonth = controlTest;
                    if (i >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                        ctc.ControlsPerMonthBuffer = controlTest;

                    noofControls = ins.Instrument.QuarterlyCtrlTest;
                    controlTest = ((noofControls / (1 - _hemAdditionalTestsDuetoWastage)) * ins.Quantity);
                    if (i == currentQuarter)
                    {
                        currentQuarter += 3;
                        if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                            ctc.ControlsPerQuarter = controlTest;
                        if (i >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                            ctc.ControlsPerQuarterBuffer = controlTest;
                    }

                    //Samples Referred from Elsewhere
                    ctc.SampleReferredTestsForecastPeriod = _hemMonthlyOutputs[i].TestsonInstrumentForecastPeriodFromReferringSites * testRunpercent;
                    ctc.SampleReferredTestsBufferStock = _hemMonthlyOutputs[i].TestsonInstrumentBufferStockFromReferringSites * testRunpercent;

                    noofControls = ins.Instrument.MaxTestBeforeCtrlTest;
                    if (noofControls > 0)
                    {
                        ctc.SampleReferredControlsPerNoOfTests = ctc.SampleReferredTestsForecastPeriod / noofControls;
                        ctc.SampleReferredControlsPerNoOfTestsBuffer = ctc.SampleReferredTestsBufferStock / noofControls;
                    }

                    hemPlat.AddTestAndControl(ctc);
                }

                hemPlat.AddTestAndControl(DoByondForcastCalc(ins, noofTestdays, currentQuarter));
                _hemPlatformTests.Add(hemPlat);
            }
        }

        private double BufferTestBeyondForecast()
        {
            return _hemMonthlyOutputs[12].TotalTestConducted() * PeriodInfo.NumberofBufferMonthsBeyondForecast;
        }

        public double SubtotalBufferTestBeyondForecast()
        {
            double sum = BufferTestBeyondForecast();
            return sum + ((sum / (1 - _hemAdditionalTestsDuetoWastage)) - sum);
        }

        private TestsAndControls DoByondForcastCalc(SiteInstrument ins, int noofTestdays, int currentQuarter)
        {
            double testRunpercent = Convert.ToDouble(ins.TestRunPercentage) / 100d;
            TestsAndControls ctc = new TestsAndControls(13);

                ctc.TestsonInstrumentForecastPeriod = 0;
                ctc.TestsonInstrumentBufferStock = SubtotalBufferTestBeyondForecast() * testRunpercent;

                //Samples Referred from Elsewhere
                ctc.SampleReferredTestsForecastPeriod = 0;
                ctc.SampleReferredTestsBufferStock = _hemTestsReceivedFromReferringSitesBeyondForecast * testRunpercent;

            double noofControls = ins.Instrument.MaxTestBeforeCtrlTest;
            if (noofControls > 0)
            {
                ctc.ControlsPerNoOfTests = 0;
                ctc.ControlsPerNoOfTestsBuffer = (ctc.TestsonInstrumentBufferStock / noofControls);
            }

            noofControls = ins.Instrument.DailyCtrlTest;
            double controlTest = ((noofControls / (1 - _hemAdditionalTestsDuetoWastage)) * testRunpercent) * noofTestdays;
            ctc.ControlsPerDay = 0;
            ctc.ControlsPerDayBuffer = controlTest * PeriodInfo.NumberofBufferMonthsBeyondForecast;

            noofControls = ins.Instrument.WeeklyCtrlTest;
            controlTest = ((noofControls / (1 - _hemAdditionalTestsDuetoWastage)) * testRunpercent) * 4;
            ctc.ControlsPerWeek = 0;
            ctc.ControlsPerWeekBuffer = controlTest * PeriodInfo.NumberofBufferMonthsBeyondForecast;

            noofControls = ins.Instrument.MonthlyCtrlTest;
            controlTest = ((noofControls / (1 - _hemAdditionalTestsDuetoWastage)) * testRunpercent) * 1;
            ctc.ControlsPerMonth = 0;
            ctc.ControlsPerMonthBuffer = controlTest * PeriodInfo.NumberofBufferMonthsBeyondForecast;

            noofControls = ins.Instrument.QuarterlyCtrlTest;
            controlTest = ((noofControls / (1 - _hemAdditionalTestsDuetoWastage)) * testRunpercent);

            int quarter = 0;
            if (currentQuarter == 12)
                quarter = 2;
            else if (currentQuarter == 11)
                quarter = 1;
            else if (currentQuarter == 10)
                quarter = 0;

            ctc.ControlsPerQuarter = 0;
            ctc.ControlsPerQuarterBuffer = Math.Round((PeriodInfo.NumberofBufferMonthsBeyondForecast - quarter) / 3d) * controlTest;

            noofControls = ins.Instrument.MaxTestBeforeCtrlTest;
            if (noofControls > 0)
            {
                ctc.SampleReferredControlsPerNoOfTests = 0;
                ctc.SampleReferredControlsPerNoOfTestsBuffer = ctc.SampleReferredTestsBufferStock / noofControls;
            }

            return ctc;
        }

        private void DoQuantification()
        {
            //DOES THIS SITE RECEIVE hematology SUPPLIES?
            if (ArtSite.ForecastHematology)
            {
                double svalue;
                double sreferralValue;

                #region per test consumable
                IList<ConsumableUsage> pu = DataRepository.GetConsumableUsageByTestArea(_testingArea.Id, QuanifyConsumableBasedOnEnum.PerTest);
                foreach (var pusage in pu)
                {
                    PrimeryQuantifyedReagent pqr = new PrimeryQuantifyedReagent();
                    pqr.ProductId = pusage.Product.Id;
                    pqr.UnitCost = pusage.Product.GetActiveProductPrice(DateTime.Now).Price;
                    pqr.PackSize = pusage.Product.GetActiveProductPrice(DateTime.Now).PackSize;
                    pqr.Unit = pusage.Product.BasicUnit;

                    svalue = (GetTotalHematologyTestForSite() * Convert.ToDouble(pusage.ProductUsageRate)) / pusage.NoOfTest;
                    sreferralValue = (GetTotalHematologyTestForReferral() * Convert.ToDouble(pusage.ProductUsageRate)) / pusage.NoOfTest;

                    double testperpack = Convert.ToDouble(pqr.PackSize / pusage.ProductUsageRate);
                    double valueofmetric = pusage.Product.CollectionSupplieAppliedTo ? svalue : svalue + sreferralValue;
                    if (ArtSite.Site.CD4RefSite > 0 && !pusage.Product.CollectionSupplieAppliedTo)
                        valueofmetric = 0;

                    pqr.Value = testperpack > 0 ? valueofmetric / testperpack : 0;
                    pqr.MinimumQuantity = pusage.Product.MinimumPackSize;
                    _lstPrimaryQuanReagents.AddPrimeryQR(pqr);
                }
                #endregion

                #region Per Period consumable

                IList<ConsumableUsage> pusages = DataRepository.GetConsumableUsageByTestArea(_testingArea.Id, QuanifyConsumableBasedOnEnum.PerPeriod);
                foreach (var pusage in pusages)
                {
                    svalue = 0;
                    switch (pusage.PeriodToEnum)
                    {
                        case PeriodEnum.Daily:
                            svalue = ArtSite.Site.HematologyTestingDaysPerMonth * (PeriodInfo.NumberofBufferMonthsBeyondForecast + PeriodInfo.NumberofMonthsinBudgetPeriod);
                            break;
                        case PeriodEnum.Weekly:
                            svalue = PeriodInfo.WeeksinBudgetPeriod;
                            break;
                        case PeriodEnum.Monthly:
                            svalue = PeriodInfo.NumberofMonthsinBudgetPeriod;
                            break;
                        case PeriodEnum.Quarterly:
                            svalue = PeriodInfo.QuartersinBudgetPeriod;
                            break;
                        case PeriodEnum.Yearly:
                            svalue = 1;
                            break;
                    }

                    PrimeryQuantifyedReagent pqr = new PrimeryQuantifyedReagent();
                    pqr.ProductId = pusage.Product.Id;
                    pqr.UnitCost = pusage.Product.GetActiveProductPrice(DateTime.Now).Price;
                    pqr.PackSize = pusage.Product.GetActiveProductPrice(DateTime.Now).PackSize;
                    pqr.Unit = pusage.Product.BasicUnit;

                    double testperpack = Convert.ToDouble(pqr.PackSize / pusage.ProductUsageRate);
                    pqr.Value = testperpack > 0 ? svalue / testperpack : 0;
                    pqr.MinimumQuantity = pusage.Product.MinimumPackSize;
                    _lstPrimaryQuanReagents.AddPrimeryQR(pqr);
                }
                #endregion

                #region per instrument consumable
                foreach (SiteInstrument ins in ArtSite.Site.GetInstrumentByPlatform(ClassOfMorbidityTestEnum.Hematology))
                {
                    IList<ConsumableUsage> pusagesIns = DataRepository.GetConsumableUsageByTestArea(_testingArea.Id, QuanifyConsumableBasedOnEnum.PerInstrument, ins.Id);
                    foreach (var pusage in pusagesIns)
                    {
                        svalue = 0;
                        switch (pusage.PeriodToEnum)
                        {
                            case PeriodEnum.Daily:
                                svalue = PeriodInfo.WorkingDaysinBudgetPeriod;
                                break;
                            case PeriodEnum.Weekly:
                                svalue = PeriodInfo.WeeksinBudgetPeriod;
                                break;
                            case PeriodEnum.Monthly:
                                svalue = PeriodInfo.NumberofMonthsinBudgetPeriod;
                                break;
                            case PeriodEnum.Quarterly:
                                svalue = PeriodInfo.QuartersinBudgetPeriod;
                                break;
                            case PeriodEnum.Yearly:
                                svalue = 1;
                                break;
                        }

                        svalue = svalue * ins.Quantity;

                        PrimeryQuantifyedReagent pqr = new PrimeryQuantifyedReagent();
                        pqr.ProductId = pusage.Product.Id;
                        pqr.UnitCost = pusage.Product.GetActiveProductPrice(DateTime.Now).Price;
                        pqr.PackSize = pusage.Product.GetActiveProductPrice(DateTime.Now).PackSize;
                        pqr.Unit = pusage.Product.BasicUnit;

                        double testperpack = Convert.ToDouble(pqr.PackSize / pusage.ProductUsageRate);
                        pqr.Value = testperpack > 0 ? svalue / testperpack : 0;
                        pqr.MinimumQuantity = pusage.Product.MinimumPackSize;
                        _lstPrimaryQuanReagents.AddPrimeryQR(pqr);
                    }
                }
                #endregion

                #region test and control-test usage
                foreach (PlatformTestsAndControls cpt in _hemPlatformTests)
                {
                    IList<ProductUsage> list = DataRepository.GetProductUsageByInsId(cpt.InstrumentId);
                    foreach (var pusage in list)
                    {
                        PrimeryQuantifyedReagent pqr = new PrimeryQuantifyedReagent();
                        pqr.ProductId = pusage.Product.Id;
                        pqr.UnitCost = pusage.Product.GetActiveProductPrice(DateTime.Now).Price;
                        pqr.PackSize = pusage.Product.GetActiveProductPrice(DateTime.Now).PackSize;
                        pqr.Unit = pusage.Product.BasicUnit;

                        double SiteValue = 0;
                        double ReferalSiteValue = 0;
                        double testperpack = Convert.ToDouble(pqr.PackSize / pusage.Rate);

                        if (pusage.IsForControl)
                        {
                            SiteValue = cpt.GetSumOfControlsByDuration(pusage.Instrument.ControlTestDurationEnum);
                            if (pusage.Instrument.ControlTestDurationEnum == TestingDurationEnum.PerTest)
                                ReferalSiteValue = cpt.SampleReferredTotalControls();
                        }
                        else
                        {
                            SiteValue = cpt.TotalSumOfTestOnInstrument();
                            ReferalSiteValue = cpt.TotalSumOfSampleReferredTestOnInstrumanet();
                        }

                        double valueofmetric = pusage.Product.CollectionSupplieAppliedTo ? SiteValue : SiteValue + ReferalSiteValue;
                        if (ArtSite.Site.HematologyRefSite > 0 && !pusage.Product.CollectionSupplieAppliedTo)
                            valueofmetric = 0;

                        pqr.Value = testperpack > 0 ? valueofmetric / testperpack : 0;
                        pqr.MinimumQuantity = pusage.Product.MinimumPackSize;
                        _lstPrimaryQuanReagents.AddPrimeryQR(pqr);
                    }
                }
                #endregion

            }
        }

        private double GetTotalHematologyTestForSite()
        {
            double result = 0;
            if (ArtSite.Site.HematologyRefSite == 0)
            {
                foreach (PlatformTestsAndControls cpt in _hemPlatformTests)
                {
                    result += cpt.TotalSumOfTestOnInstrument();
                }

            }
            else
            {
                for (int i = 1; i <= 12; i++)
                {
                    result += _hemMonthlyOutputs[i].TotalHematologyTestsReferred();
                }
            }
            return result;
        }

        private double GetTotalHematologyTestForReferral()
        {
            double result = 0;
            foreach (PlatformTestsAndControls cpt in _hemPlatformTests)
            {
                result += cpt.TotalSumOfSampleReferredTestOnInstrumanet();
            }

            return result;
        }

        private HemaandViralNumberofTest _hemtestNumber;
        public HemaandViralNumberofTest GetHematologyTestNumber()
        {
            _hemtestNumber = new HemaandViralNumberofTest();
            _hemtestNumber.ForecastId = Forecast.Id;
            _hemtestNumber.SiteId = ArtSite.Site.Id;
            _hemtestNumber.Platform = (int)ClassOfMorbidityTestEnum.Hematology;
            if (ArtSite.ForecastHematology)
            {
                for (int i = 1; i <= 12; i++)
                {
                    _hemtestNumber.InvalidTestandWastage += _hemMonthlyOutputs[i].AdditionalTestsdueToWastage;
                    _hemtestNumber.RepeatedDuetoClinicalReq += _hemMonthlyOutputs[i].RepeatDuetoClinicianRequest;
                    _hemtestNumber.SymptomDirectedTests += _hemMonthlyOutputs[i].SymptomDirectedTests;
                    _hemtestNumber.TestBasedOnProtocols += _hemMonthlyOutputs[i].TestsBasedonProtocols;
                }

                foreach (PlatformTestsAndControls ptc in _hemPlatformTests)
                {
                    _hemtestNumber.ReagentstoRunControls += ptc.TotalControlsFP() + ptc.SumOfSampleReferredControlsPerNoOfTests();
                    _hemtestNumber.BufferStockandControls += ptc.TotalControlsBP() + ptc.SumOfSampleReferredControlsPerNoOfTestsBuffer();
                }
            }
            return _hemtestNumber;
        }
    }

}
