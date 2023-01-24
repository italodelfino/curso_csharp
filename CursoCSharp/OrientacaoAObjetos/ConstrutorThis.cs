using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoAObjetos
{

    public class Animal
    {
        public string Nome { get; set; }
        public Animal(string nome) { 
            Nome = nome;
        }
    }
    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }
        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }
        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }
    internal class ConstrutorThis
    {
        public static void Executar()
        {
            var liz = new Cachorro("Liz");
            var preta = new Cachorro("Preta", 40.0);

            Console.WriteLine(liz);
            Console.WriteLine(preta);
        }
    }
}
