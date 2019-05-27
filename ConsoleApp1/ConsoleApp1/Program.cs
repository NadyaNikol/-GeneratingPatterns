using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza(new LazioRegionFactory());
            pizza.CalculatePrice();
            Console.WriteLine(pizza);

            Console.ReadKey();
        }


    }

    public abstract class IngridientsFactory
    {
        public abstract Cheese CreateCheese();
        public abstract Base CreateBase();
        public abstract Sause CreateSause();
        public abstract List<Addon> CreateAddons();
    }

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


    public class Pizza
    {
        private Cheese cheese;
        private Base basee;
        private Sause sause;
        // private List<Addon> addons;

        public Pizza(IngridientsFactory IF)
        {
            cheese = IF.CreateCheese();
            basee = IF.CreateBase();
            sause = IF.CreateSause();

            //for (int i = 0; i < addons.Count; i++)
            //{

            //}         
        }

        public override string ToString()
        {
            return $"Основа: {basee.GetType().Name}\n" +
                   $"Cыр: {cheese.GetType().Name}\n" +
                   $"Соус: {sause.GetType().Name}\n" +
                   $"Cыр: {cheese.GetType().Name}\n";
        }

        public void CalculatePrice()
        {

        }
    }


}
