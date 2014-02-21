using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDependancyInversion
{
    public interface IControl
    {
        void TurnOn();
        void TurnOff();
    }
}
