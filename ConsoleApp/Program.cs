using ConsoleApp;
using ConsoleApp.Helpers;
using ConsoleApp.Printers;

var color = ConsoleColor.DarkGreen;
var order = OrderContainer.Order;
Console.ForegroundColor = color;
HelperMethods.PrintHeader(HelperMethods.GetHeader("Set up"));
var form = new NumberForm<decimal>
{
    Min = 0,
    Name = "demand for concrete (m^3)",
    Parser = decimal.TryParse,
    StringHandler = (string str) => str.Replace('.', ',')
};
order.Concrete.Demand = form.GetNumber();
form.Name = "demand for cement (m^3)";
order.Cement.Demand = form.GetNumber();
var slabForm = new NumberForm<uint>
{
    Name = "demand for reinforced concrete slabs (items)",
    Parser = uint.TryParse
};
order.Slab.Demand = slabForm.GetNumber();
var printer = new OrderPrinter();
printer.Print();
Console.ResetColor();