using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaWhile {
        public static void Executar() {
            Console.WriteLine("Estrutura while");

            int num = 0;
            Random rnd = new Random();

            while(num != 10) {
                Console.Write($"{num} ");
                num = rnd.Next(1, 11);//(1, 11) gera um numero aleatorio de 1 a 10.
            }
        }
    }
}
