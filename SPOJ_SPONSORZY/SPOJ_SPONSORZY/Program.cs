using System;

namespace SPOJ_SPONSORZY
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sponsors,players,number, exponent;
            long sum_1 = 1;
            long sum_2 = 1;
            int how_much=Convert.ToInt32( Console.ReadLine());
            for (int i = 0; i < how_much; i++)
            {

                sponsors = Convert.ToInt32(Console.ReadLine());
                players = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < sponsors;j++)
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    exponent = Convert.ToInt32(Console.ReadLine());
                    for (int x = 0; x < exponent;x++)
                    {
                        sum_1 = sum_1 * number;
                    }
                    sum_2 = sum_2 * sum_1;
                }
                if(sum_2%players==0)
                {
                    Console.WriteLine("TAK");
                }
                else
                {
                    Console.WriteLine("NIE");
                }
                sum_1 = 1;
                sum_2 = 1;
            }
        }
    }
}
