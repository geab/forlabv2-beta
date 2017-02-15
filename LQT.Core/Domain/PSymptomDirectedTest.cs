
using System;
using System.Collections;
using LQT.Core.Util;

namespace LQT.Core.Domain
{	
	/// <summary>
	/// SymptomDirectedTest object for NHibernate mapped table 'Symptom-DirectedTest'.
	/// </summary>
	public class PSymptomDirectedTest
		{
		
		private int _id;
        private double _adultInTreatmeant;
        private double _pediatricInTreatmeant;
        private double _adultPreART;
        private double _pediatricPreART;
        //private string _chemTestName;
        //private string _otherTestName;
		private Protocol _protocol;
		private Test _test;
		
		
		#region Constructors

		public PSymptomDirectedTest() 
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

        //public virtual string ChemTestName
        //{
        //    get { return _chemTestName; }
        //    set { _chemTestName = value; }
        //}

        //public virtual ChemistryTestNameEnum ChemTestNameToEnum
        //{
        //    get { return (ChemistryTestNameEnum)Enum.Parse(typeof(ChemistryTestNameEnum), _chemTestName); }
        //}

        //public virtual string OtherTestName
        //{
        //    get { return _otherTestName; }
        //    set { _otherTestName = value; }
        //}

        //public virtual OtherTestNameEnum OtherTestNameToEnum
        //{
        //    get { return (OtherTestNameEnum)Enum.Parse(typeof(OtherTestNameEnum), _otherTestName); }
        //}
        public virtual double AdultInTreatmeant
		{
			get { return _adultInTreatmeant; }
			set { _adultInTreatmeant = value; }
		}

        public virtual double PediatricInTreatmeant
		{
			get { return _pediatricInTreatmeant; }
			set { _pediatricInTreatmeant = value; }
		}

        public virtual double AdultPreART
		{
			get { return _adultPreART; }
			set { _adultPreART = value; }
		}

        public virtual double PediatricPreART
		{
			get { return _pediatricPreART; }
			set { _pediatricPreART = value; }
		}

		public virtual Protocol Protocol
		{
			get { return _protocol; }
			set { _protocol = value; }
		}

		public virtual Test Test
		{
			get { return _test; }
			set { _test = value; }
		}

        
		#endregion

        public virtual double SumOfSymptomDirected()
        {
            return _adultInTreatmeant + _adultPreART + _pediatricInTreatmeant + _pediatricPreART;
        }
	}

}
