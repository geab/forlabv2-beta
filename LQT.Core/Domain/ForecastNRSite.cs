
using System;
using System.Collections;

namespace LQT.Core.Domain
{
	
	/// <summary>
	/// ForecastNRSite object for NHibernate mapped table 'ForecastNRSite'.
	/// </summary>
	public class ForecastNRSite 
	{
		#region Member Variables
		
		private int _id;
		private ForlabSite _nReportedSite;
		private ForecastSite _forecastSite;

		#endregion

		#region Constructors

		public ForecastNRSite() 
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

		public virtual ForlabSite NReportedSite
		{
			get { return _nReportedSite; }
			set { _nReportedSite = value; }
		}

		public virtual ForecastSite ForecastSite
		{
			get { return _forecastSite; }
			set { _forecastSite = value; }
		}

        
		#endregion
		
       
	}

}
