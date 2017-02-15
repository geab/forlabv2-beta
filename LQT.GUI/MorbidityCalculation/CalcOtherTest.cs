using System;
using System.Collections.Generic;

using LQT.Core.Domain;
using LQT.Core.Util;

namespace LQT.GUI.MorbidityCalculation
{
    public class CalcOtherTest : BaseCalc
    {
        private double _othrRepeatsduetoClinicianRequest;
        private double _othAdditionalTestsDuetoWastage;

        private IDictionary<int, QuantifyedReagent> _chemReagents = new Dictionary<int, QuantifyedReagent>();
        private IDictionary<int, MOutputOtherTest> _othMonthlyOutputs = new Dictionary<int, MOutputOtherTest>();

        //private PlatformQuantifyObject _platformObject;
        private TestingArea _testingArea;

        public CalcOtherTest(ARTSite site, MorbidityForecast forecast, BudgetPeriodInfo periodinfo, int target)
            : base(site, forecast, periodinfo, target)
        {
            _lstPrimaryQuanReagents = new ListOfPrimeryQR(ClassOfMorbidityTestEnum.OtherTest);
        }

        public Dictionary<int, CalculatedSitePatientNumber> CalculatedPatientNos { get; set; }
        public TestingArea TestingArea
        {
            set { _testingArea = value; }
        }
        public CalcConsumable CalculatedConsumable { get; set; }

        public void DoCalculation()
        {
            CalculateOtherTest();
            DoQuantification();
        }

        private void CalculateOtherTest()
        {
            _othrRepeatsduetoClinicianRequest = (OtherTestProtocol.TestReapeated / 100d);
            _othAdditionalTestsDuetoWastage = (InvAssumption.OtherTests / 100d);

            for (int i = 1; i <= 12; i++)
            {
                MOutputOtherTest otherOut = new MOutputOtherTest();
                otherOut.Month = i;

                foreach (PSymptomDirectedTest sdt in OtherTestProtocol.SymptomDirectedTests)
                {
                    OtherSymptomDirectedTest csdt = new OtherSymptomDirectedTest();
                    csdt.TestId = sdt.Test.Id;
                    csdt.AdultSymptomDirectTest = (CurrentAdultinTreatment * (sdt.AdultInTreatmeant/100d)) / 12d;
                    csdt.PedSymptomDirectTest = (CurrentPediatricinTreatment * (sdt.PediatricInTreatmeant/100d)) / 12d;
                    csdt.PreArtAdultSymptomDirectTest = (CurrentAdultinPreArt * (sdt.AdultPreART/100d)) / 12d;
                    csdt.PreArtPedSymptomDirectTest = (CurrentPediatricinPreArt * (sdt.PediatricPreART / 100d)) / 12d;
                    csdt.RepeatPercent = _othrRepeatsduetoClinicianRequest;

                    otherOut.OtherSymptomDirectedTest.Add(csdt);
                }

                foreach (ProtocolPanel panel in OtherTestProtocol.ProtocolPanels)
                {
                    OtherTestByPannel othpanel = new OtherTestByPannel();

                    othpanel.ExistingAdultPatientsinTreatment = CalculatedPatientNos[i].ArtAdultPreExistingPatients * panel.AdultInTreatmentDistribution;
                    othpanel.ExistingPedPatientsinTreatment = CalculatedPatientNos[i].ArtPediatricPreExistingPatients * panel.PediatricInTreatmentDistribution;
                    othpanel.ExistingAdultPatientsinPreArt = CalculatedPatientNos[i].PreArtAdultPreExistingPatients * panel.AdultPreARTDistribution;
                    othpanel.ExistingPedPatientsinPreArt = CalculatedPatientNos[i].PreArtPediatricPreExistingPatients * panel.PediatricPreARTDistribution;

                    for (int x = 1, y = i; x <= i; x++, y--)
                    {
                        othpanel.NewAdultPatientstoTreatment += CalculatedPatientNos[i].GetArtAdultPatientsEntering(x) * panel.AdultArtTestGivenInMonth(y) * (panel.AITNewPatient/100d);
                        othpanel.NewPedPatientstoTreatment += CalculatedPatientNos[i].GetArtPediatricPatientsEntering(x) * panel.AdultPreArtTestGivenInMonth(y) * (panel.PITNewPatient/100d);
                        othpanel.NewAdultPatientstoPreArt += CalculatedPatientNos[i].GetPreArtAdultPatientsEntering(x) * panel.PediatricArtTestGivenInMonth(y) * (panel.APARTNewPatient/100d);
                        othpanel.NewPedPatientstoPreArt += CalculatedPatientNos[i].GetPreArtPediatricPatientsEntering(x) * panel.PediatricPreArtTestGivenInMonth(y) * (panel.PPARTNewPatient / 100d);
                    }

                    //OtherTestNameEnum[] othtest = LqtUtil.EnumToArray<OtherTestNameEnum>();

                    //for (int x = 0; x < othtest.Length;x++ )
                    foreach(Test t in _testingArea.Tests)
                    {
                        double tconducted = 0d;
                        if (panel.IsTestSelected(t.Id))
                        {
                            tconducted = othpanel.TotalTestsForRegimen();
                        }
                        othpanel.SetOtherTestValue(t.Id, tconducted);
                        otherOut.GetOtherSymptomDirectedTestById(t.Id).TestConducted += tconducted;
                    }
                    otherOut.OtherTestByPanel.Add(othpanel);
                }

                _othMonthlyOutputs.Add(i, otherOut);
            }

            double adultPatientEnterPerMonth = 0d;
            double pedPatientEnterPerMonth = 0d;
            double preAdultPatientEnterPerMonth = 0d;
            double prePedPatientEnterPerMonth = 0d;

            foreach (PSymptomDirectedTest sdt in OtherTestProtocol.SymptomDirectedTests)
            {
                for (int i = 1; i <= 12; i++)
                {
                    OtherSymptomDirectedTest csdt = _othMonthlyOutputs[i].GetOtherSymptomDirectedTestById(sdt.Test.Id);
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
                        OtherSymptomDirectedTest ct = _othMonthlyOutputs[x].GetOtherSymptomDirectedTestById(sdt.Test.Id);
                        ct.AdultSymptomDirectTest += adultPatientEnterPerMonth;
                        ct.PedSymptomDirectTest += pedPatientEnterPerMonth;
                        ct.PreArtAdultSymptomDirectTest += preAdultPatientEnterPerMonth;
                        ct.PreArtPedSymptomDirectTest += prePedPatientEnterPerMonth;
                    }

                    if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                        csdt.TotalTest = csdt.GetCalculatedTotalTest();
                    if (i >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                        csdt.TestsforBufferStock = csdt.GetCalculatedTotalTest();

                    csdt.AdditionalTestsdueToWastage = csdt.TotalTest * _othAdditionalTestsDuetoWastage;
                    csdt.AdditionalTestsdueToWastageBeyondForecast = csdt.TestsforBufferStock * _othAdditionalTestsDuetoWastage;
                }
            }

            for (int i = 1; i <= 12; i++)
            {
                if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                    _othMonthlyOutputs[i].TotalOtherSamplesWithinForecastPeriod = _othMonthlyOutputs[i].GetSumOfTotalOtherSamples();
                else
                    _othMonthlyOutputs[i].TotalOtherSamplesWithinForecastPeriod = 0d;
                if (i >= PeriodInfo.BeginsOnmonth && i <= PeriodInfo.EndOnMonth)
                    _othMonthlyOutputs[i].TotalOtherSamplesWithinBufferStock = _othMonthlyOutputs[i].GetSumOfTotalOtherSamples();
                else
                    _othMonthlyOutputs[i].TotalOtherSamplesWithinBufferStock = 0d;
            }

           
        }

        private double TotalSamplesBeyoundForecast()
        {
            return _othMonthlyOutputs[12].GetSumOfTotalOtherSamples() * PeriodInfo.NumberofBufferMonthsBeyondForecast;
        }

        private double BufferTestBeyondForecast(int testId)
        {
            return _othMonthlyOutputs[12].GetSumOfOtherTest(testId) * PeriodInfo.NumberofBufferMonthsBeyondForecast;
        }

        private double SubtotalBufferTestBeyondForecast(int testId)
        {
            double sum = BufferTestBeyondForecast(testId);
            return sum + (sum * _othAdditionalTestsDuetoWastage);
        }
               
        private void DoQuantification()
        {
            //DOES THIS SITE RECEIVE Chemistry SUPPLIES?
            if (ArtSite.ForecastOtherTest)
            {
                #region test usage
                foreach (Test t in _testingArea.Tests)
                {
                    double svalue = GetSumofTest(t.Id);
                    if (svalue == 0)
                        continue;

                    IList<ProductUsage> list = DataRepository.GetProductUsageByTestId(t.Id, false);
                    foreach (var pusage in list)
                    {
                        PrimeryQuantifyedReagent pqr = new PrimeryQuantifyedReagent();
                        pqr.ProductId = pusage.Product.Id;
                        pqr.UnitCost = pusage.Product.GetActiveProductPrice(DateTime.Now).Price;
                        pqr.PackSize = pusage.Product.GetActiveProductPrice(DateTime.Now).PackSize;
                        pqr.Unit = pusage.Product.BasicUnit;

                        double testperpack = Convert.ToDouble(pqr.PackSize / pusage.Rate);
                        pqr.Value = testperpack > 0 ? svalue / testperpack : 0;
                        pqr.MinimumQuantity = pusage.Product.MinimumPackSize;
                        _lstPrimaryQuanReagents.AddPrimeryQR(pqr);
                    }
                }

                #endregion
            }
        }

        private double GetSumofTest(int testId)
        {
            double result = 0d;
            for (int i = 1; i <= 12; i++)
            {
                result += _othMonthlyOutputs[i].GetOtherSymptomDirectedTestById(testId).TestsReferredtoAnotherFacility;
                
            }
            result += SubtotalBufferTestBeyondForecast(testId);
            return result;
        }

        private IList<ChemandOtherNumberofTest> _othtestNumber;
        public IList<ChemandOtherNumberofTest> GetOtherTestNumber()
        {
            _othtestNumber = new List<ChemandOtherNumberofTest>();
            if (ArtSite.ForecastOtherTest)
            {
                foreach (PSymptomDirectedTest sdt in OtherTestProtocol.SymptomDirectedTests)
                {
                    ChemandOtherNumberofTest ct = new ChemandOtherNumberofTest();
                    ct.ForecastId = Forecast.Id;
                    ct.SiteId = ArtSite.Site.Id;
                    ct.Platform = (int)ClassOfMorbidityTestEnum.OtherTest;
                    ct.TestId = sdt.Test.Id;
                    //ct.TestName = sdt.OtherTestName;

                    for (int i = 1; i <= 12; i++)
                    {
                        OtherSymptomDirectedTest csdt = _othMonthlyOutputs[i].GetOtherSymptomDirectedTestById(sdt.Test.Id);
                        ct.InvalidTestandWastage += csdt.AdditionalTestsdueToWastage;
                        
                        if (i >= PeriodInfo.FirstMonth && i <= PeriodInfo.LastMonth)
                        {
                            ct.TestBasedOnProtocols += csdt.TestConducted; //_othMonthlyOutputs[i].GetSumOfOtherTest(sdt.OtherTestNameToEnum); 
                            ct.SymptomDirectedTests += csdt.TotalSymptomDirectTest();
                            ct.RepeatedDuetoClinicalReq += (csdt.TestConducted + csdt.TotalSymptomDirectTest()) *_othrRepeatsduetoClinicianRequest;
                        }

                        ct.BufferStock += csdt.SubtotalOfTestForBufferStock;
                    }

                    _othtestNumber.Add(ct);
                }
            }
            return _othtestNumber;
        }
    }
}
