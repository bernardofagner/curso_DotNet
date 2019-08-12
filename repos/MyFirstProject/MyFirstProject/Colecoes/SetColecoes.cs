using System;
using System.Collections.Generic; //Para usar List

namespace CursoCSharp.Colecoes {
    //Nao eh preciso redefinir a classe produto, pois ela ja foi definida no arquivo 'ListColecao' que esta neste mesmo namespace

    class SetColecoes {

        public static void Executar() {
            Console.WriteLine("Coleção Set");
            Console.WriteLine();

            Produto livro = new Produto("A Queda dos Reinos - Primavera Rebelde", 45.60);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("A Queda dos Reinos - Tempestade de Cristal", 45.50),
                new Produto ("A Queda dos Reinos - A Ascensão das Trevas", 89.56),
                new Produto("A Queda dos Reinos - Maré Congelada", 75.40),
                new Produto("A Queda dos Reinos - Reinado Mortal", 71.99),
                new Produto("O Senhor dos Anéis - O Silmarillion", 45.20),
                new Produto("O Segredo Secreto", 10.20)
            };

            //Adiciona um arraylist ao final de outro arraylist
            carrinho.UnionWith(combo);

            Console.WriteLine(carrinho.Count);
            foreach (var item in carrinho) {
                Console.WriteLine($" {item.Nome} - {item.Valor} - {item.Quantidade}");
            }

            Console.WriteLine();

            foreach (var item in carrinho) {
                Console.WriteLine($" {item.Nome} - {item.Valor} {item.Quantidade}");
            }
        }
    }
}
