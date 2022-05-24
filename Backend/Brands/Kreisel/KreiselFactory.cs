using Backend.Interfaces;
using Backend.Materials;

namespace Backend.Brands.Kreisel
{
    public class KreiselFactory : IAbstractFactory
    {
        public Cement CreateCement() => new KreiselCement();

        public Concrete CreateConcrete() => new KreiselConcrete();

        public Slab CreateSlab() => new KreiselSlab();
    }
}
