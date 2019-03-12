using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cember_alan_cevre_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double yaricap, cevre, alan;
                Console.Write("Yarıçapı giriniz:");
                double.TryParse(Console.ReadLine(), out yaricap);
                cevre = 2 * 3.141592 * yaricap;
                alan = 3.141592 * yaricap * yaricap;

                Console.WriteLine("cevre:{0:f2}, alan:{1:f2}", cevre, alan);
            }
        }
    }





}
 