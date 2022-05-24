using Backend.Materials;

namespace Backend.Brands.Kropyvnytskyi
{
    internal class KropyvnytskyiCement : Cement
    {
        public override decimal Price => 80.5m;

        public override decimal MaxPerDay => 90.5m;

        public override ushort DurabilityMark => 150;
    }
}
