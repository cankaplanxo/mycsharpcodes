using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrenheit_santigrat_dönüstürme
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, santigrat;

            Console.Write("Fahrenheit sıcaklığını giriniz:");
            double.TryParse(Console.ReadLine(), out fahrenheit);

            santigrat = (fahrenheit - 32) / 1.8;

            Console.Write("{0} Fahrenheit derece {1:F3} santigrat dereceye eşittir", fahrenheit, santigrat);
        }
    }
}

/*
           İKİNCİ YOL 
double fahrenheit, santigrat;

Console.Write("Fahrenheit sıcaklığını giriniz:");
fahrenheit = double.Parse(Console.ReadLine());

santigrat = (fahrenheit - 32) / 1.8;
Console.Write("{0} Fahrenheit derece {1:F3} santigrat dereceye eşittir", fahrenheit, santigrat);
            */