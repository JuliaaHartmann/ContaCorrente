/*
    Abstração da Conta Corrente

    (Descrição/Atributos) [x]
    Uma conta corrente é composta por diversos atributos essenciais para sua operação.
    Ela possui um número de identificação único, um saldo disponível e um limite de débito estabelecido.

    (Ações/Métodos) [x]
    Saque: Permite a retirada de valores, respeitando o limite máximo permitido.
    Depósito: Possibilita a adição de fundos à conta.
    Consulta de saldo: Fornece informações atualizadas sobre o montante disponível.
    Transferência entre contas: Permite a movimentação de valores entre contas correntes distintas.
*/

class ContaCorrente
{
    public int numeroIdentificacao;
    public string titular;
    public decimal saldo;
    public decimal limiteDebito;

    public void Sacar()
    {
        Console.Write("Digite o valor que deseja sacar (R$): ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        if (saldo <= -limiteDebito)
            if (valorSaque > saldo + limiteDebito)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("O valor do limite de débito já foi ultrapassado");
                Console.ReadLine();
            }
            else
            {
                saldo -= valorSaque;
                Console.WriteLine("O valor foi sacado com sucesso!");
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();

            }

        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void Depositar()
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja depositar ()R$: ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        saldo += valorDeposito;

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O valor foi depositado com sucesso!");
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void TransferirPara(ContaCorrente contaDestino)
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja transferir (R$): ");
        decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

        saldo -= valorTransferencia;
        contaDestino.saldo += valorTransferencia;

        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"O valor dde R${valorTransferencia} foi transferido com sucesso!");
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void ObterSaldo()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"O valor do saldo da conta é (R$): {saldo}");
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }
}
