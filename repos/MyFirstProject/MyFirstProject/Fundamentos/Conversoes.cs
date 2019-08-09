using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            Console.WriteLine("Conversoes explicitas de tipo");

            int num1 = 100;
            double num2 = 300.0, num3;
            num3 = num1;
            num1 = (int)num2;

            Console.Write("Digite um numero, mas pode tentar digitar letra se quiser, pra ver o que dá ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine($"O primeiro numero informado foi {numero1}.");

            Console.Write("Digite um numero, mas pode tentar digitar letra se quiser, pra ver o que dá ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"O segundo numero informado foi {numero2}.");
        }
    }
}
