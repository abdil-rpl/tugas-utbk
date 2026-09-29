using System;

namespace UTBK
{
    class Home
    {
        static void Main(string[] args)
        {
            int MTK = 90;
            int Bing = 95;
            int mpilih = 95;

            int tnt = MTK + Bing + mpilih;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Lewat Jalur Prestasi ");
            Console.WriteLine("Nilai Matematika      : " + MTK);
            Console.WriteLine("Nilai Bahasa Inggris  : " + Bing);
            Console.WriteLine("Nilai Mapel Pilihan   : " + mpilih);
            Console.WriteLine("Total nilai TKA       : " + tnt);
            if (tnt >= 280)
            {
                Console.WriteLine("Status                : Selamat, Anda DITERIMA di ITS (Jalur Prestasi)!");
            }
            else
            {
                Console.WriteLine("Status                : Maaf, Anda TIDAK LOLOS Jalur Prestasi.");
            }

            Console.WriteLine("-----------------------------");
            double batasLulus = 600;
            double kontribusiTKA = 0.30 * tnt;
            double utbkDibutuhkan = batasLulus - kontribusiTKA;

            Console.WriteLine("Lewat Jalur UTBK");
            Console.WriteLine("Batas Minimal Kelulusan : " + batasLulus);
            Console.WriteLine("Nilai Tambahan dari TKA (30%): " + kontribusiTKA);
            Console.WriteLine("Nilai UTBK Minimal yang Dibutuhkan: " + utbkDibutuhkan);
            Console.WriteLine("-----------------------------");
        }
    }
}
