using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Outkeyword
    {
        public void Addref(int a, int b, ref int c, ref int d)
        {
            c = a + b;
            d = a * b;
        }

        public void Add(int a, int b, out int c, out int d)
        {
            c = a + b; // out keyword is for getting result directly using out keyword without return keyword simple
            d = a * b;            
        }
    }

    class Callout
    {
        //static void Main()
        //{
        //    int add, mul;
        //    outkeyword o = new outkeyword();
        //    Console.WriteLine("Please Enter two inputs for result : ");
        //    o.Add(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), out add, out mul);
        //    Console.WriteLine();

        //    Console.WriteLine("The addition of two number is : {0}", add);
        //    Console.WriteLine("The multiplication of two number is : {0}", mul);
        //    Console.WriteLine();

        //    int addref=0, mulref=0; //ref keyword reference mandatory
        //    o.Addref(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), ref addref, ref mulref);
        //    Console.WriteLine();

        //    Console.WriteLine("The addition of two number is : {0}", addref);
        //    Console.WriteLine("The multiplication of two number is : {0}", mulref);



        //    Console.ReadLine();
        //}
    }



    //class outkeywordinparameter
    //{
    //    public void Math1(int a, int b, ref int c, ref int d) // int a, int b <- input parameter, ref int c, ref int d <- output parameter these two sent the results out of the method after execution
    //    {
    //        c = a + b;
    //        d = a * b;
    //    }

    //    public void Math2(int a, int b, out int c, out int d) // int a, int b <- input parameter, ref int c, ref int d <- output parameter these two sent the results out of the method after execution
    //    {
    //        c = a + b;
    //        d = a * b;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter First Number :");
    //        int m = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Enter Second Number :");
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine();

    //        int h = 0, k = 0;
    //        //int h, k; // <- compolsory declaring because its values goes to the method
    //        Console.WriteLine(h + " " + k); //Print ref h and ref k values before execution

    //        outkeywordinparameter m1 = new outkeywordinparameter();
    //        m1.Math1(m, n, ref h, ref k);
    //        Console.WriteLine("The Addition of two numbers is : {0} The Multiplication of two numbers is : {1}", h , k); //ref values here overriden by new values

    //        //Console.WriteLine(x + " " + y);
    //        //int x, y; // these values is not goes to the method because its parametrs is type of out so we mandatory to initialize values in out type of parameter methods and we does'nt required to declare parameters seprately
    //        //int x = 0, y = 0; //You can't set values in out type variables simple but you can in ref type
    //        m1.Math2(m, n, out int x, out int y);
    //        Console.WriteLine("The Addition of two numbers is : {0} The Multiplication of two numbers is : {1}", x, y);

    //        Console.ReadLine();
    //    }
    //}
}

// out in parameter c#
// The out is a keyword in C# which is used for the passing the arguments to methods
// as a reference type. It is generally used when a method returns multiple values.
// Important Points: It is similar to ref keyword.

//Difference between ref and out in C#
//ref is used to state that the parameter passed may be modified by the method.
//in is used to state that the parameter passed cannot be modified by the method.
//out is used to state that the parameter passed must be modified by the method.
