using ConsoleApp3.Infrastructure.Interface;

namespace ConsoleApp3.Infrastructure.Service
{
    public class ConsoleInput : IInputReader
    {
        public string? Leer() => Console.ReadLine();
    }
}
