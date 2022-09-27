using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_raulz
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Double gaji_pokok, TG, B, PPH, TOTAL, Gaji_bersih, Hasil;

            Console.Write("Nama Kamu Adalah :  ");
            string NamaLengkap = Console.ReadLine();

            Console.Write("Masukkan Gaiji Pokok Kamu : ");
            gaji_pokok = Convert.ToInt32(Console.ReadLine());

            TG = (gaji_pokok * 20) / 100;
            B = (gaji_pokok * 15) / 100;
            PPH = (gaji_pokok * 3.5) / 100;
            TOTAL = gaji_pokok + TG + B;
            Gaji_bersih = TOTAL - PPH;
            Hasil = Gaji_bersih;

            Console.Write("\nTunjangan: " + TG);
            Console.Write("\nBonus: " + B);
            Console.Write("\nPPH: " + PPH);
            Console.Write("\nTotal: " + gaji_pokok, TG, B);
            Console.Write("\nGaji Bersih: " + TOTAL, PPH);
            Console.Write("\nHasil:" + Gaji_bersih);
        }
    }
}
