using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            Console.WriteLine("Notação ponto");

            string resultado = "Mensagem original".ToUpper().Insert(8, " texto inserido");
            Console.WriteLine(resultado);
            resultado = resultado.Replace("ORIGINAL", "MODIFICADA");
            Console.WriteLine(resultado);
            Console.WriteLine($"Comprimeno da string {resultado.Length}");

            string msg = null;
            Console.WriteLine($"Tentando ler o tamanho da string msg: {msg?.Length}");
            msg = "Oi";
            Console.WriteLine($"Tentando ler o tamanho da string msg: {msg?.Length}");
        }
    }
}
