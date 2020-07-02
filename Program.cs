using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, temp;
            Console.WriteLine("Waiting for pyramid size... ");
            size = int.Parse(Console.ReadLine());
            for (int line = size ; line >= 0; line--)
            {
                for (temp = 0; temp < line; temp ++)
                {
                    Console.Write(" ");
                }
                for (temp = temp; temp < size; temp ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
