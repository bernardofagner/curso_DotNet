using System;


namespace CursoCSharp.Colecoes {
    class ArrayColecao {
        public static void Executar() {
            Console.WriteLine("Colecao array");
            Console.WriteLine("");

            //Sintaxe de criacao de um array
            string[] Nomes = new string[5]; //Alocacao explicita
            string[] Cidades = {"BH", "Mariana", "Ouro Preto","Lafaiete"}; //Alocacao implicita
            int[] Vetor = new int[5];
            char[] Letras = { 't', 'o', 'u', 'c', 'h' };

            Nomes[0] = "Felipe?";
            Nomes[1] = "Smith?";
            Nomes[2] = "Bixão";
            Nomes[3] = "Enéas";
            Nomes[4] = "Ronaldo";

            Vetor[0] = 1;
            Vetor[1] = 10;
            Vetor[2] = 100;
            Vetor[3] = 1000;
            Vetor[4] = 10000;
            Console.WriteLine(Nomes[0]);

            foreach(var nome in Nomes) {
                Console.Write($"{nome}, ");
            }

            Console.WriteLine("");

            foreach (var num in Vetor) {
                Console.Write($"{num}, ");
            }

            Console.WriteLine("");

            foreach (var cidade in Cidades) {
                Console.Write($"{cidade} ");
            }
            Console.WriteLine("");

            Console.WriteLine($"qtd cidaes: {Cidades.Length}");

            foreach (var letra in Letras) {
                Console.Write($"{letra} ");
            }
            Console.WriteLine("");

            String palavra = new String(Letras);
            Console.WriteLine($"String criada: {palavra}");

            for(int i = 0; i < Vetor.Length; i++) {
                Console.Write($"{Vetor[i]}, ");
            }
            Console.WriteLine("");
        }
    }
}
