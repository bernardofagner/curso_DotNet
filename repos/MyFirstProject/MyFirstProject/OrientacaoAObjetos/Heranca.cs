using System;

namespace CursoCSharp.OrientacaoAObjetos {

    class Carro {
        protected readonly double VelociadeMaxima;
        protected string Modelo;
        protected string Marca;
        protected double VelocidadeAtual;

        public Carro(double velociadeMaxima, string marca = "", string modelo = "", double velocidadeAtual = 0.0) {
            VelociadeMaxima = velociadeMaxima;
            Marca = marca;
            Modelo = modelo;
            VelocidadeAtual = velocidadeAtual;
        }

        protected Carro AlterarVelocidade(double delta) {
            if (this.VelocidadeAtual + delta < 0.0) {
                this.VelocidadeAtual = 0.0;
                return this;
            }

            if(this.VelocidadeAtual + delta > this.VelociadeMaxima) {
                this.VelocidadeAtual = this.VelociadeMaxima;
                return this;
            }

            this.VelocidadeAtual += delta;
            return this;
        }

        //O modificador virtual permite que o metodo seja sobrescrito (override)
        public virtual Carro Acelerar() {
            Console.WriteLine($"{this.Marca} {this.Modelo} acelerou! Velociade atual: {this.VelocidadeAtual}");
            return AlterarVelocidade(5);            
        }

        public virtual Carro Desacelerar() {
            Console.WriteLine($"{this.Marca} {this.Modelo} desacelerou! Velociade atual: {this.VelocidadeAtual}");
            return AlterarVelocidade(-5);            
        }

        public string MarcaModelo() {
            return this.Marca.ToString() + this.Modelo.ToString();

        }
    }

    //Herança. A classe Uno Herda (:) da classe Carro
    class Fiat : Carro {
        //Construtor
        //O construtor da classe uno herda (:) o construtor da classe pai (base) e passa o parametro da velocidade maxioa que eh requerido.
        public Fiat(string marca, string modelo) : base(220) {
            this.Marca = marca;
            this.Modelo = modelo;
        }
    }

    class MacLaren : Carro {
        //Construtor
        //O construtor da classe uno herda (:) o construtor da classe pai (base) e passa o parametro da velocidade maxioa que eh requerido.
        public MacLaren(string marca, string modelo) : base(220) {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public override Carro Acelerar() {
            Console.WriteLine($"{this.Marca} {this.Modelo} acelerou! Velociade atual: {this.VelocidadeAtual}");
            return AlterarVelocidade(25);
        }

        public override Carro Desacelerar() {
            Console.WriteLine($"{this.Marca} {this.Modelo} desacelerou! Velociade atual: {this.VelocidadeAtual}");
            return AlterarVelocidade(-10);
        }
    }

    class Heranca {
        public static void Executar() {
            Console.WriteLine("Heranca");
            Console.WriteLine();

            Fiat carro1 = new Fiat("Fiat", "Uno");
            Carro carro3 = new MacLaren("MacLarem", "P1");
            
            carro1.Acelerar();
            carro1.Desacelerar().Acelerar().Desacelerar().Acelerar().Acelerar().Acelerar();
            Console.WriteLine(carro1.MarcaModelo());

            //Aponta para o mesmo endereço de memoria que o carro1 aponta
            Carro carro2 = carro1;
            Console.WriteLine( carro2.MarcaModelo());

            carro3.Desacelerar().Acelerar().Desacelerar().Acelerar().Acelerar().Acelerar();
            Console.WriteLine(carro3.MarcaModelo()); ;
        }
    }
}
