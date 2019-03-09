using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_islem_hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HESAP MAKİNESİ\n");

            string sayi1, sayi2, islem;
            int s1, s2;
            double sonuc=0;


            Console.WriteLine("İlk sayıyı gir:");
            sayi1 = Console.ReadLine();
            s1 = Int32.Parse(sayi1);

            Console.WriteLine("İkinci sayıyı gir");
            sayi2 = Console.ReadLine();
            s2 = Int32.Parse(sayi2);

            Console.WriteLine("Hangi işlemi yapacaksın ? \n\nToplama işlemi için : + \nÇıkarma işlemi için : - \nÇarpma işlemi için: * \nBölme işlemi için: /\n");
            islem = Console.ReadLine();



            switch (islem)
            {
                case "+": sonuc = s1 + s2; break;
                case "-": sonuc = s1 - s2; break;
                case "/": sonuc = (double)s1 / (double)s2; break;
                case "*": sonuc = s1 * s2; break;
                default: break;
            }
            Console.WriteLine("İşlem Sonucu : " + sonuc.ToString());
            Console.WriteLine("Çıkmak İçin Bir Tuşa Basın !");
            Console.ReadKey();

        }
    }
}
