using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IQuantifyMenuDao : IDao<QuantifyMenu>
    {
        IList<QuantifyMenu> GetAllQuantifyMenuByClass(string classofTest);
        IList<QuantifyMenu> GetGeneralQuantifyMenuByClass(string classofTest);
        IList<QuantifyMenu> GetAllGeneralQuantifyMenus();
        IList<QuantifyMenu> GetAllQuantifyMenuByInstrument(int instrumentId);
        QuantifyMenu GetQuantifyMenuByProductId(int productId);
    }
}
