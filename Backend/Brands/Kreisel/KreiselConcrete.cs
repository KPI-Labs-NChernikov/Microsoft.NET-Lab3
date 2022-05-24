using Backend.Materials;

namespace Backend.Brands.Kreisel
{
    internal class KreiselConcrete : Concrete
    {
        public override decimal Price => 1960;

        public override decimal MaxPerDay => 100;

        public override ushort DurabilityMark => 350;

        public override double DurabilityClass => 25;

        public override ushort FrostResistance => 200;

        public override ushort WaterResistance => 6;

        public override ushort Fluidity => 3;
    }
}
