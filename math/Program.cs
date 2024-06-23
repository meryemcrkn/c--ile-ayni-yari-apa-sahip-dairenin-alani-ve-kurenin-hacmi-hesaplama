using System;

namespace math
{
    //Aynı yarıçapa sahip dairenin alanı ve kürenin hacmi hesaplanacaktır.
    //Buna göre klavyeden girilen iki sayı arasındaki  0,5 aralıklı değerler için
    //alan ve hacmi ayrı fonksiyonlarda hesaplayıp ekranda gösteriniz.Fonksiyonlar tek parametre olacak.
    class Program
    {
        static double Alan(double yaricap_par)
        {
            return yaricap_par * yaricap_par * Math.PI;
        }
        static double Hacim(double yaricap_par)
        {
            return (double)4 / 3 * Math.PI * Math.Pow(yaricap_par, 3);
        }

        static void Sirala(int a, int b, int c)
        {
            Random rnd = new Random();
            int[] dizi = new int[c];
        }
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            double yaricap;
            Console.WriteLine("Sayıları giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());

            for (double i = sayi1; i <= sayi2; i += 0.5)
            {
                Console.WriteLine("Yarıçap {0} için", i);
                Console.WriteLine("Alan " + Alan(i));
                Console.WriteLine("Hacim " + Hacim(i));
                Console.WriteLine();

            }
        }
    }
    }
}
