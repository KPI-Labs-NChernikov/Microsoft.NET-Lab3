using Backend.Materials;

namespace Backend.Interfaces
{
    public interface IAbstractFactory
    {
        Concrete CreateConcrete();

        Cement CreateCement();

        Slab CreateSlab();
    }
}
