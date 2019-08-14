using System;
using System.IO;

namespace CursoCSharp.API {
    class Diretorios {

        public static void Executar() {
            Console.WriteLine("Diretorios");

            var novoDir = @"~\Documentos\PastaCSharp".ParseHome();
            var novoDestino = @"~\Documentos\PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~\source\repos\MyFirstProject\MyFirstProject".ParseHome();

            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true); //True faz exclusao recursiva (todos os diretorios dentro do novoDir
            }

            if (Directory.Exists(novoDestino)) {
                Directory.Delete(novoDestino, true);
            }

            try{
                Directory.CreateDirectory(novoDir);
                Console.WriteLine(Directory.GetCreationTime(novoDir));
            }catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
