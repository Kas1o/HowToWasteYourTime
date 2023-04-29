using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToWasteYourTime.Lib
{
    public static class GetRandom
    {
        static Random random = new Random();

        public static int[] getRandomIntArray(int intCount)
        {
            //give Me more string angle cobe;
            int[] array = new int[intCount];
            int ia = 0;
            foreach (int i in array)
            {
                array[ia] = random.Next(0, intCount - 1);
                ia++;
            }
            return array;
        }

    }
}
