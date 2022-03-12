using System;

namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.arrayMax());
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
    }
}
