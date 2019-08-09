using System;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        //Variaveis da classe começam com letra maiuscula
        //Variaveis de metodos começam com letra minuscula

        //***************Atributos***************
        private string Nome = null;
        private int Idade;
        private static string Especie = null;

        //***************Construtor***************
        //Se nao forem fornecidos parametros, o construtor usa os valores padrao 'Otario' e '0'
        public Pessoa(string nome = "Otario", int idade = 0) {
            SetNome(nome); //Se a primeira letra do atributo for diferente da primeira letra do parametro, nao precisa usar this
            SetIdade(idade);
            SetEspecie("Humana");
        }

        //***************Metodos***************
        public string Apresentacao() {
            return string.Format($"Muito prazer, meu nome eh {this.GetNome()}, tenho {this.GetIdade()} anos e sou da especie {GetEspecie()}");
        }

        public static void TesteStaticMethods() {
            Console.WriteLine("Teste de metodo estatico");
        }

        public string GetNome() {
            return this.Nome;
        }
        public void SetNome(string nome) {
            this.Nome = nome;
        }

        public int GetIdade() {
            return this.Idade;
        }

        public void SetIdade(int idade) {
            if (idade > 0) {
                this.Idade = idade;
            }
        }

        public static void SetEspecie(string especie) {
            Especie = especie;
        }

        public static string GetEspecie() {
            return Especie;
        }
    }
}