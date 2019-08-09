using System;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {

        //Recebe a referecia de um inteiro e altera seu valor
        //a palavra reservada ref representa uma passagem por referencia
        public static void AlteraRef(ref int valor) {
            valor = valor + 100;
        }

        //
        public static void AlterarOut(int valor) {
            valor = valor + 50;
        }

        public static void Executar() {
            Console.WriteLine("Prametros por referencia");

            int a = 5;
            Console.WriteLine(a);
            AlteraRef(ref a);
            Console.WriteLine(a);
        }
    }
}
