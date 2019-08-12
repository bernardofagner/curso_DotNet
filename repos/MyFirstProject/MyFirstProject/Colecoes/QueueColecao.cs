using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    class QueueColecao {
        public static void Executar() {
            Console.WriteLine("Colecao Queue");
            Console.WriteLine();

            //Instancia uma fila
            var fila = new Queue<string>();
            var fila2 = new Queue<Produto>();

            fila2.Enqueue(new Produto("A Queda dos Reinos - Tempestade de Cristal", 45.50));

            for (int i = 0; i < 10; i++) {
                //Adiciona itens a fila
                fila.Enqueue("Registro " + i);
            }

            foreach (var item in fila) {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("Qtd de itens na fila: " + fila.Count);
            Console.WriteLine($"Item: <{fila.Dequeue()}> removido da fila");
            Console.WriteLine("Qtd de itens na fila: " + fila.Count);

            foreach (var item in fila) {
                Console.WriteLine($"{item}");
            }

            //Pega o elemento na primeira posicao da fila (o candidato a sair da fila)
            Console.WriteLine($"Pega o primeiro item da fila: {fila.Peek()}");



        }
    }
}
