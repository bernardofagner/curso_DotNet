using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaContinue {
        public static void Executar() {
            Console.WriteLine("Estrutura continue");
            int limite = 50;

            for (int i = 0; i < limite; i++) {

                if (i%2 == 0) {
                    //interrompe a continuação da execução quando i for par, logo nao o exibe.
                    continue;
                }
                Console.Write($"{i} ");
            }
        }

    }
}
