using System;
using System.Globalization;
using System.Text;
using lap3.Exercise1;
using lap3.Exercise2;

namespace lap3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("1. Exercise1");
                Console.WriteLine("2. Exercise2");
                Console.WriteLine("0. Exits");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        new Exercise1Menu().ShowMenu();
                        break;
                    case 2:
                        new Exercise2Menu().ShowMenu();
                        break;
                    case 0:
                        Console.WriteLine("Bye Bye");
                        break;
                }

                if (choice == 0)
                {
                    break;
                }
            }
            
        }
    }
}