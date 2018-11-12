using System;

namespace Spoj_PRIME_T
{
    class MainClass
    {
        //Sprawdź, które spośród danych liczb są liczbami pierwszymi
        //INPUT
        //n - liczba testów n<100000, w kolejnych liniach n liczb z przedziału [1..10000]
        //OUTPUT
        //Dla każdej liczby słowo TAK, jeśli liczba ta jest pierwsza, słowo: NIE, w przeciwnym wypadku.


        public static void Main(string[] args)
        {
            int intQuantity;
            intQuantity = Convert.ToInt32(Console.ReadLine());
            int[] intNumber = new int[intQuantity];

            for (int i = 0; i < intQuantity; i++)
            {
                intNumber[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < intQuantity; i++)
            {
                Prime(intNumber[i]);
            }
        }



        private static void Prime(int intNumber)
        {
            double intRepeat = Math.Sqrt(intNumber);
            if (intNumber == 1)
            {
                Console.WriteLine("NIE");
                return;
            }
            if(intNumber == 2)
            {
                Console.WriteLine("TAK");
                return;
            }
            if(intNumber % 2 == 0)
            {
                Console.WriteLine("NIE");
                return;
            }
            for (int i = 3; i < intRepeat; i = i + 2)
            {
                if (intNumber % i == 0)
                {
                    Console.WriteLine("NIE");
                    return;
                }
            }
            Console.WriteLine("TAK");
        }


    }
}
