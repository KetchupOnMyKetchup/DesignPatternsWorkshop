using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityConsoleApp
{
    public class Television : ITelevision
    {
        public IAdapter Adapter { get; set; }
        public IRemote Remote { get; set; }
        public string Manufacturer { get; set; }
        public string ModelNumber { get; set; }

        public Television(IAdapter adapter, IRemote remote, string manufacturer, string modelNumber)
        {
            Adapter = adapter;
            Remote = remote;
            Manufacturer = manufacturer;
            ModelNumber = modelNumber;
        }
        public void TurnOn()
        {
            Console.WriteLine("Bzzt. TV just turned on!");
        }

        public void TurnOff()
        {
            Console.WriteLine("Aw. TV just turned off!");
        }
    }
}
