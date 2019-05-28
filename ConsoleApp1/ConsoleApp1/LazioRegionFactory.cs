using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LazioRegionFactory : IngridientsFactory
    {
        public override List<Addon> CreateAddons()
        {
            return new List<Addon>()
            {
                new Mushroom(),
                new Seafood()
            };
        }

        public override Base CreateBase()
        {
            return new XXL();
        }

        public override Cheese CreateCheese()
        {
            return new Mozarella();
        }

        public override Sause CreateSause()
        {
            return new Barbecue();
        }
    }
}
