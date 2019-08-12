using System;
using System.Collections;

namespace CursoCSharp.Colecoes {
    class ArrayListColecoes {

        public static void Executar() {
            Console.WriteLine("Colecao Array List");
            Console.WriteLine();

            var arrayList = new ArrayList {
                "Palavra",
                3.4,
                true,
                5
            };

            arrayList.Add('a');
            arrayList.Add(3.1415);

            //'object' é o tipo mais generico
            foreach (object item in arrayList) {
                Console.WriteLine($"Item: {item}, de tipo {item.GetType()}");
            }

            Console.WriteLine($"Total de itens no array list: {arrayList.Count}");
        }
    }
}
