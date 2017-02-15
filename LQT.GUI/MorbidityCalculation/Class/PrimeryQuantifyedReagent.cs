using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.GUI.MorbidityCalculation
{
    public class PrimeryQuantifyedReagent
    {
        public int ProductId { get; set; }
        public decimal UnitCost { get; set; }
        public string Unit { get; set; }
        public int PackSize { get; set; }
        public double Value { get; set; }
        public int MinimumQuantity { get; set; }
    }
}
