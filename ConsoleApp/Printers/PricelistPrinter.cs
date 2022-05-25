using Backend;
using ConsoleApp.Interfaces;
namespace ConsoleApp.Printers
{
    public class PricelistPrinter : IPrinter
    {
        private PricelistContainer _pricelist;

        public PricelistPrinter(PricelistContainer pricelist)
        {
            _pricelist = pricelist ?? throw new ArgumentNullException(nameof(pricelist));
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
