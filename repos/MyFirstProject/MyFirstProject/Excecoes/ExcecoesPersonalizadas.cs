using System;

namespace CursoCSharp.Excecoes {

    //Excecoes personalizadas tem uma relação É UM, logo herda da classe Exception
    class NegativeException : Exception {
        
        //Construtor padrao
        public NegativeException() { }
        //Cria um construtor que recebe uma msg. Logo, deve inicializar o construtor da superclasse, pois a variavel que ficara c a msg esta la
        public NegativeException(string msg) : base(msg) { }

        //Define um construtor que pode receber outra excecao que pode ter lancado essa excecao (falha de rede, por exemplo)
        public NegativeException(string msg, Exception inner) : base(msg, inner) { }

    }

    class ImparException : Exception {
        //Cria um construtor que recebe uma msg. Logo, deve inicializar o construtor da superclasse, pois a variavel que ficara c a msg esta la
        public ImparException(string msg) : base(msg) { }
    }

    class ExcecoesPersonalizadas {

        //Metodo para testar as excecoes personalizadas.
        public static int GeraPositivoPar() {
            Random rnd = new Random();
            int valor = rnd.Next(-30, 30);

            if(valor < 0) {
                throw new NegativeException("Valor negativo gerado");
            }

            if(valor%2 != 0) {
                throw new ImparException("Valor impar gerado");
            }

            return valor;
        }

        public static void Executar() {
            Console.WriteLine("Excecoes personalizadas\n");
            try {
                Console.WriteLine(GeraPositivoPar());
            }catch(NegativeException e) {
                Console.WriteLine("Excecao de " + e.Message);
                //Gera log do erro eh melhor q mandar msg p o usuario
            }catch(ImparException e) {
                Console.WriteLine("Excecao de " + e.Message);
                //Gera log do erro eh melhor q mandar msg p o usuario
            }
        }
    }
}
