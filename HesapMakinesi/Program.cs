using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2;
            int islem;
            string c = "---------------------------";

            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine(c);

            Console.WriteLine("Hangi islemi yapmak istersiniz");
            Console.WriteLine("Toplama[1]");
            Console.WriteLine("Cikarma[2]");
            Console.WriteLine("Carpma[3]");
            Console.WriteLine("Bolme[4]");
            islemsec:
            Console.Write("Seciminiz: ");
            islem = Convert.ToInt32(Console.ReadLine());
            
            if (islem > 4 || islem < 1)
            {
                Console.WriteLine("Lutfen dogru islem seciniz!");
                goto islemsec;
            }

            Console.Write("Sayi giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayi giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            switch (islem)
            {
                case 1: Console.WriteLine("Sonuc: {0}",sayi1 + sayi2); 
                    break;
                case 2:
                    Console.WriteLine("Sonuc: {0}", sayi1 - sayi2);
                    break;
                case 3:
                    Console.WriteLine("Sonuc: {0}", sayi1 * sayi2);
                    break;
                case 4:
                    if(sayi2 == 0)
                    {
                        Console.WriteLine("Bolme isleminde ikinci sayi 0 olamaz!");
                        break;
                    }
                    Console.WriteLine("Sonuc: {0}", sayi1 / sayi2);
                    break;
                default:
                    Console.WriteLine("Eksik ya da hatalı tuslama!");
                        break;
            }
        }
    }
}