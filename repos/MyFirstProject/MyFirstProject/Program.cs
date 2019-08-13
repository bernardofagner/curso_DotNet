using System;
using System.Collections.Generic;

//Importa as pastas com as classes criadas ao longo do curso
using CursoCSharp.Fundamentos; 
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OrientacaoAObjetos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao de strings - Fundamentos", Interpolacao.Executar},
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversão de tipos - Fundamentos", Conversoes.Executar},
                {"Operadores aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operador ternario - Fundamentos", OperadorTernario.Executar},

                // Estruturas de controle
                {"Estrutura if - Estruturas de controle", EstruturaIf.Executar},
                {"Estrutura switch - Estruturas de controle", EstruturaSwitch.Executar},
                {"Estrutura while - Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura foreach - Estruturas de controle", EstruturaForEach.Executar},
                {"Estrutura continue - Estruturas de controle", EstruturaContinue.Executar},

                //Classes e metodos
                {"Sobre classes - Classes e metodos", SobreClasses.Executar},
                {"Parametros variaveis - Classes e metodos", ParametrosVariaveis.Executar},
                {"Parametros nomeados - Classes e metodos", ParametrosNomeados.Executar},
                {"Atributos readyonly - Classes e metodos", ReadOnly.Executar},
                {"Enumeracoes - Classes e metodos", Enumeracao.Executar},
                {"Exemplo struct - Classes e metodos", ExemploStruct.Executar},
                {"Parametros por referencia - Classes e metodos", ParametrosPorReferencia.Executar},

                //Colecoes
                {"Array - Colecoes", ArrayColecao.Executar},
                {"List - Colecoes", ListColecao.Executar},
                {"ArrayList - Colecoes", ArrayListColecoes.Executar},
                {"Set - Colecoes", SetColecoes.Executar},
                {"Queue - Colecoes", QueueColecao.Executar},
                {"Igualdade - Colecoes", IgualdadeColecao.Executar},
                {"Stack - Colecoes", StackColecao.Executar},
                {"Dictionary - Colecoes", DictionaryColecao.Executar},

                //Orientacao a objetos
                {"Heranca - Orientacao a objetos", Heranca.Executar},
                {"Construtor This - Orientacao a objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientacao a objetos", OrientacaoAObjetos.Encapsulamento.Executar},
                {"Classe abstrata - Orientacao a objetos", ClasseAbstrata.Execuatar},
                {"Interface - Orientacao a objetos", Interface.Executar},
                {"Classe Selada 'sealed' -Orientacao a objetos", Sealed.Executar},

                //Metodos e funcoes - Programacao funcional
                {"Expressao lambda - Metodos e funcoes", ExpressaoLambda.Executar},
                {"Expressao lambda com delegate - Metodos e funcoes", LambdaComDelegate.Executar},

                //Erros e tratamento de excecoes
                {"Primeira excecao - Tratamento de erros e excecoes", PrimeiraExcecao.Executar},
                {"Excecoes personalizadas - Tratamento de erros e excecoes", ExcecoesPersonalizadas.Executar},

                //API
                {"Primeiro arquivo - API", PrimeiroArquivo.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}