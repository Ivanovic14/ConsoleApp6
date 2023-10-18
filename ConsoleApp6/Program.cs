using System;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace Uppgift_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int start = 10; start <= 30; start += 1)
            {
                Console.WriteLine(start);
            }
            for (int i = 200; 180 <= i; i--)
            {
                Console.WriteLine(i);
            }
            for (int hej = 1000; hej <= 1400; hej += 50)
            {
                Console.WriteLine(hej);
            }
        }
    }
}