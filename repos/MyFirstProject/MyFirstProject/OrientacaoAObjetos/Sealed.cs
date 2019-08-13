using System;

namespace CursoCSharp.OrientacaoAObjetos {

    sealed class FamiliaEvellas{
        //Outra forma de declarar funcoes
        public double ValorHeranca() => 1_245_769.45;
    }

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        } 
    }

    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia(){
            return true;
        }
    }

    class FilhoRebelde : Pai {
        //O metodo HonrarNomeFamilia() nao pode ser sobrescrito mais pois foi selado na classe Pai
        //public override bool HonrarNomeFamilia() {
        //    return false;
        //}

        //O que se pode fazer eh criar outro metodo (usando 'new') que vai ocultar o metodo da classe pai
        public new bool HonrarNomeFamilia() {
            return false;
        }
    }

    class Sealed {

        public static void Executar() {
            Console.WriteLine("Classe selada");

            FamiliaEvellas familia = new FamiliaEvellas();
            Console.WriteLine("Fortuna da familia: " + familia.ValorHeranca());
            Console.WriteLine();

            FilhoRebelde filho1 = new FilhoRebelde(); //Filho adotado haha
            Console.WriteLine("Filho do tipo Filho Honrou a familia? " + filho1.HonrarNomeFamilia());

            Pai filho2 = new FilhoRebelde(); //Filho legitmo
            Console.WriteLine("Filho do tipo Pai Honrou a familia? " + filho2.HonrarNomeFamilia());
        }
    }
}
