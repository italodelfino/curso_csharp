using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindradas;

        public Moto(string marca, string modelo, int cilindradas)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindradas = cilindradas;
        }   
        public Moto()
        {

        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public  string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public int GetCilindradas()
        {
            return Cilindradas;
        }
        public void SetCilindradas(int cilindradas)
        {
            if(Cilindradas > 0)
            {
                Cilindradas = cilindradas;
            }
           
        }
    }

    internal class GetSet
    {

        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja zx-GR", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindradas());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindradas(-150);

            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindradas());
        }
    }
}
