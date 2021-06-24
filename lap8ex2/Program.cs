using System;
using System.Collections;
using System.Text;

namespace lap8ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var random = new Random();
            var temperature = new double[300];
            for (var i = 0; i < 300; i++)
            {
                temperature[i] = random.Next(0, 1000);
            }

            while (true)
            {
                Console.Write("vui lòng nhập vào số min : ");
                var min = int.Parse(Console.ReadLine());
                Console.WriteLine(
                    $"GreaterCount trả về : {GreaterCount(temperature, min)} lần temperature lớn hơn số min đã nhập : {min}\n\n");
            }
        }

        public static int GreaterCount(IEnumerable enumerable, double min)
        {
            var count = 0;
            foreach (var item in enumerable)
            {
                if (double.Parse(item.ToString()) >= min)
                {
                    count++;
                }
            }

            return count;
        }
    }
}