
using System;
using System.Collections;
using LQT.Core.Util;

namespace LQT.Core.Domain
{	
	/// <summary>
	/// ForecastCategoryProduct object for NHibernate mapped table 'ForecastCategoryProduct'.
	/// </summary>
    public class ForecastCategoryProduct : BaseDataUsage, IBaseDataUsage,  System.IComparable
	{
		#region Member Variables
		

		private ForecastCategory _category;
        private static String _sortExpression = "DurationDateTime";
        private static SortDirection _sortDirection = SortDirection.Descending;

		#endregion

		#region Constructors

		public ForecastCategoryProduct() 
		{

		}

		
		#endregion

		#region Public Properties

		
		public virtual ForecastCategory Category
		{
			get { return _category; }
			set { _category = value; }
		}

        public static String SortExpression
        {
            get { return _sortExpression; }
            set { _sortExpression = value; }
        }

        public static SortDirection SortDirection
        {
            get { return _sortDirection; }
            set { _sortDirection = value; }
        }

        #endregion

        #region IComparable Methods

        public int CompareTo(object obj)
        {
            if (!(obj is ForecastSiteProduct))
                throw new InvalidCastException("This object is not of type ForecastSiteProduct");

            int relativeValue;
            switch (SortExpression)
            {
                case "Id":
                    relativeValue = this.Id.CompareTo(((ForecastSiteProduct)obj).Id);
                    break;
                case "DurationDateTime":
                    relativeValue = (this.DurationDateTime != null) ? this.DurationDateTime.Value.CompareTo(((ForecastSiteProduct)obj).DurationDateTime) : -1;
                    break;
                default:
                    goto case "Id";
            }
            if (ForecastSiteProduct.SortDirection == SortDirection.Ascending)
                relativeValue *= -1;
            return relativeValue;
        }
        #endregion
		
       
	}

}
