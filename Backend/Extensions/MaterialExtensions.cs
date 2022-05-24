using Backend.Interfaces;

namespace Backend.Extensions
{
    public static class MaterialExtensions
    {
        public static decimal GetCost(this IMaterial material, decimal demand)
        {
            if (demand < 0)
                throw new ArgumentOutOfRangeException(nameof(demand), "Demand should be positive or equal 0");
            return material.Price * demand;
        }

        public static TimeSpan GetDeliveryTime(this IMaterial material, decimal demand)
        {
            if (demand < 0)
                throw new ArgumentOutOfRangeException(nameof(demand), "Demand should be positive or equal 0");
            return TimeSpan.FromDays((double)demand / (double)material.MaxPerDay);
        }
    }
}
