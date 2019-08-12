using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class StackColecao {
        public static void Executar() {
            Console.WriteLine("Colecao Stack(Pilha)");

            var pilhaDeProdutos = new Stack<Produto>();

            pilhaDeProdutos.Push(new Produto("A Queda dos Reinos - Tempestade de Cristal", 45.50));
            pilhaDeProdutos.Push(new Produto("A Queda dos Reinos - Maré Congelada", 75.40));
            pilhaDeProdutos.Push(new Produto("A Queda dos Reinos - A Ascensão das Trevas", 89.56));
            pilhaDeProdutos.Push(new Produto("A Queda dos Reinos - Reinado Mortal", 71.99));
            pilhaDeProdutos.Push(new Produto("O Senhor dos Anéis - O Silmarillion", 45.20));
            pilhaDeProdutos.Push(new Produto("O Segredo Secreto", 10.20));

            Console.WriteLine($"Quantidade de intens na pilha: {pilhaDeProdutos.Count}");
            foreach(var item in pilhaDeProdutos) {
                Console.WriteLine($"Item da pilha (top to down): {item.Nome}");
            }

            Console.WriteLine();
            var produtoRemovido = pilhaDeProdutos.Pop();
            Console.WriteLine($"Item removido do topo da pilha: {produtoRemovido.Nome}");
            Console.WriteLine();

            Console.WriteLine($"Quantidade de intens na pilha: {pilhaDeProdutos.Count}");
            foreach (var item in pilhaDeProdutos) {
                Console.WriteLine($"Item da pilha (top to down): {item.Nome}");
            }

            Console.WriteLine();
            Console.WriteLine($"Pega o item do topo da pilha (sem remove-lo): {pilhaDeProdutos.Peek().Nome}");
            Console.WriteLine();


        }
    }
}
