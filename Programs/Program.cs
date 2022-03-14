using System;

namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arrayMax();
            leapYear();
            int[] array = { 2, 2, 3 };
            perfectSequence(array);
            SumOfrows();
        }
        static string arrayMax()
        {
            int[] array = new int[5];
            int num;
            Console.WriteLine("Enter 5 elements from 1-10 to fill the array:-");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Select any number:-");
            num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    count++;
                }
            }
            return "your score is: " + num * count;
        }
        static string leapYear()
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                return "is a Leap Year." + Year;
            else
                return " is not a Leap Year." + Year;

        }
        static string perfectSequence(int[] array)
        {
            int prod = 1;
            int sum = 0;
            foreach (int num in array)
            {
                prod *= num;
                sum += num;
                if (num < 0)
                {
                    return "No";
                }

            }
            if (prod == sum)
            {
                return "Yes";
            }

            return "No";
        }
        static int SumOfrows()
        {
            int i, j, col, row;
            int[,] arr1 = new int[3, 5];
            int[] rsum = new int[10];
            Console.Write("enter row number : ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter column number : ");
            col = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Sum of rows 
            for (i = 0; i < row; i++)
            {
                rsum[i] = 0;
                for (j = 0; j < col; j++)
                    rsum[i] += arr1[i, j];
                Console.Write("\n");
                Console.Write("{" + rsum[i] + "}");
                Console.Write("\n");
            }
            return 0;
    }
    }
}
