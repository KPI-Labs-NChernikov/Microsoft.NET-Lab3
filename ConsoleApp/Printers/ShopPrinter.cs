using Backend;
using Backend.Brands.Kreisel;
using Backend.Brands.Kropyvnytskyi;
using Backend.Brands.Kryukivskyi;
using ConsoleApp.Helpers;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Printers
{
    public class ShopPrinter : IPrinter
    {
        public void Print()
        {
            PricelistContainer pricelist;
            var menu = new Menu
            {
                Header = HelperMethods.GetHeader("Shop"),
                Name = "brand",
                Items = new (string, Action?)[]
                {
                    ("Kreisel", () =>
                    {
                        pricelist = new PricelistContainer(new KreiselFactory());
                        new PricelistPrinter(pricelist).Print();
                    }
                    ),
                    ("Kropyvnytskyi", () =>
                    {
                        pricelist = new PricelistContainer(new KropyvnytskyiFactory());
                        new PricelistPrinter(pricelist).Print();
                    }
                    ),
                    ("Kryukivskyi", () =>
                    {
                        pricelist = new PricelistContainer(new KryukivskyiFactory());
                        new PricelistPrinter(pricelist).Print();
                    }
                    )
                }
            };
            menu.Print();
        }
    }
}
