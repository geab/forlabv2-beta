using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LQT.Core.Util;

namespace LQT.Core.Domain
{
	

	public class MorbiditySupplyProcurement 
	{
		#region Member Variables
		
		private int _id;
        private int _mForecastId;
        private int _platform;
        private double _quantityNeeded;
        private double _quantityInStock;
        private int _productId;
        private double _unitCost;
        private int _packSize;


		#endregion

		#region Constructors

		public MorbiditySupplyProcurement()
		{
            this._id = -1;
		}

		#endregion

		#region Public Properties

        public virtual int Id
		{
			get {return _id;}
			set {_id = value;}
		}

        public virtual int MForecastId
		{
			get { return _mForecastId; }
			set { _mForecastId = value; }
		}

        public virtual int Platform
		{
			get { return _platform; }
			set { _platform = value; }
		}

        public virtual double QuantityNeeded
		{
			get { return _quantityNeeded; }
			set { _quantityNeeded = value; }
		}

        public virtual double QuantityInStock
		{
			get { return _quantityInStock; }
			set { _quantityInStock = value; }
		}

        public virtual int ProductId
		{
			get { return _productId; }
			set { _productId = value; }
		}

        public virtual double UnitCost
		{
            get { return _unitCost; }
            set { _unitCost = value; }
		}

        public virtual int PackSize
		{
			get { return _packSize; }
			set { _packSize = value; }
		}

        public virtual ClassOfMorbidityTestEnum PlatformEnum
        {
            get
            {
                return (ClassOfMorbidityTestEnum)Enum.ToObject(typeof(ClassOfMorbidityTestEnum), _platform);
            }
        }

        public virtual double QuantityToPurchase
        {
            get
            {
                double purchaseQ = _quantityNeeded - _quantityInStock;
                if (purchaseQ < 0)
                    purchaseQ = 0;

                return purchaseQ;
            }
        }

        public virtual double TotalCost
        {
            get
            {
                return QuantityToPurchase * _unitCost;
            }
        }
       
		#endregion

       
    
	}


}
