
using System;
using System.Collections;

namespace LQT.Core.Domain
{
	
	/// <summary>
	/// ForecastCategorySite object for NHibernate mapped table 'ForecastCategorySite'.
	/// </summary>
	public class ForecastCategorySite 
	{
		#region Member Variables
		
		private int _id;
		private ForlabSite _site;
		private ForecastCategory _category;

		#endregion

		#region Constructors

		public ForecastCategorySite() 
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

		public virtual ForlabSite Site
		{
			get { return _site; }
			set { _site = value; }
		}

		public virtual ForecastCategory Category
		{
			get { return _category; }
			set { _category = value; }
		}

        
		#endregion
		
       
	}

}
