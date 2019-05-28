using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Sause : Item
    {
    }
    public class Tomato:Sause
    {
        public Tomato()
        {
            Price = 10.33;
        }
    }
    public class Barbecue : Sause
    {
        public Barbecue()
        {
            Price = 8.50;
        }
    }
}
