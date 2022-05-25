using Backend.Interfaces;
using Backend.Materials;

namespace Backend
{
    public class PricelistContainer
    {
        private readonly IAbstractFactory _factory;

        public PricelistContainer(IAbstractFactory factory)
        {
            _factory = factory;
        }

        public IEnumerable<IMaterial> Pricelist 
            => new IMaterial[] { _factory.CreateConcrete(), _factory.CreateCement(), _factory.CreateSlab()};

        public IMaterial? GetMaterialByName(string name)
        {
            name = name.Replace(" ", string.Empty).ToLower();
            IMaterial? material = null;
            if (name == typeof(Concrete).Name.ToLower())
                material = _factory.CreateConcrete();
            else if (name == typeof(Cement).Name.ToLower())
                material = _factory.CreateCement();
            else if (name.Contains(typeof(Slab).Name.ToLower()))
                material = _factory.CreateSlab();
            return material;
        }

        public string Brand
        {
            get
            {
                var name = _factory.GetType().Name;
                return name.Remove(name.IndexOf("Factory"));
            }
        }
    }
}
