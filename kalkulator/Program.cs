using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            float a, b;

            Console.WriteLine("Pilih menu calculator:");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Input nomor menu [1..4]: ");
            menu = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inputkan nilai a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Inputkan nilai b = ");
            b = float.Parse(Console.ReadLine());

            if (menu == 1)
            {
                Console.WriteLine($"Hasil Penambahan {a} + {b} = {a + b}");
            }
            else if (menu == 2)
            {
                Console.WriteLine($"Hasil Pengurangan {a} - {b} = {a - b}");
            }
            else if (menu == 3)
            {
                Console.WriteLine($"Hasil Perkalian {a} * {b} = {a * b}");
            }
            else if (menu == 4)
            {
                if (b == 0)
                {
                    Console.WriteLine("Tidak dapat melakukan pembagian dengan nol");
                }
                else
                {
                    Console.WriteLine($"Hasil Pembagian {a} / {b} = {a / b}");
                }
            }
            else
            {
                Console.WriteLine("Input tidak valid");
            }

            Console.WriteLine("Tekan sembarang key untuk keluar");
            Console.ReadKey();
        }
    }
}
    

