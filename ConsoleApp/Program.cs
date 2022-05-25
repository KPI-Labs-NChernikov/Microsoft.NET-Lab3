using Backend;
using ConsoleApp.Helpers;
using ConsoleApp.Printers;

var _color = ConsoleColor.DarkGreen;
Console.ForegroundColor = _color;
var _order = new Order();
HelperMethods.PrintHeader(HelperMethods.GetHeader("Set up"));
var form = new NumberForm<decimal>
{
    Min = 0,
    Name = "demand for concrete (m^3)",
    Parser = decimal.TryParse,
    StringHandler = (string str) => str.Replace('.', ',')
};
_order.Concrete.Demand = form.GetNumber();
form.Name = "demand for cement (m^3)";
_order.Cement.Demand = form.GetNumber();
var slabForm = new NumberForm<uint>
{
    Name = "demand for reinforced concrete slabs (items)",
    Parser = uint.TryParse
};
_order.Slab.Demand = slabForm.GetNumber();
var printer = new OrderPrinter(_order);
printer.Print();
Console.ResetColor();