using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToWasteYourTime.Math
{
    public static class Square
    {
        static Random 随δ机 = new();
        public static int Get(int number)
        {
            while (true)
            {
                int ara = 随δ机.Next(0, int.MaxValue);
                if(ara == number * number)
                {
                    return ara;
                } 
            }
        }
        public static int GetB(int number) {
            int c = number;
            for(int i = 0; i < number; i++)
            {
                c = c * number;
            }
            return c;
        }
    }
}
