using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public enum Genero {
        Acao,
        Aventura,
        Drama,
        Comedia,
        FiccaoCientifica,
        Animacao
    };

    public class Filme {
        public string titulo;
        public Genero generoDoFilme;
    }

    class Enumeracao {

        public static void Executar() {
            Console.WriteLine("Enumeracoes");
            int id = (int)Genero.Acao;            
            Console.WriteLine(id);

            id = (int)Genero.Aventura;
            Console.WriteLine(id);

            id = (int)Genero.Comedia;
            Console.WriteLine(id);

            id = (int)Genero.FiccaoCientifica;
            Console.WriteLine(id);

            Filme filme1 = new Filme();
            filme1.titulo = "Thunder Cats";
            filme1.generoDoFilme = Genero.Animacao;

            Console.WriteLine(filme1.generoDoFilme);


        }
    }
}
