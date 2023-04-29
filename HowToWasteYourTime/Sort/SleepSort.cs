using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HowToWasteYourTime.Sort
{
    public static class SleepSort
    {
        static int[] cahce;
        static int f;
        static int t;
        static int sleeprate;
        static SleepSort()
        {
            cahce = new int[1];
            sleeprate = 500;
        }
        static void ThreadStart(object item)
        {
            Thread.Sleep(sleeprate * (int)item);
            cahce[f] = (int)item;
            f++;
        }

        public static int[] Sort(int[] items, int SR)
        {
            f = 0;
            t = items.Length;
            cahce = new int[t];
            sleeprate = SR;
            foreach (var item in items)
            {
                #pragma warning disable 8622
                new Thread(ThreadStart).Start(item);
            }
            while(f != t){
                
            }
            return cahce;
        }

    }
}
