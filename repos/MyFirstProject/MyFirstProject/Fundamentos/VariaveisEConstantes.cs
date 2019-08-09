using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            Console.WriteLine("Variaveis, tipos e constantes");
            Console.WriteLine("");

            const double margemErro = 0.95;
            int idade = 30;
            double pesoKg = 95.2;
            double alturaMts = 1.85;
            double imc = (pesoKg / (alturaMts * alturaMts)) * margemErro;

            Console.WriteLine("O IMC é: " + imc);
            Console.WriteLine("O IMC somado à idade é: " + (imc + idade)); //parenteses = precedencia da soma em relacao à concatenacao

            bool ehVerdade = true;
            Console.WriteLine("Tudo certo? " + ehVerdade);

            sbyte a = sbyte.MaxValue;
            Console.WriteLine("sbyte max value " + a);

            sbyte b = sbyte.MinValue;            
            Console.WriteLine("sbyte min value " + b);

            int maiorInt = int.MinValue;
            Console.WriteLine("int min value " + maiorInt);

            int menorInt = int.MaxValue;
            Console.WriteLine("int max value " + menorInt);

            uint maiorIntSemSinal = uint.MaxValue; // O MinValue é zero
            Console.WriteLine("Maior inteiro sem sinal " + maiorIntSemSinal);

            double premioMegaSena = 54_243_124.45; //Use underline para melhorar a visualizacao de numeros
            Console.WriteLine("Premio mega sena " + premioMegaSena);

            char letra = 'a';
            Console.WriteLine("Um char " + letra);

            string frase = "Uma string";
            Console.Write("Uma string" + frase);

            Console.WriteLine("");
            
        }
    }
}
