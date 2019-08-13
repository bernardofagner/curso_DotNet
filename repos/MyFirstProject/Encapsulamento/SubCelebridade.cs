using System;

namespace Encapsulamento {
    public class SubCelebridade {

        //Disponivel a todos que acessarem essa classe
        public string InfoPublic = "Informacao public";

        //Protected, transmitido por heranca
        protected string InfoProtected = "Informacao protected";

        //Internal, mesmo projeto (msm assembly)
        internal string InfoInternal = "Informacao internal";

        //Heranca ou msm projteo
        protected internal string InfoProtectedInternal = "Informacao internal e protected";

        //Mesma classe ou heranca no msm projeto (Disponivel no C#, a partir da versao 7.2)
        private protected string InfoPrivateProtected = "Informacao private e protected";

        //Somente acessado pela classe em que foi instanciado - É o padrao
        string InfoPrivada = "Informacao privada nao precisa escrever private";

        public virtual void MeusAcessos() {

            Console.WriteLine("SubCelebridade - Classe original");
            Console.WriteLine(InfoPublic);
            Console.WriteLine(InfoProtected);
            Console.WriteLine(InfoInternal);
            Console.WriteLine(InfoProtectedInternal);
            Console.WriteLine(InfoPrivateProtected);
            Console.WriteLine(InfoPrivada);
            Console.WriteLine();
        }
    }
}
