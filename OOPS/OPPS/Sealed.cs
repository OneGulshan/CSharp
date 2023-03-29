using System;

namespace OOPS
{
    sealed class Test
    {
        public int age = 29;
    }

    //class Example : Test //can't Inherit Sealed Class
    //{
    //    public int rollno = 37;
    //}

    class Abc
    {
        //static void Main()
        //{
        //    Test t = new Test();
        //    Console.WriteLine(t.age);

        //    //Example e = new Example();
        //    //Console.WriteLine(e.rollno);
        //    //Console.WriteLine(e.age);
        //}
    }

    //-------------------------------------------------------    


    class Animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Animal Sound");
        }
    }

    class Dog : Animal
    {
        // sealed method
        sealed public override void makeSound() // Sealed Methods
        {            
            Console.WriteLine("Dog Sound");
        }
    }

    class Puppy : Dog
    {
        // trying to override sealed method
        //public override void makeSound()
        //{
        //    Console.WriteLine("Puppy Sound");
        //}
    }

    class Programs
    {
        //static void Main()
        //{
        //    Puppy d1 = new Puppy();
        //    d1.makeSound();
        //    Console.ReadLine();
        //}
    }
}

//Sealed classes are used to restrict the users from inheriting the class.





//update set cname="India" where Country like ('AS')