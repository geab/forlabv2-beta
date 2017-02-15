﻿using System;
using System.Collections.Generic;
using System.Text;

using LQT.Core;
using LQT.Core.Util;
using LQT.Core.Domain;

namespace LQT.GUI.MorbidityCalculation
{
    public class MorbidityCalculater
    {
        #region propertys

        private MorbidityForecast _forecast;
        private IList<ARTSite> _artSites;
        private InventoryAssumption _invAssumption;
        
        private Protocol _cd4Protocol;
        private Protocol _cheProtocol;
        private Protocol _hemProtocol;
        private Protocol _vilProtocol;
        private Protocol _othProtocol;
        private bool _isProtocolInitalized = false;
        private PlatformFactory _platformFactory;

        private int _targetSelected;
        private RapidTestAlgorithm _rapidTestAlgorithm;
        private BudgetPeriodInfo _peridoInfo;

        private IDictionary<int, ArtSiteCalculated> _artsiteCalculated;
        private IDictionary<int, MorbidityCalcContainer> _listOfMorbidityCalcContainers;

        public delegate void PerformMorbidityCalculationOnSite(int counter , PerformMorbidityCalculationArgs args);
        public event PerformMorbidityCalculationOnSite UpdateCalculationEvent;

        #endregion

        public MorbidityCalculater(MorbidityForecast forecast, IList<ARTSite> artsites, InventoryAssumption invAssumption)
        {
            this._forecast = forecast;
            this._artSites = artsites;
            this._invAssumption = invAssumption;
        }

        public IDictionary<int, ArtSiteCalculated> GetListOfArtSiteCalculated
        {
            get { return _artsiteCalculated; }
        }

        public int TargetSelected
        {
            get { return _targetSelected; }
            set { _targetSelected = value; }
        }

        public RapidTestAlgorithm RapidTestAlgorithm
        {
            get { return _rapidTestAlgorithm; }
            set { _rapidTestAlgorithm = value; }
        }

        public BudgetPeriodInfo BudgetPeridoInfo
        {
            get { return _peridoInfo; }
            set { _peridoInfo = value; }
        }
        
        public bool IsProtocolInitalized
        {
            get { return _isProtocolInitalized; }
        }

        public TestingArea CD4TestingArea { get; set; }
        public TestingArea ChemistryTestingArea { get; set; }
        public TestingArea HematologyTestingArea { get; set; }
        public TestingArea ViralLoadTestingArea { get; set; }
        public TestingArea OtherTestTestingArea { get; set; }
        //public TestingArea ConsumableTestingArea { get; set; }

        public void InitForCalculation()
        {
            if (_platformFactory == null)
                _platformFactory = new PlatformFactory();

            if (!_isProtocolInitalized)
                InitProtocols();

            if(_listOfMorbidityCalcContainers != null)
            {
                _listOfMorbidityCalcContainers.Clear();
                _listOfMorbidityCalcContainers = null;
            }
            _listOfMorbidityCalcContainers = new Dictionary<int, MorbidityCalcContainer>();

            if (_artsiteCalculated != null)
            {
                _artsiteCalculated.Clear();
                _artsiteCalculated = null;
            }
            _artsiteCalculated = new Dictionary<int, ArtSiteCalculated>();
        }

        public void CalculateTestConducted()
        {
            int count =1;
            foreach (ARTSite site in _artSites)
            {
                if (UpdateCalculationEvent != null)
                    UpdateCalculationEvent(count, new PerformMorbidityCalculationArgs() { SiteName = site.Site.SiteName, ArgumentType = 1 });
                count++;
                _peridoInfo.WorkingDaysinBudgetPeriod = _peridoInfo.NumberofMonthsinBudgetPeriod * site.Site.MaxWorkingDays();

                CalcPatientNumber calcPatientNo = new CalcPatientNumber(site, _forecast, _peridoInfo, _targetSelected);
                calcPatientNo.DoCalculation();

                ArtSiteCalculated scalculated = new ArtSiteCalculated(site.Site.Id);
                scalculated.SiteName = site.Site.SiteName;
                Dictionary<int, CalculatedSitePatientNumber> pNumbers = calcPatientNo.CalculatedPatientNumbers;
                scalculated.PatientNumbers = pNumbers;

                PatientsNoofTest ptest = new PatientsNoofTest();
                ptest.SiteId = site.Site.Id;
                ptest.ForecastId = _forecast.Id;
                for (int i = 1; i <= 12; i++)
                {
                    ptest.SetArtPatinetNumber(i, pNumbers[i].TotalPatinetInTreatment());
                    ptest.SetPreArtPatinetNumber(i, pNumbers[i].TotalPatientInPreART());
                }

                scalculated.PatinetNoOfTest = ptest;
                //--------------------end patient numbers----------------------

                CalcRapidTest calcRapid = new CalcRapidTest(site, _forecast, _peridoInfo, _targetSelected, _rapidTestAlgorithm);
                calcRapid.CalculatedPatientNos = pNumbers;
                calcRapid.RapidTestPlatformQuantifyObject = _platformFactory.RapidTestPlatform;
                InitBaseCalcValue(calcPatientNo, calcRapid);
                calcRapid.DoCalculation();

                scalculated.RapidNumberofTest = calcRapid.RapidNumberofTest();
                CopySupplyForecast(calcRapid.QuantifyedReagents(), scalculated.TestReagents);

                //--------------------end rapid test----------------------

                MorbidityCalcContainer mcalcContainer = new MorbidityCalcContainer(site.Site.Id);
                //--------------------init container----------------------

                CalcCD4Test calcCd4 = new CalcCD4Test(site, _forecast, _peridoInfo, _targetSelected);
                calcCd4.CalculatedPatientNos = pNumbers;
                calcCd4.TestingArea = CD4TestingArea;
                calcCd4.RapidTestOutputs = calcRapid.RapidTestOutputs;
                calcCd4.CD4TestProtocol = _cd4Protocol;
                InitBaseCalcValue(calcPatientNo, calcCd4);

                calcCd4.CalculateTestConducted();
                mcalcContainer.CD4Calculation = calcCd4;
                mcalcContainer.CD4ReferedSites = DataRepository.GetListOfReferedSites(scalculated.SiteId, ClassOfMorbidityTestEnum.CD4.ToString());

                //--------------------end CD4 test----------------------

                CalcHematology calcHema = new CalcHematology(site, _forecast, _peridoInfo, _targetSelected);
                calcHema.CalculatedPatientNos = pNumbers;
                calcHema.TestingArea = HematologyTestingArea;
                calcHema.HemTestProtocol = _hemProtocol;
                InitBaseCalcValue(calcPatientNo, calcHema);

                calcHema.CalculateTestConducted();
                mcalcContainer.HematologyCalculation = calcHema;
                mcalcContainer.HemaReferedSites = DataRepository.GetListOfReferedSites(scalculated.SiteId, ClassOfMorbidityTestEnum.Hematology.ToString());


                //--------------------end Hema test----------------------

                CalcViralLoad calcVl = new CalcViralLoad(site, _forecast, _peridoInfo, _targetSelected);
                calcVl.CalculatedPatientNos = pNumbers;
                calcVl.TestingArea = ViralLoadTestingArea;
                calcVl.VLTestProtocol = _vilProtocol;
                InitBaseCalcValue(calcPatientNo, calcVl);

                calcVl.CalculateTestConducted();
                mcalcContainer.ViralLoadCalculation = calcVl;
                mcalcContainer.ViraReferedSites = DataRepository.GetListOfReferedSites(scalculated.SiteId, ClassOfMorbidityTestEnum.ViralLoad.ToString());


                //--------------------end VL test----------------------

                CalcChemistryTest calcChem = new CalcChemistryTest(site, _forecast, _peridoInfo, _targetSelected);
                calcChem.CalculatedPatientNos = pNumbers;
                calcChem.TestingArea = ChemistryTestingArea;
                calcChem.ChemTestProtocol = _cheProtocol;
                InitBaseCalcValue(calcPatientNo, calcChem);

                calcChem.CalculateTestConducted();
                mcalcContainer.ChemistryCalculation = calcChem;
                mcalcContainer.ChemReferedSites = DataRepository.GetListOfReferedSites(scalculated.SiteId, ClassOfMorbidityTestEnum.Chemistry.ToString());


                //--------------------end Chemistry test----------------------

                CalcConsumable calcCon = new CalcConsumable(site, _forecast, _peridoInfo, _targetSelected);
                calcCon.CalculatedPatientNos = pNumbers;
                calcCon.ConsumablePlatformQuantifyObject = _platformFactory.ConsumablePlatform;
                calcCon.CD4MonthlyOutputs = calcCd4.GetCD4TestOutputs;
                calcCon.RapidTestOutputs = calcRapid.RapidTestOutputs;

                calcCon.RapidTestCalculator = calcRapid;
                calcCon.CD4TestCalculator = calcCd4;
                calcCon.ChemistryTestCalculator = calcChem;
                calcCon.HematologyTestCalculator = calcHema;
                calcCon.ViralTestCalculator = calcVl;

                InitBaseCalcValue(calcPatientNo, calcCon);
                mcalcContainer.ConsumableCalculation = calcCon;

                //--------------------end Consumable----------------------

                CalcOtherTest calcOth = new CalcOtherTest(site, _forecast, _peridoInfo, _targetSelected);
                calcOth.CalculatedPatientNos = pNumbers;
                calcOth.TestingArea = OtherTestTestingArea;
                calcOth.CalculatedConsumable = calcCon;
                calcOth.OtherTestProtocol = _othProtocol;

                InitBaseCalcValue(calcPatientNo, calcOth);
                mcalcContainer.OtherTestCalculation = calcOth;

                //--------------------end Other test----------------------

                _artsiteCalculated.Add(scalculated.SiteId, scalculated);
                _listOfMorbidityCalcContainers.Add(mcalcContainer.SiteId, mcalcContainer);
            }
        }

        public void ForecastCalculatedTestContacted()
        {
            int count = 1;
            foreach (ArtSiteCalculated scalculated in _artsiteCalculated.Values)
            {
                if (UpdateCalculationEvent != null)
                    UpdateCalculationEvent(count, new PerformMorbidityCalculationArgs() { SiteName = scalculated.SiteName, ArgumentType = 2 });
                count++;
                MorbidityCalcContainer mcalcContainer = _listOfMorbidityCalcContainers[scalculated.SiteId];
                mcalcContainer.CD4Calculation.SetTestsReceivedFromReferringSites(GetCalculatedReferred(mcalcContainer.CD4ReferedSites, ClassOfMorbidityTestEnum.CD4));

                mcalcContainer.CD4Calculation.DoCalculation();
                scalculated.CD4TestNumber = mcalcContainer.CD4Calculation.GetCD4TestNumber();
                CopySupplyForecast(mcalcContainer.CD4Calculation.QuantifyedReagents(), scalculated.TestReagents);

                mcalcContainer.HematologyCalculation.SetTestsReceivedFromReferringSites(GetCalculatedReferred(mcalcContainer.HemaReferedSites, ClassOfMorbidityTestEnum.Hematology));
                mcalcContainer.HematologyCalculation.DoCalculation();
                scalculated.HematologyTestNumber = mcalcContainer.HematologyCalculation.GetHematologyTestNumber();
                CopySupplyForecast(mcalcContainer.HematologyCalculation.QuantifyedReagents(), scalculated.TestReagents);

                mcalcContainer.ViralLoadCalculation.SetTestsReceivedFromReferringSites(GetCalculatedReferred(mcalcContainer.ViraReferedSites, ClassOfMorbidityTestEnum.ViralLoad));
                mcalcContainer.ViralLoadCalculation.DoCalculation();
                scalculated.ViralLodTestNumber = mcalcContainer.ViralLoadCalculation.GetViralLoadTestNumber();
                CopySupplyForecast(mcalcContainer.ViralLoadCalculation.QuantifyedReagents(), scalculated.TestReagents);

                mcalcContainer.ChemistryCalculation.SetTestsReceivedFromReferringSites(GetCalculatedReferredForChemistry(mcalcContainer.ChemReferedSites));
                mcalcContainer.ChemistryCalculation.DoCalculation();
                scalculated.ChemistryTestNumber = mcalcContainer.ChemistryCalculation.GetChemistryTestNumber();
                CopySupplyForecast(mcalcContainer.ChemistryCalculation.QuantifyedReagents(), scalculated.TestReagents);

                mcalcContainer.ConsumableCalculation.DoCalculation();
                CopySupplyForecast(mcalcContainer.ConsumableCalculation.QuantifyedReagents(), scalculated.TestReagents);

                mcalcContainer.OtherTestCalculation.DoCalculation();
                scalculated.OtherTestNumber = mcalcContainer.OtherTestCalculation.GetOtherTestNumber();
                CopySupplyForecast(mcalcContainer.OtherTestCalculation.QuantifyedReagents(), scalculated.TestReagents);
            }
        }

        private void InitBaseCalcValue(BaseCalc calcPatientNo, BaseCalc calcNew)
        {
            calcNew.CurrentAdultinPreArt = calcPatientNo.CurrentAdultinPreArt;
            calcNew.CurrentAdultinTreatment = calcPatientNo.CurrentAdultinTreatment;
            calcNew.CurrentPediatricinPreArt = calcPatientNo.CurrentPediatricinPreArt;
            calcNew.CurrentPediatricinTreatment = calcPatientNo.CurrentPediatricinTreatment;

            calcNew.InvAssumption = _invAssumption;
        }

        private void CopySupplyForecast(IList<MorbiditySupplyForecast> source, IList<MorbiditySupplyForecast> destination)
        {
            foreach (MorbiditySupplyForecast sp in source)
            {
                destination.Add(sp);
            }
        }

        private void InitProtocols()
        {
            //try
            //{
                if (!_isProtocolInitalized)
                {
                    _cd4Protocol = DataRepository.GetProtocolByPlatform((int)ClassOfMorbidityTestEnum.CD4);
                    _cheProtocol = DataRepository.GetProtocolByPlatform((int)ClassOfMorbidityTestEnum.Chemistry);
                    _hemProtocol = DataRepository.GetProtocolByPlatform((int)ClassOfMorbidityTestEnum.Hematology);
                    _vilProtocol = DataRepository.GetProtocolByPlatform((int)ClassOfMorbidityTestEnum.ViralLoad);
                    _othProtocol = DataRepository.GetProtocolByPlatform((int)ClassOfMorbidityTestEnum.OtherTest);
                }

                //if (_cd4Protocol == null || _cheProtocol == null || _hemProtocol == null || _othProtocol == null || _vilProtocol == null)
                //    _isProtocolInitalized = false;
                //else
                    _isProtocolInitalized = true;
            //}
            //catch
            //{
            //    _isProtocolInitalized = false;
            //}
        }
         
        private double[] GetCalculatedReferred(IList<int> siteIds, ClassOfMorbidityTestEnum test)
        {
            double[] result = new double[] { 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d };

            foreach (int id in siteIds)
            {
                MorbidityCalcContainer m = _listOfMorbidityCalcContainers[id];
                switch (test)
                {
                    case ClassOfMorbidityTestEnum.CD4:
                        for (int i = 1; i <= 12; i++)
                        {
                            result[i - 1] += m.CD4Calculation.GetCD4TestOutputs[i].TotalCD4TestsReferred();
                        }

                        result[12] += m.CD4Calculation.SubtotalBufferTestBeyondForecast();
                        break;
                    case ClassOfMorbidityTestEnum.Hematology:
                        for (int i = 1; i <= 12; i++)
                        {
                            result[i - 1] += m.HematologyCalculation.GetHematologyTestOutputs[i].TotalHematologyTestsReferred();
                        }

                        result[12] += m.HematologyCalculation.SubtotalBufferTestBeyondForecast();
                        break;
                    case ClassOfMorbidityTestEnum.ViralLoad:
                        for (int i = 1; i <= 12; i++)
                        {
                            result[i - 1] += m.ViralLoadCalculation.GetViralTestOutputs[i].TotalVLTestsReferred();
                        }

                        result[12] += m.ViralLoadCalculation.SubtotalBufferTestBeyondForecast();
                        break;
                }
            }
            return result;
        }

        private ClassOfChemistryTests[] GetCalculatedReferredForChemistry(IList<int> siteIds)
        {
            ClassOfChemistryTests[] result = new ClassOfChemistryTests[13];
            for (int i = 0; i <= 12; i++)
            {
                result[i] = new ClassOfChemistryTests();
            }
            foreach (int id in siteIds)
            {
                MorbidityCalcContainer m = _listOfMorbidityCalcContainers[id];
                for (int i = 1; i <= 12; i++)
                {
                    ClassOfChemistryTests ctest = result[i - 1];
                    foreach (ChemistrySymptomDirectedTest csdt in m.ChemistryCalculation.GetChemistryTestOutputs[i].ChemSymptomDirectedTest)
                    {
                        ctest.SetChemTestValue(csdt.TestId, ctest.GetChemTestValue(csdt.TestId) + csdt.TestsReferredtoAnotherFacility);
                    }
                    ctest.TotalSamples += m.ChemistryCalculation.GetChemistryTestOutputs[i].TotalChemistrySamples;
                }

                ClassOfChemistryTests cbeyond = result[12];
                foreach (ChemistrySymptomDirectedTest csdt in m.ChemistryCalculation.GetChemistryTestOutputs[1].ChemSymptomDirectedTest)
                {
                    cbeyond.SetChemTestValue(csdt.TestId, cbeyond.GetChemTestValue(csdt.TestId) + m.ChemistryCalculation.SubtotalBufferTestBeyondForecast(csdt.TestId));
                }
                cbeyond.TotalSamples += m.ChemistryCalculation.TotalChemistrySamplesBeyoundForecast();
            }
            return result;
        }

    }

   
}
