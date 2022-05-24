using Backend.Materials;

namespace Backend.Brands.Kropyvnytskyi
{
    internal class KropyvnytskyiConcrete : Concrete
    {
        public override decimal Price => DurabilityMark * 5 + 150;

        public override decimal MaxPerDay => 100;

        public override ushort DurabilityMark => 350;

        public override double DurabilityClass => 25;

        public override ushort FrostResistance => 150;

        public override ushort WaterResistance => 5;

        public override ushort Fluidity => 1;
    }
}
