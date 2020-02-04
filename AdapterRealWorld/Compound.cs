using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterRealWorld
{
    public class Compound
    {
        protected string chemical;
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecularWeight;
        protected string molecularFormula;
        public Compound(string chemical)
        {
            this.chemical = chemical;
        }
        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} -------", chemical);
        }
    }
}
