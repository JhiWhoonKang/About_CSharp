using System;
using System.Runtime.CompilerServices;

namespace Anonymous_Func
{
    internal class Program
    {
        delegate int Calculate(int a, int b);
        delegate string Concatenate(string[] args);                

        static void Main(string[] args)
        {
            Calculate calc = (a, b) => a + b;

            Console.WriteLine($"{3} + {4} : {calc(3, 4)}");

            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');

            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (string s in arr)
                    result += s;

                return result;
            };

            Console.WriteLine(concat(inputArray));

            Func<int> func1 = () => 10;
            Console.WriteLine($"func1() : {func1()}");

            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine($"func2(4) : {func2(4)}");

            Func<double, double, double> func3 = (x, y) => x / y;
            Console.WriteLine($"func3(22, 7) : {func3(22, 7)}");

            Action act1 = () => Console.WriteLine("Action()");
            act1();

            int action_result = 0;
            Action<int> act2 = (x) => action_result = x * x;

            act2(3);
            Console.WriteLine($"result : {action_result}");

            Action<double, double> act3 = (x, y) =>
            {
                double pi = x / y;
                Console.WriteLine($"Action<T1, T2>({x}, {y} : {pi}");
            };
            act3(22.0, 7.0);
        }
    }
}