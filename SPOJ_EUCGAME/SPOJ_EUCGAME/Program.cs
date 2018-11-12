using System;

namespace SPOJ_EUCGAME
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number_of_games = Convert.ToInt32(Console.ReadLine());
            int[] player_1 = new int[number_of_games];
            int[] player_2 = new int[number_of_games];
            for (int i = 0; i < number_of_games; i++)
            {
                player_1[i] = Convert.ToInt32(Console.ReadLine());
                player_2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < number_of_games; i++)
            {
                while (true)
                {
                    if(player_1[i]> player_2[i])
                    {
                        player_1[i] = player_1[i] - player_2[i];
                    }
                    else if (player_1[i] < player_2[i])
                    {
                        player_2[i] = player_2[i] - player_1[i];
                    }
                    else
                    {
                        Console.WriteLine(player_1[i]+player_2[i]);
                        break;
                    }

                }
            }
        }
    }
}
