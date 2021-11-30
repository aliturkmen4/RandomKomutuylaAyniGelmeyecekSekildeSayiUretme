using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Pazar.Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ödev1
            int[] sayilar = new int[10];
            Random rnd1 = new Random();
            int sayac = 0;
            while (sayac < 10)
            {
                int sayi = rnd1.Next(0, 100);
                if (sayilar.Contains(sayi))
                {
                    continue;
                }
                sayilar[sayac] = sayi;
                sayac++;
            }
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            #endregion
            #region ödev2
            Console.WriteLine("Satır sayısını giriniz: ");
            int satır = int.Parse(Console.ReadLine());
            Console.WriteLine("Sütun sayısını giriniz: ");
            int sütun = int.Parse(Console.ReadLine());
            int[,] dizi = new int[satır,sütun];
            Random rnd = new Random();
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    int sayi = rnd.Next(1, 100);
                    dizi[i,j] = sayi;
                    Console.Write($" {dizi[i,j]}");
                }
                Console.WriteLine(" ");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
