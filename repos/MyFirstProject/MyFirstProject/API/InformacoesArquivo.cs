using System;
using System.IO;

namespace CursoCSharp.API {
    class InformacoesArquivo {

        //Apaga todos os arquivos criados na execucao anterior
        public static void ApagaSeExistir(params string[] paths) {

            foreach (var path in paths) {
                FileInfo arquivo = new FileInfo(path);
                if (arquivo.Exists) {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar() {
            Console.WriteLine("File info\n");

            var originPat1 = @"~/Downloads/origem/arquivo_a_mover.txt".ParseHome();
            var originPath2 = @"~/Downloads/origem/arquivo_a_mover.txt".ParseHome();
            var destinationPath = @"~/Downloads/destino/arquivo_destino.txt".ParseHome();
            var copyPath = @"~\Downloads\copia\arquivo_copiado_do_original.txt".ParseHome();

            ApagaSeExistir(originPat1, copyPath, destinationPath);

            try {
                using (StreamWriter escritor = File.CreateText(originPat1)) {
                    escritor.WriteLine("Arquivo original 1"); //Se o arquivo nao existir ele eh criado e recebe essa linha de texto
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            try {
                using (StreamWriter escritor = File.CreateText(originPath2)) {
                    escritor.WriteLine("Arquivo original 2"); //Se o arquivo nao existir ele eh criado e recebe essa linha de texto
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            FileInfo origem1 = new FileInfo(originPat1); //Cria uma instancioa que contem informacoes do caminho de origem
            FileInfo origem2 = new FileInfo(originPath2); //Cria uma instancioa que contem informacoes do caminho de origem
            Console.WriteLine("Informacoes sobre a origem");
            Console.WriteLine("Nome: " + origem1.Name);
            Console.WriteLine("Nome completo: " + origem1.FullName);
            Console.WriteLine("Tamanho: " + origem1.Length);
            Console.WriteLine("Extensao: " + origem1.Extension);
            Console.WriteLine("Nome do diretorio: " + origem1.DirectoryName);

            origem1.CopyTo(copyPath);
            origem2.MoveTo(destinationPath);
        }
    }
}
