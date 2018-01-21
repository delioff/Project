using System;
namespace MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (isPalindrome(i) == true && divisibleSum(i) == true
                    && haveEven(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool isPalindrome(int number)
        {
            string str = number.ToString();
            if (str.Length == 1)
            {
                return true;
            }
            for (var i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool divisibleSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                sum += lastDigit;
                n /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool haveEven(int n)
        {
            
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
                n /= 10;
            }
            return false;
        }
    }
}
