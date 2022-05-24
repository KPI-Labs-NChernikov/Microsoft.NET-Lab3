namespace Backend.Interfaces
{
    public interface IMaterial
    {
        ushort DurabilityMark { get; }

        decimal Price { get; }

        decimal MaxPerDay { get; }
    }
}
