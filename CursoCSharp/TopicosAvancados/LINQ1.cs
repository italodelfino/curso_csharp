using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    internal class LINQ1
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
            Console.WriteLine("=== Aprovados ======");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }
            Console.WriteLine("\n== Chamada ========");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine("\n== Aprovados (por idade) ==========");
            var alunoAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach (var aluno in alunoAprovados)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
