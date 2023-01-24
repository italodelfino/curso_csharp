using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Italo", Idade = 38, Nota = 8.0},
                new Aluno() {Nome = "Thais", Idade = 33, Nota = 9.5},
                new Aluno() {Nome = "Isabelle", Idade = 15, Nota = 10.0},
                new Aluno() {Nome = "Liz", Idade = 3, Nota = 7.5},
                new Aluno() {Nome = "Preta", Idade = 2, Nota = 8.0},
                new Aluno() {Nome = "Italo", Idade = 38, Nota = 4.0},
                new Aluno() {Nome = "Delfino", Idade = 78, Nota = 5.5},
            };

            var isabelle = alunos.Single(aluno => aluno.Nome.Equals("Isabelle"));
            Console.WriteLine($"{isabelle.Nome} {isabelle.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if(fulano == null)
            {
                Console.WriteLine("aluno inexistente");
            }
            var preta = alunos.First(aluno => aluno.Nome.Equals("Preta"));
            Console.WriteLine(preta.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("aluno inexistente");
            }
            var outroItalo = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Italo"));
            Console.WriteLine(outroItalo.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }
            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var maiorIdade = alunos.Max(aluno => aluno.Idade);
            Console.WriteLine(maiorIdade);

            var menorIdade = alunos.Min(aluno => aluno.Idade);
            Console.WriteLine(menorIdade);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}
