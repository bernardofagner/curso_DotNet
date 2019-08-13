using System;

namespace CursoCSharp.MetodosEFuncoes {

    class TesteDaAction {
        public void Testando() {
            Console.WriteLine("Teste bem suscedido");
            Console.WriteLine();
        }
    }

    class ExpressaoLambda {
        public static void Executar() {
            Console.WriteLine("Expressao Lambda");
            Console.WriteLine();

            TesteDaAction testar = new TesteDaAction();

            // Passa o metodo a ser executado para a Action
            Action teste_01 = testar.Testando;

            //Tenta executar o teste
            try {
                Console.WriteLine("Tentando executar o teste...");
                teste_01();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            //Definicao da expressao Lamnda
            Action algoNoConsole = () => {
                Console.WriteLine("Conteudo da Lambda");
            };

            //Nao possui parametros de entrada e o retorno eh do tipo 'int'
            Func<int> jogarD6 = () => {
                Random rnd = new Random();
                return rnd.Next(1, 7);
            };

            //Recebe 2 inteiros como parametro e retorna uma string
            Func<int, string> qqCoisa = n1 => {
                return (n1.ToString());
            };

            //Mesma coisa da funcao acima, mas numa outra sintaxe, sem return
            Func<int, string> qqCoisa2 = n1 => (n1.ToString("X")); //conversao p Hexadecimal

            //Expressao Lambda com mais de um argumento deve organiza-los em uma tupla (a, b, c, d, e, ...).
            //O ultimo parametro da lista é o tipo do retorno
            Func<int, int, int, string> formatarData = (dia, mes, ano) => $"{dia:D2}/{mes:D2}/{ano}"; //D2, indica 2 digitos para a representacao do dado

            //Chamada
            algoNoConsole();
            Console.WriteLine(jogarD6());
            Console.WriteLine(qqCoisa(10));
            Console.WriteLine(qqCoisa2(2543));
            Console.WriteLine(formatarData(3, 8, 2019));
        }
    }
}
