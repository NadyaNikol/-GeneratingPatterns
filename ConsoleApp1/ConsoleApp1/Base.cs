using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Base : Item
    {

    }
    public class Standart:Base
    {
        public Standart()
        {
            Price = 15.09;
        }
    }
    public class XXL : Base
    {
        public XXL()
        {
            Price = 32.55;
        }
    }
}
