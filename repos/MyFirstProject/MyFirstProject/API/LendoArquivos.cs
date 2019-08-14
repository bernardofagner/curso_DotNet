using System;
using System.IO;

namespace CursoCSharp.API {
    class LendoArquivos {

        public static void Executar() {
            Console.WriteLine("Lendo arquivos\n");

            var path = @"~\Downloads\origem\lendo_arquivos.txt".ParseHome(); //Chama o metodo estatico da classe EscrevendoArquivos

            if (!File.Exists(path)) {
                using (StreamWriter escritor = File.AppendText(path)) {
                    escritor.WriteLine("Nome;Preco;Quantidade");
                    escritor.WriteLine("Caneta;4.50;5");
                    escritor.WriteLine("Borracha;0.45;10");
                }
            }

            try {
                using (StreamReader leitor = new StreamReader(path)) {
                    var texto = leitor.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch(IOException e) {
                Console.WriteLine(e.Message); ;
            }catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
