using Backend.Interfaces;
using Backend.Materials;

namespace Backend.Brands.Kropyvnytskyi
{
    public class KropyvnytskyiFactory : IAbstractFactory
    {
        public Cement CreateCement() => new KropyvnytskyiCement();

        public Concrete CreateConcrete() => new KropyvnytskyiConcrete();

        public Slab CreateSlab() => new KropyvnytskyiSlab();
    }
}
