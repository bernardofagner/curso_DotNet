using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaSwitch {
        public static void Executar() {
            Console.WriteLine("Estrutura switch");
            int opcao;
            char letra;
            Console.WriteLine("Digite qualquer coisa");
            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao) {
                case 1:
                    Console.WriteLine($"Faça algo com {opcao}.");
                    break;

                default:
                    Console.WriteLine("Não faz nada");
                    break;
            }

            Console.WriteLine("Digite uma letra");
            char.TryParse(Console.ReadLine(), out letra);

            switch (letra) {
                case 'a':
                    Console.WriteLine($"Faça algo com a letra {letra}.");
                    break;

                default:
                    Console.WriteLine("Entrou no default");
                    break;
            }
        }
    }
}
