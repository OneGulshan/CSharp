using System;
using System.Collections.Concurrent;

namespace OOPS
{
    public delegate void Show_Delegate();
    public delegate void Calculation2(int num);    
    class Call
    {
        public static void Square(int num)
        {
            int square = num * num;
            Console.WriteLine("Square of {0} is {1}", num, square);            
        }

        public static void Cube(int num)
        {
            int cube = num * num * num;
            Console.WriteLine("Cube of {0} is {1}", num, cube);
        }

        public static void Show()
        {
            Console.WriteLine("This is a show method !!");
        }

        //static void Main(string[] args)
        //{
        //    int i;
        //    Console.Write("Enter a Number : ");
        //    i = int.Parse(Console.ReadLine());
        //    if (i % 2 == 0)
        //    {
        //        Console.Write("Entered Number is an Even Number");
        //    }
        //    else
        //    {
        //        Console.Write("Entered Number is an Odd Number");
        //    }

        //    Console.WriteLine(); Console.WriteLine();

        //    -------------------------------------------------------------------

        //    Calculation2 obj = new Calculation2(Square);
        //    obj(2);
        //    obj = Cube;
        //    obj(3);

        //    Show_Delegate obj1 = new Show_Delegate(Show);
        //    obj1();

        //    string abc = string.Concat(Enumerable.Repeat("Hii " + "Happy Birthday " + "Yashu , ", 100));
        //    Console.WriteLine("{0}", abc);


        ////    for (int i = 1; i <= 4; ++i)
        ////    {
        ////        for (int j = 1; j <= i; ++j)
        ////        {

        ////            Console.WriteLine("*");

        ////        }
        ////        Console.WriteLine();
        ////    }

        //    try
        //    {
        //        int[] myNumbers = { 1, 2, 3 };
        //        Console.WriteLine(myNumbers[10]);
        //    }
        //    catch
        //     (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
    }
}
