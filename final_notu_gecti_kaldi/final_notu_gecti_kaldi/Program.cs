using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_notu_gecti_kaldi
{
    class Program
    {
        static void Main(string[] args)
        {

            int finalNotu;

            Console.Write("Final Notu Giriniz:");
            int.TryParse(Console.ReadLine(), out finalNotu);

            if (finalNotu >= 50)
            {
                Console.WriteLine("Geçti!");
            }

            else
            {
                Console.WriteLine("Kaldı!");
            }
                Console.ReadKey();
        }
    }
}
