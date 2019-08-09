using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaForEach {
        public static void Executar() {
            Console.WriteLine("Estrutura foreach");

            string palavra = "parangaricutirrimirruaru";
            foreach(var letra in palavra) {
                Console.Write($"{letra}-");
            }

            string[] lista = new string[] {"Fagner", "Thiago", "Camila", "Natalia", "Chapolin"};
            foreach(var nome in lista) {
                Console.WriteLine($"Nome: {nome}");
            }
        }
    }
}
