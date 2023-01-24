using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoAObjetos
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "TRIm itrm trim...";
        }
    }

    public class Samsung : Celular { 
        public override string Assistente()
        {
            return "Ola! meu nome é Biby!";
        }
    }
    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá meu nome é Siri!";
        }
    }
    internal class ClasseAbstrata
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
           {
               new Iphone(),
               new Samsung()
           };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
