using System;

namespace Adapter
{
    /// <summary>
    /// The Adapter class
    /// Adapts the Adaptee, ChemicalDataBank, to Target interface, the 
    /// legacy Compound class.
    /// </summary>
    public class CompoundAdapter : LegacyCompound
    {
        // CompoundAdapter uses composition to communicate with Legacy interface.
        private ChemicalDatabank _bank;

        // Constructor
        public CompoundAdapter(string name) : base(name)
        {
        }

        // Override and adapt Display to extract specific information
        // from the legacy ChemicalDatabank.
        public override void Display()
        {
            // The Adaptee
            _bank = new ChemicalDatabank();
            _criticalBoilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _bank.GetMolecularWeight(_chemical);
            _molecularFormula = _bank.GetMolecularStructure(_chemical);
            
            // Call base display
            base.Display();

            Console.WriteLine(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Weight : {0}", _molecularWeight);
            Console.WriteLine(" Melting Point: {0}", _meltingPoint);
            Console.WriteLine(" Critical Boiling Point: {0}", _criticalBoilingPoint);
        }
    }
}
