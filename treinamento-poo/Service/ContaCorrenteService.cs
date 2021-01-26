using System;
using treinamento_poo.Model;

namespace treinamento_poo.Service
{
    /// <summary>
    /// Nesta classe vamos manter todas as regras de negócio da nossa pequena aplicação
    /// </summary>
    public class ContaCorrenteService
    {
        #region Metodos Públicos

        public void OperacaoSaque()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja sacar: " + "\n");
            var valor = Console.ReadLine();

            var valorConvertido = Convert.ToDouble(valor);

            //Informações da contaCorrente
            var contaCorrente = new ContaCorrente(){
                Titular = nome,
                Agencia = 2501,
                Numero = 202101,
                Saldo = 1500.00
            };

            //Double
            // Implemente a ação sacar aqui e exiba as informações para o usuário...
            var saque = Sacar(valorConvertido, contaCorrente.Saldo);

            //Frase
            Console.WriteLine();
            Console.WriteLine($"O {contaCorrente.Titular} " + $"fez o saque de: { valorConvertido} " + "\n" + 
                $"pois, o seu saldo agora é de: {saque} reais.");

            Console.ReadKey();
        }

        public void OperacaoDeposito()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja depositar: " + "\n");
            var valor = Console.ReadLine();

            var valorConvertido = Convert.ToDouble(valor);

            //Informações da contaCorrente
            var contaCorrente = new ContaCorrente()
            {
                Titular = nome,
                Agencia = 2501,
                Numero = 202101,
                Saldo = 1500.00
            };

            // implemente a ação depositar aqui e exiba as informações para o usuário...
            var deposito = Depositar(valorConvertido, contaCorrente.Saldo);

            //Frase
            Console.WriteLine();
            Console.WriteLine($"Foi efetuado um deposito no valor de: {valorConvertido} reais. " + $"Agora o {nome} " + $"está com R$ {deposito} reais.");

            Console.ReadKey();
        }

        public void OperacaoTransferencia()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja transferir: " + "\n");
            var valor = Console.ReadLine();
            var valorConvertido = Convert.ToDouble(valor);

            //Informações da contaCorrente
            var contaCorrente = new ContaCorrente()
            {
                Titular = nome,
                Agencia = 2501,
                Numero = 202101,
                Saldo = 1500.00
            };

            var contaDestino = new ContaCorrente()
            {
                Titular = "Jessica",
                Agencia = 2601,
                Numero = 202101,
                Saldo = 34.00
            };

            // implemente a ação transferir aqui e exiba as informações para o usuário
            var transferencia = Transferir(valorConvertido, contaCorrente.Saldo, contaDestino);

            //Tirando a prova real.
            //Console.WriteLine();
            //Console.WriteLine($"Conforme feito o deposito, agora (ela/ele): {contaDestino.Titular} está com o saldo de: R$ {contaDestino.Saldo} reais.");

            Console.ReadKey();
        }
        #endregion Metodos Públicos

        // criar os métodos Sacar, Depositar e Transferir como private
        #region Métodos Privados

        private double Sacar(double valor, double saldo)
        { 
            if (saldo < valor)
            {
                Console.WriteLine("Não foi possível concluir a tansação. Seu saldo é inferiro ao valor do saque");
            }
            else
            {
                //O Saldo irá subtrair com o valor digitado (em outro método)
                saldo -= valor;
                return saldo;
            }

            return saldo;
        }

        private double Depositar(double valor, double saldo)
        {
            saldo += valor;
            return saldo;
        }

        private bool Transferir(double valor, double saldo, ContaCorrente contaDestino)
        {
            if(saldo < valor)
            {
                Console.WriteLine("Não foi possível concluir a transação. Seu saldo é inferior ao valor que deseja transferir");
            }
            else
            {
                //O saldo da conta origem irá subtrair o valor
                saldo -= valor;
                //Enfiim a conta destino receberá o valor digitado
                contaDestino.Saldo += valor;
                Console.WriteLine($"Transferencia realizada com sucesso!. O seu saldo agora é de: R$ {saldo} reais.");


            }
            return true;
        }

        #endregion Métodos Privados
    }
}
