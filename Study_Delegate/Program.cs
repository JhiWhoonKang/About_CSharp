using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Delegate
{
    delegate int MyDelegate(int a, int b);
    delegate int Compare(int a, int b);    

    class Calculate
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static int DescendCompare(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            #region ex1
            Calculate Calc = new Calculate();
            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calculate.Minus);
            Console.WriteLine(Callback(7, 5));
            #endregion

            #region ex2
            //int[] array = { 3, 7, 4, 2, 10 };
            int[] array = { -3, -7, -4, -2, -10 };
            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, new Compare(AscendCompare));

            for(int i=0;i<array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting descending...");
            BubbleSort(array2, new Compare(DescendCompare));

            for(int i=0;i<array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }

            Console.WriteLine();
            #endregion
        }
    }
}
