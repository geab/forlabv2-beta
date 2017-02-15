
using System;
using System.Collections;
using LQT.Core.Util;

namespace LQT.Core.Domain
{
	
	/// <summary>
	/// ProductType object for NHibernate mapped table 'Fr_ProductType'.
	/// </summary>
	public class ProductType 
	{
		#region Member Variables
		
		private int _id;
		private string _typeName;
		private string _description;
		private IList _products;
        private Boolean _useInDemography;
        private string _classOfTest;

		#endregion

		#region Constructors

		public ProductType() 
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

        public virtual string TypeName
		{
			get { return _typeName; }
			set
			{
				if ( value != null && value.Length > 64)
					throw new ArgumentOutOfRangeException("Invalid value for TypeName", value, value.ToString());
				_typeName = value;
			}
		}

        public virtual string Description
		{
			get { return _description; }
			set
			{
				if ( value != null && value.Length > 256)
					throw new ArgumentOutOfRangeException("Invalid value for Description", value, value.ToString());
				_description = value;
			}
		}

        public virtual string ClassOfTest
        {
            get { return _classOfTest; }
            set { _classOfTest = value; }
        }
        public virtual ClassOfMorbidityTestEnum ClassOfTestToEnum
        {
            get { return (ClassOfMorbidityTestEnum)Enum.Parse(typeof(ClassOfMorbidityTestEnum), ClassOfTest); }
        }
        public virtual IList Products
		{
			get
			{
				if (_products==null)
				{
					_products = new ArrayList();
				}
				return _products;
			}
			set { _products = value; }
		}
        /// <summary>
        /// Use in demograpy
        /// </summary>
        public virtual Boolean UseInDemography
        {
            get { return _useInDemography; }
            set { _useInDemography = value; }
        }

        
		#endregion
		
       
	}

}
