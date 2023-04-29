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
        static void ThreadStart(object item)
        {
            Thread.Sleep(1000 * (int)item);
            cahce[f] = (int)item;
            f++;
        }

        public static int[] Sort(params int[] items)
        {
            f = 0;
            t = items.Length;
            cahce = new int[t];
            foreach (var item in items)
            {
                new Thread(ThreadStart).Start(item);
            }
            while(f != t){
                
            }
            return cahce;
        }

    }
}
