using Backend.Interfaces;

namespace Backend.Materials
{
    public abstract class Concrete : IMaterial
    {
        public abstract decimal Price { get; }

        public abstract decimal MaxPerDay { get; }

        public abstract ushort DurabilityMark { get; }

        public abstract double DurabilityClass { get; }

        public abstract ushort FrostResistance { get; }

        public abstract ushort WaterResistance { get; }

        public abstract ushort Fluidity { get; }

        public override string ToString()
        {
            return $"Concrete M{DurabilityMark}:{Environment.NewLine}" +
                $"Durability class: B{DurabilityClass}{Environment.NewLine}" +
                $"Frost resistance: F{FrostResistance}{Environment.NewLine}" +
                $"Water resistance: W-{WaterResistance}{Environment.NewLine}" +
                $"Price: {Price:F2} UAH{Environment.NewLine}" +
                $"Maximum delivery per day: {MaxPerDay} m^3";
        }
    }
}
