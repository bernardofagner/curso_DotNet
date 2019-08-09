using System;

namespace CursoCSharp.ClassesEMetodos {
    class SobreClasses {
        //Variaveis da classe começam com letra maiuscula
        //Variaveis de metodos começam com letra minuscula

        public static void Executar() {
            Console.WriteLine("Sobre classes");

            Pessoa p1 = new Pessoa("Fagner", 30);
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();
            p3.SetNome("Eneas");
            p3.SetIdade(56);
            Console.WriteLine(p1.Apresentacao());
            Pessoa.SetEspecie("Animal");
            Console.WriteLine(p2.Apresentacao());
            Pessoa.SetEspecie("Planta");
            Console.WriteLine(p3.Apresentacao());

            //Utilizacao de metodo estatico de outra classe, deve-se informar o nome da classe e depois o metodo
            Pessoa.TesteStaticMethods();

            //Teste set and get

        }
    }
}
