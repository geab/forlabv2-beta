using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.GUI
{
    [Serializable]
    public class SqlDatabaseSettings
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Version { get; set; }
    }
}
