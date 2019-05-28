using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PugliaReionFactory: IngridientsFactory
    {
        public override List<Addon> CreateAddons()
        {
            return new List<Addon>()
            {
                new Salami(),
                new Papperoni()
            };
        }

        public override Base CreateBase()
        {
            return new Standart();
        }

        public override Cheese CreateCheese()
        {
            return new Parmezan();
        }

        public override Sause CreateSause()
        {
            return new Tomato();
        }
    }
}
