using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            Console.WriteLine("Interpolação de strings");

            string nomeDoPersonagem = "Vincent Evellas";
            string nomeDoFamiliar = "Eol";
            string terraNatal = "Aglarond";
            int idade = 19;

            //Forma 1
            Console.WriteLine("O personagem {0}, nascido em {1}, tem {2} anos de idade e um familiar chamado {3}",
                nomeDoPersonagem, terraNatal, idade, nomeDoFamiliar);
            // Forma 2
            Console.WriteLine($"O personagem {nomeDoPersonagem}, nascido em {terraNatal}, tem {idade} anos de idade e um familiar chamado {nomeDoFamiliar}");

            //Interpolar operacoes
            Console.WriteLine($"Soma de 2 + 3 = {2+3}");
        }
    }
}
