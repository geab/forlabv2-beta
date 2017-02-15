
using System;
using System.Collections;

namespace LQT.Core.Domain
{	
	/// <summary>
	/// ProductUsage object for NHibernate mapped table 'ProductUsage'.
	/// </summary>
    public class ProductUsage
    {
        #region Member Variables

        private int _id;
        private decimal _rate;
        private MasterProduct _product;
        private Test _test;
        private Instrument _instrumane;
        private string _productUsedIn;
        private bool _isForControl;

        #endregion

        #region Constructors

        public ProductUsage()
        {
            this._id = -1;
        }


        #endregion

        #region Public Properties

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual decimal Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        public virtual MasterProduct Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public virtual Test Test
        {
            get { return _test; }
            set { _test = value; }
        }

        public virtual Instrument Instrument
        {
            get { return _instrumane; }
            set { _instrumane = value; }
        }

        public virtual string ProductUsedIn
        {
            get { return _productUsedIn; }
            set { _productUsedIn = value; }
        }

        public virtual bool IsForControl
        {
            get { return _isForControl; }
            set { _isForControl = value; }
        }

        #endregion


    }

}
