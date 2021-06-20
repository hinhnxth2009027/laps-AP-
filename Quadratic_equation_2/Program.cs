using System;
using System.Text;

namespace Quadratic_equation_2
{
    internal class Program
    {
        public delegate void Equation(int a, int b, int c);


        public static void SolvetTheEquation(int a, int b, int c)
        {
            float delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                var no1 = ((-b - Math.Sqrt(delta)) / 2 * a);
                var no2 = ((-b + Math.Sqrt(delta)) / 2 * a);
                Console.WriteLine($"phương trình có 2 nghiệm là : {no1}  và : {no2}");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"phương trình có nghiệm kép là {-b / 2 * a}");
            }
            else
            {
                Console.WriteLine("phương trình vô nghiệm");
            }
        }


        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            while (true)
            {
                Console.Write("vui lòng nhập số thứ 1 :");
                var number1 = int.Parse(Console.ReadLine());
                Console.Write("vui lòng nhập số thứ 2 :");
                var number2 = int.Parse(Console.ReadLine());
                Console.Write("vui lòng nhập số thứ 3 :");
                var number3 = int.Parse(Console.ReadLine());
                Equation checkEquation = SolvetTheEquation;
                checkEquation(number1, number2, number3);
                Console.WriteLine("\n");
                Console.WriteLine("----------------------------");
                Console.WriteLine("\n");
            }
        }
    }
}