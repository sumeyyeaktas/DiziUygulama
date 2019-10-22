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

            //Dizideki sayıların toplamı ve ortalaması
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                toplam = toplam + a[i];
            }
            Console.WriteLine("Dizi içerisindeki sayıların toplamı= " + toplam);
            Console.WriteLine("Dizi içerisindeki sayıların ortalaması= " + (toplam / 10));

            //Dizideki sayılardan 50'den büyük olanların sayısı            
            int buyuklerin_adeti = 0;
            for (int i = 0; i < 10; i++)
            {
                if (a[i] > 50)
                    buyuklerin_adeti++;
            }
            Console.WriteLine("50'den büyük olanların adeti= " + buyuklerin_adeti);

            //Dizideki sayılardan 50'den küçük olanların toplamını yazdırma  
            int kucuklerin_toplami = 0;
            for (int i = 0; i < 10; i++)
            {
                if (a[i] < 50)
                    kucuklerin_toplami = kucuklerin_toplami + a[i];
            }
            Console.WriteLine("50'den küçük olanların toplamı= " + kucuklerin_toplami);

            //Dizideki sayılardan en büyüğünü ve en küçüğünü bulup, en büyüğünden en küçüğünü çıkaran  
            int enb = 0, enk = 0;
            enb = a[0]; enk = a[0];
            for (int i = 0; i < 10; i++)
            {
                if (a[i] < enk)
                    enk = a[i];
                if (a[i] > enb)
                    enb = a[i];
            }
            Console.WriteLine("Sayılardan en büyüğü= " + enb);
            Console.WriteLine("Sayılardan en küçüğü= " + enk);
            Console.WriteLine("Büyük ile Küçük Sayının Farkı= " + (enb - enk));


            //Dizideki sayıları küçükten büyüğe sıralama  
            int yedek = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (a[i] > a[j])
                    {
                        yedek = a[i];
                        a[i] = a[j];
                        a[j] = yedek;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }

            //Array.Sort(a) ile de küçükten büyüğe doğru sıralayabiliriz

            //Dizi içerisinde arama yapma 1.Yöntem
            Console.Write("Aranacak sayıyı giriniz= ");
            int aranan = Convert.ToInt32(Console.ReadLine());
            bool bulundu = false;
            for (int i = 0; i < 10; i++)
            {
                if (aranan == a[i])
                    bulundu = true;
            }
            if (bulundu == true)
            {
                Console.WriteLine("Aranan değer mevcut");
            }
            else
            {
                Console.WriteLine("Aranan değer mevcut değil");
            }

            //Dizi içerisinde arama yapma 2.Yöntem
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

            //Dizi içerisinde arama yapma 3.Yöntem
            Console.Write("Aranacak sayıyı giriniz= ");
            int aranan3 = Convert.ToInt32(Console.ReadLine());
            if (Array.IndexOf(a, aranan3) == -1)
            {
                Console.WriteLine("Aranan değer mevcut değil");
            }
            else
            {
                Console.WriteLine("Aranan değer mevcut");
            }


            //Dizi içerisinde aranan değerden kaç adet var
            Console.Write("Aranacak sayıyı giriniz= ");
            int aranan4 = Convert.ToInt32(Console.ReadLine());
            int aranan_adet = 0;
            bool bulundu4 = false;
            for (int i = 0; i < 10; i++)
            {
                if (aranan4 == a[i])
                {
                    bulundu4 = true;
                    aranan_adet++;
                }
            }
            if (bulundu4 == true)
            {
                Console.WriteLine("Aranan değer mevcut. " + aranan_adet + " adet");
            }
            else
            {
                Console.WriteLine("Aranan değer mevcut değil");
            }

            //her elemanın karesini alarak b dizisina aktaran , her elamanın kare kökünü alarak c dizisine aktaran , b ve c dizilerinin toplamını d dizisine aktaran ve d dizisini ekranda gösteren kod
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
