using System;

namespace Encapsulamento {
    public class AmigoProximo {

        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos() {

            Console.WriteLine("Amigo proximo - Mesmo projeto sem heranca");

            Console.WriteLine(amigo.InfoPublic);
            //Console.WriteLine(amigo.InfoProtected);
            Console.WriteLine(amigo.InfoInternal);
            Console.WriteLine(amigo.InfoProtectedInternal);
            //Console.WriteLine(amigo.InfoPrivateProtected);
            //Console.WriteLine(amigo.InfoPrivada);
            Console.WriteLine();

        }
    }
}
