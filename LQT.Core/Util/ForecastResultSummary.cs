using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.Core.Util
{
    public class ForecastResultSummary
    {
        private decimal _forecastValue;
        private DateTime _forecastDateTime;
        private string _productType;

        public virtual decimal ForecastValue
        {
            get { return _forecastValue; }
            set { _forecastValue = value; }
        }

        public virtual DateTime ForecastDateTime
        {
            get { return _forecastDateTime; }
            set { _forecastDateTime = value; }
        }

        public virtual string ProductType
        {
            get { return _productType; }
            set { _productType = value; }
        }
    }
}
