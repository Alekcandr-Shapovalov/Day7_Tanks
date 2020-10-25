using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WordOfTanks;

namespace Day7_Tanks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string Victory;
            Tank[] Pantera = new Tank[5];
            Tank[] T34 = new Tank[5];

            try
            {

                for (int i = 0; i < T34.Length; i++)
                {
                    T34[i] = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "T34");
                }

                for (int i = 0; i < T34.Length; i++)
                {
                    Pantera[i] = new Tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "Pantera");
                }

                for (int i = 0; i < 5; i++)
                {
                    T34[i].Print();
                    Pantera[i].Print(); ;
                    Victory = T34[i] * Pantera[i];
                    Console.WriteLine();
                    Console.WriteLine($"Победил танк {Victory}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Блок catch");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }

            Console.ReadKey();
        }
    }
}
