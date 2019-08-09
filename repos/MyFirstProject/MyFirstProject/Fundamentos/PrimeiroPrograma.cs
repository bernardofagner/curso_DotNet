/*Importa a biblioteca padrão System para usar os métodos das classes dela. Ex.: classe Console, métoo WriteLine("msg")*/
using System;

namespace CursoCSharp.Fundamentos {
    class PrimeiroPrograma {
        public static void Executar() {
            //Escreve e para na mesma linha
            System.Console.Write("Olá: "); //Usar System aqui é desnecessário, pois a biblioteca foi importada
            //Escreve a msg e quebra a linha
            Console.WriteLine("Qual o seu nome?");
            Console.WriteLine("Meu nome é Enéas!");
        }
    }
}
