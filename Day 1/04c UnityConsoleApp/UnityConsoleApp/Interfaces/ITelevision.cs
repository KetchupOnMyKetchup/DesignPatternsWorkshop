using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityConsoleApp
{
    public interface ITelevision
    {
        IAdapter Adapter { get; set; }
        IRemote Remote { get; set; }
        string Manufacturer { get; set; }
        string ModelNumber { get; set; }
        void TurnOn();
        void TurnOff();
    }
}
