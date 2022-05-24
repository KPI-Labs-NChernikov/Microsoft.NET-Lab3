using Backend.Interfaces;

namespace Backend.Materials
{
    public abstract class Cement : IMaterial
    {
        public abstract decimal Price { get; }
        public abstract decimal MaxPerDay { get; }
        public abstract ushort DurabilityMark { get; }

        public override string ToString()
        {
            return $"Cement M{DurabilityMark}:{Environment.NewLine}" +
                $"Price: {Price:F2} UAH{Environment.NewLine}" +
                $"Maximum delivery per day: {MaxPerDay} m^3";
        }
    }
}
