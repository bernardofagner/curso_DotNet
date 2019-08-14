using System;
using System.IO;

namespace CursoCSharp.API {
    class Diretorios {

        public static void Executar() {
            Console.WriteLine("Sobre Diretorios\n");

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
                Directory.CreateDirectory(novoDir); //Nao sei pq nao esta criando o diretorio, tentar tirar o 'Documentos' do path e deixar na raiz
                Console.WriteLine(novoDir);
                //Console.WriteLine(Directory.GetDirectories(@"~\Documentos".ParseHome()));
                Console.WriteLine(Directory.GetCreationTime(novoDir));
            }catch(Exception e) {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("========================== Pastas do projeto ==========================");
            var pastas = Directory.GetDirectories(dirProjeto);

            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine($"Criado em: {Directory.GetCreationTime(dirProjeto)}\n");

            Console.WriteLine("===================== Arquivos na raiz do projeto =====================");
            var arquivos = Directory.GetFiles(dirProjeto);

            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine();

            Console.WriteLine("================================ Raiz =================================");

            Console.WriteLine(Directory.GetDirectoryRoot(dirProjeto));
            Console.WriteLine();

            Console.WriteLine("=======================================================================");

            Directory.Move(novoDir, novoDestino);
        }
    }
}
