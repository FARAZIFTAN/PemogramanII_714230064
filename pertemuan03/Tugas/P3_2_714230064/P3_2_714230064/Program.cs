using System;

namespace P3_2_714230064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        HitungLuas();
                        break;

                    case "2":
                        HitungKeliling();
                        break;

                    case "3":
                        Console.WriteLine("Terima kasih telah menggunakan program ini.");
                        exitProgram = true;
                        break;

                    default:
                        Console.WriteLine("Menu tidak valid! Pilih menu yang benar (1, 2, atau 3).");
                        break;
                }

                if (!exitProgram)
                {
                    TanyakanUlang(ref exitProgram);
                }
            }
        }

        // Method untuk menghitung luas persegi panjang
        static void HitungLuas()
        {
            Console.Write("Masukkan panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar: ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double luas = panjang * lebar;
            Console.WriteLine($"Luas persegi panjang adalah: {luas}");
        }

        // Method untuk menghitung keliling persegi panjang
        static void HitungKeliling()
        {
            Console.Write("Masukkan panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar: ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double keliling = 2 * (panjang + lebar);
            Console.WriteLine($"Keliling persegi panjang adalah: {keliling}");
        }

        // Method untuk menanyakan apakah ingin mengulang atau keluar
        static void TanyakanUlang(ref bool exitProgram)
        {
            Console.Write("Ingin mengulang kembali (Y/T)? ");
            string ulang = Console.ReadLine().ToUpper();

            if (ulang == "T")
            {
                Console.WriteLine("Terima kasih!");
                exitProgram = true;
            }
            else if (ulang != "Y")
            {
                Console.WriteLine("Input tidak valid, kembali ke menu...");
            }
        }
    }
}
