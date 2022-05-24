using Backend.Materials;

namespace Backend.Brands.Kryukivskyi
{
    internal class KryukivskyiConcrete : Concrete
    {
        public override decimal Price => DurabilityMark * 5;

        public override decimal MaxPerDay => 80;

        public override ushort DurabilityMark => 350;

        public override double DurabilityClass => 25;

        public override ushort FrostResistance => 150;

        public override ushort WaterResistance => 3;

        public override ushort Fluidity => 1;
    }
}
