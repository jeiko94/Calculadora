using ConsoleApp3.Application.Service;
using ConsoleApp3.Infrastructure.Service;
using ConsoleApp3.UI;

class Program
{
    static void Main(string[] args) 
    {
        var CalculadoraService = new CalculadoraService();
        var inputReader = new ConsoleInput();
        var outputReader = new ConsoleOutput();
        var menu = new Menu(CalculadoraService, inputReader, outputReader);

        menu.Mostrar();
    }
}