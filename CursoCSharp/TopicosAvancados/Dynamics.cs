using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.Nome = "Italo Delfino";
            aluno.Nota = 9.9;
            aluno.Idade = 38;

            Console.WriteLine($" o nome do aluno: {aluno.Nome} sua nota: {aluno.Nota} sua idade {aluno.Idade}");
        }
    }
}
