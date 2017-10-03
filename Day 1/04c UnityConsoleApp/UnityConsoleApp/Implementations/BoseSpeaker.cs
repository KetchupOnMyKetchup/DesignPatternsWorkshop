using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityConsoleApp
{
    public class BoseSpeaker : ISpeaker
    {
        public void Start()
        {
            Console.Write("Sounds great!");
        }
    }
}
