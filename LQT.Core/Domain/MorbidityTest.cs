
using System;
using System.Collections.Generic;
using LQT.Core.Util;

namespace LQT.Core.Domain
{	
	/// <summary>
	/// MorbidityTest object for NHibernate mapped table 'MorbidityTest'.
	/// </summary>
	public class MorbidityTest
		{
		
		private int _id;
		private string _classOfTest;
		private string _testName;
		private Instrument _instrument;
        private string _testSpecificationGroup;
		private IList<QuantifyMenu> _quantifyMenus;
		
		
		#region Constructors

		public MorbidityTest() 
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

		public virtual string ClassOfTest
		{
			get { return _classOfTest; }
			set
			{
				if ( value != null && value.Length > 16)
					throw new ArgumentOutOfRangeException("Invalid value for ClassOfTest", value, value.ToString());
				_classOfTest = value;
			}
		}

        public virtual ClassOfMorbidityTestEnum ClassOfTestEnum
        {
            get
            {
                return (ClassOfMorbidityTestEnum)Enum.Parse(typeof(ClassOfMorbidityTestEnum), ClassOfTest, true); 
            }
        }
		public virtual string TestName
		{
			get { return _testName; }
			set
			{
				if ( value != null && value.Length > 156)
					throw new ArgumentOutOfRangeException("Invalid value for TestName", value, value.ToString());
				_testName = value;
			}
		}

        public virtual string TestSpecificationGroup
        {
            get { return _testSpecificationGroup; }
            set
            {
                _testSpecificationGroup = value;
            }
        }

		public virtual Instrument Instrument
		{
			get { return _instrument; }
			set { _instrument = value; }
		}

		public virtual IList<QuantifyMenu> QuantifyMenus
		{
			get
			{
				if (_quantifyMenus==null)
				{
					_quantifyMenus = new List<QuantifyMenu>();
				}
				return _quantifyMenus;
			}
			set { _quantifyMenus = value; }
		}

        
		#endregion

        public virtual QuantifyMenu GetQuantifyMenuByTestType(TestTypeEnum testtype)
        {
            foreach (QuantifyMenu q in QuantifyMenus)
            {
                if (q.TestTypeToEnum == testtype)
                {
                   return q;
                }
            }
            return null;
        }

        public virtual QuantifyMenu GetQuantifyMenuByTestType(TestTypeEnum testtype, TestingDurationEnum duration)
        {
            foreach (QuantifyMenu q in QuantifyMenus)
            {
                if (q.TestTypeToEnum == testtype && q.DurationToEnum == duration)
                {
                    return q;
                }
            }
            return null;
        }
        public virtual QuantifyMenu GetQuantifyMenuById(int id)
        {
            foreach (QuantifyMenu q in QuantifyMenus)
            {
                if (q.Id == id)
                {
                    return q;
                }
            }
            return null;
        }
	}

}
