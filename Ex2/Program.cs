using System;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (Shop myShop = new Shop("SuperMart", "123 Main Street", ShopType.Grocery))
        {
            myShop.ShowInfo();
        }
    }
    enum ShopType
    {
        Grocery,
        Household,
        Clothing,
        Footwear
    }

    class Shop : IDisposable
    {
        public string NameOfShop { get; set; }
        public string Adress { get; set; }
        public ShopType Type { get; set; }

        public Shop(string nameOfShop, string adress, ShopType type)
        {
            NameOfShop = nameOfShop;
            Adress = adress;
            Type = type;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Shop Name: {NameOfShop}");
            Console.WriteLine($"Adress: {Adress}");
            Console.WriteLine($"Type: {Type}");
        }
        public void Dispose()
        {
            Console.WriteLine($"Shop{NameOfShop} is being disposed.");

        }
        ~Shop()
        {
            Console.WriteLine($"Destructor called for Shop {NameOfShop}");
        }
    }
}

