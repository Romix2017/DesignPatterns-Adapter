using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterRealWorld
{
    public class RichCompound : Compound
    {
        private ChemicalDatabank bank;
        public RichCompound(string name) : base(name)
        {
        }
        public override void Display()
        {
            bank = new ChemicalDatabank();
            boilingPoint = bank.GetCriticalPoint(chemical, "B");
            meltingPoint = bank.GetCriticalPoint(chemical, "M");
            molecularWeight = bank.GetMolecularWeight(chemical);
            molecularFormula = bank.GetMolecularStructure(chemical);
            base.Display();
            Console.WriteLine(" Formula: {0}", molecularFormula);
            Console.WriteLine(" Weight: {0}", molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", boilingPoint);
        }
    }
}
