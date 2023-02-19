using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerRollDies
{
    class RollDies
    {
        public static void Dies()
        {
            int player = 0;
            Random random = new Random();
            int rollDice = random.Next(0, 7);

            Console.WriteLine("Rolling Of Dies Palyer Gets: " + rollDice);
        }
        


    }
}
