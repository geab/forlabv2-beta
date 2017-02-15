using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IInstrumentDao :IDao<Instrument>
    {
        Instrument GetInstrumentByName(string name);
        Instrument GetInstrumentByNameAndTestingArea(string name, int testingAreaId);
        IList<Instrument> GetListOfInstrumentByTestingArea(int testingAreaId);
        IList<Instrument> GetListOfInstrumentByTestingArea(string classofTest);
    }
}
