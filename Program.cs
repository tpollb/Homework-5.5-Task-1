using System;

namespace Homework_5._5_Task_1
{
    class Program
    {
        static string[] SplitArray (string Arg)
        {
            int i = 0;
            string[] arr = new string[100];

            string[] arrSplited = Arg.Split(' ');
            foreach (var e in arrSplited)
            {
                Console.WriteLine($"{e}");
                i = i++;
                arr[i] = e;
            }
            return arr;
        }

        static void Main(string[] args)
        {
            
            string str;

            Console.WriteLine("Введите несколько слов, разделённых пробелом");
            str = Console.ReadLine();
            SplitArray(str);
            

            Console.ReadKey();
        }
    }
}
