using System;
using System.Collections.Generic;

namespace CursoCSharp.OrientacaoAObjetos {

    interface Informativo {
        string Informacao();
    }
    interface OperacaoBinaria {
        //Implicitamnte todos os metodos de uma interface sao publics e abstracts
        int Operacao(int a, int b);
    }

    //Implementa multiplas interfaces
    class Soma : OperacaoBinaria, Informativo {
        public int Operacao(int x, int y) {
            return x + y;
        }

        public string Informacao() {
            return "Soma";
        }
    }

    class Subtracao : OperacaoBinaria {
        //Outra forma de implementar funcoes
        public int Operacao(int x, int y) => x - y;
    }

    class Multiplicacao : OperacaoBinaria {
        //Outra forma de implementar funcoes
        public int Operacao(int x, int y) => x * y;
    }

    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string SomaSubtraiMultiplica(int a, int b) {
            string resultado = null;

            foreach (var op in operacoes) {
                resultado += $"Usando a operacao {op.GetType().Name} de {a} e {b} = {op.Operacao(a, b)} \n";
            }

            return resultado;
        }
    }

    class Interface {

        public static void Executar() {
            Console.WriteLine("Interface");
            Console.WriteLine();            var calculadora = new Calculadora();            Console.WriteLine(calculadora.SomaSubtraiMultiplica(10, 5));
        }
    }
}
