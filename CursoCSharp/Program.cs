using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OrientacaoAObjetos;
using CursoCSharp.MetdosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos 01 - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},

                //Estrutras de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura IF/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/Else/IF - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do / While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura FOR - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                //Classes e Metodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo  - Classes e Métodos", DesafioAtributo.Executar},
                {"Params  - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados  - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get / Set - Classes e Métodos", GetSet.Executar},
                {"Propriedades - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Enumeração ENUM - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", Struct.Executar},
                {"Struct VS Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor VS Referencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parametros por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Métodos", ParametroPadrao.Executar},

                //Coleções
                {"Array - Coleções ", Colecoes.Array.Executar},
                {"List - Coleções ", ColecoesList.Executar},
                {"Array List - Coleções ", ColecoesArrayList.Executar},
                {"Set - Coleções ", ColecoesSet.Executar},
                {"Queue - Coleções ", ColecoesQueue.Executar},
                {"Igualdade - Coleções ", Igualdade.Executar},
                {"Stack - Coleções ", ColecoesStack.Executar},
                {"Dictionary - Coleções ", ColecoesDictionary.Executar},

                //Orientação a Objetos
                {"Herança - Orientação a Objetos ", Heranca.Executar},
                {"Construtor This - Orientação a Objetos ", ConstrutorThis.Executar},
                {"Encapsulamento- Orientação a Objetos ", OrientacaoAObjetos.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos ", Polimorfismo.Executar},
                {"Classe Abstrata - Orientação a Objetos ", ClasseAbstrata.Executar},
                {"Interface - Orientação a Objetos ", Interface.Executar},
                {"Sealed - Orientação a Objetos ", Sealed.Executar},

                //Metodos e Funções
                {"Exemplo Lambda- Metodos e Funções", ExemploLambda.Executar},
                {"Lambdas Delegate- Metodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate- Metodos e Funções", UsandoDelegate.Executar},
                {"Delegate Funções Anonimas- Metodos e Funções", DelegateFunAnonima.Executar},
                {"Delegate como Parametros - Metodos e Funções", DelegatesComoParametros.Executar},
                {"Metodos de Extensao - Metodos e Funções", MetodosDeExtensao.Executar},

                //Exceções
                {"Tratamneto de Erro - Exceções", PrimeiraExcecao.Executar},
                {"Exceções personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                //Explorando Api
                {"Escrevendo dados - Explorando Api", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Explorando Api", LendoArquivos.Executar},
                {"Exemplo FileInfo - Explorando Api", ExemploFileInfo.Executar},
                {"Diretorios - Explorando Api", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Explorando Api", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Explorando Api", ExemploPath.Executar},
                {"Exemplo DateTime - Explorando Api", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Explorando Api", ExemploTimeSpan.Executar},
                
                //Topicos Avançados
                 {"Linq#01 - Topicos Avançados", LINQ1.Executar},
                 {"Linq#02 - Topicos Avançados", LINQ2.Executar},
                 {"Nullables - Topicos Avançados", Nullables.Executar},
                 {"Dynamic - Topicos Avançados", Dynamics.Executar},
                 {"Generics - Topicos Avançados", Genericos.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}