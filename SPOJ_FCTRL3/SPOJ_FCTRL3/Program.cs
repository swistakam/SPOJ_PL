using System;

namespace SPOJ_FCTRL3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int how_much =Convert.ToInt32(Console.ReadLine());
            long[] number = new long [how_much];

            for (int i = 0; i < how_much; i++)
            {
                number[i] = Convert.ToInt64(Console.ReadLine());
            }
            for (int i = 0; i < how_much; i++)
            {
                exponentiation(number[i]);
            }
        }

        public static void exponentiation(long number)
        {
            long sum = 1;
            for (int i = 1; i <= number; i++ )
            {
                sum = sum * i;
            }
            long x = sum % 10;
            sum = sum / 10;
            long y = sum % 10;
            Console.WriteLine("{0} {1}",y,x);

        }
    }
}
