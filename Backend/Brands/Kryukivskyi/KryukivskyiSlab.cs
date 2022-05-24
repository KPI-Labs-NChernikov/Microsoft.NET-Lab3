using Backend.Materials;

namespace Backend.Brands.Kryukivskyi
{
    internal class KryukivskyiSlab : Slab
    {
        public override decimal Price => 
            DurabilityMark * ((decimal)Height * (decimal)Width * (decimal)Length / (decimal)Math.Pow(1000, 3)) * 3;

        public override decimal MaxPerDay => 5m;

        public override ushort DurabilityMark => 350;

        public override double Height => 220;

        public override double Width => 1490;

        public override double Length => 5380;
    }
}
