using ConsoleApp3.Domain.Interface;
using ConsoleApp3.Infrastructure.Interface;
using ConsoleApp3.Domain.Dto;

namespace ConsoleApp3.UI
{
    public class Menu
    {
        private readonly ICalculadoraService _calculadoraService;
        private readonly IInputReader _inputReader;
        private readonly IOutputWriter _outputWriter;

        public Menu(ICalculadoraService calculadoraService, IInputReader inputReader, IOutputWriter outputWriter)
        {
            _calculadoraService = calculadoraService;
            _inputReader = inputReader;
            _outputWriter = outputWriter;
        }

        public void Mostrar()
        {
            bool valida = true;

            while (valida)
            {
                _outputWriter.Escribir("---Calculadora---\n");
                _outputWriter.Escribir("Selecciona 1 para suma.");
                _outputWriter.Escribir("Selecciona 0 para salir.");
                string? opcion = _inputReader.Leer();

                switch (opcion)
                {
                    case "1":
                        EjecutarSuma();
                        break;
                    case "0":
                        valida = false;
                        _outputWriter.Escribir("Vuelva pronto, gracias!");
                        break;

                    default:
                        _outputWriter.Escribir("Opcion no valida.");
                        break;
                }
            }
        }

        private void EjecutarSuma()
        {
            var numeros = new NumerosDto
            {
                Num1 = LeerNumero("Ingresa el primer número: "),
                Num2 = LeerNumero("Ingresa el segundo número: ")
            };

            int resultado = _calculadoraService.Sumar(numeros);
            _outputWriter.Escribir($"La suma de {numeros.Num1} y {numeros.Num2} es {resultado}");
        }

        private int LeerNumero(string mensaje)
        {
            while (true)
            {
                _outputWriter.Escribir(mensaje);
                if (int.TryParse(_inputReader.Leer(), out int num))
                {
                    return num;
                }

                _outputWriter.Escribir("Entrada de datos no valida. Ingrese un numero.");
            }
        }
    }
}
