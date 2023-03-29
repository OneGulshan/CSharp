using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class OperatorOverloading
    {
        public string str;
        public int num;

        public static OperatorOverloading operator +(OperatorOverloading obj1, OperatorOverloading obj2) //operator overloading ke liye agar ham koi function bana rahe hain to hamein ek keyword use karna hoga jiska nam hai operator.
        {
            OperatorOverloading obj3 = new OperatorOverloading(); //static keyword with same class return type
            obj3.str = obj1.str + " " + obj2.str;
            obj3.num = obj1.num + obj2.num;

            return obj3;
        }
    }


    class CallOprOver
    {
        //static void Main()
        //{
        //    OperatorOverloading c = new OperatorOverloading();
        //    Console.WriteLine("Enter Your First Name !!");
        //    c.str = Console.ReadLine();
        //    Console.WriteLine("Enter Your Last month Bill Amount !!");
        //    c.num = Convert.ToInt32(Console.ReadLine());

        //    OperatorOverloading c1 = new OperatorOverloading();
        //    Console.WriteLine("Enter Your Last Name !!");
        //    c1.str = Console.ReadLine();
        //    Console.WriteLine("Enter Your Current month Bill Amount !!");
        //    c1.num = Convert.ToInt32(Console.ReadLine());

        //    new OperatorOverloading();
        //    OperatorOverloading c2 = c + c1;

        //    Console.WriteLine("\nYou FullName is : {0}", c2.str);
        //    Console.WriteLine("Your Total bill Amount is : {0}", c2.num);

        //    Console.ReadLine();
        //}
    }
}

//jo hamare operators hote hai vo internaly as a function kaam karte hain to isiliye
//hamein apne operator kel liye ek function ki zarurat hogi.

//type level in c# static method?
//That means, all instances of the class share the same copy of the method and its data.

