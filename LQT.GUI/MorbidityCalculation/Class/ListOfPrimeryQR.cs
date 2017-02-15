using System;
using System.Collections.Generic;
using System.Linq;
using LQT.Core.Util;

namespace LQT.GUI.MorbidityCalculation
{
    public class ListOfPrimeryQR
    {
        private IList<PrimeryQuantifyedReagent> _listofPQR;
        private IDictionary<int, QuantifyedReagent> _listofSupplies;
        private int _platform;

        private ListOfPrimeryQR()
        {
        }

        public ListOfPrimeryQR(ClassOfMorbidityTestEnum platform)
        {
            _platform = (int)platform;
            _listofPQR = new List<PrimeryQuantifyedReagent>();
            _listofSupplies = new Dictionary<int, QuantifyedReagent>();

        }

        public void AddPrimeryQR(PrimeryQuantifyedReagent pqr)
        {
            _listofPQR.Add(pqr);
        }

        public int Platform
        {
            get { return _platform; }
        }

        public IDictionary<int, QuantifyedReagent> GetSuppliesForecasted()
        {
            foreach (PrimeryQuantifyedReagent pr in _listofPQR)
            {
                if (_listofSupplies.ContainsKey(pr.ProductId))
                {
                    _listofSupplies[pr.ProductId].QuantityNeeded = _listofSupplies[pr.ProductId].QuantityNeeded + pr.Value;
                }
                else
                {
                    QuantifyedReagent qr = new QuantifyedReagent(_platform, pr.ProductId, pr.MinimumQuantity);
                    qr.UnitCost = pr.UnitCost;
                    qr.Unit = pr.Unit;
                    qr.PackSize = pr.PackSize;
                    qr.QuantityNeeded = pr.Value;
                    _listofSupplies.Add(pr.ProductId, qr);
                }
            }
            return _listofSupplies;
        }
    }
}
