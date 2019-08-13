using System;

namespace Encapsulamento {
    public class FilhoReconhecido : SubCelebridade{

        public override void MeusAcessos() {
            Console.WriteLine("Filho reconhecido - Mesmo projeto com heranca");
            Console.WriteLine(InfoPublic);
            Console.WriteLine(InfoProtected);
            Console.WriteLine(InfoInternal);
            Console.WriteLine(InfoProtectedInternal);
            Console.WriteLine(InfoPrivateProtected);
            //Console.WriteLine(InfoPrivada); //Nao pode ser acessado diretamente
            Console.WriteLine();
        }
    }
}
