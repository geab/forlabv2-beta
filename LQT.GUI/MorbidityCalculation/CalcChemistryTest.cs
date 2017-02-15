using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.Util;

namespace LQT.GUI.MorbidityCalculation
{
    public class CalcChemistryTest : BaseCalc
    {
        private double _chemRepeatsduetoClinicianRequest;
        private double _chemAdditionalTestsDuetoWastage;
        private double TotalPatientSamples = 0;
        private double TotalControls = 0;
        
        private IDictionary<int, MOutputChemistryTest> _chemMonthlyOutputs = new Dictionary<int, MOutputChemistryTest>();
        private IList<ChemistryPlatformTests> _chemPlatformTests = new List<ChemistryPlatformTests>();
        //private PlatformQuantifyObject _platformObject;
        private ClassOfChemistryTests _testsReceivedFromReferringSitesBeyondForecast;
        private TestingArea _testingArea;
        public CalcChemistryTest(ARTSite site, MorbidityForecast forecast, BudgetPeriodInfo periodinfo, int target)
            : base(site, forecast, periodinfo, target)
        {
            _lstPrimaryQuanReagents = new ListOfPrimeryQR(ClassOfMorbidityTestEnum.Chemistry);            
        }
        
        public Dictionary<int, CalculatedSitePatientNumber> CalculatedPatientNos { get; set; }
            public TestingArea TestingArea
            {
                set { _testingArea = value; }
            }

        public IDictionary<int, MOutputChemistryTest> GetChemistryTestOutputs
        {
            get { return _chemMonthlyOutputs; }
        }

        public void DoCalculation()
        {
            CalcInstrumentDetailsAndControls();
            DoQuantification();
        }

        public void CalculateTestConducted()
        {
            CalculateChemistryTestConducted();
        }

        private void CalculateChemistryTestConducted()
        {
            _chemRepeatsduetoClinicianRequest = (ChemTestProtocol.TestReapeated / 100d);
            _chemAdditionalTestsDuetoWastage = (InvAssumption.Chemistry / 100d);

            for (int i = 1; i <= 12; i++)
            {
                MOutputChemistryTest chemOut = new MOutputChemistryTest();
                chemOut.Month = i;

                foreach (PSymptomDirectedTest sdt in ChemTestProtocol.SymptomDirectedTests)
                {
                    ChemistrySymptomDirectedTest csdt = new ChemistrySymptomDirectedTest();
                    csdt.TestId = sdt.Test.Id;
                    csdt.AdultSymptomDirectTest = (CurrentAdultinTreatment * (sdt.AdultInTreatmeant / 100d)) / 12d;
                    csdt.PedSymptomDirectTest = (CurrentPediatricinTreatment * (sdt.PediatricInTreatmeant / 100d)) / 12d;
                    csdt.PreArtAdultSymptomDirectTest = (CurrentAdultinPreArt * (sdt.AdultPreART / 100d)) / 12d;
                    csdt.PreArtPedSymptomDirectTest = (CurrentPediatricinPreArt * (sdt.PediatricPreART / 100d)) / 12d;
                    csdt.RepeatPercent = _chemRepeatsduetoClinicianRequest;

                    chemOut.ChemSymptomDirectedTest.Add(csdt);
                }

                foreach (ProtocolPanel panel in ChemTestProtocol.ProtocolPanels)
                {
                    ChemistryTestByPannel chemp = new ChemistryTestByPannel();

                    chemp.ExistingAdultPatientsinTreatment = CalculatedPatientNos[i].ArtAdultPreExistingPatients * panel.AdultInTreatmentDistribution;
                    chemp.ExistingPedPatientsinTreatment = CalculatedPatientNos[i].ArtPediatricPreExistingPatients * panel.PediatricInTreatmentDistribution; // ((pediatricsinTreatment / 12d) * preExistingPatientsonPanel);
                    chemp.ExistingAdultPatientsinPreArt = CalculatedPatientNos[i].PreArtAdultPreExistingPatients * panel.AdultPreARTDistribution;
                    chemp.ExistingPedPatientsinPreArt = CalculatedPatientNos[i].PreArtPediatricPreExistingPatients * panel.PediatricPreARTDistribution;

                    for (int x = 1, y = i; x <= i; x++, y--)
                    {
                        chemp.NewAdultPatientstoTreatment += CalculatedPatientNos[i].GetArtAdultPatientsEntering(x) * panel.AdultArtTestGivenInMonth(y) * (panel.AITNewPatient/100d);
                        chemp.NewPedPatientstoTreatment += CalculatedPatientNos[i].GetArtPediatricPatientsEntering(x) * panel.PediatricArtTestGivenInMonth(y) * (panel.PITNewPatient/100d);
                        chemp.NewAdultPatientstoPreArt += CalculatedPatientNos[i].GetPreArtAdultPatientsEntering(x) * panel.AdultPreArtTestGivenInMonth(y) * (panel.APARTNewPatient/100d);
                        chemp.NewPedPatientstoPreArt += CalculatedPatientNos[i].GetPreArtPediatricPatientsEntering(x) * panel.PediatricPreArtTestGivenInMonth(y) * (panel.PPARTNewPatient/100d);
                    }

                    //ChemistryTestNameEnum[] chemtest = LqtUtil.EnumToArray<ChemistryTestNameEnum>();

                    //for (int z = 0; z < chemtest.Length; z++)
                    foreach (Test t in _testingArea.Tests)
                    {
                        double tconducted = 0d;
                        if (panel.IsTestSelected(t.Id))
                        {
                            tconducted = chemp.TotalTestsForRegimen();
                        }
                        chemp.SetChemTestValue(t.Id, tconducted);
                        if (chemOut.GetChemSymptomDirectedTestById(t.Id) != null)
                            chemOut.GetChemSymptomDirectedTestById(t.Id).TestConducted += tconducted;
                    }
                    chemOut.ChemTestByPanel.Add(chemp);
                }

                _chemMonthlyOutputs.Add(i, chemOut);
            }

            double adultPatientEnterPerMonth = 0d;
            double pedPatientEnterPerMonth = 0d;
            double preAdultPatientEnterPerMonth = 0d;
            double prePedPatientEnterPerMonth = 0d;

            foreach (PSymptomDirectedTest sdt in ChemTestProtocol.SymptomDirectedTests)
            {
                for (int i = 1; i <= 12; i++)
                {
                    ChemistrySymptomDirectedTest csdt = _chemMonthlyOutputs[i].GetChemSymptomDirectedTestById(sdt.Test.Id);
                    adultPatientEnterPerMonth = (CalculatedPatientNos[i].GetArtAdultPatientsEntering(i) * (sdt.AdultInTreatmeant / 100d)) / 12d;
                    csdt.AdultSymptomDirectTest += adultPatientEnterPerMonth;
                    pedPatientEnterPerMonth = (CalculatedPatientNos[i].GetArtPediatricPatientsEntering(i) * (sdt.PediatricInTreatmeant / 100d)) / 12d;
                    csdt.PedSymptomDirectTest += pedPatientEnterPerMonth;

                    preAdultPatientEnterPerMonth = (CalculatedPatientNos[i].GetPreArtAdultPatientsEntering(i) * (sdt.AdultPreART / 100d)) / 12d;
                    csdt.PreArtAdultSymptomDirectTest += preAdultPatientEnterPerMonth;
                    prePedPatientEnterPerMonth = (CalculatedPatientNos[i].GetPreArtPediatricPatientsEntering(i) * (sdt.PediatricPreART / 100d)) / 12d;
                    csdt.PreArtPedSymptomDirectTest += prePedPatientEnterPerMonth;

                    for (int x = i + 1; x <= 12; x++)
                    {
                        ChemistrySymptomDirectedTest ct = _chemMonthlyOutputs[x].GetChemSymptomDirectedTestById(sdt.Test.Id);
                        ct.AdultSymptomDirectTest += adultPatientEnterPerMonth;
                        ct.PedSymptomDirectTest += pedPatientEnterPerMonth;
                        ct.PreArtAdultSymptomDirectTest += preAdultPatientEnterPerMonth;
                        ct.PreArtPedSymptomDirectTest += prePedPatientEnterPerMonth;
                    }

                    if (1 >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                        csdt.TestBasedonProtocol = csdt.GetCalculatedTotalTest();
                    if (1 >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                        csdt.TestsforBufferStock = csdt.GetCalculatedTotalTest();

                    csdt.AdditionalTestsdueToWastage = csdt.TestBasedonProtocol * _chemAdditionalTestsDuetoWastage;
                    csdt.AdditionalTestsdueToWastageBeyondForecast = csdt.TestsforBufferStock * _chemAdditionalTestsDuetoWastage;
                }
            }

            for (int i = 2; i <= 13; i++)
            {
                if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                    _chemMonthlyOutputs[i - 1].TotalChemistrySamplesWithinForecastPeriod = _chemMonthlyOutputs[i - 1].GetSumOfTotalChemistrySamples();
                else
                    _chemMonthlyOutputs[i - 1].TotalChemistrySamplesWithinForecastPeriod = 0d;
                if (i >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                    _chemMonthlyOutputs[i - 1].TotalChemistrySamplesWithinBufferStock = _chemMonthlyOutputs[i - 1].GetSumOfTotalChemistrySamples();
                else
                    _chemMonthlyOutputs[i - 1].TotalChemistrySamplesWithinBufferStock = 0d;
            }

        }
        /// <summary>
        /// sample referral
        /// </summary>
        /// <param name="result"></param>
        public void SetTestsReceivedFromReferringSites(ClassOfChemistryTests[] result)
        {
            //ChemistryTestNameEnum[] chemTests = LqtUtil.EnumToArray<ChemistryTestNameEnum>();

            for (int i = 1; i <= 12; i++)
            {
                //for (int x = 0; x < chemTests.Length; x++)
                foreach(Test t in _testingArea.Tests)
                {
                    ChemistrySymptomDirectedTest csdt = _chemMonthlyOutputs[i].GetChemSymptomDirectedTestById(t.Id);
                    if ((i + 1) >= PeriodInfo.FirstMonth && (i + 1) <= PeriodInfo.LastMonth)
                        csdt.TestsonInstrumentForecastPeriodFromReferringSites = result[i - 1].GetChemTestValue(t.Id);

                    if ((i + 1) > PeriodInfo.LastMonth)
                        csdt.TestsonInstrumentBufferStockFromReferringSites = result[i - 1].GetChemTestValue(t.Id);
                }

                if ((i + 1) >= PeriodInfo.FirstMonth && (i + 1) <= PeriodInfo.LastMonth)
                    _chemMonthlyOutputs[i].TotalSampleForecastPeriodRecivedFromReferrSites = result[i - 1].TotalSamples;
                if ((i + 1) > PeriodInfo.LastMonth)
                    _chemMonthlyOutputs[i].TotalSampleBufferStockRecivedFromReferrSites = result[i - 1].TotalSamples;
            }

            _testsReceivedFromReferringSitesBeyondForecast = result[12];
        }

        private void CalcInstrumentDetailsAndControls()
        {
            int noofControls;
            int noofTestdays = ArtSite.Site.ChemistryTestingDaysPerMonth;
            double testRunpercent;
            double controlTest = 0;

            foreach (SiteInstrument ins in ArtSite.Site.GetInstrumentByPlatform(ClassOfMorbidityTestEnum.Chemistry))
            {
                ChemistryPlatformTests chemPlat = new ChemistryPlatformTests();
                chemPlat.InstrumentId = ins.Instrument.Id;
                chemPlat.Quantity = ins.Quantity;
                testRunpercent = Convert.ToDouble(ins.TestRunPercentage) / 100d;

                int currentQuarter = PeriodInfo.FirstMonth;

                for (int i = 1; i <= 12; i++)
                {
                    ChemistryTestsAndControls ctc = new ChemistryTestsAndControls(i);
                    foreach (ChemistrySymptomDirectedTest csdt in _chemMonthlyOutputs[i].ChemSymptomDirectedTest)
                    {
                        ChemistryTestOnInstrument cti = new ChemistryTestOnInstrument();
                        cti.TestId = csdt.TestId;
                        cti.TestsonInstrumentForecastPeriod = csdt.SubtotalOfTestBasedonProtocol* testRunpercent;
                        cti.TestsonInstrumentBufferStock = csdt.SubtotalOfTestForBufferStock * testRunpercent;

                        //Samples Referred from Elsewhere
                        cti.SampleReferredTestsForecastPeriod = csdt.TestsonInstrumentForecastPeriodFromReferringSites * testRunpercent;
                        cti.SampleReferredTestsBufferStock = csdt.TestsonInstrumentBufferStockFromReferringSites * testRunpercent;

                        ctc.ChemTestsOnInstrument.Add(cti);
                    }

                    noofControls = ins.Instrument.MaxTestBeforeCtrlTest;
                    if (noofControls > 0)
                    {
                        ctc.ControlsPerNoOfTests = (_chemMonthlyOutputs[i].TotalChemistrySamplesWithinForecastPeriod / noofControls);
                        ctc.ControlsPerNoOfTestsBuffer = (_chemMonthlyOutputs[i].TotalChemistrySamplesWithinBufferStock / noofControls);
                    }

                    noofControls = ins.Instrument.DailyCtrlTest;
                    controlTest = ((noofControls / (1 - _chemAdditionalTestsDuetoWastage)) * ins.Quantity) * noofTestdays;
                    if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                        ctc.ControlsPerDay = controlTest;
                    if (i >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                        ctc.ControlsPerDayBuffer = controlTest;

                    noofControls = ins.Instrument.WeeklyCtrlTest;
                    controlTest = ((noofControls / (1 - _chemAdditionalTestsDuetoWastage)) * ins.Quantity) * 4;
                    if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                        ctc.ControlsPerWeek = controlTest;
                    if (i >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                        ctc.ControlsPerWeekBuffer = controlTest;

                    noofControls = ins.Instrument.MonthlyCtrlTest;
                    controlTest = ((noofControls / (1 - _chemAdditionalTestsDuetoWastage)) * ins.Quantity) * 1;
                    if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                        ctc.ControlsPerMonth = controlTest;
                    if (i >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                        ctc.ControlsPerMonthBuffer = controlTest;

                    noofControls = ins.Instrument.QuarterlyCtrlTest;
                    controlTest = ((noofControls / (1 - _chemAdditionalTestsDuetoWastage)) * ins.Quantity);
                    if (i == currentQuarter)
                    {
                        currentQuarter += 3;
                        if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                            ctc.ControlsPerQuarter = controlTest;
                        if (i >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                            ctc.ControlsPerQuarterBuffer = controlTest;
                    }

                    ctc.TotalSamplesFP = _chemMonthlyOutputs[i].TotalChemistrySamplesWithinForecastPeriod * testRunpercent;
                    ctc.TotalSamplesBS = _chemMonthlyOutputs[i].TotalChemistrySamplesWithinBufferStock * testRunpercent;

                    ctc.SampleReferredTotalSamplesFP = _chemMonthlyOutputs[i].TotalSampleForecastPeriodRecivedFromReferrSites * testRunpercent;
                    ctc.SampleReferredTotalSamplesBS = _chemMonthlyOutputs[i].TotalSampleBufferStockRecivedFromReferrSites * testRunpercent;

                    noofControls = ins.Instrument.MaxTestBeforeCtrlTest;
                    if (noofControls > 0)
                    {
                        ctc.SampleReferredControlsPerNoOfTests = _chemMonthlyOutputs[i].TotalSampleForecastPeriodRecivedFromReferrSites / noofControls;
                        ctc.SampleReferredControlsPerNoOfTestsBuffer = _chemMonthlyOutputs[i].TotalSampleBufferStockRecivedFromReferrSites / noofControls;
                    }
                    chemPlat.AddTestAndControl(ctc);
                }

                chemPlat.AddTestAndControl(DoByondForcastCalc(ins, noofTestdays, currentQuarter));
                _chemPlatformTests.Add(chemPlat);
            }
        }

        public double TotalChemistrySamplesBeyoundForecast()
        {
            return _chemMonthlyOutputs[12].GetSumOfTotalChemistrySamples() * PeriodInfo.NumberofBufferMonthsBeyondForecast;
        }

        public double BufferTestBeyondForecast(int testId)
        {
            return _chemMonthlyOutputs[12].GetSumOfChemTest(testId) * PeriodInfo.NumberofBufferMonthsBeyondForecast;
        }

        public double SubtotalBufferTestBeyondForecast(int testId)
        {
            double sum = BufferTestBeyondForecast(testId);
            return sum + (sum * _chemAdditionalTestsDuetoWastage);
        }

        private ChemistryTestsAndControls DoByondForcastCalc(SiteInstrument ins, int noofTestdays, int currentQuarter)
        {
            double testRunpercent = Convert.ToDouble(ins.TestRunPercentage) / 100d;
            ChemistryTestsAndControls ctc = new ChemistryTestsAndControls(13);
            foreach (ChemistrySymptomDirectedTest csdt in _chemMonthlyOutputs[12].ChemSymptomDirectedTest)
            {
                ChemistryTestOnInstrument cti = new ChemistryTestOnInstrument();
                cti.TestId = csdt.TestId;
                cti.TestsonInstrumentForecastPeriod = 0;
                cti.TestsonInstrumentBufferStock = SubtotalBufferTestBeyondForecast(csdt.TestId) * testRunpercent;

                //Samples Referred from Elsewhere
                cti.SampleReferredTestsForecastPeriod = 0;
                cti.SampleReferredTestsBufferStock = _testsReceivedFromReferringSitesBeyondForecast.GetChemTestValue(csdt.TestId) * testRunpercent; 

                ctc.ChemTestsOnInstrument.Add(cti);
            }

            double noofControls = ins.Instrument.MaxTestBeforeCtrlTest;
            if (noofControls > 0)
            {
                ctc.ControlsPerNoOfTests = 0;
                ctc.ControlsPerNoOfTestsBuffer = (TotalChemistrySamplesBeyoundForecast() / noofControls);
            }

            noofControls = ins.Instrument.DailyCtrlTest;
            double controlTest = ((noofControls / (1 - _chemAdditionalTestsDuetoWastage)) * testRunpercent) * noofTestdays;
            ctc.ControlsPerDay = 0;
            ctc.ControlsPerDayBuffer = controlTest * PeriodInfo.NumberofBufferMonthsBeyondForecast;

            noofControls = ins.Instrument.WeeklyCtrlTest;
            controlTest = ((noofControls / (1 - _chemAdditionalTestsDuetoWastage)) * testRunpercent) * 4;
            ctc.ControlsPerWeek = 0;
            ctc.ControlsPerWeekBuffer = controlTest * PeriodInfo.NumberofBufferMonthsBeyondForecast;

            noofControls = ins.Instrument.MonthlyCtrlTest;
            controlTest = ((noofControls / (1 - _chemAdditionalTestsDuetoWastage)) * testRunpercent) * 1;
            ctc.ControlsPerMonth = 0;
            ctc.ControlsPerMonthBuffer = controlTest * PeriodInfo.NumberofBufferMonthsBeyondForecast;

            noofControls = ins.Instrument.QuarterlyCtrlTest;
            controlTest = ((noofControls / (1 - _chemAdditionalTestsDuetoWastage)) * testRunpercent);

            int quarter = 0;
            if (currentQuarter == 12)
                quarter = 2;
            else if (currentQuarter == 11)
                quarter = 1;
            else if (currentQuarter == 10)
                quarter = 0;

            ctc.ControlsPerQuarter = 0;
            ctc.ControlsPerQuarterBuffer = ((PeriodInfo.NumberofBufferMonthsBeyondForecast - quarter) / 3) * controlTest;

            ctc.TotalSamplesFP = 0;
            ctc.TotalSamplesBS = TotalChemistrySamplesBeyoundForecast() * testRunpercent;

            ctc.SampleReferredTotalSamplesFP = 0;
            ctc.SampleReferredTotalSamplesBS = _testsReceivedFromReferringSitesBeyondForecast.TotalSamples * testRunpercent;

            ctc.SampleReferredControlsPerNoOfTests = 0;
            noofControls = ins.Instrument.MaxTestBeforeCtrlTest;
            if (noofControls > 0)
            {   
                ctc.SampleReferredControlsPerNoOfTestsBuffer = ctc.SampleReferredTotalSamplesBS / noofControls;
            }
            return ctc;
        }

        private void DoQuantification()
        {
            //DOES THIS SITE RECEIVE Chemistry SUPPLIES?
            if (ArtSite.ForecastChemistry)
            {
                InitTotalValues();
                               
                #region per test consumable
                
                foreach (Test t in _testingArea.Tests)
                {
                    if (GetTotalValues(t.Id) > 0)
                    {
                        IList<ConsumableUsage> pu = DataRepository.GetConsumableUsageByTestId(t.Id, QuanifyConsumableBasedOnEnum.PerTest);
                        foreach (var pusage in pu)
                        {
                            PrimeryQuantifyedReagent pqr = new PrimeryQuantifyedReagent();
                            pqr.ProductId = pusage.Product.Id;
                            pqr.UnitCost = pusage.Product.GetActiveProductPrice(DateTime.Now).Price;
                            pqr.PackSize = pusage.Product.GetActiveProductPrice(DateTime.Now).PackSize;
                            pqr.Unit = pusage.Product.BasicUnit;

                            double svalue = (GetTotalValues(t.Id) * Convert.ToDouble(pusage.ProductUsageRate)) / pusage.NoOfTest;
                            double sreferralValue = 0;

                            double testperpack = Convert.ToDouble(pqr.PackSize / pusage.ProductUsageRate);
                            double valueofmetric = pusage.Product.CollectionSupplieAppliedTo ? svalue : svalue + sreferralValue;
                            if (ArtSite.Site.CD4RefSite > 0 && !pusage.Product.CollectionSupplieAppliedTo)
                                valueofmetric = 0;

                            pqr.Value = testperpack > 0 ? valueofmetric / testperpack : 0;
                            pqr.MinimumQuantity = pusage.Product.MinimumPackSize;
                            _lstPrimaryQuanReagents.AddPrimeryQR(pqr);
                        }
                    }
                }
                #endregion

                #region Per Period consumable
                                
                IList<ConsumableUsage> pusages = DataRepository.GetConsumableUsageByTestArea(_testingArea.Id, QuanifyConsumableBasedOnEnum.PerPeriod);
                foreach (var pusage in pusages)
                {
                     double svalue = 0;
                    switch (pusage.PeriodToEnum)
                    {
                        case PeriodEnum.Daily:
                            svalue = ArtSite.Site.ChemistryTestingDaysPerMonth * (PeriodInfo.NumberofBufferMonthsBeyondForecast + PeriodInfo.NumberofMonthsinBudgetPeriod);
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
                foreach (SiteInstrument ins in ArtSite.Site.GetInstrumentByPlatform(ClassOfMorbidityTestEnum.Chemistry))
                {
                    IList<ConsumableUsage> pusagesIns = DataRepository.GetConsumableUsageByTestArea(_testingArea.Id, QuanifyConsumableBasedOnEnum.PerInstrument, ins.Id);
                    foreach (var pusage in pusagesIns)
                    {
                         double svalue = 0;
                        switch (pusage.PeriodToEnum)
                        {
                            case PeriodEnum.Daily:
                                svalue = ArtSite.Site.ChemistryTestingDaysPerMonth * (PeriodInfo.NumberofBufferMonthsBeyondForecast + PeriodInfo.NumberofMonthsinBudgetPeriod);
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
                foreach (ChemistryPlatformTests cpt in _chemPlatformTests)
                {
                    #region test usage
                    foreach (Test t in _testingArea.Tests)
                    {
                        if (ParameterIncluded(t.Id))
                        {
                            IList<ProductUsage> list = DataRepository.GetProductUsageByInsId(cpt.InstrumentId, false);
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

                                SiteValue = cpt.TotalTestsOnInstrument(t.Id);
                                double valueofmetric = pusage.Product.CollectionSupplieAppliedTo ? SiteValue : SiteValue + ReferalSiteValue;
                                if (ArtSite.Site.ChemistryRefSite > 0 && !pusage.Product.CollectionSupplieAppliedTo)
                                    valueofmetric = 0;

                                pqr.Value = testperpack > 0 ? valueofmetric / testperpack : 0;
                                pqr.MinimumQuantity = pusage.Product.MinimumPackSize;
                                _lstPrimaryQuanReagents.AddPrimeryQR(pqr);

                            }
                        }
                    }
                    #endregion

                    #region control test usage
                    IList<ProductUsage> conlist = DataRepository.GetProductUsageByInsId(cpt.InstrumentId, true);
                    foreach (var pusage in conlist)
                    {
                        PrimeryQuantifyedReagent pqr = new PrimeryQuantifyedReagent();
                        pqr.ProductId = pusage.Product.Id;
                        pqr.UnitCost = pusage.Product.GetActiveProductPrice(DateTime.Now).Price;
                        pqr.PackSize = pusage.Product.GetActiveProductPrice(DateTime.Now).PackSize;
                        pqr.Unit = pusage.Product.BasicUnit;

                        double SiteValue = 0;
                        double ReferalSiteValue = 0;
                        double testperpack = Convert.ToDouble(pqr.PackSize / pusage.Rate);

                        SiteValue = cpt.GetSumOfControlsByDuration(pusage.Instrument.ControlTestDurationEnum);

                        double valueofmetric = pusage.Product.CollectionSupplieAppliedTo ? SiteValue : SiteValue + ReferalSiteValue;
                        if (ArtSite.Site.ChemistryRefSite > 0 && !pusage.Product.CollectionSupplieAppliedTo)
                            valueofmetric = 0;

                        pqr.Value = testperpack > 0 ? valueofmetric / testperpack : 0;
                        pqr.MinimumQuantity = pusage.Product.MinimumPackSize;
                        _lstPrimaryQuanReagents.AddPrimeryQR(pqr);

                    }

                    #endregion
                }
                #endregion
            }
        }

        private void InitTotalValues()
        {
            if (ArtSite.Site.ChemistryRefSite == 0)
            {
                foreach (ChemistryPlatformTests cpt in _chemPlatformTests)
                {
                    TotalPatientSamples += cpt.TotalSmaples();
                    TotalControls += cpt.TotalControls();
                }
            }
            else
            {
                for (int i = 1; i <= 12; i++)
                {
                    MOutputChemistryTest moc = _chemMonthlyOutputs[i];
                    TotalPatientSamples += moc.TotalChemistrySamplesWithinForecastPeriod + moc.TotalChemistrySamplesWithinBufferStock;
                }
            }
        }
        private double GetTotalValues(int testid)
        {
            double totalv = 0d;
            if (ArtSite.Site.ChemistryRefSite == 0)
            {
                foreach (ChemistryPlatformTests cpt in _chemPlatformTests)
                {                    
                    if (ParameterIncluded(testid))
                        totalv += cpt.TotalTestsOnInstrument(testid);
                }

            }
            else
            {
                for (int i = 1; i <= 12; i++)
                {
                    MOutputChemistryTest moc = _chemMonthlyOutputs[i];
                    totalv += moc.GetChemSymptomDirectedTestById(testid).TestBasedonProtocol + moc.GetChemSymptomDirectedTestById(testid).TestsforBufferStock;
                }
            }
            return totalv;
        }

        private bool ParameterIncluded(int testId)
        {
            foreach (ProtocolPanel pp in ChemTestProtocol.ProtocolPanels)
            {
                if (pp.IsTestSelected(testId))
                    return true;
            }

            PSymptomDirectedTest psdt = ChemTestProtocol.GetSymptomDirectedTestByTestId(testId);
            if (psdt != null)
                return psdt.SumOfSymptomDirected() > 0;

            return false;
        }

        private IList<ChemandOtherNumberofTest> _chemtestNumber;
        public IList<ChemandOtherNumberofTest> GetChemistryTestNumber()
        {
            _chemtestNumber = new List<ChemandOtherNumberofTest>();
            if (ArtSite.ForecastChemistry)
            {
                foreach (PSymptomDirectedTest sdt in ChemTestProtocol.SymptomDirectedTests)
                {
                    ChemandOtherNumberofTest ct = new ChemandOtherNumberofTest();
                    ct.ForecastId = Forecast.Id;
                    ct.SiteId = ArtSite.Site.Id;
                    ct.Platform = (int)ClassOfMorbidityTestEnum.Chemistry;
                    ct.TestId = sdt.Test.Id;
                    //ct.TestName = sdt.ChemTestName;

                    for (int i = 1; i <= 12; i++)
                    {
                        ChemistrySymptomDirectedTest csdt = _chemMonthlyOutputs[i].GetChemSymptomDirectedTestById(sdt.Test.Id);
                        ct.InvalidTestandWastage += csdt.AdditionalTestsdueToWastage;
                        ct.RepeatedDuetoClinicalReq += csdt.RepeatedDuetoClinicianRequest();
                        ct.SymptomDirectedTests += csdt.TotalSymptomDirectTest();
                        ct.TestBasedOnProtocols += _chemMonthlyOutputs[i].GetSumOfChemTest(sdt.Test.Id);
                        //ct.TestBasedOnProtocols += csdt.TestBasedonProtocol;
                    }

                    foreach (ChemistryPlatformTests ptc in  _chemPlatformTests)
                    {
                        if (ct.TestBasedOnProtocols > 0)
                        {
                            ct.ReagentstoRunControls += ptc.TotalControlsFP() + ptc.SampleReferredTotalControlsFP();
                            ct.BufferStock += ptc.TotalControlsBP() + ptc.SampleReferredTotalControlsBP();
                        }
                        else
                        {
                            ct.ReagentstoRunControls = 0;
                            ct.BufferStock += ptc.TotalControlsBP();
                        }
                    }
                    _chemtestNumber.Add(ct);
                }
            }
            return _chemtestNumber;
        }

        /*
        private void DoQuantification()
        {
            //DOES THIS SITE RECEIVE Chemistry SUPPLIES?
            if (ArtSite.ForecastChemistry)
            {
                InitTotalValues();
                int allChemQMid = 0;
                double value, allChemInsQty = 0;
                foreach (QuantifyMenu qm in _platformObject.GeneralQuantifyMenus)
                {
                    value = 0;
                    if (qm.Title == GeneralQuantifyMenuEnum.Total_Chemistry_Patient_Samples_Run_On_All_Instruments.ToString())
                        value = TotalPatientSamples;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_Chemistry_controls_for_all_instruments.ToString())
                        value = TotalControls;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_ALP_Tests_on_all_instruments.ToString())
                        value = TotalALP;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_ALT_Tests_on_all_instruments.ToString())
                        value = TotalALT;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_AMY_Tests_on_all_instruments.ToString())
                        value = TotalAMY;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_AST_Tests_on_all_instruments.ToString())
                        value = TotalAST;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_CHO_Tests_on_all_instruments.ToString())
                        value = TotalCHO;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_CO2_Tests_on_all_instruments.ToString())
                        value = TotalCO2;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_CRE_Tests_on_all_instruments.ToString())
                        value = TotalCRE;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_Electrolyte_Panel_tests_on_all_instruments.ToString())
                        value = TotalElectrolyte;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_GGT_Tests_on_all_instruments.ToString())
                        value = TotalGGT;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_GLC_Tests_on_all_instruments.ToString())
                        value = TotalGLC;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_TG_Tests_on_all_instruments.ToString())
                        value = TotalTG;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Total_Urea_tests_on_all_instruments.ToString())
                        value = TotalUrea;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Per_Instrument_All_Chemistry_Instruments.ToString())
                        allChemQMid = qm.Id;
                    else if (qm.Title == GeneralQuantifyMenuEnum.Per_Day_All_Chemistry_Instruments.ToString() && _chemPlatformTests.Count > 0)
                        value = ArtSite.Site.ChemistryTestingDaysPerMonth * (PeriodInfo.NumberofBufferMonthsBeyondForecast + PeriodInfo.NumberofMonthsinBudgetPeriod);

                    if (value > 0)
                    {
                        QMenuWithValue qval = new QMenuWithValue();
                        qval.QuantifyMenuId = qm.Id;
                        qval.SiteValue = value;
                        qval.ReferalSiteValue = 0;
                        _listOfQMenuWithValue.Add(qval);
                    }
                }

                ChemistryTestNameEnum[] chemTests = LqtUtil.EnumToArray<ChemistryTestNameEnum>();
                TestingDurationEnum[] tduration = LqtUtil.EnumToArray<TestingDurationEnum>();

                foreach (ChemistryPlatformTests cpt in _chemPlatformTests)
                {
                    allChemInsQty += cpt.Quantity;

                    CTestPlatformQuantifyMenu pqm = (CTestPlatformQuantifyMenu)_platformObject.GetPlatformQuantifyMenuByInsId(cpt.InstrumentId);
                    if (pqm != null)
                    {
                        QMenuWithValue qval = new QMenuWithValue();
                        qval.QuantifyMenuId = pqm.TotalPatientSamplesRunOnIns;
                        qval.SiteValue = cpt.TotalSmaples();
                        qval.ReferalSiteValue = 0;
                        _listOfQMenuWithValue.Add(qval);

                        qval = new QMenuWithValue();
                        qval.QuantifyMenuId = pqm.GetQuantifyMenuId(TestTypeEnum.PerInstrument);
                        qval.SiteValue = cpt.Quantity;
                        qval.ReferalSiteValue = 0;
                        _listOfQMenuWithValue.Add(qval);

                        qval = new QMenuWithValue();
                        qval.QuantifyMenuId = pqm.GetQuantifyMenuId(TestTypeEnum.PerDay);
                        qval.SiteValue = ArtSite.Site.ChemistryTestingDaysPerMonth * (PeriodInfo.NumberofBufferMonthsBeyondForecast + PeriodInfo.NumberofMonthsinBudgetPeriod);
                        qval.ReferalSiteValue = 0;
                        _listOfQMenuWithValue.Add(qval);

                        for (int i = 0; i < chemTests.Length; i++)
                        {

                            if (ParameterIncluded(chemTests[i]))
                            {
                                qval = new QMenuWithValue();
                                qval.QuantifyMenuId = pqm.GetChemQuantifyMenuId(chemTests[i]);
                                qval.SiteValue = cpt.TotalTestsOnInstrument(chemTests[i]);
                                qval.ReferalSiteValue = 0;
                                _listOfQMenuWithValue.Add(qval);
                            }
                        }

                        for (int i = 0; i < tduration.Length; i++)
                        {
                            qval = new QMenuWithValue();
                            qval.QuantifyMenuId = pqm.GetQuantifyMenuId(tduration[i]);
                            qval.SiteValue = cpt.GetSumOfControlsByDuration(tduration[i]);
                            qval.ReferalSiteValue = 0;
                            _listOfQMenuWithValue.Add(qval);
                        }
                    }
                }

                //Per Instrument - All Chemistry Instruments
                QMenuWithValue qv = new QMenuWithValue();
                qv.QuantifyMenuId = allChemQMid;
                qv.SiteValue = allChemInsQty;
                qv.ReferalSiteValue = 0;
                _listOfQMenuWithValue.Add(qv);

                foreach (QMenuWithValue qm in _listOfQMenuWithValue)
                {
                    IList<QuantificationMetric> list = _platformObject.GetQuanMetricByQuanMenuId(qm.QuantifyMenuId);

                    foreach (QuantificationMetric r in list)
                    {
                        PrimeryQuantifyedReagent pqr = new PrimeryQuantifyedReagent();
                        pqr.ProductId = r.Product.Id;
                        pqr.UnitCost = r.Product.GetActiveProductPrice(DateTime.Now).Price;
                        pqr.PackSize = r.Product.GetActiveProductPrice(DateTime.Now).PackSize;
                        pqr.Unit = r.Product.BasicUnit;

                        double testperpack = r.Product.GetActiveProductPrice(DateTime.Now).PackSize / r.UsageRate;
                        double valueofmetric = r.CollectionSupplieAppliedTo == CollectionSupplieAppliedToEnum.Collection.ToString() ? qm.SiteValue : qm.TotalValue;
                        if (ArtSite.Site.ChemistryRefSite > 0 && r.CollectionSupplieAppliedTo == CollectionSupplieAppliedToEnum.Testing.ToString())
                            valueofmetric = 0;
                        pqr.Value = testperpack > 0 ? valueofmetric / testperpack : 0;
                        pqr.MinimumQuantity = r.Product.MinimumPackSize;
                        _lstPrimaryQuanReagents.AddPrimeryQR(pqr);
                    }
                }
            }
        }
        */
    }
}
