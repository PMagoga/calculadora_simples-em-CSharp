internal class Program
{

    private static void Main(string[] args)
    {
        //solicita ao usuário que escolha entre as 4 operações para executar
        Console.WriteLine("Qual operação deseja executar? ");
        Console.WriteLine("Digite (1) para Adição: ");
        Console.WriteLine("Digite (2) para Subtração: ");
        Console.WriteLine("Digite (3) para Multiplicação: ");
        Console.WriteLine("Digite (4) para Divisão: ");
        //na variável operacao vai salvar o que o usuário vai digitar no console
        int operacao = int.Parse(Console.ReadLine());

        switch (operacao)
        {
            case 1:
                {
                    //solicita ao usuário o primeiro número para efetuar a operação
                    Console.WriteLine("Digite o primeiro número: ");
                    int numero1 = int.Parse(Console.ReadLine());
                    //solicita ao usuário o segundo número para efetuar a operação
                    Console.WriteLine("Digite o segundo número: ");
                    int numero2 = int.Parse(Console.ReadLine());
                    //devolve o resultado da operação
                    Calculadora.Models.Calculadora.Somar(numero1, numero2);
                    break;
                }
            case 2:
                {
                    //solicita ao usuário o primeiro número para efetuar a operação
                    Console.WriteLine("Digite o primeiro número: ");
                    int numero1 = int.Parse(Console.ReadLine());
                    //solicita ao usuário o segundo número para efetuar a operação
                    Console.WriteLine("Digite o segundo número: ");
                    int numero2 = int.Parse(Console.ReadLine());
                    //devolve o resultado da operação
                    Calculadora.Models.Calculadora.Subtrair(numero1, numero2);
                    break;
                }
            case 3:
                {
                    //solicita ao usuário o primeiro número para efetuar a operação
                    Console.WriteLine("Digite o primeiro número: ");
                    int numero1 = int.Parse(Console.ReadLine());
                    //solicita ao usuário o segundo número para efetuar a operação
                    Console.WriteLine("Digite o segundo número: ");
                    int numero2 = int.Parse(Console.ReadLine());
                    //devolve o resultado da operação
                    Calculadora.Models.Calculadora.Multiplica(numero1, numero2);
                    break;
                }
            case 4:
                {
                    //solicita ao usuário o primeiro número para efetuar a operação
                    Console.WriteLine("Digite o primeiro número: ");
                    int numero1 = int.Parse(Console.ReadLine());
                    //solicita ao usuário o segundo número para efetuar a operação
                    Console.WriteLine("Digite o segundo número: ");
                    int numero2 = int.Parse(Console.ReadLine());
                    //devolve o resultado da operação
                    Calculadora.Models.Calculadora.Dividir(numero1, numero2);
                    break;
                }
            default:
                {
                    //caso o usuário na digite uma opção não válida (a saber, caso não digite: 1, 2, 3 ou 4)
                    Console.WriteLine("Digite uma opção Válida...");
                    break;
                }
        }
    }
}