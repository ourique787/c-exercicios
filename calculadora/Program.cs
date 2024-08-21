Console.WriteLine("Digite um número: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite 1 para Adição");
Console.WriteLine("Digite 2 para Subtração");
Console.WriteLine("Digite 3 para Multiplicação");
Console.WriteLine("Digite 4 para Divisão");
Console.WriteLine("Digite 5 para Sair");
string opcao = Console.ReadLine();

        switch (opcao){
            case "1":
                double adicao = num1 + num2;
                Console.WriteLine($"Resultado: {adicao}");
                break;

            case "2":
                double sub = num1 - num2;
                Console.WriteLine($"Resultado: {sub}");
                break;

            case "3":
                double mult = num1 * num2;
                Console.WriteLine($"Resultado: {mult}");
                break;

            case "4":
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                else
                {
                    double div = num1 / num2;
                    Console.WriteLine($"Resultado: {div}");
                }
                break;

            case "5":
                Console.WriteLine("Programa encerrado.");
                break;

            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                break;
}
    

