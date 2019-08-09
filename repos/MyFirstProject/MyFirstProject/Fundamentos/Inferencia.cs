using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            Console.WriteLine("Inferencia");

            var nome = "Fagner"; //Inferiu o tipo string
            Console.WriteLine("Variavel tipo string " + nome);
        }
    }
}
