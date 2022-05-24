using Backend.Interfaces;

namespace Backend.Materials
{
    public abstract class Slab : IMaterial
    {
        public abstract decimal Price { get; }
        public abstract decimal MaxPerDay { get; }
        public abstract ushort DurabilityMark { get; }

        public abstract double Height { get; }

        public abstract double Width { get; }

        public abstract double Length { get; }

        public override string ToString()
        {
            return $"Reinforced concrete slab M{DurabilityMark}:{Environment.NewLine}" +
                $"Size (l x w x h): {Length} x {Width} x {Height}{Environment.NewLine}" +
                $"Price: {Price:F2} UAH{Environment.NewLine}" +
                $"Maximum delivery per day: {MaxPerDay} items";
        }
    }
}
