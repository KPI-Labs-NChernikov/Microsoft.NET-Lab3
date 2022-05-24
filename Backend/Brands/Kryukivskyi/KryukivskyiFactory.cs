using Backend.Interfaces;
using Backend.Materials;

namespace Backend.Brands.Kryukivskyi
{
    public class KryukivskyiFactory : IAbstractFactory
    {
        public Cement CreateCement() => new KryukivskyiCement();

        public Concrete CreateConcrete() => new KryukivskyiConcrete();

        public Slab CreateSlab() => new KryukivskyiSlab();
    }
}
