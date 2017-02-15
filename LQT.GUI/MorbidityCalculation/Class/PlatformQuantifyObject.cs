using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.Util;

namespace LQT.GUI.MorbidityCalculation
{
    public class PlatformQuantifyObject
    {
        private IList<PlatformQuantifyMenu> _platformQuantifyMenus;
        private IList<QuantificationMetric> _quaMetrics;
        private IList<QuantifyMenu> _generalQuaMenu;

        public PlatformQuantifyObject(IList<PlatformQuantifyMenu> platformQuantifyMenus, IList<QuantificationMetric> quantificationMetrics, IList<QuantifyMenu> generalQuantifyMenus)
        {
            this._platformQuantifyMenus = platformQuantifyMenus;
            this._quaMetrics = quantificationMetrics;
            this._generalQuaMenu = generalQuantifyMenus;
        }

        public IList<PlatformQuantifyMenu> PlatformQuantifyMenus
        {
            get { return _platformQuantifyMenus; }
        }

        public IList<QuantifyMenu> GeneralQuantifyMenus
        {
            get { return _generalQuaMenu; }
        }

        public IList<QuantificationMetric> QuantificationMetrics
        {
            get { return _quaMetrics; }
        }

        public object GetPlatformQuantifyMenuByInsId(int instrumentId)
        {
            foreach (PlatformQuantifyMenu pqm in _platformQuantifyMenus)
            {
                if (pqm.InstrumentId == instrumentId)
                    return pqm;
            }
            return null;
        }
        
        public QuantifyMenu GetQuantifyMenuByProductId(int productId)
        {
            foreach (QuantifyMenu pqm in _generalQuaMenu)
            {
                if (pqm.ProductId == productId)
                    return pqm;
            }
            return null;
        }

        public IList<QuantificationMetric> GetQuanMetricByQuanMenuId(int quanmenuid)
        {
            IList<QuantificationMetric> result = new List<QuantificationMetric>();

            foreach (QuantificationMetric q in _quaMetrics)
            {
                if (q.QuantifyMenu.Id == quanmenuid)
                {
                    result.Add(q);
                }
            }
            return result;
        }

        public QuantifyMenu GetQuanMenuByTitle(string title)
        {
            foreach (QuantifyMenu q in _generalQuaMenu)
            {
                if (q.Title == title)
                    return q;
            }
            return null;
        }
    }
}
