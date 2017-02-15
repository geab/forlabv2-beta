
using System;
using System.Collections;

namespace LQT.Core.Domain
{	
	/// <summary>
	/// ForlabParameter object for NHibernate mapped table 'ForlabParameters'.
	/// </summary>
	public class ForlabParameter
		{
		
		private string _id;
		private string _parmValue;
		
		public ForlabParameter() 
		{
			this._id = "-1";
		}

		public ForlabParameter( string parmValue )
		{
			this._parmValue = parmValue;
		}

		#region Public Properties

		public virtual string Id
		{
			get {return _id;}
			set
			{
				if ( value != null && value.Length > 64)
					throw new ArgumentOutOfRangeException("Invalid value for Id", value, value.ToString());
				_id = value;
			}
		}

		public virtual string ParmValue
		{
			get { return _parmValue; }
			set
			{
				if ( value != null && value.Length > 128)
					throw new ArgumentOutOfRangeException("Invalid value for ParmValue", value, value.ToString());
				_parmValue = value;
			}
		}

        
		#endregion
	}

}
