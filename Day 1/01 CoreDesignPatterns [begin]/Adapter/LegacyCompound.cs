using System;

namespace Adapter
{
    /// Legacy Class
    /// Defines interface that client will leverage
    public class LegacyCompound
    {
        // Note access modifier of protected. Only adapter can inherit
        protected readonly string _chemical;

        // Properties of chemical
        protected float _boilingPoint;
        protected float _criticalBoilingPoint;
        protected float _meltingPoint;
        protected string _molecularFormula;
        protected double _molecularWeight;

        // Constructor
        public LegacyCompound(string chemical)
        {
            _chemical = chemical;
        }

        // How we would normally display chemcial information.
        // But, can override in derived class and adapt to legacy interface.
        public virtual void Display()
        {
            // Legacy system has limited infomration about chemcial
            _boilingPoint = GetSimpleBoilingPoint(_chemical);
            
            // Here, display cannot return information about the chemical, i.e.,
            // it cannot access the chemical Databank as the inferface is different.
            Console.WriteLine("\nCompound: {0} ------ ",
                _chemical);
            Console.WriteLine(" Simple Boiling Point: {0}",
                _boilingPoint);
        }

        private float GetSimpleBoilingPoint(string _chemical)
        {
            return (float) new Random().NextDouble();
        }
    }
}
