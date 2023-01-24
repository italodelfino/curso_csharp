using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "italo";
            sicrano.Idade = 38;

            sicrano.ApresentarConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Isabelle";
            fulano.Idade = 15;

            var apresentacaoDoFulano = fulano.Apresentar();
        }
    }
}
