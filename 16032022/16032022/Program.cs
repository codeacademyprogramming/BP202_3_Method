using System;

namespace _16032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Birinci ededi daxil edin:");
            string num1Str = Console.ReadLine();
            Print("2.  ededi daxil edin:");
            string num2Str = Console.ReadLine();
            Print("ucuncu ededi daxil edin:");
            string num3Str = Console.ReadLine();

            int n1 = Convert.ToInt32(num1Str);
            int n2 = Convert.ToInt32(num2Str);
            int n3 = Convert.ToInt32(num3Str);


            int result = Sum(n1,n2,n3);
            Console.WriteLine($"result: {result}");

            int[] numbers = { 45, 9, -5, -23, 14 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = Sum(sum, numbers[i]);
            }

            Console.WriteLine($"sum: {sum}");

            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string fullname = MakeFullName(name,surname);
            Console.WriteLine($"fullname: {fullname}");

            Console.WriteLine("Eded daxil et");
            string intpurStr = Console.ReadLine();
            int intputInt = Convert.ToInt32(intpurStr);

            bool isEven = IsEven(intputInt);

            Console.WriteLine($"{intputInt} ededi cutdurmu? - {isEven}");

            int[] nums = { 45, 10, 44, 12, 37 };
            int evenCount = FindEvenCount(nums);

            Console.WriteLine($"Cut ededlerin sayi: {evenCount}");
            int wantedIndex = FindNumberIndex(nums, 11);
            Console.WriteLine($"Wanted index: {wantedIndex}");
        }

        static int Sum(int num1,int num2,int? num3=null)
        {
            if (num3 == null)
            {
                return  num1 + num2;
            }
            else
            {
               return num1 + num2 + Convert.ToInt32(num3);
            }
        }

        static string MakeFullName(string str1,string str2)
        {
            string fullName = str1 + " " + str2;
            return fullName;
        }

        static void Print(string output)
        {
            if(HasDigit(output)==false)
                Console.WriteLine(output);
        }

        static bool HasDigit(string str)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == str[i])
                        return true;
                }
            }

            return false;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static int FindEvenCount(int[] numbers)
        {
            int count = 0;
            foreach (var item in numbers)
            {
                if (IsEven(item))
                    count++;
            }

            return count;
        }

        static int FindNumberIndex(int[] numbers, int num)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                    return i;
            }

            return -1;
        }


    }
}
