using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.GUI.MorbidityCalculation
{
    public class QuantifyedReagent
    {
        private int _platform;
        private int _productId;
        private double _quantityNeeded;
        private double _finalValue;
        private int _minimumQuantity;

        private QuantifyedReagent()
        {
        }

        public QuantifyedReagent(int platform, int productid, int minimumQty)
        {
            _platform = platform;
            _productId = productid;
            _minimumQuantity = minimumQty;
        }
        
        public decimal UnitCost { get; set; }
        public string Unit { get; set; }
        public int PackSize { get; set; }

        public int Platform
        {
            get { return _platform; }
        }

        public int ProductId
        {
            get { return _productId; }
        }

        public double QuantityNeeded
        {
            get { return _quantityNeeded; }
            set
            {
                _quantityNeeded = value;
                if (_quantityNeeded < _minimumQuantity)
                    _finalValue = _minimumQuantity;
                else
                    _finalValue = _quantityNeeded;
            }
        }

        public int MinimumQuantity
        {
            get { return _minimumQuantity; }
        }

        public double FinalValue
        {
            get { return _finalValue; }
        }
    }
}
