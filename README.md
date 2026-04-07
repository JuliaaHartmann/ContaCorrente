# Conta Corrente

## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2026

## Introdução

Uma conta corrente é composta por diversos atributos essenciais para sua operação. Ela possui um número de identificação único, um saldo disponível e um limite de débito estabelecido. Além disso, a conta mantém um registro de movimentações financeiras, que englobam todas as transações realizadas.

Cada movimentação registrada na conta corresponde a uma transação financeira, que pode ser classificada como crédito (depósito ou entrada de dinheiro) ou débito (saque ou retirada de fundos). Cada transação contém um valor associado e impacta diretamente o saldo da conta.

As operações disponíveis para uma conta corrente incluem:

- Saque: Permite a retirada de valores, respeitando o limite máximo permitido.
- Depósito: Possibilita a adição de fundos à conta.
- Consulta de saldo: Fornece informações atualizadas sobre o montante disponível.
- Emissão de extrato: Lista todas as movimentações realizadas em um período específico.
- Transferência entre contas: Permite a movimentação de valores entre contas correntes distintas.

No que se refere aos saques, a conta corrente só pode efetuar retiradas caso o valor solicitado não ultrapasse o limite de saque permitido, que corresponde à soma do saldo disponível com o limite adicional concedido à conta.

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

   ```bash
   dotnet restore
   ```

4. Para executar o projeto compilando em tempo real

   ```bash
   dotnet run --project ContaCorrente.ConsoleApp
   ```

## Requisitos

- .NET 10.0 SDK