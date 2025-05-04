using ConsoleApp3.Domain.Dto;
using ConsoleApp3.Domain.Interface;

namespace ConsoleApp3.Application.Service
{
    public class CalculadoraService : ICalculadoraService
    {
        public int Sumar(NumerosDto numeros)
        {
            return numeros.Num1 + numeros.Num2;
        }
    }
}
