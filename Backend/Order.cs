using Backend.Extensions;
using Backend.Interfaces;
using Backend.Materials;

namespace Backend
{
    public class Order
    {
        public OrderItem<Concrete, decimal> Concrete { get; set; } = new();

        public OrderItem<Cement, decimal> Cement { get; set; } = new();

        public OrderItem<Slab, uint> Slab { get; set; } = new();

        public IEnumerable<OrderItem<IMaterial, decimal>> Materials => new OrderItem<IMaterial, decimal>[]
        {
            Concrete,
            Cement,
            new OrderItem<IMaterial, decimal> { Material = Slab.Material, Demand = Slab.Demand}
        };

        public decimal Cost => Materials.Sum(mat => mat.Material?.GetCost(mat.Demand) ?? 0);

        public TimeSpan MinDeliveryTime => Materials.Max(mat => mat.Material?.GetDeliveryTime(mat.Demand) ?? new TimeSpan());

        public decimal? GetDemandByName(string name)
        {
            name = name.ToLower();
            decimal? demand = null;
            if (name.Contains(typeof(Concrete).Name.ToLower()))
                demand = Concrete.Demand;
            else if (name.Contains(typeof(Cement).Name.ToLower()))
                demand = Cement.Demand;
            else if (name.Contains(typeof(Slab).Name.ToLower()))
                demand = Slab.Demand;
            return demand;
        }

        public void SetMaterial(IMaterial material)
        {
            if (material is Concrete con)
                Concrete.Material = con;
            else if (material is Cement cement)
                Cement.Material = cement;
            else if (material is Slab slab)
                Slab.Material = slab;
            else
                throw new ArgumentException("Cannot found a type for this material", nameof(material));
        }
    }
}
