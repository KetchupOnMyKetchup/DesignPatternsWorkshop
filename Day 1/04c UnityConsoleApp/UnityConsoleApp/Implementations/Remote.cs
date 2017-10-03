using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityConsoleApp
{
    public class Remote : IRemote
    {
        public bool IsRefurb()
        {
            return false;
        }

        public string ModelType()
        {
            return "The Super Remote";
        }

        public string SerialNumber()
        {
            return "REMOTE1234654";
        }

        public string Manufacturer()
        {
            return "Samsung";
        }
    }
}
