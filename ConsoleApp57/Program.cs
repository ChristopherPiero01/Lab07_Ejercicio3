using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int añoinicial = 1900;
            int añofinal = 2023;

            Console.WriteLine("Años bisiestos desde 1900...");
            Console.WriteLine();

            do
            {
                if (añoinicial % 4 == 0 && añoinicial % 100 != 0 || añoinicial % 400 == 0)
                {
                    Console.Write(añoinicial+ ", ");
                }
                añoinicial++;

            } while (añoinicial <= añofinal);

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
