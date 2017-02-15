using System;
using System.Collections.Generic;
using System.Text;

using LQT.Core.Domain;

namespace LQT.Core.Util
{
    public class rmPlatformValidation
    {
        private ARTSite _site;
        public bool CD4Selected;
        public bool CD4Refred;
        
        public IList<CategorizedSitePlatform> CD4Paltfroms;

        public int LargestPlatformCount()
        {
            int temp = 0;
            if (_site.Site.GetInstrumentByPlatform(ClassOfMorbidityTestEnum.CD4).Count > temp) //if (CD4Paltfroms.Count > temp)
                temp = _site.Site.GetInstrumentByPlatform(ClassOfMorbidityTestEnum.CD4).Count;

            return temp;
        }

        public bool HasPlatform(ClassOfMorbidityTestEnum ctest)
        {
            return NoOfPlatform(ctest) > 0;
            //_site.ForecastCD4
        }

        public int NoOfPlatform(ClassOfMorbidityTestEnum ctest)
        {
            return _site.Site.GetInstrumentByPlatform(ctest).Count;

            //int no = 0;
            //switch (ctest)
            //{
            //    case ClassOfMorbidityTestEnum.CD4:
            //        no = CD4Paltfroms.Count;
            //        break;
            //}
            //return no;
        }
    }

    public class CategorizedSitePlatform
    {
        public ClassOfMorbidityTestEnum ClassOfTest;
        public int InstrumentId;
        public string InstrumentName;
        public int Quantity;
        public double Percent;

        public CategorizedSitePlatform(string calssOftest, int insId, string insName, int qty, double percent)
        {
            ClassOfTest = (ClassOfMorbidityTestEnum)Enum.Parse(typeof(ClassOfMorbidityTestEnum), calssOftest);
            InstrumentId = insId;
            InstrumentName = insName;
            Quantity = qty;
            Percent = percent;
        }
    }

}
