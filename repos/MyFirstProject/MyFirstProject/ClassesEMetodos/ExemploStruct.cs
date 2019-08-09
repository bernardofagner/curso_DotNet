using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    //Simplesmente define uma interface para uso didatico
    interface Ponto {
        void MoveNaDiagonal(int delta);
    }

    //Define a struct propriamente dita
    struct Coordenada : Ponto {
        public int X;
        public int Y;

        //Construtor dastruct
        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        //Impleenta o metodo da interface
        public void MoveNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }
    
    class Teste {
        const string teste = "Passou no teste";

        public void exibe() {
            Console.WriteLine(teste);
        }
    }

    class ExemploStruct {
        public static void Executar() {
            Console.WriteLine("Exemplo de struct");

            Coordenada coordenadaInicial; //Declaracao como tipo primitivo COPIA
            Teste novoTeste = new Teste(); // Criação de uma instancia (objeto) REFERENCIA

            Coordenada outraCoordenada = new Coordenada(y:3, x:1); //Parametros nomeados
            Coordenada outraCoordenada2 = new Coordenada { X = 1, Y = 1 }; //Outra forma de inicializar

            coordenadaInicial.X = 1;
            coordenadaInicial.Y = 2;
            Console.WriteLine($"Corrdenadas iniciais ({coordenadaInicial.X}, {coordenadaInicial.Y}).");
            coordenadaInicial.MoveNaDiagonal(3);
            outraCoordenada.MoveNaDiagonal(5);
            outraCoordenada2.MoveNaDiagonal(10);
            Console.WriteLine($"Corrdenadas modificadas ({coordenadaInicial.X}, {coordenadaInicial.Y}).");
            Console.WriteLine($"Corrdenadas outrasCoordenadas ({outraCoordenada.X}, {outraCoordenada.Y}).");
            Console.WriteLine($"Corrdenadas outrasCoordenadas2 ({outraCoordenada2.X}, {outraCoordenada2.Y}).");
            novoTeste.exibe();
        }
    }
}
