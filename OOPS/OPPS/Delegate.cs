using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    public delegate void Calculation(int a, int b);
    
    class DelegatePractice
    {
        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition is: {0}", result);
        }

        public static void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction is: {0}", result);
        }

        public static void Mul(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication is: {0}", result);
        }

        public static void Div(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division is: {0}", result);
        }

        class CallCal
        {
            //static void Main(string[] args)
            //{
            //    Calculation obj = new Calculation(Add);
            //    obj(5, 6);
            //    Sub(10, 9);
            //    Mul(2, 9);
            //    Div(4, 2);

            //    Console.ReadLine();
            //}
        }
    }
}

// C# ka manna ye hai ki agar aap Delegates ka use zyada karte ho to aapki
// application ki performance me bhetri aati hai(means fast chalti hai)

//About Delegate
// Delegate is a an object which refers to a method. its a reference type variable
// that's can hold a reference to the methods.
// Delegates can be chained together as two or more methods can be called on a single event.
// It doesn’t care about the class of the object that it references.


//Limitations
// Delegate is like a mediater that communicating between two things
// Delegate me data return type and parameters same hone chaiye methods se
// Delegate ka use agar hamein apne method ko Encapsulate karna ho or indirectely
// way me apne method ko call karna ho
// Instantiate(means obj banana)
// Ham 1 hi Delegate ke throw diff Methods ko bhi point kar sakte hai

// Delegates allow methods to be passed as parameters.
// Delegates can be used to define callback methods.
// Delegates can be chained together; for example, multiple methods can be called on a single event.
// Methods don't have to match the delegate type exactly.

// Agar hamein 1 hi Method ko call karana hai to use khete hai Single Cast Delegate(means 1 delegate se aap diff method pass nahi karva sakte/point nahi karva sakte)