using System;
using System.Linq.Expressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {            

            try {
                        // Kasus Normal

                Console.Write("Masukan angka pertama: ");
                int angka1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan angka kedua: ");
                int angka2 = Convert.ToInt32(Console.ReadLine());

                int hasil = angka1 / angka2;
                Console.WriteLine("hasil pembagian ialah: " + hasil);
            }

                        //  Kasus pembagian dengan nol

            catch (DivideByZeroException) 
                {
                    Console.WriteLine("Error: tidak dapat membagi dengan nol.");
                }

                        //  Kasus Input Non-Numerik
            
            catch (FormatException)
                {
                    Console.WriteLine("Error: input harus berupa angka.");
                }    
                
        } 
    }
}
