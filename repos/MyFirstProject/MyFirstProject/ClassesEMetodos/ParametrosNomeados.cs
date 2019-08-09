using System;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {

        public static void FormatarData(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Executar() {
            Console.WriteLine("Parametros nomeados");

            //chama o metodo nomeando os parametros
            //Isso permite passa-los em qualquer ordem.
            FormatarData(ano:2019, mes:8, dia:8);
        }
    }
}
