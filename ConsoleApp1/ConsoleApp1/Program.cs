using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Input (string[] args)
        {
            Console.Write(mesage);
            return int.Parse(Console.ReadLine());
        }
        static int Num(int x, int y)
        {
            return x < y ? x : y;
        }
        public static void Borput(int result)
        {
            Console.WriteLine(result);
        }

        static void Main(string[]args)
        {
            int x = Input("x=");
            int y = Input("y=");
            int result = Num(x,y);
            Borput(result);
            Console.Read();
        }
    }
}
