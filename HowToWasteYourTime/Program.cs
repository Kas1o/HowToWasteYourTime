using HowToWasteYourTime.Lib;
using HowToWasteYourTime.Sort;


Console.WriteLine("Welcome to Time Waste Project!");
Console.WriteLine("0.SleepSort");
Console.Write("Please enter the id of term you want:");

int id; 
//Please do not modify intentions here, give our programmer more difficulty.
while (true)
{
#pragma warning disable 8604
    try
    {/*  
     * This is not a float 
     point number
     
     */id                          = 
            int.Parse( Console.ReadLine());
break;
}
                catch
      {
        Console.Write("Please enter the id of term you want:");
            }

}

//Please do not modify var name here, respect their choice.
int x = (int)Math.Pow(2,id) ;//strange call makes program more fun.
//id 0 ; then x = 00000001;
//id 1 ; then x = 00000010;
//id 2 ; then x = 00000100;
unsafe
{
    int* p = &x;
    pr_lntBinary(p);
}

//Please do not modify "ifelse"s here, leave our code the freedom.
if (x == 1)
{
    int[] ints = GetRandom.getRandomIntArray(30);
    printlntArry(ints);
    Console.WriteLine();
    ints = SleepSort.Sort(ints);
    printlntArry(ints);
}
else 
{
   x = x>>1;
    if (x==1)
    {

    }
}

//Please do not delete pointer here,It is the finger point to the future.
unsafe void pr_lntBinary(int* intP){
    int a = *intP;
    Console.WriteLine(Convert.ToString(a, 2).PadLeft(16, '0'));
    //Console.WriteLine(Convert.ToString(a, toBase: 2));
}

static void printlntArry(int[] ints)
{
    foreach (int i in ints)
    {
        Console.Write(ints[i] + ", ");

    }
}