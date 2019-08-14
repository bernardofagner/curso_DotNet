using System;
using System.IO; //Para usar arquivos

namespace CursoCSharp.API {

    //Classe que vai lidar como caminho ate a pasta Home, independente do SO
    public static class ExtensaoString{
        public static string ParseHome(this string path) {
            //Verifica qual SO esta por baixo deste programa e pega a variavel de ambiemte adequada
            string home =
                (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            //Retorna o caminho substituindo o '~' pelo caminho do sistema
            return path.Replace("~", home);
        }
    }
    class EscrevendoArquivos {

        public static void Executar() {
            Console.WriteLine("Escrevendo arquivos\n");

            //Deve-se usar '@' antes da string para q ela seja interpretada de forma literal, evitando conflitos com \n ou \t por exemplo
            //Deve-se tratar o acaracter til '~' para resolver a parte da home do usuario logado no sistema. Funcao ParseHome().

            var path = @"~\Downloads\origem\escrevendo_arquivo.txt".ParseHome();
            Console.WriteLine($"Arquivo armazenado em: {path}");

            if (!File.Exists(path)) {
                //Abre um escritor de stream para escrever no arquivo e fecha assim que acaba o contexto {}
                using (StreamWriter escritor = File.CreateText(path)) {
                    escritor.WriteLine("Era uma casa muito engraçada");
                    escritor.WriteLine("Não tinah teto, não tinha nada");
                    escritor.WriteLine("Ninguém podia entrar nela, não");
                    escritor.WriteLine("Porque na casa não tinha chão");
                }
            }

            //Continua a editar o arquivo apos a ultima linha ja escrita
            using (StreamWriter escritor = File.AppendText(path)) {
                escritor.WriteLine("Era uma casa muito engraçada");
                escritor.WriteLine("");
                escritor.WriteLine("Ninguém podia dormir na rede");
                escritor.WriteLine("Porque na casa não tinha parede");
                escritor.WriteLine("Ninguém podia fazer xixi");
                escritor.WriteLine("Porque penico, não tinha ali");
            }
        }
    }
}
