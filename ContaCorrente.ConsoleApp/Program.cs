using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Conta Corrente 1
        ContaCorrente contaUm = new ContaCorrente();
        contaUm.numeroIdentificacao = 1;
        contaUm.titular = "Julia";

        //Conta Corrente 2
        ContaCorrente contaDois = new ContaCorrente();
        contaUm.numeroIdentificacao = 2;
        contaDois.saldo = 12000;
        contaDois.titular = "Tiago";

        while (true)
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine($"Conta Corrente #{contaUm.numeroIdentificacao} de {contaUm.titular}");
            Console.WriteLine("============================");
            Console.WriteLine("1 - Saque");
            Console.WriteLine("2 - Depósito");
            Console.WriteLine("3 - Transferência");
            Console.WriteLine("4 - Consulta de Saldo");
            Console.WriteLine("5 - Sair");
            string? opcaoMenu = Console.ReadLine()?.ToUpper();

            if (opcaoMenu == "S")
                break;

            if (opcaoMenu == "1")
            {
                contaUm.Sacar();
            }
            else if (opcaoMenu == "2")
            {
                contaUm.Depositar();
            }
            else if (opcaoMenu == "3")
            {
                contaUm.TransferirPara(contaDois);
            }
            else if (opcaoMenu == "4")
            {
                contaUm.ObterSaldo();
            }
        }
    }
}