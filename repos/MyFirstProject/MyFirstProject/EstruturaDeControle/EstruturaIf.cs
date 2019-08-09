using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIf {
        public static void Executar() {
            Console.WriteLine("Estrutura if");

            Console.WriteLine("Digite numero e veja ele, digite string e veja uma msg");
            Double.TryParse(Console.ReadLine(), out double valor);
            if (valor != 0) {
                Console.WriteLine($"O valor informado foi: {valor}");
            }
            else {
                Console.WriteLine("O dado informado nao eh um numero");
            }

            string palavra = "S";
            bool info;

            info = palavra == "S" || palavra == "s";
        }
    }
}
