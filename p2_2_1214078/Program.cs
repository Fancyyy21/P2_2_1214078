using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_2_1214078
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Nama = Maulana Imanulhaq Nurdiana
              NPM = 1214078*/

            Console.WriteLine("===============================");

            Console.WriteLine("Silakan Masukkan Jumlah Gaji Disini !");

            Console.WriteLine("===============================");

            
            try 
            {
                Console.Write("Nominal Gaji Kamu = ");
                float gaji = float.Parse(Console.ReadLine());

                Console.WriteLine("===============================");

                Console.Write("1. Tunjangan (20% dari gaji pokok)             = ");
                Console.WriteLine(gaji * 20 / 100);

                Console.Write("2. Bonus (15% dari gaji pokok)                 = ");
                Console.WriteLine(gaji * 15 / 100);

                Console.Write("3. PPH (3,5% dari gaji pokok)                  = ");
                Console.WriteLine(gaji * 35 / 1000);

                Console.Write("4. Total Gaji (Gaji Pokok + Tunjangan + Bonus) = ");
                Console.WriteLine((gaji) + (gaji * 20 / 100) + (gaji * 15 / 100));

                Console.Write("5. Gaji Bersih (Total Gaji – PPH)              = ");
                Console.WriteLine((gaji) - (gaji * 35 / 1000));

                Console.WriteLine("===============================");
                Console.WriteLine("===============================");
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi kesalahan \n" + e.Message); ;
                Console.ReadLine();
            }


        }
    }
}
