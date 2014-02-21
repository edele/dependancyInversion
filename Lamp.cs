using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDependancyInversion
{
    class Lamp:IControl
    {
        public void TurnOn()
        {
            Console.WriteLine("горит");
        }
        public void TurnOff()
        {
            Console.WriteLine("не горит");
        }
    }
}
