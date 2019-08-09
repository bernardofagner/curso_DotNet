using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            // Um atributo readonli so pode ser modificado no construtor
            Nascimento = new DateTime(2000, 1, 1); //Valor default
            Nascimento = nascimento;

        }

        public string GetDataNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    class ReadOnly {
    public static void Executar() {
            Console.WriteLine("Ready only");

            Cliente c1 = new Cliente("Fagner", new DateTime(1989, 5, 25));

            Console.WriteLine(c1.Nome);
            Console.WriteLine(c1.GetDataNascimento());

            //c1.Nascimento = new DateTime(2018, 1, 20);
        }
    }
}
