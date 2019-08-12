using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class DictionaryColecao {

        public static void Executar() {
            Console.WriteLine("Colecao Dictionary");

            var filmes = new Dictionary<int, string>(); //Parecido com hash

            filmes.Add(1, "Harry Potter e a Pedra Filosofal");
            filmes.Add(2, "Harry Potter e a Câmara Secreta");
            filmes.Add(3, "Harry Potter e o Prisioneiro de Azkaban");
            filmes.Add(4, "Harry Potter e o Calice de Fogo");
            filmes.Add(5, "Harry Potter e a Ordem da Fenix");
            filmes.Add(6, "Harry Potter e o Enigma do Principe");
            filmes.Add(7, "Harry Potter e as Reliquias da Morte");

            Console.WriteLine();
            Console.WriteLine("Lista de filmes");

            foreach(var filme in filmes) {
                Console.WriteLine($"Filme registrado: {filme.Key} - {filme.Value}");
            }
            Console.WriteLine();

            Console.Write("Chave pesquisada foi encontrada? ");
            Console.WriteLine(filmes.ContainsKey(1));
            Console.Write("Valor pesquisado foi encontrado? ");
            Console.WriteLine(filmes.ContainsValue("Harry Potter e a Pedra Filosofal"));

            // Remove baseado na chave.
            Console.Write("Removeu um filme? ");
            Console.WriteLine(filmes.Remove(1));

            filmes.TryGetValue(2, out string filmin); //Usa a chave na pesquisa e recupera o valor
            Console.WriteLine($"Filme selecionado sem remover do dicionario: {filmin}");
            Console.WriteLine();

            Console.WriteLine("Lista de filmes");
            foreach (var filme in filmes) {
                Console.WriteLine($"Filme registrado: {filme.Key} - {filme.Value}");
            }

            //Estrategias para percorrer o dicionario
            //Busca por chave
            Console.WriteLine();
            foreach (var chave in filmes.Keys) {
                Console.WriteLine($"Chaves no dicionario: {chave}");
            }

            //Busca por valor
            Console.WriteLine();
            foreach (var valor in filmes.Values) {
                Console.WriteLine($"Valores no dicionario: {valor}");
            }

            //Busca por chave/valor(KeyValuePair)
            Console.WriteLine();
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"A chave {filme.Key} pertence ao filme: {filme.Value}");
            }

            //Inferencia de chave/valor(KeyValuePair) realizada pelo compilaador
            Console.WriteLine();
            foreach (var filme in filmes) {
                Console.WriteLine($"A chave {filme.Key} pertence ao filme: {filme.Value}");
            }
        }
    }
}
