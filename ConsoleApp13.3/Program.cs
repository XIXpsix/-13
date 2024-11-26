using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._3
{
    /// <summary>
    /// Задача 3. Найти s=min(a, b) + min(c, d),
    /// используя вспомогательные функции (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = Inf("a=");
            int b = Inf("b=");
            int c = Inf("c=");
            int d = Inf("d=");
            int result = Num(a, b) + Num(c, d);
            Out(result);
            Console.ReadLine();
        }
        static int Num(int x, int y)
        {
            return x < y ? x : y;
        }
        static int Inf(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Out(int result)
        {
            Console.WriteLine(result);
        }
    }
}
