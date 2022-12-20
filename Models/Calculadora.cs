using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calculadora
    {
        public static int Somar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            Console.WriteLine($"A soma dos números {numero1} e {numero2} é: {resultado}");
            return resultado;
        }

        public static int Subtrair(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            Console.WriteLine($"A subtração dos números {numero1} e {numero2} é: {resultado}");
            return resultado;
        }
        public static int Multiplica(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            Console.WriteLine($"A multiplicação dos números {numero1} e {numero2} é: {resultado}");
            return resultado;
        }
        public static int Dividir(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            Console.WriteLine($"A divisão dos números {numero1} e {numero2} é: {resultado}");
            return resultado;
        }

    }
}