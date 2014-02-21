using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDependancyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var subj = new TV(); // new Lamp will also work
            var btn = new Button();
            btn.Subject = subj;
            while (true)
            {
                btn.Action();
                Console.ReadKey(true);
            }
        }
    }
}
