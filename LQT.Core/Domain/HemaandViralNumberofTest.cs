using System;
using System.Collections;


namespace LQT.Core.Domain
{
	#region HemaandViralNumberofTest

	/// <summary>
	/// HemaandViralNumberofTest object for NHibernate mapped table 'HemaandViralNumberofTest'.
	/// </summary>
	public class HemaandViralNumberofTest
		{
		#region Member Variables
		
		private int _id;
        private int _platform;
        private int _forecastId;
        private int _siteId;
        private double _testBasedOnProtocols;
        private double _symptomDirectedTests;
        private double _repeatedDuetoClinicalReq;
        private double _invalidTestandWastage;
        private double _bufferStockandControls;
        private double _reagentstoRunControls;
	
		#endregion

		#region Constructors

		public HemaandViralNumberofTest() {
            this._id = -1;
        }

		

		#endregion

		#region Public Properties

		public virtual int Id
		{
			get {return _id;}
			set {_id = value;}
		}

        public virtual int Platform
		{
			get { return _platform; }
			set { _platform = value; }
		}

        public virtual int ForecastId
		{
			get { return _forecastId; }
			set { _forecastId = value; }
		}

        public virtual int SiteId
		{
			get { return _siteId; }
			set { _siteId = value; }
		}

        public virtual double TestBasedOnProtocols
		{
			get { return _testBasedOnProtocols; }
			set { _testBasedOnProtocols = value; }
		}

        public virtual double SymptomDirectedTests
		{
			get { return _symptomDirectedTests; }
			set { _symptomDirectedTests = value; }
		}

        public virtual double RepeatedDuetoClinicalReq
		{
			get { return _repeatedDuetoClinicalReq; }
			set { _repeatedDuetoClinicalReq = value; }
		}

        public virtual double InvalidTestandWastage
		{
			get { return _invalidTestandWastage; }
			set { _invalidTestandWastage = value; }
		}

        public virtual double BufferStockandControls
		{
			get { return _bufferStockandControls; }
			set { _bufferStockandControls = value; }
		}

        public virtual double ReagentstoRunControls
		{
			get { return _reagentstoRunControls; }
			set { _reagentstoRunControls = value; }
		}

      
		#endregion
		
       
	}

	#endregion
}

