using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace retro
{
    class Program
    {
        static void Main(string[] args)
        {
            slow("Hello, World!", 30);
            Console.ReadKey();
        }
        public static void slow(string say, int time = 10)
        {
            for (int i = 0; i < say.Length; i++)
            {
                Console.Write(say[i]);
                Thread.Sleep(time);
            }
            return;
        }
    }
}
