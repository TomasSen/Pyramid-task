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
                for (temp = 0; temp < size; temp ++)
                {
                    if (temp < line)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

