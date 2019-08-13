using System;
using System.IO; //Para usar arquivos

namespace CursoCSharp.API {

    //Classe que vai lidar como caminho ate a pasta do projeto
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
    class PrimeiroArquivo {

        public static void Executar() {
            Console.WriteLine("Primeiro arquivo\n");

            //Deve-se usar '@' antes da string para q ela seja interpretada de forma literal, evitando conflitos com \n ou \t por exemplo
            //Deve-se tratar o acaracter til '~' para resolver a parte da home do usuario logado no sistema. Funcao ParseHome().

            var path = @"~\Downloads\primeiro_arquivo.txt".ParseHome();
            Console.WriteLine(path);

            if (!File.Exists(path)) {
                //Abre um escritor de stream para escrever no arquivo e fecha assim que acaba o contexto {}
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Era uma casa muito engraçada");
                    sw.WriteLine("Não tinah teto, não tinha nada");
                    sw.WriteLine("Ninguém podia entrar nela, não");
                    sw.WriteLine("Porque na casa não tinha chão");
                }

                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Era uma casa muito engraçada");
                    sw.WriteLine("");
                    sw.WriteLine("Ninguém podia dormir na rede");
                    sw.WriteLine("Porque na casa não tinha parede");
                    sw.WriteLine("Ninguém podia fazer xixi");
                    sw.WriteLine("Porque penico, não tinha ali");
                }
            }
        }
    }
}
