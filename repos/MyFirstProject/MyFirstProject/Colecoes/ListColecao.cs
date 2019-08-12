using System;
using System.Collections.Generic; //Para usar List

namespace CursoCSharp.Colecoes {

    public class Produto {
        public string Nome;
        public double Valor;
        public int Quantidade;

        public Produto(string nome = "Base", double valor = 0.0, int quantidade = 1) {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public override bool Equals(object obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Valor == produto.Valor &&
                   Quantidade == produto.Quantidade;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Valor, Quantidade);
        }
    }

    class ListColecao {

        public static void Executar() {
            Console.WriteLine("Coleção Lista");
            Console.WriteLine();

            Produto livro = new Produto("A Queda dos Reinos - Primavera Rebelde", 45.60);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("A Queda dos Reinos - Tempestade de Cristal", 45.50),
                new Produto ("A Queda dos Reinos - A Ascensão das Trevas", 89.56),
                new Produto("A Queda dos Reinos - Maré Congelada", 75.40),
                new Produto("A Queda dos Reinos - Reinado Mortal", 71.99),
                new Produto("O Senhor dos Anéis - O Silmarillion", 45.20),
                new Produto("O Segredo Secreto", 10.20)
            };

            //Adiciona uma lista ao final de outra lista
            carrinho.AddRange(combo);

            Console.WriteLine(carrinho.Count);
            foreach(var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} - {item.Valor}");
            }

            Console.WriteLine();
            carrinho.RemoveAt(carrinho.Count-1);

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} - {item.Valor}");
            }
        }
    }
}
