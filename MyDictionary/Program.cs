using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> myDictonary1 = new MyDictonary<int, string>();
            myDictonary1.Add(1, "Engin");

            MyDictonary<int, string> myDictonary2 = new MyDictonary<int, string>();
            myDictonary2.Add(2, "Enes");
        }
    }
}
