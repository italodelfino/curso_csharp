﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class NegativeException : Exception
    {
        public NegativeException() { }

        public NegativeException(string message) : base(message) { }

        public NegativeException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }
     class ExcecoesPersonalizadas 
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if(valor < 0){
                throw new NegativeException("Numero negativo... :(");
            }
            if (valor % 2 == 1)
            {
                throw new ImparException("Valor impar...:(");
            }
            return valor;
        }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            } 
            catch (NegativeException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(ImparException ex) {
                Console.WriteLine(ex.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
