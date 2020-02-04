using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
