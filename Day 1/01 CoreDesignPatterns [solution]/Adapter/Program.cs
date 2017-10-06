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

   
    //internal class LegacyCompound1
    //{
    //    protected float _criticalBoilingPoint;
    //    protected string _chemical;
    //    protected float _meltingPoint;
    //    protected string _molecularFormula;
    //    protected double _molecularWeight;

    //    // Constructor
    //    public LegacyCompound1(string chemical)
    //    {
    //        _chemical = chemical;
    //    }

    //    // How we would normally display chemcial information.
    //    // But, can override in derived class and adpat to legacy interface.
    //    public virtual void Display()
    //    {
    //        // Here, display cannot return information about the chemical, i.e.,
    //        // it cannot access the chemical Databank as the inferface is different.
    //        Console.WriteLine("\nCompound: {0} ------ ", _chemical);
    //    }
    //}
    
    /// 
    /// /// <summary>
    /// The 'CompundAdapter' class
    /// Adapts the Adaptee, ChemicalDataBank, to Target interface, the 
    /// legacy Compound class.
    /// </summary>
    //internal class CompoundAdapter : LegacyCompound
    //{
    //    // CompundAdapter uses composition to communicate with Legacy interface.
    //    private ChemicalDatabank _bank;

    //    // Constructor
    //    public CompoundAdapter(string name) : base(name)
    //    {
    //    }

    //    // Override and adapt Display to extract specific information
    //    // from the legacy ChemicalDatabank.
    //    public override void Display()
    //    {
    //        // The Adaptee
    //        _bank = new ChemicalDatabank();
    //        _criticalBoilingPoint = _bank.GetCriticalPoint(_chemical, "B");
    //        _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
    //        _molecularWeight = _bank.GetMolecularWeight(_chemical);
    //        _molecularFormula = _bank.GetMolecularStructure(_chemical);
            
    //        // Call base display
    //        base.Display();

    //        Console.WriteLine(" Formula: {0}", _molecularFormula);
    //        Console.WriteLine(" Weight : {0}", _molecularWeight);
    //        Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
    //        Console.WriteLine(" Boiling Pt: {0}", _criticalBoilingPoint);
    //    }
    //}

    /// <summary>
    /// The 'Adaptee' class
    /// This is interface that we adapt to the legacy Compound class.
    /// We just purchased this program and need adapt it to legacy.
    /// </summary>
    //internal class ChemicalDatabank1
    //{
    //    // The databank 'legacy API'
    //    public float GetCriticalPoint(string compound, string point)
    //    {
    //        // Melting Point
    //        if (point == "M")
    //        {
    //            switch (compound.ToLower())
    //            {
    //                case "water":
    //                    return 0.0f;
    //                case "benzene":
    //                    return 5.5f;
    //                case "ethanol":
    //                    return -114.1f;
    //                default:
    //                    return 0f;
    //            }
    //        }

    //            // Boiling Point
    //        switch (compound.ToLower())
    //        {
    //            case "water":
    //                return 100.0f;
    //            case "benzene":
    //                return 80.1f;
    //            case "ethanol":
    //                return 78.3f;
    //            default:
    //                return 0f;
    //        }
    //    }

    //    public string GetMolecularStructure(string compound)
    //    {
    //        switch (compound.ToLower())
    //        {
    //            case "water":
    //                return "H20";
    //            case "benzene":
    //                return "C6H6";
    //            case "ethanol":
    //                return "C2H5OH";
    //            default:
    //                return "";
    //        }
    //    }

    //    public double GetMolecularWeight(string compound)
    //    {
    //        switch (compound.ToLower())
    //        {
    //            case "water":
    //                return 18.015;
    //            case "benzene":
    //                return 78.1134;
    //            case "ethanol":
    //                return 46.0688;
    //            default:
    //                return 0d;
    //        }
    //    }
    //}
}