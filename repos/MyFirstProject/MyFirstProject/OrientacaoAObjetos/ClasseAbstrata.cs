using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoAObjetos {

    //Classe abstrata
    public abstract class Celular {
        
        //Metodo abstrato
        public abstract string Toque();
        
        public virtual string BoasVindas() {
            return "Bem vindo!";
        }
    }

    public class Samsung : Celular {

        public override string Toque() {
            return "Trin... Trin...";
        }

        public override string BoasVindas() {
            return "Bem vindo ao S4";
        }
    }

    public class IPhone : Celular {
        public override string Toque() {
            return "Trululu... trululu...";
        }

        public override string BoasVindas() {
            return "Bem vindo ao IPhone 6";
        }
    }

    class ClasseAbstrata {

        public static void Execuatar() {
            Console.WriteLine("Classe abstrata");

            Celular aparelho1 = new Samsung();
            Celular aparelho2 = new IPhone();

            Console.WriteLine(aparelho1.Toque());
            Console.WriteLine(aparelho2.Toque());

            //Cria uma lista de celulares
            List<Celular> aparelhos = new List<Celular> {
                new Samsung(),
                new IPhone(),
                new IPhone(),
                new Samsung()
            };

            foreach (var celular in aparelhos) {
                Console.WriteLine(celular.BoasVindas());
            }
        }
    }
}
