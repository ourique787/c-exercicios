double saldo = 0;
bool ativo = true;

while (ativo)
{
    Console.WriteLine("1 - Consultar saldo");
    Console.WriteLine("2 - Sacar o saldo");
    Console.WriteLine("3 - Depositar");
    Console.WriteLine("4 - Sair");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine($"Seu saldo é: {saldo}");
            break;
        case "2":
            Console.WriteLine("Digite o valor do saque: ");
            double saque = Convert.ToDouble(Console.ReadLine());
            
            if (saque > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else if (saque <= 0)
            {
                Console.WriteLine("Valor de saque inválido. Insira um valor maior que zero");
            }
            else
            {
                saldo -= saque;
                Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldo}");
            }
            break;
        case "3":
            Console.WriteLine("Digite o valor do depósito: ");
            double deposito = Convert.ToDouble(Console.ReadLine());

            if (deposito <= 0)
            {
                Console.WriteLine("Valor de depósito inválido. Por favor, insira um valor maior que zero.");
            }
            else
            {
                saldo += deposito;
                Console.WriteLine($"Depósito realizado com sucesso. Novo saldo: {saldo}");
            }
            break;
        case "4":
            Console.WriteLine("Saindo do sistema");
            ativo = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}


