using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Addon : Item
    {
    }
    public class Mushroom:Addon
    {
        public Mushroom()
        {
            Price = 4.75;
        }
    }
    public class Seafood : Addon
    {
        public Seafood()
        {
            Price = 4.80;
        }
    }
    public class Salami : Addon
    {
        public Salami()
        {
            Price = 9.50;
        }
    }
    public class Papperoni : Addon
    {
        public Papperoni()
        {
            Price = 9.40;
        }
    }
}
