using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeAndLadder
{
    internal class PlayerPosition
    {
        public static void player()
        {
            byte count = 0, playerposition = 0,lastPosition=100;
            Random random= new Random();
            Random random_1 =new Random();
            for(int i = 0; i < lastPosition; i++)
            {
                while(count  <= lastPosition)
                {
                    int position = random.Next(0, 3);
                    int dice = random_1.Next(1,7);
                    if (playerposition == 0)
                    {
                        if (position == 0)
                        {
                            position = position - dice;
                            Console.WriteLine("snake");
                            Console.WriteLine("Player position move to behind ");
                            Console.WriteLine("Position :" + position);
                        }
                        else if (position == 1)
                        {
                            position = position + dice;
                            Console.WriteLine("Ladder");
                            Console.WriteLine("player Position move ahead");
                            Console.WriteLine("Position: " + position);
                        }
                        else
                        {
                            Console.WriteLine("No play");
                            Console.WriteLine("Player in zero position");

                        }
                    }
                }
                count++;
            }

        }
    }
}
