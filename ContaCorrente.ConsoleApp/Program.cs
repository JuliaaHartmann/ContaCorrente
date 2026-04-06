/*
    Pilar da programação orientada à objetos -> Abstração:

    (Descrição/Atributos da Conta)
    Uma conta corrente é composta por diversos atributos essenciais para sua operação.I
    Ela possui um número de identificação único, um saldo disponível e um limite de débito estabelecido.

    (Ações na/da Conta Corrente)
    Saque: Permite a retirada de valores, respeitando o limite máximo permitido.
    Depósito: Possibilita a adição de fundos à conta.
    Consulta de saldo: Fornece informações atualizadas sobre o montante disponível.
*/

using System.Security.Cryptography;

//Conta Corrente
int numeroIdentificacao = RandomNumberGenerator.GetInt32(1, 101);
string titular = "Julia";
decimal saldo = 1000;
decimal limiteDebito = 1200;

while (true)
{
    Console.Clear();
    Console.WriteLine("============================");
    Console.WriteLine($"Conta Corrente de {titular}");
    Console.WriteLine("============================");
    Console.WriteLine("1 - Saque");
    Console.WriteLine("2 - Depósito");
    Console.WriteLine("3 - Consulta de Saldo");
    Console.WriteLine("4 - Sair");
    string? opcaoMenu = Console.ReadLine()?.ToUpper();

    if (opcaoMenu == "S")
        break;

    if (opcaoMenu == "1")
    {
        Console.Write("Digite o valor que deseja sacar (R$): ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        if (saldo <= -limiteDebito)
        {
            Console.WriteLine("O valor do limite de débito já foi ultrapassado");
            Console.ReadLine();
        }
        else
        {
            saldo -= valorSaque;
            Console.WriteLine("O valor foi sacado com sucesso!");
            Console.ReadLine();
        }
    }
    else if (opcaoMenu == "2")
    {
        Console.Write("Digite o valor que deseja depositar ()R$: ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        saldo += valorDeposito;
    }
    else if (opcaoMenu == "3")
    {
        Console.WriteLine($"O valor do saldo da conta é (R$): {saldo}");
        Console.ReadLine();
    }
}
