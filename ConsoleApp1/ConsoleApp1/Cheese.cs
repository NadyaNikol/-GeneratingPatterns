using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Cheese : Item
    {
    }

    public class Mozarella:Cheese
    {
        public Mozarella()
        {
            Price = 33.89;
        }
    }
    public class Parmezan : Cheese
    {
        public Parmezan()
        {
            Price = 36.00;
        }
    }
    public class Ricotta : Cheese
    {
        public Ricotta()
        {
            Price = 29.90;
        }
    }

}
