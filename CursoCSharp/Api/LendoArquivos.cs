using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace CursoCSharp.Api
{
    internal class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivo.txt".ParseHome();

            if (File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preço;Qtde");
                    sw.WriteLine("caneta bic preta;3.59;89");
                    sw.WriteLine("borracha branca;2.89;27");
                }
            }          
            try
            {
                using(StreamReader sr = new StreamReader(path+ ",txt")) {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
