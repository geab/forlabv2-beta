using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.Core.Domain
{
    public class Consumption
    {
        private decimal _total;
        private int _noconsumption;

        public Consumption(int noc, decimal totalc)
        {
            _noconsumption = noc;
            _total = totalc;
        }

        public int NoConsumption
        {
            get { return _noconsumption; }
        }
        public decimal TotalConsumption
        {
            get { return _total; }
        }
    }
}
