using System;
using System.Collections.Generic;


namespace LQT.Core.Domain
{
    public interface IBaseDataUsage
    {
        int Id
        {
            get;
            set;
        }
        decimal AmountUsed
        {
            get;
            set;
        }

        string CDuration
        {
            get;
            set;
        }

        int StockOut
        {
            get;
            set;
        }

        decimal Adjusted
        {
            get;
            set;
        }

        Test Test
        {
            get;
            set;
        }

        MasterProduct Product
        {
            get;
            set;
        }
        DateTime? DurationDateTime
        {
            get;
            set;
        }

        int InstrumentDowntime
        {
            get;
            set;
        }
    }
}
