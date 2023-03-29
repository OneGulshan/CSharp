using System;

namespace OOPS
{
    class Vehicle // single Inheritence
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Cars : Vehicle
    {
        public string modelName = "Mustang";
    }

    //--------------------------------------------------------------------

    class Product //Multiple Inheritence Example
    {
        public string name = "Alhmirha";
    }

    class Manufacturing : Product
    {
        public int ManufacturingPrice = 5000;
    }

    class Production : Manufacturing
    {
        public string DiliveryAgentAddress = "K - 68, Pharhganj, phase - 1 khasra - 4";
    }

    //--------------------------------------------------------------------

    interface Infrastructur // Multiple Inheritence using Interface
    {
        void Infra();
    }

    class Furniture
    {
        public string Color = "brown";
        public string size = "28-30 inches";
        public string typeofwood = "Teak Wood";
    }

    class Marketing : Furniture, Infrastructur
    {
        public string MarketPlaces = "Madhya Pradesh, Maharashtra, Tamil Nadu, Karnataka, Kerala, Gujarat, Orissa, Rajasthan, Andhra Pradesh and Manipur";

        public void Infra()
        {
            string nameofproduct = "Table";
            Console.WriteLine(nameofproduct);
        }
    }

    //--------------------------------------------------------------------

    class cal1 //Calculation performed using Multiple Inheritence
    {
        public int result1;

        public int add(int a, int b) 
        {           
            return result1 = a + b;
        }
    }
    interface cal2
    {
        int sub(int x, int y);
    }
    interface cal3
    {
        int mul(int r, int s);
    }
    interface cal4
    {
        int div(int c, int d);
    }
    class Calulation : cal1, cal2, cal3, cal4
    {               
        public int result2;
        public int sub(int x, int y)
        {
            return result2 = x - y;
        }
        public int result3;
        public int mul(int r, int s)
        {
            return result3 = r * s;
        }
        public int result4;
        public int div(int c, int d)
        {
            return result4 = c / d;
        }
    }

    //--------------------------------------------------------------------

    interface A
    {
        void A();
    }

    interface B : A
    {
        void B();
    }


    interface C : A
    {
        void C();
    }
    
    class D : B, C
    {         
        public void A()
        {
            Console.WriteLine("This is the A Interface !!");
        }

        public void B()
        {
            Console.WriteLine("This is the B Interface !!");
        }

        public void C()
        {
            Console.WriteLine("This is the C Interface !!");
        }
    }

    //--------------------------------------------------------------------

    class Program
    {
        //static void Main(string[] args)
        //{
        //    Cars mycar = new Cars();
        //    Console.WriteLine(mycar.brand + " " + mycar.modelName);
        //    mycar.honk(); Console.WriteLine();

        //    Production production = new Production();
        //    Console.WriteLine("Product Name: " + production.name);
        //    Console.WriteLine("Product Manufacturing Price: " + production.ManufacturingPrice);
        //    Console.WriteLine("Production Agent Address: " + production.DiliveryAgentAddress); Console.WriteLine();

        //    Marketing m = new Marketing();
        //    m.Infra();            
        //    Console.WriteLine(m.Color);
        //    Console.WriteLine(m.MarketPlaces);
        //    Console.WriteLine(m.size);
        //    Console.WriteLine(m.typeofwood); Console.WriteLine();

        //    calulation c = new calulation();
        //    c.add(8, 2);
        //    c.sub(20, 10);
        //    c.mul(5, 2);
        //    c.div(20, 10);            
        //    Console.WriteLine("Addition: " + c.add(4, 7));
        //    Console.WriteLine("Substraction: " + c.result2);
        //    Console.WriteLine("Multiplication :" + c.result3);
        //    Console.WriteLine("Division: " + c.result4); Console.WriteLine();

        //    D d = new D();
        //    d.A(); d.B(); d.C();
        //}
    }
}

//Inheritance is the mechanism in C# by which one class is allowed to inherit the features(fields and methods) of another class.

//Syntax:
//class derived-class(Sub Class, Child Class) : base-class(Super Class, Parent Class)
//{  
// methods and fields
//}

//Sealed classes are used to restrict the users from inheriting the class, cannot be extended.

//Private member inheritance: A subclass does not inherit the private members of its parent class.
//However, if the superclass has properties(get and set methods) for accessing its private fields, then a subclass can inherit.