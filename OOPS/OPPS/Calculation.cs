using System;

namespace OOPS
{    
    class Addition
    {
        public int sum;
        public void Add(int a, int b)
        {            
            Console.WriteLine("Addition of a & b is: {0}", sum = a + b);
        }
    }

    class Subtraction : Addition
    {
        public void sub(int a, int b)
        {
            Console.WriteLine("Subtraction of a & b is: {0}", sum = a - b);
        }
    }

    class Multiplication : Subtraction
    {
        public void mul(int a, int b)
        {            
            Console.WriteLine("Multiplication of a & b is: {0}", sum = a * b);
        }
    }

    class Caculation
    {
        //static void Main(string[] args)
        //{                             
        //    Console.WriteLine("Enter Number a: ");
        //    int a = Convert.ToInt32(Console.ReadLine());            
        //    Console.WriteLine("Enter Number b: ");
        //    int b = Convert.ToInt32(Console.ReadLine());

        //    Multiplication cal = new Multiplication();
        //    cal.Add(a, b);
        //    cal.sub(a, b);
        //    cal.mul(a, b);            
            
        //    Console.ReadLine();
        //}
    }
}
