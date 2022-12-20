internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Qual operação deseja executar? ");
        Console.WriteLine("Digite (1) para Adição: ");
        Console.WriteLine("Digite (2) para Subtração: ");
        Console.WriteLine("Digite (3) para Multiplicação: ");
        Console.WriteLine("Digite (4) para Divisão: ");

        int operacao = int.Parse(Console.ReadLine());

        switch (operacao)
        {
            case 1:
                {
                    Console.WriteLine("Digite o primeiro número: ");
                    int numero1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número: ");
                    int numero2 = int.Parse(Console.ReadLine());

                    Calculadora.Models.Calculadora.Somar(numero1, numero2);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Digite o primeiro número: ");
                    int numero1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número: ");
                    int numero2 = int.Parse(Console.ReadLine());

                    Calculadora.Models.Calculadora.Subtrair(numero1, numero2);
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Digite o primeiro número: ");
                    int numero1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número: ");
                    int numero2 = int.Parse(Console.ReadLine());

                    Calculadora.Models.Calculadora.Multiplica(numero1, numero2);
                    break;
                }
            case 4:
                {
                    Console.WriteLine("Digite o primeiro número: ");
                    int numero1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número: ");
                    int numero2 = int.Parse(Console.ReadLine());

                    Calculadora.Models.Calculadora.Dividir(numero1, numero2);
                    break;
                }
            default:
                {
                    Console.WriteLine("Digite uma opção Válida...");
                    break;
                }
        }
    }
}