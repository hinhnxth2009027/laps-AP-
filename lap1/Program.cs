using System;
using lap1.Examples;
using lap1.Exercises;

class ReferenceType
{
    public int valueVal;
}

internal class Program
{
    private static Exercises _exercises = new Exercises();
    private static Examples _examples = new Examples();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n====================");
            Console.WriteLine(".1 Show example1");
            Console.WriteLine(".2 Show example2");
            Console.WriteLine(".3 Show example3");
            Console.WriteLine(".4 Show example4");
            Console.WriteLine(".5 Show example5\n");
            Console.WriteLine(".6 Show Exercise 1");
            Console.WriteLine(".7 Show Exercise 2");
            Console.WriteLine(".8 Show Exercise 3");
            Console.WriteLine(".9 Show Exercise 4");
            Console.WriteLine(".0 Show Exercise 5");
            Console.WriteLine("====================/n");
            var choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    _examples.ShowExample1();
                    break;
                case 2:
                    _examples.ShowExample2();
                    break;
                case 3:
                    _examples.ShowExample3();
                    break;
                case 4:
                    _examples.ShowExample4();
                    break;
                case 5:
                    _examples.ShowExample5();
                    break;
                case 6:
                    _exercises.ShowExercise1();
                    break;
                case 7:
                    _exercises.ShowExercise2();
                    break;
                case 8:
                    _exercises.ShowExercise3();
                    break;
                case 9:
                    _exercises.ShowExercise4();
                    break;
                case 0:
                    _exercises.ShowExercise5();
                    break;
            }
        }


        
    }
}