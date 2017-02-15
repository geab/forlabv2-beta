
using System;
using System.Collections;
using LQT.Core.Util;

namespace LQT.Core.Domain
{
	
	/// <summary>
	/// ForecastSiteTest object for NHibernate mapped table 'ForecastSiteTest'.
	/// </summary>
    public class ForecastSiteTest : BaseDataUsage, IBaseDataUsage, System.IComparable
	{
		#region Member Variables
		
		
		private ForecastSite _forecastSite;
        private static String _sortExpression = "DurationDateTime";
        private static SortDirection _sortDirection = SortDirection.Descending;

		#endregion

		#region Constructors

		public ForecastSiteTest() 
		{
		}

		
		#endregion

		#region Public Properties

		
		public virtual ForecastSite ForecastSite
		{
			get { return _forecastSite; }
			set { _forecastSite = value; }
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
            if (!(obj is ForecastSiteTest))
                throw new InvalidCastException("This object is not of type ForecastSiteTest");

            int relativeValue;
            switch (SortExpression)
            {
                case "Id":
                    relativeValue = this.Id.CompareTo(((ForecastSiteTest)obj).Id);
                    break;
                case "DurationDateTime":
                    relativeValue = (this.DurationDateTime != null) ? this.DurationDateTime.Value.CompareTo(((ForecastSiteTest)obj).DurationDateTime) : -1;
                    break;
                default:
                    goto case "Id";
            }
            if (ForecastSiteTest.SortDirection == SortDirection.Ascending)
                relativeValue *= -1;
            return relativeValue;
        }
        #endregion
		
       
	}

}
