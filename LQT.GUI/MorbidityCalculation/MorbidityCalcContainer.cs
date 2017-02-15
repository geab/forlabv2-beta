using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.GUI.MorbidityCalculation
{
    public class MorbidityCalcContainer
    {
        public MorbidityCalcContainer(int siteid)
        {
            SiteId = siteid;
        }

        public int SiteId { get; private set; }
        public CalcCD4Test CD4Calculation { get; set; }
        public CalcChemistryTest ChemistryCalculation { get; set; }
        public CalcConsumable ConsumableCalculation { get; set; }
        public CalcHematology HematologyCalculation { get; set; }
        public CalcOtherTest OtherTestCalculation { get; set; }
        public CalcViralLoad ViralLoadCalculation { get; set; }

        public IList<int> CD4ReferedSites  { get; set; }
        public IList<int> ChemReferedSites { get; set; }
        public IList<int> HemaReferedSites { get; set; }
        public IList<int> ViraReferedSites { get; set; }
    }
}
