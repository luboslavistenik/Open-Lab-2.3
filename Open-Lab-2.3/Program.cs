using System;

namespace Open_Lab_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int a = array1[4] % array1[2];
            Console.WriteLine(a);
        }
    }
}
