using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LQT.Core.Util;

namespace LQT.Core.Domain
{
    public class ConsumableUsage
    {
        #region Member Variables

        private int _id;
        private MasterConsumable _consumable;
        private Boolean _perTest;
        private Boolean _perPeriod;
        private Boolean _perInstrument;
        private int _noOfTest;
        private MasterProduct _product;
        private decimal _productUsageRate;
        private string _period;
        private Instrument _instrument;
        
        #endregion

        public ConsumableUsage() 
		{
			this._id = -1;
		}

        #region Public Properties

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual MasterConsumable MasterConsumable
        {
            get { return _consumable; }
            set { _consumable = value; }
        }

        public virtual Boolean PerTest
        {
            get { return _perTest; }
            set { _perTest = value; }
        }

        public virtual Boolean PerPeriod
        {
            get { return _perPeriod; }
            set { _perPeriod = value; }
        }

        public virtual Boolean PerInstrument
        {
            get { return _perInstrument; }
            set { _perInstrument = value; }
        }

        public virtual int NoOfTest
        {
            get { return _noOfTest; }
            set { _noOfTest = value; }
        }
       
        public virtual MasterProduct Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public virtual decimal ProductUsageRate
        {
            get { return _productUsageRate; }
            set { _productUsageRate = value; }
        }
       
        public virtual string Period
        {
            get { return _period; }
            set { _period = value; }
        }

        public virtual PeriodEnum PeriodToEnum
        {
            get
            {
                return (PeriodEnum)Enum.Parse(typeof(PeriodEnum), Period, true);
            }
        }
        public virtual Instrument Instrument
        {
            get { return _instrument; }
            set { _instrument = value; }
        }

        public virtual int TestingAreaId { get; set; }
        public virtual string QuanifyBasedOn { get; set; }
        public virtual int TestId { get; set; }
        #endregion
    
    }
}
