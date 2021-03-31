using System;

namespace FindNeigbourNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number sum: ");
            int number = Convert.ToInt32(Console.ReadLine());  //the number whose friends you are looking for
            Console.WriteLine("Enter max number: ");
            int maxNum = Convert.ToInt32(Console.ReadLine());
            int num;
            Console.WriteLine("Numbers friends with " + number);

            Console.WriteLine();

            for(num = 0; num < maxNum;num++)
            {
                int[] numarray = digitArr(num);
                int sum = 0;
                for(int i = 0; i < numarray.Length; i++)
                {
                    sum += numarray[i];
                }
                if(sum == number)
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadLine();
        }

        public static int[] digitArr(int n)
        {
            if (n == 0) return new int[1] { 0 };

            var digits = new List<int>();

            for (; n != 0; n /= 10)
                digits.Add(n % 10);

            var arr = digits.ToArray();
            Array.Reverse(arr);
            return arr;
        }
    }
}
