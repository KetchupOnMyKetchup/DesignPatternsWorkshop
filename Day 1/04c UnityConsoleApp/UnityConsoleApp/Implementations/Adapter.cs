using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityConsoleApp
{
    public class Adapter : IAdapter
    {
        public string Voltage()
        {
            return "120V";
        }
    }
}
