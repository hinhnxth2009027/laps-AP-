using System;

namespace lap1.Examples
{
    public class Examples
    {
        public void ShowExample1()
        {
            Console.WriteLine("EXAMPLE 1");
            ReferenceType refer = new ReferenceType();
            refer.valueVal = 5;
            Test(refer);
            Console.WriteLine("The value of the variable is {0}", refer.valueVal);
            Console.ReadLine();
        }
        public void ShowExample2()
        {
            Console.WriteLine("EXAMPLE 2");
            Console.WriteLine("Currency formatting - {1:C4} ", 88.8, 888.8);
            Console.WriteLine("Integer formatting - {0:D5} ", 88);
            Console.WriteLine("Exponential formatting - {0:E}", 888.8);
            Console.WriteLine("Fixed-point formatting - {0:F3}", 888.8888);
            Console.WriteLine("General formatting - {0:G}", 888.8888);
            Console.WriteLine("Number formatting - {0:N}", 888888888.8);
            Console.WriteLine("Hexadecimal formatting - {0:X4}", 88);
        }
        public void ShowExample3()
        {
            Console.WriteLine("EXAMPLE 3");
            var dt = DateTime.Now;

            Console.WriteLine("d format : {0:d}", dt);
            Console.WriteLine("D format : {0:D}", dt);

            Console.WriteLine("t format : {0:t}", dt);
            Console.WriteLine("T format : {0:T}", dt);

            Console.WriteLine("g format : {0:g}", dt);
            Console.WriteLine("G format : {0:G}", dt);

            Console.WriteLine("m format : {0:m}", dt);
            Console.WriteLine("M format : {0:M}", dt);

            Console.WriteLine("r format : {0:r}", dt);
            Console.WriteLine("R format : {0:R}", dt);

            Console.WriteLine("s format : {0:s}", dt);

            Console.WriteLine("m format : {0:m}", dt);
            Console.WriteLine("M format : {0:M}", dt);

            Console.WriteLine("u format : {0:u}", dt);
            Console.WriteLine("U format : {0:U}", dt);

            Console.WriteLine("y format : {0:y}", dt);
            Console.WriteLine("Y format : {0:Y}", dt);
        }
        public void ShowExample4()
        {
            Console.WriteLine("EXAMPLE 4");
            var i = 5;
            var s = "hello";
            var d = 1.0;

            Console.WriteLine("i x i = " + i * i);

            Console.WriteLine("s in upper case : " + s.ToUpper());

            Console.WriteLine("typeof d : " + d.GetType());
        }
        public void ShowExample5()
        {
            Console.WriteLine("EXAMPLE 5");
            var p1 = new {Name = "a", Price = 3};
            Console.WriteLine("Name = {0}\nPrice = {1}", p1.Name.ToLower(), p1.Price);
            Console.ReadLine();
        }
        static void Test(ReferenceType refer)
        {
            int temp = 5;
            refer.valueVal = temp * 2;
        }
    }
}