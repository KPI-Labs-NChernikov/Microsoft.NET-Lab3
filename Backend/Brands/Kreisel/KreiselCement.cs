using Backend.Materials;

namespace Backend.Brands.Kreisel
{
    internal class KreiselCement : Cement
    {
        public override decimal Price => 92.8m;

        public override decimal MaxPerDay => 100;

        public override ushort DurabilityMark => 150;
    }
}
