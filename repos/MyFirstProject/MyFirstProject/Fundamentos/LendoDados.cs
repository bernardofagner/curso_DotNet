using System;
using System.Globalization; //Permite usar '.' em vez de ',' na hora de passar valores numericos no console

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Lendo dados");

            Console.Write("Insira um nome ");
            string nome = Console.ReadLine();
            Console.WriteLine($"O nome informado eh: {nome}.");

            Console.Write("Insira uma idade ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"A idade informada é: {idade}.");

            //Usando System.Globalization
            Console.Write("Insira um valor fracionado ");
            double valorFracionado1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"O valor fracionado informado eh: {valorFracionado1}");
            //Sem usar System.Globalization
            Console.Write("Insira outro valor fracionado ");
            double valorFracionado2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"O outro valor fracionado eh: {valorFracionado2}");
        }
    }
}
