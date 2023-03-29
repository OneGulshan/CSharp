using System;

namespace OOPS
{
    class baseClass
    {
        public virtual void Greetings()
        {
            Console.WriteLine("baseClass Saying Hello!");
        }
    }

    class subClass : baseClass
    {
        public override void Greetings()
        {
            base.Greetings();
            Console.WriteLine("subClass Saying Hello!");
        }
    }

    class SecondsubClass : baseClass
    {
        public override void Greetings()
        {
            Console.WriteLine("Hello Second Child Buddy !!!");
        }
    }


    class CallbaseClass
    {
        //static void Main(string[] args)
        //{
        //    baseClass obj1 = new baseClass();
        //    obj1.Greetings(); Console.WriteLine();

        //    baseClass obj2 = new subClass();
        //    obj2.Greetings(); Console.WriteLine();

        //    subClass obj3 = new subClass();
        //    obj3.Greetings();

        //    Console.ReadLine();
        //}
    }
}

//using virtual or override keyword we can override our base class method in
//child class in Polymorphism. without virtual keyword we can only call base method.


//Polymorphism meaning is (Poly)many + (morphism)forms it's a greek word. There are
//two types of polymorphism in C# : run time or compile time polymorphism is achieved
//by method overloading or operator overriding.
//Method overloading is the common way of implementing polymorphism. It's a ability
//of redefining a method in more than one form.
//A user can Impliment function overloading by defining two or more functions in a
//class sharing the same name. C# can distinct methods with different method signature.
//therefore of the number of the parameter, order of parameters, and data types of the
//Parameters within the same class.

//--------------------------------------------------------------

//operator overloading
//In Operator Overloading a function can also be applied to operators. Operator
// Overloading gives the ability to use the same operator to do  various operations.

//Only the predefine set of C# operators can be overloaded.


//What is Polymorphism in C#?
//Explain the different types of Polymorphism in C#?
//What is compile-time Polymorphism in C#?
//What is Runtime Polymorphism in C#?
//Explain different types of Overloading in C#?
//What is function overloading?
//When should we overload methods in C#?
