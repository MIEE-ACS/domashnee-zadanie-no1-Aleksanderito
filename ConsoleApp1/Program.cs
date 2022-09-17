using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите V1:");
            int V1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите V2:");
            int V2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите S:");
            int S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите T:");
            int T = Convert.ToInt32(Console.ReadLine());
            int S0;
            S0 = S + V1 * T + V2 * T;
            Console.WriteLine($"Конечное растстояние между ними S0 : {S0}");
        }
    }
}
