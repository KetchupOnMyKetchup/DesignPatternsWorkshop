using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityConsoleApp.Interfaces;

namespace UnityConsoleApp.Implementations
{
    public class Box : IBox
    {
        private readonly string _material;

        public Box(string material)
        {
            _material = material;
        }
        public string TypeOfMaterial()
        {
            return "Material used: " + _material;
        }
    }
}
