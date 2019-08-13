using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoAObjetos {

    class Animal {
        public string Nome { get; set; }

        public Animal( string nome) {
            Nome = nome;
        }
    }

    class Cachorro : Animal {

        public string Raca { get; set; }

        // : base() chama o construtor da super classe para setar o nome.
        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro: {Nome} foi instanciado.");
        }

        // :this() chama o construtor da propria classe para setar o nome e  o construtor anterior chama o construtor da super classe.
        public Cachorro(string nome, string raca) : this(nome) {
            Raca = raca;
        }

        public override string ToString() {
            return $"Nome: {this.Nome}, raca: {this.Raca}";
        }
    }


    class ConstrutorThis {

        public static void Executar() {
            Console.WriteLine("Construtor This");
            Console.WriteLine();

            Animal animal1 = new Cachorro("Tico", "Dalmata");
            //Como ToString implementado eh possivel obter os dados do objeto como string, do contrario o console mostraria o nome da classe
            Console.WriteLine(animal1); // Nesse contexto, o objeto precisa ser transformado em uma string. Logo, chama o To String automaticamente           
            Console.WriteLine(animal1.ToString());
        }
    }
}
