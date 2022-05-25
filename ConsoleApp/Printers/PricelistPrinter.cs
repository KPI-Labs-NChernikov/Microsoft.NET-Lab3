using Backend;
using Backend.Extensions;
using Backend.Materials;
using ConsoleApp.Helpers;
using ConsoleApp.Interfaces;
namespace ConsoleApp.Printers
{
    public class PricelistPrinter : IPrinter
    {
        private readonly PricelistContainer _pricelist;

        public PricelistPrinter(PricelistContainer pricelist)
        {
            _pricelist = pricelist ?? throw new ArgumentNullException(nameof(pricelist));
        }

        public void Print()
        {
            var order = OrderContainer.Order;
            var menu = new Menu
            {
                Header = HelperMethods.GetHeader(_pricelist.Brand)
            };
            var materials = _pricelist.Pricelist;
            foreach (var material in materials)
            {
                var name = material.GetType().Name;
                name = name.Replace(_pricelist.Brand, string.Empty);
                decimal? demand = order.GetDemandByName(name);
                var description = material +
                    $"{Environment.NewLine}Cost: {material.GetCost(demand.GetValueOrDefault()):F2} UAH" +
                    $"{Environment.NewLine}Delivery time: " +
                    $"{HelperMethods.GetTimeSpanString(material.GetDeliveryTime(demand.GetValueOrDefault()))}" +
                    $"{Environment.NewLine}";
                var action = () =>
                {
                    var dialog = new Dialog
                    {
                        Question = $"Are you sure you want to buy a {name} M{material.DurabilityMark} " +
                        $"from {_pricelist.Brand}?",
                        YAction = () =>
                        {
                            try
                            {
                                order.SetMaterial(material);
                            }
                            catch (ArgumentException exc)
                            {
                                HelperMethods.PrintErrorMessage(exc.Message);
                            }
                        },
                    };
                    dialog.Print();
                    HelperMethods.Continue();
                };
                menu.Items.Add((description, action));
            }
            menu.Print();
        }
    }
}
