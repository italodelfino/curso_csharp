using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoAObjetos
{
    internal class Sealed
    {

        sealed class SemFilho
        {
            public double ValorDaFortuna()
            {
                return 1_407_033.65;
            }
        }

        class Avo
        {
            public virtual bool HonrarNomeFamilia()
            {
                return true;
            }
        }

        class Pai : Avo
        {
            public sealed override bool HonrarNomeFamilia()
            {
                return true;
            }
        }
        class FilhoRebelde : Pai
        {

        }
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
        }
    }
}
