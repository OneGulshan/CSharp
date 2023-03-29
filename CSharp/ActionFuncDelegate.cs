using System;

namespace CSharp
{
    public class ActionFuncDelegate
    {
        static void Main(string[] args)
        {
            //(1)Func, Action and Predicate Delegates in C# | Delegates Part 5
            //In previous videos to Invoke every method where defining a delegate in C#

            //Delegate1 ob1 = GenericDelegates.AddNums1;//AddNums1 <- Target Method
            //double result = ob1.Invoke(100, 9.8f, 27.89d);
            //Console.WriteLine(result);
            //Delegate2 ob2 = GenericDelegates.AddNums2;
            //ob2.Invoke(100, 5.6f, 34.67d);
            //Delegate3 ob3 = GenericDelegates.CheckLength;
            //bool status = ob3.Invoke("Hello World");
            //Console.WriteLine(status);
            //Func delegate has inputs parameters and one output parameter is used with returning value method

            //Func<int, float, double, double> ob1 = GenericDelegates.AddNums1;
            //double result = ob1.Invoke(100, 9.8f, 27.89d);
            //Console.WriteLine(result);
            ////Action delegate using with void type method its has only input parameters.
            //Action<int, float, double> ob2 = GenericDelegates.AddNums2;
            //ob2.Invoke(100, 5.6f, 34.67d);
            ////Predicate delegate using with bool type method its has only one parameter.
            ////Predicate<string> ob3 = GenericDelegates.CheckLength;
            //Func<string, bool> ob3 = GenericDelegates.CheckLength;//On place of Predicate delegate we can use Func delegate but preferable is predicate
            //bool status = ob3.Invoke("Hello World");
            //Console.WriteLine(status);

            Func<int, float, double, double> ob1 = (xa, ya, za) => xa + ya + za; //Without specifing names with method we can use anonymous function and lambda operators with generic delegates for calling generic delegates
            double result = ob1.Invoke(100, 9.8f, 27.89d);
            Console.WriteLine(result);
            Action<int, float, double> ob2 = (xa, ya, za) => Console.WriteLine(xa + ya + za);
            ob2.Invoke(100, 5.6f, 34.67d);
            Predicate<string> ob3 = (str) => //{ <- Scope not using with only single line of code
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
            bool status = ob3.Invoke("Hello World");
            Console.WriteLine(status);

            Console.ReadLine();
        }
    }
    //(1)Func, Action and Predicate Delegates in C# | Delegates Part 5
    //We have three predefine generic delegates in C# Func, Action and Predicate:- 
    //Calling three methods using delegate
    //public delegate double Delegate1(int x, float y, double z);//No required to define these 3 types of delegates now in C# because these three generic delegates is predefine in C#
    //public delegate void Delegate2(int x, float y, double z);
    //public delegate bool Delegate3(string str);
    class GenericDelegates
    {
        //Now No requirements of these methods after using lambda operator and anonymous function with predefined generic delegates in C#
        //public static double AddNums1(int x, float y, double z)
        //{
        //    return x + y + z;
        //}

        //public static void AddNums2(int x, float y, double z)
        //{
        //    Console.WriteLine(x+ y + z);
        //}

        //public static bool CheckLength(string str)
        //{
        //    if (str.Length > 5)
        //        return true;
        //    return false;
        //}
    }
}
