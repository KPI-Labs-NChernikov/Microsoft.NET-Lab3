using Backend.Interfaces;

namespace Backend
{
    public class OrderItem<T, K> where T : IMaterial where K : struct
    {
        public T? Material { get; set; }

        public K Demand { get; set; }

        public static implicit operator OrderItem<IMaterial, K>(OrderItem<T, K> item) => item;
    }
}
