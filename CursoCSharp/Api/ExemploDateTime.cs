﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    internal class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 10, day: 30);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);
            //com hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine(diaAtual.Hour);
            Console.WriteLine(diaAtual.Minute);
            Console.WriteLine(diaAtual.Second);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));


        }

    }
}
