using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {
            Console.WriteLine("Operadores relacionais");

            int a = 5, b = 10, c = 5;

            Console.WriteLine($"{a} é maior que {b}? {a > b}");
            Console.WriteLine($"{b} é maior que {a}? {b > a}");
            Console.WriteLine($"{b} é igual a {a}? {b == a}");
            Console.WriteLine($"{b} é diferente de {a}? {b != a}");
            Console.WriteLine($"{c} é maior ou igual a {a}? {b >= c}");
        }
    }
}
