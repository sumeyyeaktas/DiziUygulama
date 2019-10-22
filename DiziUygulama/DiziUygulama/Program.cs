using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiziUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Random rnd = new Random();
            int[] a = new int[10];          
            //1 ile 100 arasında üretilen 10 adet rastgele sayı dizi  içerisine girilecek
            for (int i = 0; i < 10; i++)
            {               
                sayi = rnd.Next(1, 100);

                a[i] = sayi;               
                Console.WriteLine(a[i]);
            }
            
            //Dizi içerisinde contains metodu ile arama yapma (Bensu)
            Console.Write("Aranacak sayıyı giriniz= ");
            int aranan2 = Convert.ToInt32(Console.ReadLine());

            if (a.Contains(aranan2) == true)
            {
                Console.WriteLine("Aranan değer mevcut");
            }
            else
            {
                Console.WriteLine("Aranan değer mevcut değil");
            }
            
            //her elemanın karesini alarak b dizisina aktaran , her elamanın kare kökünü alarak c dizisine aktaran , 
            //b ve c dizilerinin toplamını d dizisine aktaran ve d dizisini ekranda gösteren kod (Umut)
            int[] b = new int[10];
            double[] c = new double[10];
            double[] d = new double[10];

            for (int i = 0; i < 10; i++)
            {
                b[i] = a[i] * a[i];
                c[i] = Math.Sqrt(a[i]);
                d[i] = b[i] + c[i];
                Console.WriteLine(d[i].ToString());
            }
            
            Console.ReadKey();
        }
    }
}
