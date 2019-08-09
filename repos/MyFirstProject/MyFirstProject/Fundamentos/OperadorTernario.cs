using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar() {
            Console.WriteLine("Operador ternario");
            var nota = 6;
            //Sintaxe:  var1 Condicao var2 ? valor_se_verdadeiro : valor_se_falso
            var resultado = nota >= 7 ? "Aprovado" : "Reprovado"; //Operador ternario
            Console.WriteLine($"Resultado da operacao: {resultado}");
        }
    }
}
