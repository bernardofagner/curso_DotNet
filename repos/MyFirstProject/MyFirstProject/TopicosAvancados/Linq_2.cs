using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    class Linq_2 {

        public static void Executar() {
            Console.WriteLine("Language Integrated Quere - LINQ, parte 2\n");

            List<Aluno> diabinhos = new List<Aluno>() {
                new Aluno("Eneas", 56, 10.0),
                new Aluno("Lula", 65, 3.0),
                new Aluno("Aecio Neves", 54, 2.8),
                new Aluno("Marina", 108, 4.8 ),
                new Aluno("Dilma", 62, 1.5 ),
                new Aluno("Bolsonaro", 57, 6.0 ),
                new Aluno("Ciro", 64, 7.5 ),
            };

            string procurado = "Simba";

            var singleImp = diabinhos.Single(a => a.Nome.Equals("Eneas"));
            Console.WriteLine("Single " + singleImp.Nome);

            var anotherImp = diabinhos.SingleOrDefault(a => a.Nome.Equals(procurado));
            if(anotherImp == null) {
                Console.WriteLine($"Diabinho {procurado} nao encontrado");
            }

            //Pula o primeiro aluno e pega os 3 seguintes. Bom para fazer paginacao.
            var exemploSkip = diabinhos.Skip(1).Take(3);

            foreach (var imp in exemploSkip) {
                Console.WriteLine(imp.Nome);
            }

        }
    }
}
