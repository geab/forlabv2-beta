
using System;
using System.Collections;
using LQT.Core.Util;

namespace LQT.Core.Domain
{
	
	/// <summary>
	/// Instrument object for NHibernate mapped table 'Fr_Instrument'.
	/// </summary>
	public class Instrument 
	{
		#region Member Variables
		
		private int _id;
		private string _instrumentName;
		private int _maxThroughPut;
        private int _monthMaxTPut;
        private TestingArea _testingArea;
        private int _dailyCtrlTest;
        private int _maxTestBeforeCtrlTest;
        private int _weeklyCtrlTest;
        private int _monthlyCtrlTest;
        private int _quarterlyCtrlTest;


		#endregion

		#region Constructors

		public Instrument() 
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

        public virtual string InstrumentName
		{
			get { return _instrumentName; }
			set
			{
				if ( value != null && value.Length > 64)
					throw new ArgumentOutOfRangeException("Invalid value for InstrumentName", value, value.ToString());
				_instrumentName = value;
			}
		}

        public virtual int MaxThroughPut
		{
			get { return _maxThroughPut; }
			set { _maxThroughPut = value; }
		}
        public virtual int MonthMaxTPut
        {
			get
			{
				return _maxThroughPut * 22;
				//_monthMaxTPut;
			}
			set { _monthMaxTPut = _maxThroughPut * 22; }
        }

        public virtual TestingArea TestingArea
        {
            get { return _testingArea; }
            set { _testingArea = value; }
        }

        public virtual int DailyCtrlTest
        {
            get { return _dailyCtrlTest; }
            set { _dailyCtrlTest = value; }
        }

        public virtual int MaxTestBeforeCtrlTest
        {
            get { return _maxTestBeforeCtrlTest; }
            set { _maxTestBeforeCtrlTest = value; }
        }

        public virtual int WeeklyCtrlTest
        {
            get { return _weeklyCtrlTest; }
            set { _weeklyCtrlTest = value; }
        }

        public virtual int MonthlyCtrlTest
        {
            get { return _monthlyCtrlTest; }
            set { _monthlyCtrlTest = value; }
        }

        public virtual int QuarterlyCtrlTest
        {
            get { return _quarterlyCtrlTest; }
            set { _quarterlyCtrlTest = value; }
        }
		#endregion

        public virtual string CtrlTestDuration { get; set; }
        public virtual int CtrlTestNoOfRun { get; set; }

        public virtual TestingDurationEnum ControlTestDurationEnum
        {
            get
            {
                if (CtrlTestDuration != null)
                    return (TestingDurationEnum)Enum.Parse(typeof(TestingDurationEnum), CtrlTestDuration, true);

                return Util.TestingDurationEnum.Daily;
            }
        }
	}

}
