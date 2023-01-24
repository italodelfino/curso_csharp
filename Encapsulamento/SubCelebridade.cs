using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "tenho um instagram!";

        //herança
        protected string CorDoOlho = "Verde";

        //mesmo projeto (assembly)
        internal ulong NumeroCelular = 5585985817152;

        //herança
        protected internal string JeitoDefalar = "uso muitas girias";

        //mesma class ou herança no mesmo projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        //private é o padrao
        bool UsaMuitoPhotoshop = true;
        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDefalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
