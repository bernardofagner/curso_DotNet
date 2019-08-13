using System;
using Encapsulamento; //Importa o namespace Encapsulamento

namespace CursoCSharp.OrientacaoAObjetos {

    public class FilhoNaoReconhecido : SubCelebridade {

        public override void MeusAcessos() {
            //base.MeusAcessos();
            Console.WriteLine("Filho nao reconhecido - Projeto diferente com heranca");

            Console.WriteLine(InfoPublic);
            Console.WriteLine(InfoProtected);
            //Console.WriteLine(InfoInternal);
            Console.WriteLine(InfoProtectedInternal);
            //Console.WriteLine(InfoPrivateProtected);
            //Console.WriteLine(InfoPrivada);
            Console.WriteLine();
        }

    }

    class AmigoDistante {
        public readonly SubCelebridade AmigoD = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo distante - Projeto diferente sem hranca");

            Console.WriteLine(AmigoD.InfoPublic);
            //Console.WriteLine(AmigoD.InfoProtected);
            //Console.WriteLine(AmigoD.InfoInternal);
            //Console.WriteLine(AmigoD.InfoProtectedInternal);
            //Console.WriteLine(AmigoD.InfoPrivateProtected);
            //Console.WriteLine(AmigoD.InfoPrivada);
            Console.WriteLine();
        }
    }
    class Encapsulamento {

        public static void Executar() {
            Console.WriteLine("Classe Encapsulamento - Chama todas as instancias de outra classe");
            Console.WriteLine();

            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            //Instancia e nao armazena o objeto. Ele morre depois do termino do metodo MeusAcessos()
            new FilhoReconhecido().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new AmigoDistante().MeusAcessos();

        }
    }
}
