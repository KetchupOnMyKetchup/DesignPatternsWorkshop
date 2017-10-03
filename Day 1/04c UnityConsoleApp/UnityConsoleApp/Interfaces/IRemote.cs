using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityConsoleApp
{
    public interface IRemote
    {
        bool IsRefurb();
        string ModelType();
        string SerialNumber();
        string Manufacturer();
    }
}
