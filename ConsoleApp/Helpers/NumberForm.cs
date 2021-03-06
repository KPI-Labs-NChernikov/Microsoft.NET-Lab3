namespace ConsoleApp.Helpers
{
    public delegate bool TryParseHandler<T>(string? value, out T result);
    public class NumberForm<T> where T : struct, IComparable<T>
    {
        public string? Name { get; set; }

        public T? Min { get; set; }

        public T? Max { get; set; }

        public TryParseHandler<T> Parser { get; set; } = null!;

        public Func<string, string>? StringHandler { get; set; }

        public ConsoleColor Color { get; set; } = ConsoleColor.DarkGreen;

        public T GetNumber()
        {
            Console.ForegroundColor = Color;
            var getString = () =>
            {
                var entered = Console.ReadLine();
                if (entered != null && StringHandler != null)
                    entered = StringHandler.Invoke(entered);
                return entered;
            };
            var name = !string.IsNullOrEmpty(Name) ? Name : "number";
            Console.Write($"Enter the {name}");
            if (Min is not null)
                Console.Write($" from {Min}");
            if (Max is not null)
                Console.Write($" to {Max}");
            Console.WriteLine(": ");
            bool parsed;
            if (Parser is null)
                throw new InvalidOperationException("Handler cannot be null");
            parsed = Parser.Invoke(getString(), out T entered);
            while (!parsed
                || (Min is not null && entered.CompareTo((T)Min) < 0)
                || (Max is not null && entered.CompareTo((T)Max) > 0))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Error: wrong {name}");
                Console.ForegroundColor = Color;
                Console.Write($"Please, enter the {name}");
                if (Min is not null)
                    Console.Write($" from {Min}");
                if (Max is not null)
                    Console.Write($" to {Max}");
                Console.WriteLine(" once more: ");
                parsed = Parser.Invoke(getString(), out entered);
            }
            return entered;
        }
    }
}
