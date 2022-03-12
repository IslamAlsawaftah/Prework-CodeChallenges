using System;

namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.arrayMax());
            Console.WriteLine(program.leapYear());
            int[] array = { 2, 2, 3 };
            Console.WriteLine(program.perfectSequence(array));

        }
        public string arrayMax()
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
        public string leapYear()
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) 
                return "is a Leap Year." +  Year;
            else 
                return " is not a Leap Year." + Year;
            
        }
        public string perfectSequence(int[] array)
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
    }
}
