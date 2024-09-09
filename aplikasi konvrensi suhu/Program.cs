using System;

namespace SuhuKonversi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.Clear(); // Membersihkan layar setiap kali loop dimulai
                Console.WriteLine("Konversi Suhu");
                Console.WriteLine("1. Celcius ke Fahrenheit");
                Console.WriteLine("2. Celcius ke Kelvin");
                Console.WriteLine("3. Celcius ke Reamur");
                Console.WriteLine("4. Exit");
                Console.Write("Pilih opsi (1/2/3/4): ");
                string opsi = Console.ReadLine();

                switch (opsi)
                {
                    case "1":
                        CelciusKeFahrenheit();
                        break;
                    case "2":
                        CelciusKeKelvin();
                        break;
                    case "3":
                        CelciusKeReamur();
                        break;
                    case "4":
                        continueRunning = false; // Menghentikan loop jika pengguna memilih exit
                        Console.WriteLine("Keluar dari aplikasi. Terima kasih!");
                        break;
                    default:
                        Console.WriteLine("Opsi tidak valid. Silakan pilih 1, 2, 3, atau 4.");
                        break;
                }

                if (continueRunning)
                {
                    Console.WriteLine("Tekan Enter untuk melanjutkan...");
                    Console.ReadLine(); // Menunggu input dari pengguna sebelum melanjutkan
                }
            }
        }

        static void CelciusKeFahrenheit()
        {
            Console.Write("Masukkan suhu dalam Celcius: ");
            if (double.TryParse(Console.ReadLine(), out double celcius))
            {
                double fahrenheit = (celcius * 9 / 5) + 32;
                Console.WriteLine($"{celcius}°C = {fahrenheit}°F");
            }
            else
            {
                Console.WriteLine("Masukkan suhu yang valid.");
            }
        }

        static void CelciusKeKelvin()
        {
            Console.Write("Masukkan suhu dalam Celcius: ");
            if (double.TryParse(Console.ReadLine(), out double celcius))
            {
                double kelvin = celcius + 273.15;
                Console.WriteLine($"{celcius}°C = {kelvin} K");
            }
            else
            {
                Console.WriteLine("Masukkan suhu yang valid.");
            }
        }

        static void CelciusKeReamur()
        {
            Console.Write("Masukkan suhu dalam Celcius: ");
            if (double.TryParse(Console.ReadLine(), out double celcius))
            {
                double reamur = celcius * 4 / 5;
                Console.WriteLine($"{celcius}°C = {reamur}°R");
            }
            else
            {
                Console.WriteLine("Masukkan suhu yang valid.");
            }
        }
    }
}