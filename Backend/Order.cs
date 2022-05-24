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
    }
}
