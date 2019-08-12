using System;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {

        //Variavel q sera usado nas classes abaixo
        const int modificador = 100;

        //Recebe a referecia de um inteiro e altera seu valor
        //a palavra reservada ref representa uma passagem por referencia
        public static void AlteraRef(ref int valor) {
            valor = valor + modificador;
        }

        //Uma forma de enviar algo de dentro da funcao para uma variavel externa
        public static void AlterarOut(out int valor1) {
            valor1 = 0;
            valor1 = valor1 + modificador;
        }

        //polimorfismo do metodo acima
        public static void AlterarOut(out int valor1, out int valor2) {
            valor1 = 50;
            valor2 = 0;
            valor2 = valor2 + modificador;
        }

        public static void Executar() {
            Console.WriteLine("Prametros por referencia");

            int a = 5;
            Console.WriteLine($"a: {a}");
            AlteraRef(ref a);
            Console.WriteLine($"a alterado: {a}");

            int b;
            AlterarOut(out b);
            AlterarOut(out int c);
            AlterarOut(out int d, out int e);
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.WriteLine($"d: {d}, e: {e}.");
        }
    }
}
