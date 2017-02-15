
using System;
using System.Collections;
using LQT.Core.Util;
namespace LQT.Core.Domain
{	
	/// <summary>
	/// PanelTest object for NHibernate mapped table 'PanelTest'.
	/// </summary>
	public class PanelTest
		{
		
		private int _id;
        //private string _chemTestName;
        //private string _otherTestName;
		private ProtocolPanel _panel;
		private Test _test;
		
		
		#region Constructors

		public PanelTest() 
		{
			this._id = -1;
		}

		public PanelTest( ProtocolPanel panel, Test test )
		{
			this._panel = panel;
			this._test = test;
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

		public virtual ProtocolPanel Panel
		{
			get { return _panel; }
			set { _panel = value; }
		}

		public virtual Test Test
		{
			get { return _test; }
			set { _test = value; }
		}

        
		#endregion

       
	}

}
