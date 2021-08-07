using System;

namespace GeneralBaseConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Base Value: ");
            int b = int.Parse(Console.ReadLine());
            string A = Convert.ToString(a); 
            int a_len = A.Length;
            int res = 0;

            for(int i = 0; i < a_len; i++)
            {
                int t = a % 10;
                a = a / 10;
                res = res + (t * b ^ i);
            }
            Console.WriteLine("Result:" + res);
            Console.ReadKey();
        }
    }
}
