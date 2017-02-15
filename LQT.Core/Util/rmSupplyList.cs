using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.Core.Util
{
    public class rmSupplyList
    {
        public string ClassOfTest { get; set; }
        public string ProductName { get; set; }
        public int Packsize { get; set; }
        public string BasicUnit { get; set; }
        public decimal Price { get; set; }
        public int MinimumPackPerSite { get; set; }
        public double UsageRate { get; set; }
        public string Title { get; set; }
        public string AppliedTo { get; set; }
    }
}
