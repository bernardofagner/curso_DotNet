using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API {
    class Data {

        public static void Executar() {
            Console.WriteLine("Manipulando datas\n");

            var dateTime = new DateTime(year: 2025, month: 5, day: 25);
            Console.WriteLine(dateTime);
            Console.WriteLine("Dia " + dateTime.Day);
            Console.WriteLine("Mes " + dateTime.Month);
            Console.WriteLine("Ano " + dateTime.Year);

            //Com as horas
            var agora = DateTime.Now;

            //Sem as horas
            var hoje = DateTime.Today;

            var futuro = agora.AddDays(30); // addDays() consegue mudar de mes


            Console.WriteLine("Hoje " + hoje);
            Console.WriteLine("Hoje " + hoje.Day);
            Console.WriteLine("Hoje " + hoje.Month);
            Console.WriteLine("Hoje " + hoje.Year);

            Console.WriteLine("Agora " + agora);
            Console.WriteLine("Agora " + agora.Hour);
            Console.WriteLine("Agora " + agora.Minute);
            Console.WriteLine("Agora " + agora.Second);

            Console.WriteLine("Amanha " + futuro);

            Console.WriteLine("2d: " + hoje.ToString("dd")); //Pega so o dia
            Console.WriteLine("1d: " + hoje.ToString("d")); //Pega a data completa
            Console.WriteLine("D: " + hoje.ToString("D")); //'D' maiusculo gera um formato mais descritivo, baseado no formato fornecido pelo SO
            Console.WriteLine("g: " + hoje.ToString("g"));
            Console.WriteLine("G: " + hoje.ToString("G"));

            Console.WriteLine("2d: " + agora.ToString("dd")); //Pega so o dia
            Console.WriteLine("1d: " + agora.ToString("d")); //Pega a data completa
            Console.WriteLine("D: " + agora.ToString("D")); //'D' maiusculo gera um formato mais descritivo, baseado no formato fornecido pelo SO
            Console.WriteLine("g: " + agora.ToString("g"));
            Console.WriteLine("G: " + agora.ToString("G"));
            Console.WriteLine(agora.ToString("MM-dd-yyyy HH:mm:ss")); // MM = Month , mm = minutes
            Console.WriteLine(agora.ToString("MM-dd-yyyy mm:ss"));
        }
    }
}
