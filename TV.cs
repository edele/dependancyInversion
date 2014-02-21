using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDependancyInversion
{
    class TV : IControl
    {
        public void TurnOn()
        {
            Console.WriteLine("TV on");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV off");
        }
    }
}
