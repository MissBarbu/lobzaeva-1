using System;

namespace Lib_7
{
    public class LibClass
    {
        public static void Sum(int n, out int sum, out string numbers)
        {
            sum = 0;
            numbers = ""; //список сгенирированных чисел
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int value = rnd.Next(n + 1);
                if (value < n / 2) sum += value;
                numbers += value + ", ";
            }
        }
    }
}
