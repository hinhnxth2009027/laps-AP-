using System;

namespace lap1.Exercises
{
    public class Exercises
    {
        public void ShowExercise1()
        {
            Console.WriteLine("EXERCISE 1");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("vui lòng nhập tên:");
            var ten = Console.ReadLine();
            Console.WriteLine("vui lòng nhập địa chỉ:");
            var diaChi = Console.ReadLine();
            Console.WriteLine("vui lòng nhập Số diện thoại:");
            var sdt = Console.ReadLine();

            Console.WriteLine($"tên : {ten} \t địa chỉ : {diaChi} \t số điện thoại : {sdt}");
        }

        public void ShowExercise2()
        {
            Console.WriteLine("EXERCISE 2");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("\nnhập 3 số nguyên\n");
            Console.WriteLine("nhập số thứ 1:");
            var number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập số thứ 2:");
            var number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập số thứ 3:");
            var number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (number1 == number2 && number1 == number3)
            {
                Console.WriteLine("3 so bang nhau\n");
            }

            else if (number1 >= number2 && number2 > number3)
            {
                Console.WriteLine("so lon nhat la {0}\n", number1);
            }
            else if (number1 > number2 && number1 >= number3)
            {
                Console.WriteLine("so lon nhat la {0}\n", number1);
            }

            else if (number2 >= number1 && number2 > number3)
            {
                Console.WriteLine("so lon nhat la {0}\n", number2);
            }
            else if (number2 > number1 && number2 >= number3)
            {
                Console.WriteLine("so lon nhat la {0}\n", number2);
            }

            else if (number3 >= number1 && number3 > number2)
            {
                Console.WriteLine("so lon nhat la {0}\n", number3);
            }
            else if (number3 > number1 && number3 >= number2)
            {
                Console.WriteLine("so lon nhat la {0}\n", number3);
            }
        }

        public void ShowExercise3()
        {
            Console.WriteLine("EXERCISE 3");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("vui long nhap mot so tu 1 den 7");
            var luaChon = int.Parse(Console.ReadLine());
            switch (luaChon)
            {
                case 1:
                    Console.WriteLine("chu nhat");
                    break;
                case 2:
                    Console.WriteLine("thu hai");
                    break;
                case 3:
                    Console.WriteLine("thu ba");
                    break;
                case 4:
                    Console.WriteLine("thu tu");
                    break;
                case 5:
                    Console.WriteLine("thu nam");
                    break;
                case 6:
                    Console.WriteLine("thu sau");
                    break;
                case 7:
                    Console.WriteLine("thu bay");
                    break;
            }
        }

        public void ShowExercise4()
        {
            Console.WriteLine("EXERCISE 4");
            Console.WriteLine("vui long nhap so ban muon in bang cuu truong");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("bang cuu chuong : {0}", number);
            for (var i = 1; i < 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}