using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class IgualdadeColecao {

        public static void Executar() {
            Console.WriteLine("Coleção Igualdade");

            var p1 = new Produto("Caneta", 1.50);
            var p2 = new Produto("Caneta", 1.50);
            var p3 = p2;
            Produto p4 = p1;

            Console.WriteLine($"{p1 == p2}, pois sao referencias de memoria DIFERENTES (Compara endereços de memoria)");
            Console.WriteLine($"{p1 == p4}, pois sao referencias de memoria IGUAIS (Compara endereços de memoria)");
            Console.WriteLine($"{p2 == p3}, pois sao referencias de memoria IGUAIS (Compara endereços de memoria)");
            Console.WriteLine($"{p1.Equals(p2)}, pois sao referencias de memoria DIFERENTES (Compara endereços de memoria, Equals sem sobrecarga)");
        }
    }
}
