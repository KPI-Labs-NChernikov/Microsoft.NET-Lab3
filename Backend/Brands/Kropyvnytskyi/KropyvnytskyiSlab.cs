using Backend.Materials;

namespace Backend.Brands.Kropyvnytskyi
{
    internal class KropyvnytskyiSlab : Slab
    {
        public override decimal Price => 1297.44m;

        public override decimal MaxPerDay => 7.5m;

        public override ushort DurabilityMark => 350;

        public override double Height => 200;

        public override double Width => 1000;

        public override double Length => 3000;
    }
}
