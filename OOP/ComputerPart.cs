using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleHelper_50.Helper_50;

namespace m7_2
{
    abstract class ComputerPart
    {
        public string Name { get; set; }
        public abstract void Work();
    }
    class Processor : ComputerPart
    {
        public override void Work()
        {
            WriteLn("I calculating ariphmetic operations");
        }
    }
    class Motherboard : ComputerPart
    {
        public override void Work()
        {
            WriteLn("I connecting all components");
        }
    }
    class GraphicCard : ComputerPart
    {
        public override void Work()
        {
            WriteLn("I showing picture for you");
        }
    }

}
