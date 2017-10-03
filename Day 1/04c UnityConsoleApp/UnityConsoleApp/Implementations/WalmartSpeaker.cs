using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityConsoleApp
{
    public class WalmartSpeaker : ISpeaker
    {
        public void Start()
        {
            Console.Write("Sounds awful and like it cost .99!");
        }
    }
}
