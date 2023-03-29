namespace OOPS
{
    //class Construct
    //{
    //    //Construct()
    //    //{
    //    //    Console.WriteLine("Parameterless Constructor !!");
    //    //}

    //    //static Construct()
    //    //{
    //    //    Console.WriteLine("Default Constructor !!");
    //    //}

    //    //Construct(Construct co)
    //    //{
    //    //    nam = co.nam;
    //    //}


    //    //int umar;
    //    //string nam;
    //    //Construct(int a, int b)
    //    //{
    //    //    Console.WriteLine("Sum is of a & b: " + a + b);
    //    //}

    //    //Construct(string name)
    //    //{
    //    //    nam = name; // here set our field nam value for using in copy constructor
    //    //    string lastname = "Kumar";
    //    //    Console.WriteLine("Name of Employee is: " + name + " " + "{0}", lastname);
    //    //}

    //    //static void Main(string[] args)
    //    //{
    //    //    new Construct(4, 5);
    //    //    Construct co = new Construct("Gulshan");
    //    //    Construct c = new Construct();
    //    //    Console.WriteLine(c.umar);
    //    //    Console.WriteLine(c.nam);      

    //    //    Construct c1 = new Construct(co);
    //    //    Console.WriteLine(c1.nam);

    //    //    Console.WriteLine("Enter Your First Name: ");
    //    //    string fname = Console.ReadLine();
    //    //    Console.WriteLine("Enter Your Last Name: ");
    //    //    string lname = Console.ReadLine();
    //    //    Console.WriteLine("Username is: " + fname + " " + lname);
    //    //}
    //}
}
// A constructor is a special method of the class which gets automatically invoked whenever an instance of the class is created.
// Like methods, a constructor also contains the collection of instructions that are executed at the time of Object creation.
// It is used to assign initial values to the data members of the same class.

// Note: In the default constructor, all the numeric fields are initialized to 0, whereas string and object are initialized as null.
// Note: If a constructor is private, we cannot create objects of the class. Hence, all fields
// and methods of the class should be declared static, so that they can be accessed using the class name.

// Here, we are calling the Car() constructor.You can see that the static constructor is also called along with the regular constructor.
// In C#, we can create two or more constructor in a class. It is known as constructor overloading.
