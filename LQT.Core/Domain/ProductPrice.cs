using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.Core.Domain
{
    public class ProductPrice
    {
        #region Member Variables

        protected int _id;
        protected decimal _price;
        protected int _packSize;
        protected DateTime _fromDate;
        protected MasterProduct _product;

        #endregion

        #region Constructors

        public ProductPrice() 
        {
            this._id = -1;
            this._fromDate = DateTime.Now;
        }

        #endregion

        #region Public Properties

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public virtual int PackSize
        {
            get { return _packSize; }
            set { _packSize = value; }
        }

        public virtual DateTime FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; }
        }

        public virtual MasterProduct Product
        {
            get { return _product; }
            set { _product = value; }
        }

        #endregion
    }
}
