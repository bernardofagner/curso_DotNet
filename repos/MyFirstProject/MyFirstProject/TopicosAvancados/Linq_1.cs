using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {

    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;

        public Aluno(string nome = "", int idade = 0, double nota = 0.0) {
            Nome = nome;
            Idade = idade;
            Nota = nota;
        }
    }
    class Linq_1 {

        public static void Executar() {
            Console.WriteLine("Language Integrated Quere - LINQ, parte 1\n");

            List<Aluno> diabinhos = new List<Aluno>() {
                new Aluno("Eneas", 56, 10.0),
                new Aluno("Lula", 65, 3.0),
                new Aluno("Aecio Neves", 54, 2.8),
                new Aluno("Marina", 108, 4.8 ),
                new Aluno("Dilma", 62, 1.5 ),
                new Aluno("Bolsonaro", 57, 6.0 ),
                new Aluno("Ciro", 64, 7.5 ),
            };

            Console.WriteLine("=================== Diabinhos aprovados ===================\n");

            //Where retorna uma nova lista com todos os elementos da lista anterior quando sua avaliacao retornou True
            // [ imp => imp.Nota >= 6]  A expresao em colchetes eh uma expressao lambda, arrow function
            // Where  == Filter
            var diabinhosAprovados = diabinhos.Where(imp => imp.Nota >= 6).OrderBy(imp => imp.Nome);
            //Console.WriteLine(diabinhosAprovados.GetType().Name);

            foreach (var imp in diabinhosAprovados) {
                Console.WriteLine(imp.Nome);
            }
            Console.WriteLine();

            Console.WriteLine("=================== Lista de Diabinhos ===================\n");

            //Select() == Map
            // O rtorno eh um iterator
            var listaDeChamada = diabinhos.OrderBy(imp => imp.Nome).Select(imp => imp.Nome);

            //Console.WriteLine(listaDeChamada.GetType().Name);
            foreach (var imp in listaDeChamada) {
                Console.WriteLine(imp);
            }

            var listaFinal =
                from imp in diabinhos
                where imp.Nota <= 6
                orderby imp.Idade
                select imp.Nome;

            Console.WriteLine("===================== Lista final =========================\n");

            foreach (var imp in listaFinal) {
                Console.WriteLine(imp);
            }
        }
    }
}
