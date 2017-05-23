using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int total = 0; ;

            //looping
            while (true)
            {
                try

                {
                    //keluarkan pertanyaan
                    Console.WriteLine("Berapa Lama Berolahraga?");
                    //minta input dari user
                    input = Console.ReadLine();

                    //menambahkan inputnya

                    //keluar bila user masukin "quit"
                    if (input.ToLower() == "quit")
                    {
                        break;
                    }
                    //jika inputan aneh
                    if (Int32.Parse(input) < 0)
                    {
                        continue;
                    }

                    //ngeluarin inputnya
                    total = total + Int32.Parse(input);
                    Console.WriteLine("Selamat, Anda sudah " + total + " Menit ");
                }

                catch (Exception)
                {
                    Console.WriteLine("masukan yang benar" );
                    continue;

                }
            }
        }
    }
}
