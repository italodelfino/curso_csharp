using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "italo";
            alunos[1] = "thais";
            alunos[2] = "isabelle";
            alunos[3] = "liz";
            alunos[4] = "preta";
           
            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0 ;
            double[] notas = { 9.7, 4.8, 5.2, 10.0, 5.9 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'a', 'b', 'c', 'd', 'e',  };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
