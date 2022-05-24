using Backend.Materials;

namespace Backend.Brands.Kryukivskyi
{
    internal class KryukivskyiCement : Cement
    {
        public override decimal Price => DurabilityMark / 1.75m;

        public override decimal MaxPerDay => 92.5m;

        public override ushort DurabilityMark => 150;
    }
}
