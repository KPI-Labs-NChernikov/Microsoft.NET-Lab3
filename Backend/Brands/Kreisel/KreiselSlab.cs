using Backend.Materials;

namespace Backend.Brands.Kreisel
{
    internal class KreiselSlab : Slab
    {
        public override decimal Price => 2906.52m;

        public override decimal MaxPerDay => 5;

        public override ushort DurabilityMark => 450;

        public override double Height => 240;

        public override double Width => 1200;

        public override double Length => 5600;
    }
}
