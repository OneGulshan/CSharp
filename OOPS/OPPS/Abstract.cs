using System;

namespace OOPS
{	
	abstract class Shape
    {
		public abstract int area(int a = 4);		
    }

	class Square : Shape
	{
		private int side;
		
		public Square(int x = 4)
		{
			side = x;
		}

		public override int area(int a)
		{
			Console.Write("Area of Square: ");
			return (side * a);
		}
	}    

    class GFG
	{
        //static void Main(string[] args)
        //{
        //    Shape sh = new Square();
        //    double result = sh.area(7);
        //    Console.Write("{0}", result);
        //    Console.ReadLine();
        //}
    }

    abstract class Even
    {
        public abstract int evenno(int a);
    }

    class Odd : Even
    {
        public override int evenno(int a)
        {
            return ++a; // Increament before after print            
        }
    }

    class Evenodd
    {
        //static void Main(string[] args)
        //{
        //    int result = Convert.ToInt32(Console.ReadLine());
        //    Odd o = new Odd();
        //    int c = o.evenno(result);
        //    Console.Write("{0}", c);
        //    Console.ReadLine();
        //}
    }
    // all types of regex(Regular Expression), pincode, name, full name, country, state.
}//out in parameter, dictionory, dynamic, polymorphism, partial class, enum and enum to list conversion, linq(swich case,if else,join), Task(threading), non-abstract class, array(array to list, list to string with , seprated like rahul, Gulshan, shivam).

//Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited
//from another class).

//Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the
//derived class (inherited from).

// Abstract Classes and Methods
// abstration is the process of hidding certain details and showing only essential details to the user.
// Abstract class can't create object we can inherite abstract class by other class and use its members with the
// help of its base class. In abstract class always public members for accessing by base class.
// abstract class members are implimented by its inherited class. class contain abstract methods but not all abstract
// that's called abstract base class and if all methods abstract in abstract class in that case class called pure abstract base class.
