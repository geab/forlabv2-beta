
using System;
using System.Collections.Generic;
using LQT.Core.Util;
using System.Collections;

namespace LQT.Core.Domain
{
	
	/// <summary>
	/// TestingArea object for NHibernate mapped table 'Fr_TestingArea'.
	/// </summary>
	public class TestingArea 
	{
		#region Member Variables
		
		private int _id;
		private string _areaName;
     	

        private static string DEFAULT_AREA_NAME = "Unkown Area";
        private Boolean _useInDemography;
        private string _category;

        private IList _tests;

		#endregion

		#region Constructors

		public TestingArea() 
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

        public virtual string AreaName
		{
			get { return _areaName; }
			set
			{
				if ( value != null && value.Length > 64)
					throw new ArgumentOutOfRangeException("Invalid value for AreaName", value, value.ToString());
				_areaName = value;
			}
		}



        public static string GetDefaultAreaName
        {
            get { return DEFAULT_AREA_NAME; }
        }

        public virtual Boolean UseInDemography
        {
            get { return _useInDemography; }
            set { _useInDemography = value; }
        }

        public virtual string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public virtual ClassOfMorbidityTestEnum ClassOfTestToEnum
        {
            get
            {
                return (ClassOfMorbidityTestEnum)Enum.Parse(typeof(ClassOfMorbidityTestEnum), Category);
            }
        }

        public virtual IList Tests
        {
            get
            {
                if (_tests == null)
                {
                    _tests = new ArrayList();
                }
                return _tests;
            }
            set { _tests = value; }
        }

		#endregion

       
       
	}

}
