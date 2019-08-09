using System;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosVariaveis {
        //'params' permite ter uma quantidade de parametros variaveis para uma funcao
        public static void ListarPessoas(params string[] args) {
            Console.WriteLine("Listar parametros");
            Console.WriteLine("");
            foreach(var arg in args){
                Console.WriteLine($"{arg}");
            }
        }
        public static void Executar() {
            Console.WriteLine("Parametros variaveis");

            //Um metodo estatico da classe, chamado na propria classe
            ListarPessoas("Fagner", "Joseh", "Lurdes", "Tati");
        }
    }
}
