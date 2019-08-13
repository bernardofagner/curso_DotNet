using System;

namespace CursoCSharp.Excecoes {

    public class Conta {
        double saldo;

        public Conta(double saldo) {
            this.saldo = saldo;
        }

        public void Sacar(double valor) {
            if (valor > saldo) {
                //Implementa uma excecao, caso o valor a ser sacado seja maior que o saldo da conta
                throw new ArgumentException("Saldo insuficiente");
            }

            this.saldo -= valor;
        }
    }
    class PrimeiraExcecao {

        public static void Executar() {
            Console.WriteLine("Primeira excecao");

            Conta c1 = new Conta(1_450.00);

            //Ao utilizar um metodo que possa lanar uma excecao, como o metodo sacar, eh interessante usa-lo em um bloco try catch
            //Tentar se conectar a um banco de dados...
            try {
                int.Parse("abc"); //Comente essa linha p ver outra excecao
                c1.Sacar(3000.00);
                Console.WriteLine("Saque realizado.");
            } catch (Exception e) {
                //Exception representa um tratamento mais generico, vai lançar a excessao p o primeiro problema encontrado
                //ArgumentException eh um tratamento mais especifico
                //Se vc instanciou algum objeto temporario, ou fez qualquer coisa que deixou "portas abertas no sistema"
                //Aqui eh a hora de fechar essas portas e tratara o problema (fechar um socket, finalizar uma thread...).
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.Message);
            } finally {
                Console.WriteLine("Deseja fazer outra operacao?\n");
            }
        }
    }
}
