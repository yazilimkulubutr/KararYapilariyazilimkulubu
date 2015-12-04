using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariyazilimkulubu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şifrenizi Giriniz");
            string sifre = Console.ReadLine();

            if (sifre == "yazilimkulubu")
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }

            /*
             if (40 < 50)
             {
                 Console.WriteLine("Dersten kaldınız");

             }
             else if (40 == 50)
             {
                 Console.WriteLine("Uçtan Geçtiniz");
             }
             else if (40 > 50)
             {
                 Console.WriteLine("Dersten Geçtiniz");
             }
             else
             {
                 Console.WriteLine("Geçersiz Not Değeri");
             }
             */

            /*
            if (false)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }
            */
            Console.ReadLine();
        }
    }
}
