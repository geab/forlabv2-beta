using System;
using System.Collections.Generic;


namespace LQT.Core.Domain
{
    public class SiteCategory
    {
        #region Member Variables

        private int _id;
        private string _categoryName;
        
        #endregion

        #region Constructors

        public SiteCategory() 
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

        public virtual string CategoryName
        {
            get { return _categoryName; }
            set
            {
                if (value != null && value.Length > 64)
                    throw new ArgumentOutOfRangeException("Invalid value for CategoryName", value, value.ToString());
                _categoryName = value;
            }
        }

        #endregion
    }
}
