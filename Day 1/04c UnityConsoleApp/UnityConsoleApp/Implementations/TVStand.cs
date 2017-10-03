using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityConsoleApp
{
    public class TVStand
    {
        public int MaxInchesOfTV { get; set; }

        public TVStand(int maxInchesOfTv)
        {
            MaxInchesOfTV = maxInchesOfTv;
        }

        public int MaxInchesOfTVOnStand()
        {
            return MaxInchesOfTV;
        }
    }
}
