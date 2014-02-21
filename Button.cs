using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDependancyInversion
{
    class Button
    {
        private bool _flag = false;
        public IControl Subject { get; set; }
        public void Action()
        {
            _flag = !_flag;
            if (_flag)
                Subject.TurnOn();
            else Subject.TurnOff();
        }
    }
}
