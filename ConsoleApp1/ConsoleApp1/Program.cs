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
            Console.WriteLine(pizza);

            Pizza pizza2 = new Pizza(new PugliaReionFactory());
            Console.WriteLine(pizza2);

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

   


    public class Item
    {
        public double Price { get; set; }
    }

    public class Pizza
    {
        private Cheese cheese;
        private Base basee;
        private Sause sause;
        private List<Addon> addons;

        public Pizza(IngridientsFactory IF)
        {
            cheese = IF.CreateCheese();
            basee = IF.CreateBase();
            sause = IF.CreateSause();
            addons = IF.CreateAddons();        
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Основа: {basee.GetType().Name}");
            builder.AppendLine($"Сыр: {cheese.GetType().Name}");
            builder.AppendLine($"Соус: {sause.GetType().Name}");
            builder.AppendLine($"\nДобавки: ");

            foreach (Addon addon in addons)
                builder.AppendLine(addon.GetType().Name);

            builder.AppendLine($"Стоимость пиццы: {CalculatePrice()}");

            return builder.ToString();
        }

        private double CalculatePrice()
        {
            double price = 0;

            price += cheese.Price;
            price += basee.Price;
            price += sause.Price;

            foreach  (Addon item in addons)
            {
                price += item.Price;
            }

            return price;
        }
    }


}
