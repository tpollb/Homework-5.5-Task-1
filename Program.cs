using System;

namespace Homework_5._5_Task_1
{
    class Program
    {
        static string[] SplitArray (string Arg)
        {
            
            string[] arrSplited = Arg.Split(' ');
            return arrSplited;
        }

        static void ArrayOutput(string[] Arg)
        {
            int i = 0;
            for (i = 0; i < Arg.Length; i++)
            {
                Console.WriteLine($"{Arg[i]}");
            }
        }

        static void Main(string[] args)
        {
            
            string str;

            Console.WriteLine("Введите несколько слов, разделённых пробелом");
            str = Console.ReadLine();
            
            Console.WriteLine();
            ArrayOutput(SplitArray(str));
            

            Console.ReadKey();
        }
    }
}
