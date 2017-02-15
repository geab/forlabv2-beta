
using System;
using System.Collections.Generic;
using LQT.Core.Util;

namespace LQT.Core.Domain
{
	
	/// <summary>
	/// MasterProduct object for NHibernate mapped table 'Fr_MasterProduct'.
	/// </summary>
	public class MasterProduct 
	{
		private static string DEFAULT_CATEGORY = "OTHERS";

		#region Member Variables
		
		private int _id;
		private string _productName;
		private string _serialNo;
		private string _specification;
		private string _basicUnit;
		
		private string _productNote;
		private string _rapidTestGroup;
		private ProductType _productType;
		private IList<ProductPrice> _productPrices;
		private int _minimumPackSize;
        

		#endregion

		#region Constructors

		public MasterProduct() 
		{
			this._id = -1;
            CollectionSupplieAppliedTo = false;
		}

		
		#endregion

		#region Public Properties

		public virtual int Id
		{
			get {return _id;}
			set {_id = value;}
		}

		public virtual string ProductName
		{
			get { return _productName; }
			set
			{
				if ( value != null && value.Length > 150)
					throw new ArgumentOutOfRangeException("Invalid value for ProductName", value, value.ToString());
				_productName = value;
			}
		}

		public virtual string SerialNo
		{
			get { return _serialNo; }
			set
			{
				if ( value != null && value.Length > 16)
					throw new ArgumentOutOfRangeException("Invalid value for SerialNo", value, value.ToString());
				_serialNo = value;
			}
		}

		public virtual string Specification
		{
			get { return _specification; }
			set
			{
				if ( value != null && value.Length > 256)
					throw new ArgumentOutOfRangeException("Invalid value for Specification", value, value.ToString());
				_specification = value;
			}
		}

		public virtual string BasicUnit
		{
			get { return _basicUnit; }
			set
			{
				if ( value != null && value.Length > 16)
					throw new ArgumentOutOfRangeException("Invalid value for BasicUnit", value, value.ToString());
				_basicUnit = value;
			}
		}

	  

		public virtual string ProductNote
		{
			get { return _productNote; }
			set
			{
				if ( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for ProductNote", value, value.ToString());
				_productNote = value;
			}
		}
	   
		public virtual ProductType ProductType
		{
			get { return _productType; }
			set { _productType = value; }
		}

		public virtual string RapidTestGroup
		{
			get { return _rapidTestGroup; }
			set { _rapidTestGroup = value; }
		}
		public virtual TestingSpecificationGroup RapidTestGroupToEnum
		{
			get { return (TestingSpecificationGroup)Enum.Parse(typeof(TestingSpecificationGroup), RapidTestGroup); }
		}
		public static string GetDefaultCategoryName
		{
			get { return DEFAULT_CATEGORY; }
		}

		public virtual IList<ProductPrice> ProductPrices
		{
			get
			{
				if (_productPrices == null)
					_productPrices = new List<ProductPrice>();
				return _productPrices;
			}
			set { _productPrices = value; }
		}

		public virtual int MinimumPackSize
		{
			get
			{ return _minimumPackSize; }
			set { _minimumPackSize = value; }
		}

     
		#endregion

        public virtual bool CollectionSupplieAppliedTo { get; set; }
		public virtual ProductPrice GetActiveProductPrice(DateTime date)
		{
		   
			ProductPrice activeProductPrice = null;
			foreach(ProductPrice p in ProductPrices)
			{
				if (p.FromDate <= date)
				{
					if (activeProductPrice == null)
					{
						activeProductPrice = p;
					}
					else if(p.FromDate > activeProductPrice.FromDate)
					{
						activeProductPrice = p;
					}
				}
                else if (p.FromDate > date)
                {
                    activeProductPrice = p;
                }
				  
			}
			return activeProductPrice;
		}
	   
	}

}
