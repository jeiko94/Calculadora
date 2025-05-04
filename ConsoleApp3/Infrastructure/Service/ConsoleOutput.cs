using ConsoleApp3.Infrastructure.Interface;

namespace ConsoleApp3.Infrastructure.Service
{
    public class ConsoleOutput : IOutputWriter
    {
        public void Escribir(string mensaje) => Console.WriteLine(mensaje);
    }
}
