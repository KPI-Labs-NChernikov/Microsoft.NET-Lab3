using Backend;
using Backend.Extensions;
using Backend.Interfaces;
using ConsoleApp.Helpers;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Printers
{
    public class OrderPrinter : IPrinter
    {
        private readonly Order _order = OrderContainer.Order;

        private static void PrintMaterial(IMaterial? material, string name, decimal demand)
        {
            Console.Write("Chosen: ");
            if (material != null)
            {
                var brand = material.GetType().Name;
                brand = brand.Remove(brand.IndexOf(name));
                Console.WriteLine($"{brand} M{material.DurabilityMark}");
                Console.WriteLine($"Cost: {material.GetCost(demand):F2} UAH");
                var deliveryTime = material.GetDeliveryTime(demand);
                Console.WriteLine($"Delivery time: {HelperMethods.GetTimeSpanString(deliveryTime)}");
            }
            else
                Console.WriteLine("none");
            Console.WriteLine();
        }

        public void Print()
        {
            Console.Clear();
            HelperMethods.PrintHeader(HelperMethods.GetHeader("Your order"));
            Console.WriteLine($"1. Concrete: needed {_order.Concrete.Demand} m^3");
            PrintMaterial(_order.Concrete.Material, "Concrete", _order.Concrete.Demand);
            Console.WriteLine($"2. Cement: needed {_order.Cement.Demand} m^3");
            PrintMaterial(_order.Cement.Material, "Cement", _order.Cement.Demand);
            Console.WriteLine($"2. Reinforced concrete slabs: needed {_order.Slab.Demand} items");
            PrintMaterial(_order.Slab.Material, "Slab", _order.Slab.Demand);
            Console.WriteLine("Total:");
            Console.WriteLine($"Cost: {_order.Cost:F2} UAH");
            Console.WriteLine($"Delivery time: {HelperMethods.GetTimeSpanString(_order.MinDeliveryTime)}");
            Console.WriteLine($"{Environment.NewLine}");
            var menu = new LiteMenu
            {
                IsQuitable = true,
                Name = "menu item",
                Items = new (string, Action?)[]
                {
                    ("To shop", () =>
                        {
                            Console.Clear();
                            var shopPrinter = new ShopPrinter();
                            shopPrinter.Print();
                            Print();
                        }
                    )
                }
            };
            menu.Print();
        }
    }
}
