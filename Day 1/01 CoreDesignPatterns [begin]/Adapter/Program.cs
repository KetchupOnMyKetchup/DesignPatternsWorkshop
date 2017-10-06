using System;

namespace Adapter
{
    public class Program
    {
        private static void Main()
        {
            // Note how we upcast each reference to Compund, the Target class.
            // Client interacts directly with base class via polymorphism.
            
            // Get data for chemical compound from legacy source 
            LegacyCompound sulfur = new LegacyCompound("Sulfur");
            sulfur.Display();

            // Get data for chemical compound from databank via Adapter
            LegacyCompound water = new CompoundAdapter("Water");
            water.Display();

            LegacyCompound benzene = new CompoundAdapter("Benzene");
            benzene.Display();

            LegacyCompound ethanol = new CompoundAdapter("Ethanol");
            ethanol.Display();

            Console.ReadKey();
        }
    }
}