using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.Core.Domain
{
    public class SiteStatus
    {
        protected int _id;
        protected DateTime _openedFrom;
        protected DateTime? _closedOn;
        protected ForlabSite _site;

        public SiteStatus()
        {
            this._id = -1;
        }
        
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime OpenedFrom
        {
            get { return _openedFrom; }
            set { _openedFrom = value; }
        }

        public DateTime? ClosedOn
        {
            get { return _closedOn; }
            set { _closedOn = value; }
        }

        public ForlabSite Site
        {
            get { return _site; }
            set { _site = value; }
        }
    }
}
