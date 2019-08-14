using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API {
    class TimeSpanExemplos {

        public static void Executar() {
            Console.WriteLine("Time span\n");

            var intervalo = new TimeSpan(days: 10, hours: 12, minutes:30, seconds:15);
            Console.WriteLine("Tipo " + intervalo.GetType().Name);
            Console.WriteLine("Intervalo original " + intervalo);

            intervalo = intervalo.Add(TimeSpan.FromMinutes(27));

            List<string> lst = new List<string>();

            Console.WriteLine("Intervalo aumentado " + intervalo); //Adiciona 27 minutos ao intervalo
            Console.WriteLine("Dias " + intervalo.Days);
            Console.WriteLine("Minutos " + intervalo.Minutes);
            Console.WriteLine("Intervalo em minutos " + intervalo.TotalMinutes);
            Console.WriteLine("Intervalo em minutos " + intervalo.TotalSeconds);
            Console.WriteLine("Intervalo em minutos " + intervalo.TotalMilliseconds);

            var largada = DateTime.Now;
            var chegada = largada.AddMinutes(30);

            var tempo = chegada - largada; // o resultado eh um time span
            Console.WriteLine("Tipo " + tempo.GetType().Name);
            Console.WriteLine($"Duracao {tempo}");

            var novoTempo = TimeSpan.Parse("12:30:45");
            Console.WriteLine("Timesspan obtido de uma string " + novoTempo);
            Console.WriteLine("Timesspan obtido de uma string (minutos) " + novoTempo.Minutes);
        }
    }
}
