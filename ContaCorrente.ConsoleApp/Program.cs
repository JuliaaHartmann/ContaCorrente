using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Conta Corrente 1
        ContaCorrente contaUm = new ContaCorrente();
        contaUm.numeroIdentificacao = 1;
        contaUm.titular = "Júlia";
        contaUm.saldo = 400;
        contaUm.limiteDebito = 1200;

        //Conta Corrente 2
        ContaCorrente contaDois = new ContaCorrente();
        contaUm.numeroIdentificacao = 2;
        contaDois.saldo = 12000;
        contaDois.titular = "Natália";
        contaDois.limiteDebito = 1200;

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
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite o valor que deseja sacar (R$): ");
                decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

                bool conseguiuSacar = contaUm.Sacar(valorSaque);

                if (!conseguiuSacar)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("O valor do limite de débito já foi ultrapassado");
                }

                else
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("O valor foi sacado com sucesso");
                }

                Console.WriteLine("-------------------------------------");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();
            }
            else if (opcaoMenu == "2")
            {
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite o valor que deseja depositar ()R$: ");
                decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

                contaUm.Depositar(valorDeposito);

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("O valor foi depositado com sucesso!");
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();
            }
            else if (opcaoMenu == "3")
            {
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite o valor que deseja transferir (R$): ");
                decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

                bool conseguiurTransferir = contaUm.TransferirPara(contaDois, valorTransferencia);

                if (!conseguiurTransferir)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"Não foi possível transferir o valor de R${valorTransferencia} foi transferido com sucesso!");
                }
                else
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"O valor de R${valorTransferencia} foi transferido com sucesso!");
                }

                Console.WriteLine("-------------------------------------");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();
            }
            else if (opcaoMenu == "4")
            {
                decimal saldo = contaUm.ObterSaldo();

                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"O valor do saldo da conta é (R$): {saldo}");
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}