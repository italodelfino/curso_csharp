using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class FilhoEConhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDefalar);
            Console.WriteLine(SegredoFamilia);
           // Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
