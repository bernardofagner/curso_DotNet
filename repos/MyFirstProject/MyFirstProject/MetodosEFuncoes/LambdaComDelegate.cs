using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    //Declaracao do delegate
    delegate double Operacao(double x, double y);
    class LambdaComDelegate {

        public static void Executar() {
            Console.WriteLine("Expressao Lambda com delegate");
            Console.WriteLine();

            //Uso do delegate
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine("Sum " + sum(2, 5));
            Console.WriteLine("Sub " + sub(2, 5));
            Console.WriteLine("Mult " + mult(2, 5));
        }
    }
}
