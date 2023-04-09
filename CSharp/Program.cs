using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////(3)NAMESPACE AND MAIN METHOD IN C# PROGRAMMING
            //Console.WriteLine("Welcom to C# !!");

            ////(4)READING AND WRITING TO THE CONSOLE IN C# PROGRAMMING
            //Console.WriteLine("Enter Your First Name !!");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter Your Last Name !!");
            //string lastname = Console.ReadLine();
            //Console.WriteLine("Your Name is : " + name + " " + lastname);//concatinate(+)
            //Console.WriteLine("Your Name is : {0} {1}", name, lastname);//placeholder({0})

            //Console.WriteLine("Enter first Number !!");
            //int firstnumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second Number !!");
            //int secondnumber = int.Parse(Console.ReadLine());
            //int sum = firstnumber + secondnumber;
            //Console.WriteLine("The Sum of the numbers is : " + sum);//, is not supported here because where can i put the value of by sum variable required here an placeholder

            ////(5)BUILT IN DATA TYPES IN C# PROGRAMMING
            //Console.WriteLine(int.MaxValue);//for knowing max value of datatype
            //Console.WriteLine(int.MinValue);//for knowing min value of datatype

            int a = 30; int b = 20; bool c = a > b;
            Console.WriteLine("Bool value is : " + c);

            //(6)FLOAT, DOUBLE AND DECIMAL DATA TYPES IN C SHARP
            float d = 20f; double e = 23d; decimal f = 29.35m;
            Console.WriteLine("These DataTypes values are : " + d + ", " + e + ", " + f);

            //(7)STRING AND CHARACTER DATA TYPE, ESCAPE SEQUENCES, AND VERBATIM LITERAL IN C SHARP
            string g = "Hii"; char h = 'D';
            string i = "\"Hello\"";//Escape sequences -> \",\'(single,double quotes"), \\(single \), \t(tab), \n(next line)
            string j = @"Hello\Bro\How\Are\You";//verbatim literal use for ignoring escape sequences by compiler
            Console.WriteLine("DataType value is showed here : " + i);

            //(8)DATA TYPE CONVERSION IN C# PROGRAMMING
            int k = 5;//explicit data type conversion
            float l = k;

            string m = "5";//implicit conversion is done by the compiler
            int n =/*(int), Convert.ToInt32*/int.Parse(m);//explicit conversion is done by the developer because small to high datatype conversion id done by the compiler implicitly
            Console.WriteLine(n);

            //(9)CONSTANT VARIABLE IN C-SHARP
            //a contant variable value is fixed in a program can't be changeable
            Console.WriteLine(PI);

            //(10)DATE TIME FORMAT SPECIFIERS/SPECIAL CHARACTERS IN C-SHARP, For display the date and time values in different formats using with placeholder.
            DateTime dt = DateTime.Now;
            Console.WriteLine("{0:d}", dt);//D, f, F, g, t, T, yy, yyyy, t, d, dd, ddd, dddd, FF, HH, MM, MMM, ss
            Console.WriteLine("{0:HH:mm:ss tt}", dt);//we can also make our own time formate like

            //(12)ARITHMETIC OPERATORS IN C#
            //Arithmatic Operators work with two or more operands
            int o = 24, p = 3, q, r, s, t, u;
            q = o + p;
            r = o - p;
            s = o / p;
            t = o * p;
            u = o % p;//Remainder(%)

            Console.WriteLine(q);
            Console.WriteLine(r);
            Console.WriteLine(s);
            Console.WriteLine(t);
            Console.WriteLine(u);

            //(13)RELATIONAL OR COMPARISON OPERATORS IN C#
            int v = 7;
            int w = 6;
            //bool x = v == w;
            //bool x = v != w;
            //bool x = v > w;
            //bool x = v < w;
            //bool x = v >= w;
            bool x = v <= w;
            Console.WriteLine(x);

            //(14)LOGICAL OPERATORS IN C-SHARP
            //&&,||
            bool y = (v > w) && (v < w);
            bool z = (v > w) || (v < w);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //(15)ASSIGNMENT OPERATORS IN C-SHARP
            //+=, -=, *=, /=, %=
            int A = 5;
            //A += 1;//A = A + 1;
            A = +1;//no increament here
            Console.WriteLine(A);

            //(16)INCREMENT AND DECREMENT OPERATORS IN C-SHARP
            int B = 5;
            Console.WriteLine(B++);//post-increment(means B print here, then increament then add value in next cw)
            Console.WriteLine(++B);//pre-increment

            //(17)TERNARY OPERATOR IN C-SHARP PROGRAMMING //Ternary means jo 3 operators ke saath kaam kare, Known as decision making or conditional operator using by ?: these two operators
            //Console.WriteLine("Please Enter your age for voting eligibility !!");
            //int C = int.Parse(Console.ReadLine());
            //string D = (C >= 18) ? "You are eligible to vote" : "You are not eligible to vote";
            //Console.WriteLine(D);

            //(18)PRECEDENCE OF OPERATORS IN C-SHARP //Followed priority of operators using by its compiler in C# Compiler, because C# Compiler followed highest level of priority level followed by these(/,*,-,+)
            int E = 4 / 4 - 4 + 9 * 8;
            // 1 - 4 + 9 * 8
            // 1 - 4 + 72
            // -3 + 72
            // 69
            Console.WriteLine(E);

            ////(19)Selection Construct Or STATEMENT, For DECISION MAKING Statements like If-Else
            //Console.WriteLine("Enter Your User Name !!");
            //string F = Console.ReadLine().ToLower();
            //Console.WriteLine("Enter Your Password..");
            //string G = Console.ReadLine().ToLower();

            //if (F == "gulshan kumar" && G== "gulshan@123")
            //{
            //    Console.WriteLine("Login Successfully !!");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect username and password !!");
            //}

            //(20)IF ELSE IF - DECISION MAKING STATEMENT IN C-SHARP
            //Console.WriteLine("Enter Your Percentage: ");
            //int H = int.Parse(Console.ReadLine());

            //if (H >= 80)
            //{
            //    Console.WriteLine("A Grade");
            //}
            //else if (H >= 70)
            //{
            //    Console.WriteLine("B Grade");
            //}
            //else if (H >= 50)
            //{
            //    Console.WriteLine("C Grade");
            //}
            //else if (H >= 33)
            //{
            //    Console.WriteLine("Pass !!");
            //}
            //else if (H < 33)
            //{
            //    Console.WriteLine("Fail !!");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect Input Entered by You !!");
            //}

            //(21)NESTED IF - DECISION MAKING STATEMENTS IN C-SHARP //In NESTED IF use multiple if statements
            //Console.WriteLine("Enter Your Input Value !!");
            //int I = int.Parse(Console.ReadLine());
            //if (I >= 10)
            //{
            //    if (I == 10)
            //    {
            //        Console.WriteLine("Input value is equal to 10 !!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Input value is not equal to 10 !!");
            //    }
            //}
            //else
            //{
            //    if (I == 3)
            //    {
            //        Console.WriteLine("Input value is equal to 3 !!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Input value is not equal to 3 !!");
            //    }
            //}

            //Console.WriteLine("Enter your email: "); //In this program if correct email entered by user then only user can be enter our password like microsoft account
            //string email = Console.ReadLine().ToLower();

            //if(email == "gulshankumar.mailid@gmail.com")
            //{
            //    Console.WriteLine("Enter Your Password !!");
            //    string password = Console.ReadLine().ToLower();
            //    if(password == "gulshan@123")
            //    {
            //        Console.WriteLine("Login Successfully !!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect Login details !!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Email !!");
            //}

            ////(22)SWITCH CASE IN C-SHARP PROGRAMMING
            ////Switch case we use when we required to compare a single variable with multiple values            
            //Console.WriteLine("Please enter your age !!");
            //int J = int.Parse(Console.ReadLine());
            //switch (J)
            //{
            //    case 15://Multiple switch cases at once place for printing same message depends on multipe switch cases
            //    case 16:
            //    case 17:
            //        Console.WriteLine("You are not eligible to vote...");
            //        break;
            //    case 18:
            //    case 19:
            //    case 20:
            //        Console.WriteLine("your are eligible to vote...");
            //        break;
            //    default:
            //        Console.WriteLine("Your input is not valid !!");
            //        break;
            //}

            ////(23)NESTED SWITCH CASE STATEMENT IN C-SHARP
            //Console.WriteLine("Enter your pizza flavour: ");
            //string K = Console.ReadLine().ToLower();

            //switch (K)
            //{
            //    case "fajita":
            //        Console.WriteLine("You have selected Fajita Pizza !!");
            //        break;
            //    case "supreme":
            //        Console.WriteLine("You have selected Supreme Pizza !!");
            //        break;
            //    case "cheeze":
            //        Console.WriteLine("You have selected Cheeze Pizza !!");
            //        break;
            //    case "vegetable":
            //        Console.WriteLine("Please enter your vegetable name !!");
            //        string L = Console.ReadLine().ToLower();
            //        switch (L)
            //        {
            //            case "onion":
            //                Console.WriteLine("You have selected Onion flavour !!");
            //                break;
            //            case "capcicum":
            //                Console.WriteLine("You have selected Capcicum flavour !!");
            //                break;
            //            default:
            //                Console.WriteLine("You have selected wrong flavour !!");
            //                break;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("You have selected wrong pizza !!");
            //        break;
            //}

            ////(24)CREATING MARKSHEET APPLICATION IN C#
            //Console.WriteLine("Enter your name !!");
            //string M = Console.ReadLine();
            //Console.WriteLine("Enter your rollno. !!");
            //int N = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your class");
            //string O = Console.ReadLine();
            //Console.WriteLine("Enter your english marks !!");
            //int P = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your maths marks !!");
            //int Q = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your economics marks !!");
            //int R = int.Parse(Console.ReadLine());
            //int S = P + Q + R;
            //int T = S * 100 / 300;

            //Console.WriteLine("------ Marksheet ------");
            //Console.WriteLine("Your name is {0}", M);
            //Console.WriteLine("Your rolno is {0}", N);
            //Console.WriteLine("Your class is {0}", O);
            //Console.WriteLine("Your tatal marks is {0}", S);
            //Console.WriteLine("Your percentage is : " + T);

            ////(25)LOOPING STATEMENTS - For loop
            ////While loop, Do While loop, Foreach loop IN C-SHARP
            //Console.WriteLine("Enter a number for multiplication table !!");
            //int V = int.Parse(Console.ReadLine());
            //for(int U = 10; U > 0; U--)
            //{
            //    //Console.WriteLine(V + " X " + U + " = " + V * U);
            //    Console.WriteLine(U);
            //}

            //(26)WHILE LOOP IN C-SHARP
            int W = 1;
            //while (W < 10)
            //{
            //    Console.WriteLine(W);
            //    W++;
            //}

            //(27)DO-WHILE LOOP IN C-SHARP
            do
            {
                Console.WriteLine(W);
                W++;
            }
            while (W < 0);

            //(28)DIFFERENCE BETWEEN FOR AND WHILE LOOP IN C-SHARP
            //We can use for loop initialized variable out of the loop if its declared out of the loop, otherwise not but
            //in while loop we can use because bydefault in while loop initialization out of the loop simple.

            //(29)NESTED FOR LOOP IN C-SHARP
            //Nested means one thing is in another thing(inner loop) simple
            for (int X = 1; X < 3; X++)
            {
                Console.WriteLine("Hello");
                for (int Y = 1; Y <= 3; Y++)
                {
                    Console.WriteLine("Hey");
                }
            }

            //    //(30)JUMP STATEMENTS - BREAK - CONTINUE - GOTO IN C-SHARP
            //    //Jump Statement are used to transfer control from one point in a program to another.
            //    //We have four types of Jump statements there are :- break, continue, goto, return
            //    for (int Z = 0; Z < 10; Z++)
            //    {
            //        if (Z == 5/*Z % 2 == 1*/)
            //        {
            //            //break;//break statement for iteration breaking and goes throw out of the loop
            //            //continue;//continue statement for skipping current iteration
            //            //jump statement is target a perticualr location
            //            goto stop;//here stop is an label, here goto statement is used for jumping on label directly if the condition is matched and skip all statements is any found
            //        }
            //        Console.WriteLine(Z);
            //    }

            //    Console.WriteLine("Loop terminates !!");
            //stop:
            //    Console.WriteLine("Program Exits....");

            //    //(31)RESTARTING/Re-Continue C# PROGRAM WITH USER INPUT
            //    //string confirm;
            //    //int num1, num2, sum;
            //    //do
            //    //{
            //    //    Console.WriteLine("Enter the first number !!");
            //    //    num1 = Convert.ToInt32(Console.ReadLine());
            //    //    Console.WriteLine("Enter the first number !!");
            //    //    num2 = Convert.ToInt32(Console.ReadLine());
            //    //    sum = num1 + num2;
            //    //    Console.WriteLine("Sum of two numbers is: " + sum);
            //    //    Console.WriteLine("Do you want to repeat your program? Yes / No ");
            //    //    confirm = Console.ReadLine().ToLower();
            //    //}
            //    //while (confirm == "yes");

            //    while (true)
            //    {
            //        Console.WriteLine("Enter the first number !!");
            //        int num1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Enter the first number !!");
            //        int num2 = Convert.ToInt32(Console.ReadLine());
            //        int sum = num1 + num2;
            //        Console.WriteLine("Sum of two numbers is: " + sum);
            //        Console.WriteLine("Do you want to repeat your program? Yes / No ");
            //        string confirm = Console.ReadLine().ToLower();
            //        if (confirm == "yes")
            //        {
            //            continue;
            //        }
            //        Console.WriteLine("Out of the Loop..");
            //        Console.ReadLine();
            //    }

            ////(32)ARRAYS IN C-SHARP
            ////An Array is a collection of elements of a single data type storage in adjecence memory locations. <- simple
            ////Is a collection of related values placed in contigouous memory locations and these values are referenced using a common array name.
            ////Using array easily simplifies the task of maintaining these values.
            ////An array always store a single data type.
            ////Array values is known by elements.
            ////These elements is accessed using index numbers or subscripts that determines the positions of elments of array list, subscripts is known by index numbers.
            ////C# supports zero-based index values in an arrray.
            ////Array are referenced type variables whose creation involves two steps: - types of data and identifier
            //int[] int_array = new int[3];
            //int_array[0] = 11;
            //int_array[1] = 22;
            //int_array[2] = 33;
            //Console.WriteLine("Array values there are : " + int_array[1]);

            //string[] string_array1 = new string[] { "Gulshan", "Sahil", "Tarik", "Laxman" };
            //string[] string_array2 = { "Gulshan", "Sahil", "Tarik", "Laxman" };
            //Console.WriteLine(string_array1[0]);
            //Console.WriteLine(string_array2[1]);

            ////(33)ACCESSING ARRAY USING FOREACH LOOP IN CSHARP
            ////for (int ii = 0; ii < int_array.Length; ii++)
            ////{
            ////    Console.WriteLine(int_array[ii]);
            ////}
            //foreach (var item in int_array)
            //{
            //    Console.WriteLine(item);
            //}

            ////(34)(PART-1) TYPES OF ARRAYS - SINGLE AND MULTI-DIMENSIONAL - RECTANGULAR - JAGGED
            ////Dimentional meaning by rows and columns in array
            ////In Multi Dimentional/2D Array we use multiple rows and columns
            ////Diff bet single Dimentional or multi Dimentional array, In single Dimentional array data stored on single index but in multi Dimentional data stored on rows and columns form

            ////- The multidimensional array is also known as rectangular arrays in C#. It can be two dimensional or three dimensional.
            ////The data is stored in tabular form (row * column) which is also known as matrix. To create multidimensional array, we need to use comma inside the square brackets.
            //int[,] arr = new int[3, 4]
            //{
            //    {12, 13, 14, 15},//00, 01, 02, 03(first 0 is here showed row and second 0 is showed column, dimensional is worked as this way here
            //    {22, 29, 27, 29},//10, 11, 12, 13
            //    {23, 95, 39, 37} //20, 21, 22, 23
            //};
            //int[,] arr1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //Console.WriteLine(arr[1,1]);
            //Console.WriteLine(arr.GetLength(1));//for showing first dimension length here
            //Console.WriteLine(arr.Rank);//Rank -> showed how much dimension we have

            //for (int ar1 = 0; ar1 < arr.GetLength(0); ar1++)
            //{
            //    for (int ar2 = 0; ar2 < arr.GetLength(1); ar2++)
            //    {
            //        Console.Write(arr[ar1, ar2] + " ");
            //    }
            //    Console.WriteLine();
            //}


            ////foreach (int item in my_array)//Multi dimentional array showed in single dimentional using foreach loop
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////(35)(PART-2) TYPES OF ARRAYS - SINGLE AND MULTI-DIMENSIONAL - RECTANGULAR - JAGGED
            ////A jagged array is an array whose elements are arrays, possibly of different sizes. A jagged array is sometimes called an "array of arrays."
            ////The following examples show how to declare, initialize, and access jagged arrays.

            ////Jagged Array
            //int[][] my_array1 = new int[3][];
            //my_array1[0] = new[] { 11, 12, 13, 14, 29, 39 };
            //my_array1[1] = new[] { 21, 22, 23, 24, 37 };
            //my_array1[2] = new[] { 31, 32, 33 };
            ////Console.WriteLine(my_array1[0][2]);

            //for (int ar1 = 0; ar1 < my_array1.GetLength(0); ar1++)//exact Jagged array print here using for loop
            //{
            //    for (int jr1 = 0; jr1 < my_array1[ar1].Length; jr1++)
            //    {
            //        Console.Write(my_array1[ar1][jr1] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //foreach (int[] item in my_array1)
            //{
            //    foreach (int item2 in item)
            //    {
            //        Console.Write(item2 + " ");
            //    }
            //}

            ////(36)INITIALIZING OR CREATING ARRAY WITH USER INPUT IN C#
            //Console.WriteLine("Enter your Array Size !!");
            //int num = int.Parse(Console.ReadLine());
            //string[] names = new string[num];

            //for (int arr = 0; arr < num; arr++)
            //{
            //    Console.WriteLine("Enter Data on location " + (arr+1));
            //    string data = Console.ReadLine();
            //    names[arr] = data;
            //}
            //Console.WriteLine("------------------Your Data------------------");
            //foreach (string item in names)
            //{
            //    Console.WriteLine(item);
            //}

            ////(37)( PART-1 ) METHODS OR FUNCTIONS IN C# PROGRAMMING
            //Program pr = new Program();
            //pr.Show();

            //Console.WriteLine("Enter Your First Value !!");
            //int ff = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Your Second Value !!");
            //int ll = int.Parse(Console.ReadLine());
            //Show1(ff, ll);

            ////(38)( PART-2 ) METHODS OR FUNCTIONS IN C# PROGRAMMING
            ////In method we used :- <access modifier/specifier>, <return type>, <method name>, <parameter-list> and <body> of the method
            ////Invoked/Called method called creating by obj called
            ////In ram memory we have two types of memory heap and stack
            ////In methods we create parameters/signatures and call by arguments
            ////signature methods have name of method, brakets and parameter lists
            //Show_Name_Age(age:35, name:"Gulshan");//data set by unposition vise using named arguments

            //Console.WriteLine(Add(10, 30));//these are known as arguments //Here we have returned value catched here by Add method, that's we printed here
            //int xx = Add(96, 78);
            //int yy = 23;
            //int zz = xx + yy;//we can also pass variable as an argument in method parameter like :- string Arg1 = "this is my argument"; -> Display(Arg1);
            //Console.WriteLine(zz);
            ////Advantages of Methods Use:- 
            ////makes program well structured, enhance redability, reuseability, optimize memory space and execution time

            ////(39)CREATING CALCULATOR APPLICATION IN C#
            ////How to create a calculator application
            ////Use Method, decision making statements if else if, conditional operators
            //Addition(8, 2);
            //Subtraction(9, 7);
            //Multiplication(4, 2);
            //Division(8, 2);

            //Console.WriteLine("Enter First Number !!");
            //int first = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number !!");
            //int second = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your operator + , - , * , / !!");
            //char op = char.Parse(Console.ReadLine());
            //if (op.Equals('+'))
            //{
            //    Addition(first, second);
            //}
            //else if (op.Equals('-'))
            //{
            //    Subtraction(first, second);
            //}
            //else if (op.Equals('*'))
            //{
            //    Multiplication(first, second);
            //}
            //else if (op.Equals('/'))
            //{
            //    Division(first, second);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Operator !!");
            //}


            //(40)VALUE TYPE AND REFERENCE TYPE (STACK AND HEAP) IN C# PROGRAMMING
            //Stack memory is very less compatible heap so, when stack is full then default error generate heap overflow
            //struct workes on block, as(जैसे-जैसे) we assign values our struct object, vese-vese object seprated in multiple partitions of blocks and every block represent the assigned value of struct member
            //We have two types of data types in C# Programming Language, first is value type and second one is reference type
            //Struct --Value Type --Stack Memory
            //Class --Reference Type --Heap Memory
            //In Reference Type each object of object type has same reference variable created in stack memory for maching object in heap memory, means same object of every Object simple.

            Employee emp = new Employee();
            emp.Salary = 1;
            emp.Age = 15;
            Employee emp1 = emp; //In struct block to block/object to object values copying is posible like here, every object has different block
            emp.Age = 17; //We can change perticular value on perticular position of perticular block in stack memory, not impact perform on different block of object, this is a draw back of value type in c#
            Console.WriteLine(emp.Age);
            Console.WriteLine(emp1.Age);
            Program prg = new Program(); //Class reference variable(prg) created in stack and object(new Program()) created in heap, and every object have same reference of object and in heap memory created only single memory so, using by heap memory management is done very good
            //So, we prefer heap memory because we required memory management for making a big application simple, if we change only one block of memory them all blocks change automatically simple
            //bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, struct is value type
            //reference type is string, all arrays is reference type but its values are value types, class, object, delegates, interface

            //(41)PASS BY VALUE AND PASS BY REFERENCE (REF AND OUT KEYWORDS) IN C#
            //PASS BY VALUE AND PASS BY REFERENCE Used with methods
            //In Pass by value and pass by reference in c# used ref and out keywords with methods only
            int value = 5;
            PassByValue(value);
            Console.WriteLine(value);

            int values = 5;
            PassByRef(ref values);
            Console.WriteLine(values);
            //Note:- In pass by value only a copy/reference goes to a passing method, so no any link in method and variable in pass by value case
            //Using by pass by reference value is tracked by ref keyword and updated automatically on both sides variable and method
            //In Pass by value and pass by reference only have one memory block is maked in ram and used same memory block for passing the value

            int valuess;
            PassByOut(out valuess);
            Console.WriteLine(valuess);
            //In Pass by Out keyword variable's value is passed by method
            //diff bet ref and out -> no required to assign value to variable in out case but required to assign value to variable in ref case simple

            //(42)VAR AND DYNAMIC KEYWORD IN C#
            //Var is introduced in c# 3.0
            //Var keyword is store any kind of data in its variable
            //Values of var variable is decided at compile time
            //Var variable mendatory to initialize a value othervise generate a compile time error
            //var keyword supported inteligence because its checked on compile time
            //var variable can't be used with prop
            var va = "Gulshan";
            /*va = 5;*/ //same var variable can't be reassign by a different data type, but can be same data type anything can do with it, because all decided on compile time so
            Console.WriteLine(va.ToUpper());
            Console.WriteLine(va.GetType());//GetType method for knowing data type of any variable

            //DYNAMIC KEYWORD
            //Dynamic Was introduced in C# 4.0
            //Dynamic is also used to store any type of data its variable
            //Dynamic value is decided at run time //run time means after compilation, compile window decided the dynamic value
            //Dynamic variable intelligence not showed untill runtime
            //when we want not showed compilation on compile time then we can use this dynamic variable
            //Dynamic can be used with properties and return type with function and with function parameter also
            dynamic dy = "Gulshan";
            dynamic dyy;//Dynamic keyword not mendatory to initialize the value because its checked on runtime so we can assign value after declaration
            dyy = 7;
            Console.WriteLine(dy.GetType());
            /*Console.WriteLine(dy.Gettype());*/ //No error showed on compile time if syntax also wrong in dynamic because simple its checked on run time
            dy = 9;//In dynamic same variable can be reassigned by a different data type is possible
            Console.WriteLine(dy);

            Console.WriteLine(shows(3));//return type dynamic value print here
            Console.WriteLine(shows("Gulshan"));
            Console.WriteLine(shows(true));
            //var vs dynamic :- var is the value type and dynamic is the dynamic type so, var can't be changeable but dynamic can simple

            //(43)CLASSES AND OBJECTS IN C# PROGRAMMING
            Student std = new Student();//object/instance
            Console.WriteLine(std.name);
            Console.WriteLine(std.age);

            //(44)WHAT IS CONSTRUCTOR IN C# PROGRAMMING
            // A constructor is a special method of the class which gets automatically invoked whenever an instance of the class is created.
            // Like methods, a constructor also contains the collection of instructions that are executed at the time of Object creation.
            // It is used to assign initial values to the data members of the same class.

            // Note: In the default constructor, all the numeric fields are initialized to 0, whereas string and object are initialized as null.
            // Note: If a constructor is private, we cannot create objects of the class. Hence, all fields
            // and methods of the class should be declared static, so that they can be accessed using the class name.

            // Here, we are calling the Car() constructor.You can see that the static constructor is also called along with the regular constructor.
            // In C#, we can create two or more constructor in a class. It is known as constructor overloading.
            Program prog = new Program();
            new Program(4, 5);
            Program po = new Program("Gulshan");
            Program co = new Program(po);//Object to object value copy here
            Console.WriteLine(co.nam);

            //(45)CONSTRUCTOR OVERLOADING IN C# PROGRAMMING
            ConstructorOverloading cov1 = new ConstructorOverloading();
            ConstructorOverloading cov2 = new ConstructorOverloading(40);
            ConstructorOverloading cov3 = new ConstructorOverloading(10, 18);
            ConstructorOverloading cov4 = new ConstructorOverloading(13, 14, 17);
            ConstructorOverloading cov5 = new ConstructorOverloading("A", "B", "C");


            //(46)STATIC AND INSTANCE MEMBERS OF CLASS IN C#
            StaticStudent st = new StaticStudent();
            Console.WriteLine("my rollno is {0} ", st.roll = 56);
            st.firstname = "Gulshan";
            st.lastname = "Kumar";
            st.printFullName();
            Console.WriteLine(StaticStudent.schoolName);
            Console.WriteLine(StaticStudent.getFees());//return value is always goes to same member of class where return, only required to print it only like here method print then value printed supporting by method

            //(47)STATIC CONSTRUCTOR IN C#
            //Static Constructor only once call, you can't call it by making multiple objects of class, but instance constructor run multiple times with every objects
            //Static constructor is called before instance constructor
            //Static Constructor does'nt take any parameter and does not use any access modifiers

            //Key Points:- 
            //Only one static constructor can be created in the class
            //Static constructor we can't to call it CLR/Compiler automatically call it before first object of instance member

            Person pp = new Person();
            Person pr = new Person();//Static run only once and default runs twice

            //(48)COPY CONSTRUCTOR IN C#
            //Copy Constructor basic use is copy a object to in a another object simple

            ConstructorClass ctor = new ConstructorClass("Gulshan", 35);//Class object initializing with Constructor calling here simple
            ctor.GetData();
            ConstructorClass ctor1 = new ConstructorClass(ctor);//Here Copy Constructor, copy object data to object to object simple in ctor1
            ctor1.GetData();

            //(49)PRIVATE CONSTRUCTOR IN C#
            //ConstructorPrivate cp = new ConstructorPrivate();//Private Constructor can't be accessible by its protection level error message
            //Private Constructor usually used for using static members only
            //Private access specifier can't be accessible in another class so, private constructor also not accessible outside of the class
            //We can have parameters in private constructor. Yes
            ConstructorPrivate.getTime();

            //Default Constructor In C#
            //We Can't create the same member like constructor/methods if signatures are same like public Program(){}, no any Difference of access specifier are different
            ConstructorDefault cd = new ConstructorDefault();
            Console.WriteLine("My default Constructor Value Name is : {0}", cd.Name);
            Console.WriteLine("My default Constructor Value Age is : {0}", cd.age);

            //(50)STATIC CLASS IN C# PROGRAMMING
            //Product prd = new Product();//Can not create a instance of a static class
            Product.GetProductDetails();

            //(51)DESTRUCTORS IN C# PROGRAMMING
            //A destructor is a special method which has tha same name as tha class but start with the character ~ before the class name
            //and immediately de-allocates memory of objects that are no longer required.
            //Destructor can't be inherited and overloaded and explicitly invoked
            //Destructor can't specify access modifiers and cannot take parameters
            person per = new person();
            per.GetName();

            //(52,53)TYPES OF INHERITANCE - SINGLE - HIERARCHICAL - MULTILEVEL AND MULTIPLE IN C#
            //Inheritence is depended on features inheriting using drivation of base/parent class
            BaseClass bs = new BaseClass();
            bs.Show1();
            DrivedClass3 dc3 = new DrivedClass3();
            dc3.Show1();

            ////(54)CONSTRUCTOR IN INHERTANCE IN C# PROGRAMMING
            //Derived dr = new Derived();

            //(55)( PART-1 ) ACCESS SPECIFIERS - PUBLIC - PRIVATE - PROTECTED - INTERNAL IN C#
            Class1 c1 = new Class1();
            c1.Show1();

            //(56)(PART-2 ) ACCESS SPECIFIERS - PUBLIC - PRIVATE - PROTECTED - INTERNAL IN C#
            Class3 c3 = new Class3();
            //c3.Show1();//This is private access specifier only accessible in same class only, Inheritence also not supported            
            //Internal Access Specifier accessed only in same assambly only


            //(57)ENCAPSULATION IN C#
            //Encapsulation Defination :- Encapsulation in C# is achieved by taking advantage of the access modifiers that include public, private protected, private, internal, and protected that control their visibility and accessibility of the members of a class.
            //Encapsulation is one of the four fundamental oops concepts. The other three are inheritence, polymorphism, and abstraction.
            //Encapsulation in C# is a mechanism of wrapping the data(variables) and code acting on the data (methods or properties) together as a single unit.
            //In encapsulation, the variables of a class will be hidden from other classes, and can be accessed only through the methods of properties of their current class. Therefore, it is also known as data hiding.
            //Encapsulation Proper defination is :- Encapsulation retrive from by capsule when we wrap variable data and methods together in a single class then this concept is called Encapsulation simple
            //The need of Encapsulation is to protect or prevent the code(data) from accidental corruption due to the silly little errors that we are all prone to make using properties and methods.
            Encapsulation enc = new Encapsulation();
            enc.SetName("Gulshan");
            enc.GetName();
            enc.Age = 28;
            Console.WriteLine("Age : " + enc.Age);

            //(58)PROPERTIES WITH GET AND SET IN C#
            //Properties allow you to control the accessibility of a class variables, and are the recomended way to access variables from the outside in c#. 
            //A Property is much like a combination of a variable and a method - It can't take any parameters, But you are able to process the value before it's assigned to our retured.
            //Properties is the replacement of setter and getter methods
            //Properties are like data firlds (variables), but have logic behind them.
            //from the outside, they look like other member variable, but they act like a member function.
            //defined like a field, with "Get" and "Set" Accessors code added.
            //Properties are also used for Encapsulation.
            //Types of prperties in C# -> read/Write, Read Only, Write Only, Auto Implemented Properties., write property is very less usable
            Students sts = new Students("Gulshan");//now on creation of object require value to contructor here because constructor called creation of class instance so required to provide value to parameterize constructor
            sts.StdId = 1;
            sts.Name = "Gulshan";
            Console.WriteLine("My Name is : " + sts.Name);
            Console.WriteLine("My TOtal Subject Marks is : " + sts.SubjectTotalMarks);
            //sts.FirstName = "Gulshan"; //Here Auto Implemented Property set private and get public
            Console.WriteLine("My first Name is : " + sts.FirstName);

            //(59)STATIC PROPERTIES IN C#
            //Static Property is used/worked only for static variables for setting and getting data in it simple.
            University._universityName = "IGNOU";
            Console.WriteLine("My University Name is : " + University._universityName);

            //(60)POLYMORPHISM AND METHOD OVERLOADING IN C#
            //Polymorphism is one of the four pillars of Object Oriented Programming.
            //Polymorphism in C# is a concept by which we can perform a single action by different ways.(means ek kam ko different tarikon se karna)
            //Polymorphism is drived from 2 Geeks words : poly and Morphs. The word "poly" means many and "morphs" means forms.
            //so polymorphism means many forms.
            //Real World Example :- A man perform multiple roles on different places like Father, Son, Husband, Teacher etc.
            //There are two types of polymorphism

            //Static polymorphism(compile time) and Dynamic polymorphism(Run time) polymorphism
            //Static polymorphism:-
            //The mechanism of linking a function with an object during compile time is called static polymorphism or early binding., early binding because this process is done program run hone se phele, it is also called static binding.
            //C# provides two techniques to implement static polymorphism. They are - Method or Function Overloading, Operator Overloading
            //Method or Function Overloading:-
            //You can have multiple definations for the same function name in the same scope(Class).
            //The defination of the function must differ from each other by the types and/or the number of arguments in the argument list.

            MethodOverloading mo = new MethodOverloading();
            mo.Add();//Called here different methods by help of different arguments
            mo.Add(50, 80);
            mo.Add("Gulshan", "Kumar");

            //(61)OPERATOR OVERLOADING IN C#
            //In Operator overloading make sure both objects are same of the class for performing Operator overloading.
            OperatorOverloading oo1 = new OperatorOverloading();//This object is store in Operator Overloading function parameter 1 and second one in parameter two and all operation performed bari bari that we declared in Operator Overloading Function simple
            oo1.str = "Gulshan";
            oo1.num = 20;
            oo1.pointnum = 89.90f;

            OperatorOverloading oo2 = new OperatorOverloading();
            oo2.str = "Kumar";
            oo2.num = 50;
            oo2.pointnum = 11.10f;

            OperatorOverloading oo3 = new OperatorOverloading();
            oo3 = oo1 + oo2; //operator(+) cannot be applied on operands without using function in Operator Overloading simple
            Console.WriteLine(oo3.str);//Here we use perticular type of data type for performing operation on perticular data type for a result using Operator Overloading simple
            Console.WriteLine(oo3.num);
            Console.WriteLine(oo3.pointnum);

            //(62)METHOD HIDING IN INHERITANCE IN C#
            Child child = new Child();
            child.Show();//Here Child class method is hiding method of parent class this process is called method hiding
            ((Parent)child).Show();
            Parent parent = new Child();//Here child class object is goes there in parent class reference variable for calling parent class member using child class object, simply for hidding child class members by doing this, this is possible only because child class is produced by parent so, we can put child class object in parent class reference variable, because when we create the object of child class parent class object alse created simply
            parent.Show();

            //(63)METHOD OVERRIDING(RUN TIME POLYMORPHISM) IN C#
            parent par = new child();
            par.Show();

            //(67)INDEXERS IN C# PROGRAMMING
            IndexerClass ic = new IndexerClass();
            ic[2] = 5;//indexer this keyword is replaced by object name here simple
            Console.WriteLine(ic[2]);

            //(68,69,70)DELEGATES/SINGLE CAST DELEGATES/MULTIPLE DELEGATES IN C# PROGRAMMING
            //We can use += and -= assignment operators to implement multi cast delegate
            Calculation dc1 = new Calculation(DelegateClass.Addition);
            dc1(45, 25);

            DelegateClass.Addition(45, 75);

            Calculation dc = new Calculation(Subtraction);//In Delegate we can directly call private members of the class Addition etc without static keyword
            dc.Invoke(85, 65);//We Can use Invoke method with delegate            

            ShowDelegate sd = new ShowDelegate(DelegateClass.Show);
            sd.Invoke();

            Calculation d1 = new Calculation(Addition);//Multiple Delegates example
            d1.Invoke(40, 30);
            Calculation d2 = new Calculation(Subtraction);
            d2.Invoke(40, 30);

            dc = Subtraction;//this is multicast delegate means using single Delegate object calling multiple methods
            dc += Addition;//this is also multicast delegate performed by assignment operators, means single invoked worked on all methods by assignment operators using simple
            dc += Subtraction;
            dc -= Subtraction;//-= assignment operators for perticular method chodkar sare methods automatically call karna simple
            dc.Invoke(12, 8);

            //(72)ANONYMOUS FUNCTION -ANONYMOUS METHOD IN C# 
            MyDelegate dl = delegate (int aa) //that is a Anonymous function
            {
                aa += 10;
                return aa;
            };

            Console.WriteLine(dl(5));

            AnonymousClass.MyMethod(delegate (int bb) { bb += 10; Console.WriteLine(bb); }, 5);

            //(73)LAMBDA EXPRESSION IN C#
            Delegate de = (an) =>//Lambda expression left side data (an) called input/parameter, and on right side we can write expressions or statements, expressions in without curly bracess and in single line
            {//This is statement lambda
                an += 5;
                return an;
            };
            Console.WriteLine(de(7));

            Delegate dd = (an) => an * an;//This is a expression lambda
            int af = dd(8);
            Console.WriteLine(af);

            //(74)ABSTRACTION IN C# PROGRAMMING
            AbstractClass ac = new AbstractClass(28000);
            ac.ShowEmployeeDetails();

            //(75)ABSTRACT CLASS AND ABSTRACT METHOD WITH PRACTICAL EXAMPLE IN C#
            student stu = new student();
            stu.name = "Gulshan";
            stu.phoneno = "08178204873";
            stu.rollno = 1;
            stu.fees = 5000;
            stu.PrintDetails();

            Console.WriteLine("-----------------------------------");

            teacher te = new teacher();
            te.name = "Radika";
            te.phoneno = "0123456789";
            te.qualification = "Master in computer science";
            te.salary = 50000;
            te.PrintDetails();

            //(76)ABSTRACT PROPERTIES IN C#
            studentt stt = new studentt();
            Console.WriteLine(stt.Id = 0);
            Console.WriteLine(stt.Name = "Gulshan");

            //(77)INTERFACES IN C# PROGRAMMING
            PartTimeEmployees pt = new PartTimeEmployees();
            pt.Show();

            //(78)INTERFACE INHERITANCE/INTERFACE INHERITANCE CHAIN IN C# PROGRAMMING
            InterfaceImp ii = new InterfaceImp();
            ii.Print();
            ii.Print1();
            I2 myi = new InterfaceImp();//Parent Interface ke reference variable me ham child class ka object rakh sakte hain, but can't create object of interface

            //(79)EXPLICIT IMPLEMENTATION OF INTERFACE IN C#
            InterfaceClass icl = new InterfaceClass();
            icl.Show();
            ((i2)icl).Show();//child class object casting required for calling embiguity member(method) of interfaces by converting child class object in interface reference variable simple //OR

            i2 i2 = new InterfaceClass();
            i2.Show();

            //(82)MULTIPLE INHERITANCE IN C# - WHAT IS MULTIPLE INHERITANCE - C#
            Teacher tt = new Teacher();
            tt.Show();

            Employye ee = new Teacher();
            ee.Show();

            Employye1 e1 = new Teacher();
            e1.Show();

            //(83)GENERICS AND GENERIC METHOD IN C#
            int[] Numbers = new int[3];
            Numbers[0] = 11;
            Numbers[1] = 22;
            Numbers[2] = 33;
            string[] Names = { "Gulshan", "Ankit", "Sahil", "Depak", "Mahesh" };
            double[] Points = { 2.3, 4.6, 2, 7 };

            Generic.ShowArray(Numbers);
            Generic.ShowArray(Names);
            Generic.ShowArray(Points);

            Console.WriteLine(Generic.Check(10, 20));
            Console.WriteLine(Generic.Check("Gulshan", "Gulshan"));//etc

            Generic.Check("Gulshan");
            Generic.Check(45);

            //(84)GENERIC CLASS IN C# PROGRAMMING
            //GenericClass<int> gc = new GenericClass<int>(20);//on intialization time of generic object required to narrate(बताना) about the data type, for which narrate data type with work by this class object so
            //GenericClass<string> gc1 = new GenericClass<string>("Gulshan");//etc
            //Console.WriteLine(gc.getbox());
            //Console.WriteLine(gc1.getbox());

            //For working with property Constructor required to comment because of embiguity between both of them on set and get time of value in same member of class
            GenericClass<int> gg = new GenericClass<int>();//Constructor se nahi ab property se value set get ho rahi hai isliye ab bracket() empty hai//GenericClass<> <- this is the sign of Generic Class
            Console.WriteLine(gg.Box = 57);

            //(85)COLLECTIONS WITH ARRAY VS ARRAY LIST COLLECTION CLASS IN C#(COLLECTIONS AND ARRAY LIST IN C#)
            //A collection is a set of related(different) data type that can be set or modified dynamically at run-time. but array store only same data.
            //In other words, collection is a dynamic array. its length can increase on runtime.
            //- Difference between Array and Collection
            //An array in C# is a fixed-size collection of elements. whereas an ArrayList is a dynamic, resizable collection of elements.
            //Array's variables are homogeneous elements(same data type) type. But collections elements are non homogeneous elements(different data types).
            //- We have two types of collections in C# :- Non-Generic(Collections) and Generic(Collection)
            //Non-Generic collections -> Stack, ArrayList, Hashtable, SortedList etc., exist in System.Collections namespace.
            //Generic collections -> List<T>, LinkedList<T>, Queue<T>, SortedList<T<V>, exist in System.Collections.Generic namespace.

            //In Collection Auto resizing machanism is works on doubling the size of collection like 4,8,16 infinity
            int[] MyArray = new int[3];
            MyArray[0] = 10;
            MyArray[1] = 20;
            MyArray[2] = 30;
            //MyArray[3] = 40;//Here generate an error index out of range exception

            Array.Resize(ref MyArray, 4);//Here our Resize method of Array class making a new array by same name of old array with destroying old one, on same location of old array with increasing length of array
            MyArray[3] = 40;//Now we can store a new value in this array

            ArrayList MyList = new ArrayList(1);//In collection we can provide a imagination starting and stopping size both of them to Collection type(ArrayList) like 1 that can be change on runtime no issue only this is our imagination only that's can be helping in stopping the size of collection from doubling after reached on imagination size, after reaching on imagination size of collection(ArrayList) update the size by double on runtime simple
            Console.WriteLine(MyList.Capacity);//Capacity property tells the number of items can be store under any collection
            MyList.Add(20);//ArrayList Add function store object type data so, we can store any kind of data in ArrayList's object
            MyList.Add("Gulshan");
            Console.WriteLine(MyList.Capacity);

            MyList.Insert(1, 25);//We can also add/delete element middel of the collection(ArrayList)
            MyList.Remove(25);//Remove works direct with value
            MyList.RemoveAt(1);//RemoveAt works with index number

            foreach (object obj in MyList)
            {
                Console.Write(obj + " ");
            }

            //(86, 87)( PART-1 ) and (PART-2 ) HASH-TABLE COLLECTION IN C#
            //HashTable stores data in own object in key/value formate.
            //Array and ArrayList also store data in key/value formate, index number[Key] on every Key storing a value
            //- Difference in Array or ArrayList and HashTable is:-
            //In Array or ArrayList keys are pre-defined i-e index numbers, it means you cannot explicitly define keys in Array or ArrayList.
            //In HashTable, keys are not pre-defines it means you can explicitly define user-defined keys in HashTable, that means any type of key can be define by user like string(Id, Name etc), float etc., depended on user.
            //object data type is the parent of all existing(jitni bhi) classes in C#

            //Hashtable ht = new Hashtable();//we have two Syntax for storing data in HashTable Collection
            //ht.Add("Id", 1222);
            Hashtable ht = new Hashtable
            {
                { "Id", 1123 },//both key and value is of object type so we can define both any data of type like this
                { "Name", "Gulshan" },
                { "Salary", 25000.00 },
                { "Designation", "Developer" },
                { "IsMarried", false }
            };

            Console.WriteLine(ht["Id"]);


            Console.WriteLine("----------- (PART-2 ) -----------");
            //Methods:- Add, Remove, Clear, Contains/ContainsKey, ContainsValue, GetHashCode
            ht.Remove("Salary");//Remove method removes the specific key from the hashtable.
                                //ht.Clear();//Clear method removes all the items from the hashtable.
                                //Console.WriteLine(ht.ContainsKey("Name"));//Contains/ConntainsKey Determines whether the hashtable contains a specific key by bool value., this methods we often(अक्सर) use within if conditions for doing perticular work
                                //Console.WriteLine(ht.ContainsValue(25000.0));//ContainsValue Determines(finding) only values in hashtable
                                //HashCode :- Hash tables used Hashing algorithm to generate hash codes for every key/value and because of these hash codes hash tables are faster than Array and ArrayList, hashtable using by hashcode searched hashtable's elements(value/key). because of hashcode on retriving data time random data retrieved.
                                //Console.WriteLine("Gulshan".GetHashCode());

            foreach (object key in ht.Keys)//object val in ht.Values)//ht properties
            {
                //Console.WriteLine(ht[key]);
                //Console.WriteLine(val);
                Console.WriteLine(key + ": " + ht[key]);//data print here with Key and Value pair
            }
            Console.WriteLine("-------------------------");
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + ": " + ht[key]);
            }

            //Properties:- Count, Keys, Values //Keys and Values properties already used in foreach loop
            Console.WriteLine(ht.Count);

            //(88)STACK ( NON-GENERIC COLLECTION) IN C#
            //Stack works on LIFO(Last In First Out) <- means jo element sabse last me insert kia gaya tha usko sabse phele nikala jaega
            //Stack allows null value and duplicate values.
            //Stack Properties and Methods :-
            //Count:- Returns the total count of elements from the Stack.
            //Push:- Insert an item at the top of the stack.
            //Peek:- Returns the top item from the stack.
            //Pop:- Removes and returns items from the top of the stack.
            //Contains:- Checks whether an item exists in the stack or not.
            //Clear:- Removes all items from the stack.

            Stack sta = new Stack();
            sta.Push("Gulshan");
            sta.Push(27);
            sta.Push(null);
            sta.Push(27);

            foreach (object item in sta)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(sta.Count);
            Console.WriteLine(sta.Peek());
            Console.WriteLine(sta.Pop());
            //sta.Clear();
            foreach (object item in sta)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(sta.Contains("Gulshn"));

            //(89)QUEUE ( NON-GENERIC COLLECTION) IN C#
            //Queue meaning: a line or a sequence of people or vehicles.
            //Queue works on FIFO(First In First Out) < means jo element sabse phele store hoga wahi sabse phele retrieve hoga
            //Queue also allow multiple null and duplicate values.
            //Properties and Methods of Queue
            //Count, Enqueue, Dequeue, Peek, Contains, Clear
            //Enqueue() method to add item and the Dequeue() method to removes/retreive and returns the item.
            //Peek:- Returns first item from the queue.

            Queue que = new Queue();
            que.Enqueue("Gulshan");
            que.Enqueue(27);

            foreach (object item in que)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(que.Peek());
            Console.WriteLine(que.Contains("Gulshan"));
            que.Dequeue();
            //que.Clear();

            foreach (object item in que)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(que.Count);

            while (que.Count > 0) //Queue with while example
            {
                Console.WriteLine(que.Dequeue());
            }
            Console.WriteLine(que.Count);

            //(90)DIFFERENCE BETWEEN NON-GENERIC AND GENERIC COLLECTIONS IN C#
            //non-generic collections are Not Type Safe and Auto Resizing.
            //generic collections are Type Safe and Variable length(Auto Resizing).
            //non-generic holds elements as object type. So it includes overhead of type conversions.(means using boxing(value(data type(int,float etc.)) type to object(reference type)) and unboxing(object type to value)), this conversion is not good for performance
            //Variables of objects(reference types) store references to their data, while variables of value types directly contain their data.
            //generic collections reduced overhead of type conversions.
            //non-generic collections also called loosely typed.
            //generic collections also called Strongly typed.
            //non-generic collections Not type Safe.
            //generic collections Type Safe.
            //non-generic collections are Not Secure.
            //generic collections are Secure.
            //Generic Collection Known by <> Angle brackets where we specify placeholder(data type)

            //List<int> num = new List<int>();//two ways storing data in Generic List
            //num.Add(22);
            List<int> num = new List<int>
            {
                22,33,99
            };

            //(91)( PART-1 ) LIST GENERIC COLLECTION IN C#
            //List elements is accessed by its index numbers like mynum[1]
            //Predicate means in Generic Collection methods we passed conditions through lambda expression

            List<int> mynum = new List<int>
            {
                11,12
            };

            Console.WriteLine(mynum.Capacity);
            foreach (int item in mynum)
            {
                Console.WriteLine(item);
            }

            ClassList cl1 = new ClassList()
            {
                Name = "Gulshan",
                Age = 27
            };

            ClassList cl5 = new ClassList()
            {
                Name = "Shivam",
                Age = 24
            };

            ClassList cl2 = new ClassList()
            {
                Name = "Rishab",
                Age = 18
            };

            List<ClassList> cl = new List<ClassList>()//Making Complex List Collection by using Class with List
            {
                cl1,
                cl2,
                cl5
            };

            ClassList cl3 = cl.Find(cll => cll.Age > 18);//Searches for an element that matches the condition defined by the specified predicate, and returns the first occurrence within the entire List<T>.
            Console.WriteLine("Class Last Name is: {0}, Age is: {1}", cl3.Name, cl3.Age);
            ClassList cl4 = cl.FindLast(cll => cll.Age > 18);//FindLast method Searches and return an element that matches the last occurrence within the entire List<T>
            Console.WriteLine("Class Last Name is: {0}, Age is: {1}", cl4.Name, cl4.Age);
            List<ClassList> cl6 = cl.FindAll(cll => cll.Age > 18);//Retrives all the elements that matched the conditions defined by the specified predicate.
            foreach (ClassList item in cl6)
            {
                Console.WriteLine("Class Last Name is: {0}, Age is: {1}", item.Name, item.Age);//FindLast method Searches and return an element that matches the last occurrence within the entire List<T>
            }
            Console.WriteLine(cl.FindIndex(cll => cll.Age > 18));//FindIndex method using predicate returns first occurrence value index number
            Console.WriteLine(cl.FindLastIndex(cll => cll.Age > 18));//FindLastIndex method using predicate returns last occurrence value index number

            ClassList[] cls = cl.ToArray();//ToArray method for conversion List in simple Array
            List<ClassList> cls1 = cl.ToList();//ToList method for conversion Array in List

            Console.WriteLine(cl.Exists(cll => cll.Name.StartsWith("R")));//For string value knowing exist or not by bool value
            //cl.RemoveAll(cll => cll.Age > 20);//RemoveAll method works with lambda expression with condition

            //foreach (ClassList cls in cl)
            //{
            //    Console.WriteLine("List Class Name is {0}, Age is {1}", cls.Name, cls.Age);
            //}


            //(92, 93)( PART-2 ) LIST GENERIC COLLECTION IN C#
            //List methods Add, AddRange, Insert, InsertRange, Remove, RemoveAt, RemoveRange,RemoveAll, Reverse, sort, IndexOf, LastIndexOf, Contains, Exists, Clear, Find, FindLast, FindAll, FindIndex, FindLastIndex, ToArray, ToList
            //List class also provides methods to search, sort and manipulate lists.
            //List Properties Capacity, Count            

            List<int> myN = new List<int>
            {
                33,11,44
            };

            myN.Sort();//Sort method for sorting elements in assending order
            myN.AddRange(myN);//AddRange method is used for adding extra range of collection element in default List Collection
            myN.Insert(1, 10);//Insert method is used for adding an element on specific index number.
            myN.InsertRange(2, myN);//InsertRange method is used for adding range of collection element on specific index number.            
            myN.Remove(11);//Remove method remove element directly, first element milte hi
            myN.RemoveAt(3);//RemoveAt method remove element of specific index location
            myN.RemoveRange(2, 5);//RemoveRange method remove multiple elements of specific index location, from start and end index location
            myN.Reverse();//For List order Reversing
            Console.WriteLine(myN.IndexOf(11, 3));//IndexOf method returns the index number of first occurrence value of List<T>, for finding other occurrence value of List<T> provide a starting point of index number[3]
            Console.WriteLine(myN.LastIndexOf(11, 3));//Returns the zero-base index of the last occurrence of a value in the List<T>, with starting point of index number[3].
            myN.Clear();

            foreach (var item in myN)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myN.Contains(40));//For int value knowing exist or not
            Console.WriteLine(cl.Exists(cll => cll.Name.StartsWith("G")));//Worked simply

            //(94)( PART-1 ) DICTIONARY GENERIC COLLECTION IN C#
            //Now we want to create a collection in which we don't want to access elements through index.
            //We want to store data in key value format where keys are user-defined.
            //We want to insert same type of data in a collection.
            Dictionary<string, string> myDict = new Dictionary<string, string>
            {
                { "active", "engaging or ready to engage in physically energetic pursuits." },
                { "amazing", "causing great surprise or wonder; astonishing." },
                { "honest", "free of deceit; truthful and sincere." },
                { "patriotic", "having or expressing devotion to and vigorous support for one's country." },
                { "quarantine", "place of isolation" }
            };

            Console.WriteLine(myDict["active"]);
            foreach (KeyValuePair<string, string> item in myDict)//Var//Recomended is KeyValuePair
            {
                Console.WriteLine("Key is: " + item.Key + " Value is: " + item.Value);
            }

            foreach (string key in myDict.Keys)//Only Keys
            {
                Console.WriteLine(key);
            }

            foreach (string val in myDict.Values)//Only Values
            {
                Console.WriteLine(val);
            }

            Dictionary<int, string> myDict2 = new Dictionary<int, string>//Dictionary with more than one data types here
            {
                { 1, "Gulshan" },
                { 2, "Sahil" }
            };

            foreach (KeyValuePair<int, string> ite in myDict2)
            {
                Console.WriteLine(ite.Key + " " + ite.Value);
            }

            //(95)( PART-1 ) DICTIONARY GENERIC COLLECTION IN C#
            //Properties of Dictionary :- Count, Keys, Values
            //Methods of Dictionary :- Add, Remove, TryGetValue
            //In Dictionary, the key cannot be null, but value can be;
            //Dictionary duplicate keys are not supported
            Console.WriteLine(myDict.Count());

            ClassDictionary cld = new ClassDictionary();
            cld.Id = 111;
            cld.Name = "Gulshan";
            cld.Designation = "DotNet Developer";
            cld.Salary = 5000;
            ClassDictionary cld1 = new ClassDictionary();
            cld.Id = 222;
            cld1.Name = "Laxman";
            cld1.Designation = "DotNet Developer";
            cld1.Salary = 15000;

            Dictionary<int, ClassDictionary> cd1 = new Dictionary<int, ClassDictionary>
            {
                { cld.Id, cld },
                { cld1.Id, cld1 }
            };

            Console.WriteLine(cd1.Count(cll => cll.Value.Salary > 4000));
            Console.WriteLine(cd1.Count(cll => cll.Value.Name.StartsWith("G")));
            Console.WriteLine(myDict.ContainsKey("quarantine"));
            Console.WriteLine(myDict.ContainsValue("place of isolation"));
            myDict.Remove("quarantine");
            //myDict.Clear();
            foreach (KeyValuePair<string, string> item in myDict)
            {
                Console.WriteLine("Key is: " + item.Key + " Value is: " + item.Value);
            }
            string Value;
            myDict.TryGetValue("honest", out Value);//TryGetValue method work with key if key found then return the value by storing in a variable, so declared Value variable for storing out parameter value
            Console.WriteLine(Value);
            //myDict.Add(null, "Gulahan");//Generate Runtime exception
            myDict.Add("D", null);

            //(96)EXCEPTION AND EXCEPTION HANDLING IN C#
            //Exception are abnormal events that prevent a certain task from being compleated successfully.
            //A C# exception is a problem to an exceptional cicumstance that arises while a program is running, such as an attempt to divide by zero.
            //Different types of exceptions handeling by default diffent types of classes like DivideByZeroException provided by C# Default Catch machanism for handeling this exceptions, like divided by zero exception., All exception classes belongs to System namespace.
            //Note:- C# default exception handeling sw hamari agli statements execute nahi hoti or programme terminate ho jata hai isliye ham khud se exceptions handel karte hain taki program crash na ho jae
            //The exception handling in C# is one of the powerful mechanism to handle the runtime errors so that normal flow of the application can be maintained.
            //-When an exception occur 3 things happen.
            //Program teriminates or program crashes.
            //Ugly kind of error message is displayed that user can never ever understand.
            //Statements after exception will not be executed.
            //-C# Default Exception Handling Classes Hierarical :- Object -> Exception
            //Exception :- System Exception, Application Exception
            //System Exception :- ExternalException, ComException
            //System Exception :- AggregateException, ArgumentException, DividedByZeroException, NullReferenceException, OverflowException
            //ArgumentException :- ArgumentNullException, ArgumentOutOfRangeException

            //Console.WriteLine("Enter first number !!");
            //int nu = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number !!");
            //int nu1 = Convert.ToInt32(Console.ReadLine());

            //try//Jis code/line me hamein lagta hai exception aa sakti hai sirf us code ko ham try block me likhta hain
            //{
            //    int div = nu / nu1;
            //    Console.WriteLine("Division result is: {0}", div);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divide a number by zero...");//this is a user friendly exception
            //    Console.WriteLine(ex.Message);//Default message of DivideByZeroException class using its message property
            //}

            //Console.WriteLine("Remaining statement 1");
            //Console.WriteLine("Remaining statement 2");

            //(97)HANDLING INDEX OUT OF RANGE EXCEPTION IN CSHARP
            int[] arr = new int[2];
            try
            {
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
                foreach (int item in arr)//foreach loop hamne try block me isliye rakha takki exception aate hi catch block execute ho jae or foreach loop na chal pae kunki try me error ate hi C# catch block par kud jata hai jisse foreach loop execute nahi ho paega
                {
                    Console.WriteLine(item);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array's range is exceeded..");
                Console.WriteLine(ex.Message);
            }

            //(98)HANDLING NULL REFERENCE EXCEPTION IN C#
            try
            {
                string name = null;
                // Console.WriteLine(name.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("String is null...");
                Console.WriteLine(ex.Message);
            }

            ////(99)HANDLING FORMAT EXCEPTION IN C#
            //Console.WriteLine("Enter a number: ");
            //string number = Console.ReadLine(); 

            //try
            //{
            //    int nu = int.Parse(number);
            //    Console.WriteLine("Number is: " + nu);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("String Format is Invalid...");
            //    Console.WriteLine(ex.Message);
            //}

            //(100)EXCEPTION CLASS AND ITS USE IN C#
            //Exception class is a parent class of all exception classes, so this class can be handel all types of exceptions using by this single Exception Class
            try
            {
                //string aa = null;
                //Console.WriteLine(aa.Length);

                //int[] ar = new int[2];
                //ar[0] = 1;
                //ar[1] = 2;
                //ar[2] = 3;

                string na = "Gulshan";
                int pa = int.Parse(na);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //(101)TRY WITH MULTIPLE CATCH BLOCKS IN C#
            //At a time only one exception is occurred and at a time only one catch block is executed.

            try
            {
                //int n1 = 10;
                //int n2 = 0;
                //int n3 = n1 / n2;

                //string na = null;
                //Console.WriteLine(na.Length);

                int[] ar = new int[2];
                ar[0] = 1;
                ar[2] = 2;
                ar[3] = 3;

            }
            //catch (Exception ex)//All catch blocks must be ordered from most specific to most general. <- means parent class on top and child after parent class
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //(102)FINALLY BLOCK WITH TRY CATCH IN C#
            //C# finally block is always executed whether exception is occured or not/handled or not.
            //C# finally block is a block that is used to execute important code such as closing connection, stream etc.
            //C# finally block follows try or try catch block. try only can be single but catch can be multiple.
            //Note:- If you don't handle exception, before terminating the program, C# executes finally block(if any).
            //-Why use finally block in C#
            //Finally block in C# can be used to put "cleanup" code such as closing a file, closing connection etc., cleanup code means is execution of finally block before termination of program
            //Finally block also only one in C# like try block

            try
            {
                int n1 = 10;
                int n2 = 0;
                int n3 = n1 / n2;
                Console.WriteLine(n3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block Executed..");
            }

            //(103)THROW KEYWORD AND WAYS OF EXCEPTION IN C#
            //Default throw and Default Catch
            //Default throw and Our Catch
            //Our throw and Default Catch//throw keyword for generating exception own
            //Our throw and Our Catch
            //-Why should we throw an exception object
            //Because we want to set a different message.
            //Because C# Cannot recognize exceptional situation of buisness logic. <- means jab C# khud se exceptions throw nahi karata hai tab bhi hamein user se exception throw karane ki jarurat padti hai

            //Console.WriteLine("Enter your age:");
            //int age = int.Parse(Console.ReadLine());

            //try
            //{
            //    if (age >= 18)
            //    {
            //        Console.WriteLine("You are eligible to vote..");
            //    }
            //    else
            //    {
            //        throw new Exception("You are not eligible to vote..");//C# default Exception class message property set own exception message here and throw also using throw keyword
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ////another example
            //int acc_bal = 500;
            //Console.WriteLine("Enter your withdrawl amount..");

            //try
            //{
            //    int with_amo = int.Parse(Console.ReadLine());

            //    if (acc_bal < with_amo)
            //    {
            //        throw new Exception("Insufficient Balance..");
            //    }
            //    else
            //    {
            //        acc_bal -= with_amo;
            //        Console.WriteLine("Remaning balance is: " + acc_bal);
            //        Console.WriteLine("Transaction compleated successfully !!");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //(104)Partial Class In C# - Partial Class - C# Partial Class - What is Partial Class
            ClassPartial cp = new ClassPartial();
            cp.FirstName = "Gulshan";
            cp.LastName = "Kumar";
            Console.WriteLine("Your compleate name is: " + cp.FirstName + " " + cp.LastName);

            //(105)RULES FOR CREATING PARTIAL CLASS IN C#
            //Read Action and func delegate in C# said by Satya Sir
            //All the parts spread across different files, must use the partial keyword.
            //All the partial class definitions must be in the same assembly and namespace.
            //All the parts must have the same accessibility like public or private, etc.
            //If any one part is declared abstract then the whole class is declared of the abstract type.
            //If any part is declared sealed then the whole class is declared of the sealed type.
            //If any of the parts inherit a class, then the entire type inherits the class.
            //C# does not support multiple class inheritance. Different parts of the partial class, must not specify different base classes.
            //Different parts of the partial class can specify different base interfaces.
            //Any member that are declared in a partial defination are available to all of the parts of the partial class.

            //(106)PARAMS KEYWORD IN C#
            int[] array = { 10, 19, 18, 13 };
            Console.WriteLine(ClassParams.Adds(array));
            Console.WriteLine(ClassParams.Add(10, 19, 18, 13));

            ////(107)DIFFERENCE BETWEEN STRING AND STRING BUILDER IN C#
            ////The only difference is, the String is immutable and StringBuilder is mutable. <- means string cannot be changed once created. but StringBuilder can. boths are reference type. for string drawbacks overcoming use StringBuilder class.
            ////Note :- When you have to do few modifications or append, string is preferred.
            ////But when you have to do more than 3 or 4 modifications or append then StringBuilder is preferred instead of string.
            ////string is slower than StringBuilder.
            ////StringBuilder is a Class which has multiple methods. these methods cover in next video.

            //string s1 = "Gulshan";
            //Stopwatch sw1 = new Stopwatch();//Stopwatch for time calculating, how much time taken by a perticular task execution of C# like string or StringBuilder, we can know time in any medium like seconds, miliseconds etc.
            //sw1.Start();
            //for (int jj = 0; jj < 100000; jj++ )
            //{
            //    s1 = s1 + jj;//hear created one lakh copys in heap memory
            //}
            //sw1.Stop();

            //StringBuilder sb = new StringBuilder("Hello");
            //Stopwatch sw2 = new Stopwatch();
            //sw2.Start();
            //for (int jj = 0; jj < 100; jj++)
            //{
            //    sb.Append(jj);//Append means jodna(concatinate)//here one lakh modifications in same heap memory, jo ki only one hogi
            //}
            //sw2.Stop();

            //Console.WriteLine("Time Taken By String: " + sw1.ElapsedMilliseconds);//String takes 39 seconds
            //Console.WriteLine("Time Taken By StringBuilder: " + sw2.ElapsedMilliseconds);//StringBuilder takes 0 second

            //(108)STRING BUILDER IN C#
            //StringBuilder is a dynamic class, by default its dynamic size is 16, but you can set dynamic size according to user, after reaching user size SringBuilder automatically increase its size dynamically.
            //Append method for concatinating string in default StringBuilder object's string
            //AppendLine method for after apending string moving curser on next line
            //AppendFormat method for string formating before append, C(Currency), N(Amount), X(Hexadecimal)
            //The Insert() method inserts the string at specified index in StringBuilder.
            //The Remove() method removes the string at specified index with specified length.
            //The Replace() method replaces all occurrence(sabhi strings) of a specified string with a specified replacement string.
            //ToString() method to get string(immutable) from StringBuilder.

            StringBuilder sbu = new StringBuilder("Gulshan ");
            sbu.Append("Kumar");
            sbu.AppendLine("MCA");
            sbu.AppendFormat("{0:X}"/*C,N*/, 25);
            sbu.Insert(7, " C#");//StringBuilder is zero index based
            sbu.Remove(11, 5);
            sbu.Append("C#");
            sbu.Replace("C#", "Kumar");
            string str = sbu.ToString();
            Console.WriteLine(str);

            //(109, 110)( PART-1, PART-2 ) MULTI THREADING IN C#
            //Without Multithreading Multitasking not be posible in any OS
            //The threads created using the thread class are called the child threads of the main thread.
            //You can access a thread using the CurrentThread property of the thread class.
            //Thread.Sleep() cause  the currently executing thread to pause temporarily for the specified amount of time.
            //It saves time because  multiple taks are being executed at a time.
            //TO Create multithreaded application in C#, we need to use System.Threading namespace.
            
            //Multiple applications simultaneously run hone ko multi tasking khete hain, using multi threading means multiple threads. <- What is Multi tasking?
            //Every application is executed in a process provided by operating system. Every process its unique id.
            //Every application has a single thread by default to execute a program, this thread used by Process to execute application code(sabkuch like method, class etc), for dividing this process in multiple processes use multiple threads, for running application code simultaneously.
            //Every application follows single threaded model. our applications is so big, it's a drawback, for overcoming from this using multi threading concept.
            //When our application hanged on, we end process of perticular application from task manager for closing them.
            //Thread is an light weight resource. using threads will increase the performance of our application.
            //Single Thread works in sequential manner. In func2 complex coding takes 15sec for taking data from db. so, func3 delay execute because of func2. its a huge drawback for our application. so, use multiple threads.
            //Threads are executed by the operating system using time-sharing(thodi-thodi der execution for every thread simultaneously), not specified time depends on OS.
            //How many threads can be executed at a time in C#?
            //Each core can only run 1 thread at a time, i.e.hyperthreading is disabled.So, you can have a total maximum of 20 threads executing in parallel, one thread per CPU/ core.That can mean 20 single - threaded jobs, 1 multi - threaded job with 20 threads, or anything in between.

            //Thread th = Thread.CurrentThread;//Our default thread of application is CurrentThread, its a anonymous thread
            //th.Name = "Main Thread";
            //Console.WriteLine("Current Executing Thread is: " + Thread.CurrentThread.Name);
            ThreadClass.func1();
            ThreadClass.func2();
            ThreadClass.func3();
            
            ////(110)( PART-2 ) MULTI THREADING IN C#
            //Thread t1 = new Thread(func1);
            //Thread t2 = new Thread(func2);
            //Thread t3 = new Thread(func3);

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //(111, 112)( PART-1, PART-2 ) EXTENSION METHODS IN C#
            ExtensionClass ec = new ExtensionClass();
            ec.Func1();
            ec.Func2();
            ec.Func3(20);//Icon also different of extension method

            int oo = 20;//int is an struct, in this int struct we making an extension method
            Console.WriteLine(oo.IsGreaterThan(10));

            //(113)( PART-1 ) WHAT IS STRUCTURE AND DIFFERENCE BETWEEN STRUCTURES AND CLASSES IN C#
            //StructClass sc1 = new StructClass();
            StructClass sc1;
            sc1.func1();

            //(114)( PART-2 ) WHAT IS STRUCTURE AND DIFFERENCE BETWEEN STRUCTURES AND CLASSES IN C#
            //StructClass2 sc2 = new StructClass2();//Here default constructor(StructClass2();) initialized default value 0 to int a variable of Class StructClass2 automatically but if we set any value to int a, then this default Constructor can't run and can't provide default value to int a variable of Class StructClass2, DefaultConstructor created automatically when we creating object of own class
            //StructClass2 sc2;//Here not defined default constructor so, here required us provide value to unassigned field of Class StructClass2
            //sc2.a = 10;
            //sc2.func1();
            StructClass2 sc2 = new StructClass2(20);
            sc2.func1();
            myStruct ms = new myStruct();
            ms.Show();

            /* (115)WHAT IS FILE HANDLING / FILE I-O IN C#
            System.IO namespace is used for handling files, in this namespace almost all classes is available for file handling, for file handling this namespace is compulsory.
            Why file handling we use in C# understanding by an concept :- Our C# programs are stored in hardisk(secondary storage/non-volatile memory) parmanently.
            C# programs excution environment provided by ram(primary storage/volatile memory), not parmanently store in ram like output of program, File I-O use for storing output files parmanently in hard disk.
            Note:- A file is a collection of data stored in a disk with a specific name and a directory path.
            File handling allows to store/retrive data on permanent storage.
            Files and its data can be handled programmatically using C# Namespace and Classes.
            When a file is opened for reading or writing, it becomes a stream.
            The stream is basically the sequence of bytes passing through the communication path. There are main streams: the input stream and the output stream.The input stream is used for reading data file(read operation) and the output stream is used for writing into the file(write operation).
            The .Net framework provides a few basic classes for creating, reading and writing to files on the secondary storage and for retrieving file system information.(C# Called .Net Language because C# uses all code from .Net like classes, interfaces etc., so C# called C# .Net Language)
            They are located in the System.Io namespace and used both in desktop applications and the web applications.
            Classes used in file handling in C# :- FileStream, BinaryReader, BinaryWriter, StreamReader, StreamWriter, StringReader, StringWriter, DirectoryInfo, FileInfo. */

            //(116)File Handling in C# - Checking if a File Exist or Not
            //File Exists method of C# is used for cheacking file is exist or not in system directory
            string path = @"C:\CommonLibrary\CSharpLatest-master\CSharp.sln";
            if (File.Exists(path))
            {
                Console.WriteLine("Yes there is a file.");
            }
            else
            {
                Console.WriteLine("File Not Found..");
            }

            ////(117)READING DATA FROM TEXT FILE IN C# FILE HANDLIN
            ////Use the File class which is present in System.IO namespace.
            ////Use ReadAllText method of File class to read the data from text file.
            //string filepath = "C:\\CommonLibrary\\CSharpLatest-master\\CSharp\\Program.cs";
            //if (File.Exists(filepath))
            //{
            //    Console.WriteLine("File Found..");
            //    string data = File.ReadAllText(filepath);
            //    Console.WriteLine(data);
            //}
            //else
            //{
            //    Console.WriteLine("File Not Found..");
            //}

            //(118)HOW TO CREATE A COPY OF TEXT FILE IN C# FILE HANDLING
            string path1 = "C:\\CommonLibrary\\CSharpLatest-master\\CSharp\\Program.cs";
            string path2 = "C:\\CommonLibrary\\CSharpLatest-master\\CSharp\\Program1.cs";
            //File.Copy(path1, path2);//Override not supported by this overloaded method version, for coping existing file on system path
            File.Copy(path1, path2, true);

            //(119)DIRECTORY INFO CLASS - FILE HANDLING IN C#
            //It is used to create, delete and move directory.
            //It provides methods/properties to perform operations related to directory and subsirectory. It is a sealed class so, we cannot inherit it.
            //C# DirectoryInfo class provides functionality to work with folders or directories.
            //The DirectoryInfo class shares almost all of the same properties as the fileInfo class except that they operate on directories not files.
            //The DirectoryInfo class does not have static methods and can only be used on instantiated objects.
            //The DirectoryInfo object represents a physical directory on disk/drive.
            //Create:- This method is used to create the new directory.
            //CreateSubdirectory:- This method is used to create a subdirectory or subdirectories on the specified path.
            //MoveTo:- Moves a DirectoryInfo instance and its contents to a new path, replacing by previous path name(My Directory).
            //Delete:- Deletes this instance of a DirectoryInfo, specifying whether to delete subdirectories and files.
            //GetDirectories:- This method is used to get the sub directories in the given directory path.
            //GetFiles:- The GetFiles method is used to get the files in the specific folder.
            //Useful properties of DirectoryInfo Class :- Name, FullName, LastAccessTime, CreationTime, Attributes, Parent, Root, LastWriteTime

            DirectoryInfo dir = new DirectoryInfo(@"C:\My Directory");
            //dir.Create();
            //dir.CreateSubdirectory("Another Directory");
            string pathnew = "C:\\My Directory 2";
            //dir.MoveTo(pathnew);
            DirectoryInfo dir2 = new DirectoryInfo(pathnew);
            //dir2.Delete();//Deleting for empty directory
            //dir2.Delete(true);//Deleting for bhari directory
            string path3 = @"C:\new";
            DirectoryInfo dir3 = new DirectoryInfo(path3);
            DirectoryInfo[] dirs = dir3.GetDirectories();//Here we have multiple directories by Getting directories to store in array here DirectoryInfo[]
            foreach (var item in dirs)
            {
                //Console.WriteLine(item);
                //Console.WriteLine(item.Name);//Name Property for showing directories Names only
                //Console.WriteLine(item.FullName);//FullName Property for showing full directories in a perticular directory
                Console.WriteLine(item.GetFiles().Length);
            }
            string path4 = @"C:\new\new 1";
            DirectoryInfo dir4 = new DirectoryInfo(path4);
            Console.WriteLine(dir4.Name);
            Console.WriteLine(dir4.FullName);
            Console.WriteLine(dir4.LastAccessTime);
            Console.WriteLine(dir4.CreationTime);
            Console.WriteLine(dir4.Attributes);
            Console.WriteLine(dir4.Parent);
            Console.WriteLine(dir4.Root);//Root is the main directory/drive
            Console.WriteLine(dir4.LastWriteTime);//In Directory Last changes time like creation of folder/changing with file

            //(120, 121)( PART-1, PART-2 ) FILE STREAM CLASS - FILE HANDLING IN C#
            //Stream is the our file simply
            //File Stream Class is used for representing a file in C#
            //representing means read from, write to, open, and close files on a file system.
            //FileStram class is derived from Stream class.
            //To manipulate files using FileStream, you need to create an object of FileStream class.
            //This object has four parameters; the Name of the File, FileMode, FileAccess, and FileShare.
            //Name of the file = FilePath, FileMode = What's do with file like create, open, read etc., FileAcsess = purpose of File Access, FileShare = Pre Opened me another Process/FileStream ko rokne ke liye like read, write etc taki perticular task hi file par ho sake like read/write etc.
            //Create method use is overriding to precreated file by new file
            string path5 = @"C:\MyFiles\myFile.txt";//C:\myFile.txt//C Drive Can't Access Directly so use a directory folder with the C Drive for accessing drive simple
            //file.Close();//file Closing is mandatory after use but using by using keyword file opened and closed automatically by using scopes/parentheses {}
            using (FileStream file = new FileStream(path5, FileMode.Append, FileAccess.Write, FileShare.Read))//path5 -> Name of the file
            {
                //file.WriteByte(66);//66 ASCI Code for writing something on text file
                //file.WriteByte(67);
                //file.WriteByte(68);
                //string data = "Welcome to C#..";
                string data = " My Name is Gulshan.."; //This is the lengthy process for writting data in file shortcut is classes streamreader and streamwriter
                byte[] write_data = Encoding.UTF8.GetBytes(data);//UTF8 is a characters set which we use in C# for specifing encoding.
                file.Write(write_data, 0, data.Length);//file ka ek method hai write jo 3 values leta hai bitearray, offset(starting point) and count(length of your data)
                Console.WriteLine("File Created..");
            }
            //FileMode.Append :- Open the file if exist or create a new file. If file exists then place cursor at the end of the file.
            //FileMode.Create :- It specifies operating system to create a new file. If file already exists then previous file will be overwritten.
            //FileMode.CreateNew :- It create a new file and If file alreay exist then throw IOException.
            //FileMode.Open :- Open existing file.
            //FileMode.OpenorCreate :- Open existing file and if the not found then create new file.
            //FileMode.Truncate :- Open an existing file and cut all the stored data. So the file size becomes 0.
            //- It Specifies the access to the file.
            //Read - To read data from a file.
            //Write - To write data to a file.
            //Read - To read and write data to a file.

            //(122)STREAM WRITER CLASS - WRITING DATA TO FILE - FILE HANDLING IN C
            //StreamWriter.Write() method is responsible for writing text to a stream.
            //StreamWriter class is inherited from TextWriter class that provides methods to write an object to a string, write strings to a file, or to serialize XML.
            //StreamWriter class has several constructors and provides us with many methods.
            string path6 = @"C:\MyFiles\myFile2.txt";
            using (FileStream file = new FileStream(path6, FileMode.Open, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file, Encoding.UTF8))//file me hamare pass file hai
                {
                    //writer.WriteLine("Statement Number 1");
                    //writer.Write("Statement Number 2");
                    //writer.WriteLine("Statement Number 3");

                    //int[] ar = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
                    //char[] cr = { 'A', 'B', 'C', 'D', 'E' };
                    //foreach (var item in cr)
                    //{
                    //    writer.Write(item + " ");
                    //}
                }
            }

            //(123)STREAM READER CLASS - READING DATA FROM TEXT FILE - FILE HANDLING IN C#
            //StreamReader class is used to read string from the stream.
            //It Inherits TextReader class.
            //It provides ReadLine() method to read data from the stream(In stream we have files).
            string path7 = @"C:\MyFiles\myFile2.txt";
            using (FileStream fs = new FileStream(path7, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fs))//StreamReader closing also required
                {
                    //string line = reader.ReadLine();
                    //Console.WriteLine(line);
                    //foreach (var item in reader.ReadLine())//reader read characters one by one and save as a string in reader for printing
                    //{
                    //    Console.WriteLine(item);
                    //}

                    //string line = "";
                    //while ((line = reader.ReadLine()) != null)
                    //{
                    //    Console.WriteLine(line);
                    //}

                    //File se data read kar ke array me store then array se data iterate kar ke console par print
                    //string[] lines = new string[7];
                    //for (int ij = 0; ij < lines.Length; ij++)
                    //{
                    //    lines[ij] = reader.ReadLine();
                    //}

                    //foreach (var item in lines)
                    //{
                    //    Console.WriteLine(item);
                    //}

                    //string data = reader.ReadToEnd();//ReadToEnd Read till end of the line no required here 
                    //Console.WriteLine(data);

                    //For Character cheacking in file available or not using Peek() method
                    if (reader.Peek() > 0)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
            }

            //(124)Boxing And Un-Boxing in C#
            int num1 = 10;//value type
            object obj1 = num1;//implicit conversion from value type to reference type. Boxing
            int num2 = (int)obj1;//explicit conversion // Unboxing

            //(125)GUID In C# - Globally Unique Identifier In C#.
            //GUID Generate Automatically using algorithm.
            //A Guid is a "globally unique identifier".
            //We can use Guid to enforce uniqueness on every compilation of Guid object.
            //Guid is of 36 characters, Guid dava always new, Guid also use for random password generating.
            //A GUID is a 128-bit (16 bytes) that you can use across all computers and networks wherever a unique identifier is required.
            //Without getting into details, let me tell you there are 5,316,911,983,139,663,491,615,228,241,121,400,000 possible combinations.
            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid.ToString());
            Console.WriteLine(guid.ToString().Replace("-", string.Empty));
            Console.WriteLine(guid.ToString("N"));//Shortcut of replacing hyphen from guid
            Console.WriteLine(guid.ToString("N").Substring(0, 15));//For returning only 15 characters from GUID for random password generating

            //(126)Swapping Of Two Numbers Without Using Third Variable In C#
            //Swapping done by using default two variables, works with any two n numbers
            int v1 = 5;
            int v2 = 6;

            Console.WriteLine("a = " + v1);
            Console.WriteLine("b = " + v2);

            v1 = v1 + v2;// v1 = 11
            v2 = v1 - v2;// v2 = 5
            v1 = v1 - v2;// v1 = 6

            Console.WriteLine("------------ swapped Results ------------");
            Console.WriteLine("v1 = " + v1);
            Console.WriteLine("v2 = " + v2);

            ////(127)Palindrome String Program In C# -Check Whether A String Is Palindrome Or Not -C#
            ////What is Palindrome :- A Palindrome is a word that reads the same backward or forward.
            ////Example :- radar, civic, madam, level
            ////Not a Palindrome String :- Gulshan, Furniture, Laxman
            //string str = "";
            //Console.WriteLine("Enter A String");
            //str = Console.ReadLine();

            ////char[] chaar = str.ToCharArray();
            ////Array.Reverse(chaar);
            ////string str_reverse = new string(chaar);
            //var str_reverse = new string(str.ToCharArray().Reverse().ToArray());

            //if (str.ToLower().Equals(str_reverse.ToLower()))
            //{
            //    Console.WriteLine(str + " -> Its A Palindrome String..");
            //}
            //else
            //{
            //    Console.WriteLine(str + " -> Its Not A Palindrome String..");
            //}

            //(128)C# Interview Question - Can We Store Different Types Of Data In An Array Without Using Collection ?
            //Answer: Yes We can do that by creating an array of object type.
            //int[] ar = new int[3];
            object[] aray = new object[5];
            aray[0] = 11;
            aray[1] = "Gulshan";
            aray[2] = 5.11;
            aray[3] = true;

            Emp em = new Emp();
            em.EmpId = 11;
            em.EmpName = "Ankit";

            aray[4] = em;//Complex type class object also we can set in our object type array index

            foreach (object item in aray)
            {
                Console.WriteLine(item);
            }

            //(129)is VS as Operator In C# - Difference between is and as in c#
            //'is' keyword is used to check the data type of am object whether the conversion from one object type to another type is compatible or not.
            //It returns boolean value, so we can use in our if condition.
            object ob = "Gulshan";
            bool check = ob is string;//is Operator cheacking object value here by string data type
            Console.WriteLine(check);
            string dds = "Kumar";
            bool gh = dds is object;
            Console.WriteLine(gh);
            if (ob is string)
            {
                Console.WriteLine("Yes Its a String");
            }
            else
            {
                Console.WriteLine("No Its Not a String");
            }
            //As Keyword:- In the development of the software, typecasting is a common thing. In many Cases, developer need to convert a Type into another Type and sometimes he/she may get InvalidCastException. So, to overcome such types of exception C# provides "as" operator keyword.
            //'as' is a keyword used for conversion from one type to another. The type can be a reference or nullable.
            //-Difference between IS and AS:-
            //The "is" operator is used to check if the run-time type of an object is compatible with the given type or not whereas "as" operator is used to perform conversion between compatible reference types or Nullable types.
            //The "is" operator is used for only reference, boxing, and unboxing convertions whereas "as" operator is used only for nullable, reference and boxing conversions.
            object obb = 458;//"Kumar";//Return null value here because object convertion in another object is not compatible/fails.
            string str = obb as string;
            Console.WriteLine(str);

            //(130)Null Coalesce Operator In C#
            //The ?? operator is also known as the null-coalescing operator.
            //It returns the left side operand if the operand is not null else it returns the right side operand.
            //Coalescing operator returns the first non null value from the chain.
            string fruit1 = null;
            string fruit2 = null;
            string fruit3 = "Grapes";
            //string result = "";

            //if (fruit1 != null)
            //{
            //    result = fruit1;
            //}
            //if (fruit2 != null)
            //{
            //    result = fruit2;
            //}
            //if (fruit3 != null)
            //{
            //    result = fruit3;
            //}
            string result = fruit1 ?? fruit2 ?? fruit3 ?? "Anonymous";//Null value checking by using single line of code by using Null Coalesce operator in C#.
            Console.WriteLine(result);

            //(131)What Happens If a Finally block throws an Exception in C# ?
            try
            {
                try
                {
                    int va1 = 10;
                    int va2 = 0;
                    int va3 = va1 / va2;
                    Console.WriteLine(va3);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You cannot Divided a number by zero");
                }
                finally
                {
                    string name = null;
                    Console.WriteLine(name.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------");

            try
            {
                FinallyBlockException.Shows();
            }
            catch (Exception ex)//here finally block Null reference exception is handeled by our Shows method here
            {
                Console.WriteLine(ex.Message);
            }

            //(132)Serialization In C#.NET | C# Serialization | Binary Serialization | Serializable C# .Net
            string pat = @"C:\MyFiles\Sample.exe";//docx,txt,pdf,png
            ClassSerialization cs = new ClassSerialization(11, "Gulshan");
            using (FileStream fss = new FileStream(pat, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fss, cs);//here our class object is serialized in our file stream using BinaryFormatter class
            }
            Console.WriteLine("File Created Successfully -> " + pat);


            string patt = @"C:\MyFiles\Sample.txt";//docx,exe,pdf,png
            BinaryFormatter bss = new BinaryFormatter();
            using (FileStream fls = new FileStream(patt, FileMode.Open))
            {
                ClassSerialization css = (ClassSerialization)bss.Deserialize(fls);//here return class object so required obj conversion in ClassSerialization class type
                Console.WriteLine(css.Id);
                Console.WriteLine(css.Name);
            }

            //------------------------
            string paat = @"C:\MyFiles\Sample.exe";
            ClassSerialization ccs = new ClassSerialization(11, "Gulshan");
            ClassSerialization ccs1 = new ClassSerialization(22, "Shivam");
            ClassSerialization ccs2 = new ClassSerialization(33, "Rohan");
            using (FileStream fss = new FileStream(paat, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fss, cs);
            }
            Console.WriteLine("File Successfully Created -> " + paat);

            //(136, 137, 138)Constructor, Property, Method Injection - Dependency Injection (Di) In C# - Practical Example - Learn C#
            Acount acco = new Acount();
            acco.PrintAccounts();

            IAccount ca = new CurrentAccount();
            Account acc = new Account(ca);//Here IAccount interface role is injector used for injecting object to Account class constructor object. for working with constructor here.
            //ca.PrintDetails();//we can also call class object directly without using constructor Initialization DI.
            acc.PrintAccounts();

            IAccount sa = new SavingAccount();
            //sa.PrintDetails();
            Account acc2 = new Account(sa);//Now here our Account class is not depended on other classes its loosly coupled here because here Account class needed object is provided by Our IAction Interface here thats is reference type always provided/stored different type of object of different tpe of classes by Interface here simple.
            acc2.PrintAccounts();//single method of IAccount interface used multiple times by using inheritence by different classes

            AccountProperty ap = new AccountProperty();
            ap.account1 = new SavingAccount();
            ap.PrintAccounts();

            ap.account1 = new CurrentAccount();
            ap.PrintAccounts();

            AccountMethod am = new AccountMethod();
            am.PrintAccounts(new SavingAccount());//Here IAccount type parameter required a class type object for calling the class members of IAction impliment class members simple 
            am.PrintAccounts(new CurrentAccount());

            //(139, 140)Enum In C# | C# Enumeration | C# Enum | Enum Conversion | Enum With Switch C# (Part-1, Part-2)
            //Explicit casting is required to convert from an enum type to its underlying integral type.

            //Console.BackgroundColor = ConsoleColor.Gray;//ConsoleColor <- Built In Enums in C# and Gray is Constant and so much this types of built in enums is available in C#
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.WriteLine("My Name is Gulshan Kumar");
            Console.WriteLine(Days.Sunday);
            Days myDay = (Days)3;//Here type casting explicitly
            Console.WriteLine(myDay);

            int valu = (int)Days.Saturday;
            Console.WriteLine(valu);

            //------------------------(Part-2)--------------------------
            //Why and when to use enums?
            //Use enums when you have values that you know aren't going to change, like month days, colors etc in future in your program.
            //Enum with switch

            //Console.WriteLine("Enter Your Name");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Enter Your Day Sunday = 1, Monday = 2, Tuesday = 3");
            //int valus = int.Parse(Console.ReadLine());

            //Days myDa = (Days)valus;
            //Console.WriteLine("My Name is: " + Name + " And My Birth Day Is: " + myDa);

            //----------------------------------------------------------
            string[] members = Enum.GetNames(typeof(Days));
            foreach (string member in members)
            {
                Console.WriteLine(member);
            }

            int[] valuemembers = (int[])Enum.GetValues(typeof(Days));//Enum values here of string type required to convertion in int type of array
            foreach (int valuemember in valuemembers)
            {
                Console.WriteLine(valuemember);
            }

            //----------------------------------------------------------
            Days myD = Days.Monday;
            //int myD = (int)Days.Tuesday;//Here in myDay has Enum type that's is string, then with int value enum not working

            switch (myD)//Switch shortcut with enum switch tab-2 the write enum in switch parentheses then down arrow key/enter press that's it
            {
                case Days.Sunday:
                    Console.WriteLine("Hello This is Sunday");
                    break;
                case Days.Monday:
                    Console.WriteLine("Hello This is Monday");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("Hello This is Tuesday");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Hello This is Wednesday");
                    break;
                case Days.Thursday:
                    Console.WriteLine("Hello This is Thursday");
                    break;
                case Days.Friday:
                    Console.WriteLine("Hello This is Friday");
                    break;
                case Days.Saturday:
                    Console.WriteLine("Hello This is Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Day..");
                    break;
            }

            int myDa = (int)Days.Wednesday;
            switch (myDa)//Enum we can use two types, using enum constants members or enum default values starting by 0
            {
                case 1:
                    Console.WriteLine("Hello This is Sunday");
                    break;
                case 2:
                    Console.WriteLine("Hello This is Monday");
                    break;
                case 3:
                    Console.WriteLine("Hello This is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Hello This is Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Hello This is Thursday");
                    break;
                case 6:
                    Console.WriteLine("Hello This is Friday");
                    break;
                case 7:
                    Console.WriteLine("Hello This is Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Day..");
                    break;
            }

            Task1();
            Task2();
            Task3();
            Task4();

            Console.ReadLine();
        }
        //(142)Async And Await In C# - Synchronous VS Asynchronous In C# - C# Async Await - Learn C#
        //-What is Synchronous in C#?
        //Synchronous programming is a programming model where operations take place sequentially.
        //Executes in a Sequence, Dependent on each other
        //-What is ASynchronous in C#?
        //ASynchronous programming is a programming model where operations does not dependent on each other.
        //Not Executes in a Sequence, Not Dependent on each other
        //Task class is used for performing Asynchronous operations, Task perform a single operation using Run method
        
        //Async and Await are the two keywords that help us to program asynchronously.
        //An async keyword is a method that performs asynchronous tasks such as fetching data from a database, reading a file, etc, they can be marked as "async".
        //Whereas await keyword making "await" to a statement means suspending the execution of the async method it is residing in untill the asynchronous task completes. <- means after async method body execution compleation method calling performing by await keyword for showing output of method simple.
        //After suspention, the control goes back to the caller method.
        //Once the task completes, the control back to the states where await is mentioned and executes the reamaining statements in the enclosing method.
        public static async void Task1()
        {
            //Console.WriteLine("Task 1 Starting..");//This is synchronous programming <- default programming in C#
            //Thread.Sleep(4000);
            //Console.WriteLine("Task 1 Completed..");
            await Task.Run(() => //This is a function using with lambda expression in js this function is known by name of arrow function
            {//This is Asynchronous programming, await keyword is said here this method delay here/takes time
                Console.WriteLine("Task 1 Starting..");
                Thread.Sleep(4000);
                Console.WriteLine("Task 1 Completed..");
            });
        }
        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 Starting..");
                Thread.Sleep(2000);
                Console.WriteLine("Task 2 Completed..");
            });
            Console.WriteLine("Hello Gulshan");//This line is executed after task compleation by await keyword
        }
        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 3 Starting..");
                Thread.Sleep(5000);
                Console.WriteLine("Task 3 Completed..");
            });
        }
        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 4 Starting..");
                Thread.Sleep(1000);
                Console.WriteLine("Task 4 Completed..");
            });
        }

        //(141)How To Download And Install Visual Studio 2022 - For ASP.Net Core MVC - For Desktop And Console App

        //(139, 140)Enum In C# | C# Enumeration | C# Enum | Enum Conversion | Enum With Switch C# (Part-1, Part-2)
        //-What is Enum? Built In Enums? How Can We Create Enums? Practical Example, Why And When To Use Enums? Enum Conversion(Type Casting With Enum)
        //Enum is a set of constants.
        //A enum is a special "class" that represents a group od constants (unchangeable/read only variables).
        //Enum is short form of "enumerations", which means "specifically listed" <- means constants not changeable.
        //-How to create enum in C#?
        //To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma.
        //Enum is converted into abstract class behind the scenes.
        enum Days//Custom enum //we can declare our enum in namespace, class or structure, default enum type is int, enums.
        {
            Sunday=1,//These enum constants is hold on int values position, 0 is the defualt enum value and increased by 1 after adding constants in enum, we can also change our enum default values accordingly user requirements
            Monday,//=7//we can change our enum default values
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        //(136, 137, 138)Constructor, Property, Method Injection - Dependency Injection (Di) In C# - Practical Example - Learn C#
        //constructor injection is nothing but the process of injecting dependent class object through the constructor.
        //Setter or property injection is injecting dependent class object through the property.

        //Account Example Using Tight Coupling
        class CurrentAcount
        {
            public void PrintDetails()
            {
                Console.WriteLine("Details of Current Account..");
            }
        }

        class SavingAcount
        {
            public void PrintDetails()
            {
                Console.WriteLine("Details of Saving Account..");
            }
        }

        class Acount//This Account class is depended on both CurrentAccount and SavingAccount because Account class here required to create object of both classes for printing details simply.
        {
            CurrentAcount ca = new CurrentAcount();
            SavingAcount sa = new SavingAcount();

            public void PrintAccounts()
            {
                ca.PrintDetails();
                sa.PrintDetails();
            }
        }

        //Account Example Using DI with constructor injection
        public interface IAccount
        {
            void PrintDetails();
        }

        class CurrentAccount : IAccount
        {
            public void PrintDetails()
            {
                Console.WriteLine("Details of Current Account..");
            }
        }

        class SavingAccount : IAccount
        {
            public void PrintDetails()
            {
                Console.WriteLine("Details of Saving Account..");
            }
        }

        class Account
        {
            private IAccount account;//This IAccount interface variable implementation by Constructor is every time different by providing different type of class to IAccount interface reference variable

            public Account(IAccount account)
            {
                this.account = account;
            }

            public void PrintAccounts()
            {
                account.PrintDetails();
            }
        }

        class AccountProperty
        {
            public IAccount account1 { get; set; }

            public void PrintAccounts()
            {
                account1.PrintDetails();
            }
        }

        class AccountMethod
        {
            public void PrintAccounts(IAccount account)
            {
                account.PrintDetails();
            }
        }

        //(135)Dependency Injection (Di) In C# - C# Dependency Injection - Design Pattern - Types
        //-Tight Coupling:- Tight coupling is when a group of classes are highly dependent on one another.
        //Difficult to maintain. Difficult to test.
        //-Loose Coupling:- Loose coupling means that the classes are independent of each other.
        //Loose coupling is achieved by means of a design that promotes single-resposibility and separation of a design that promotes single-responsibility and separation of concerns.
        //Easy to maintain. Easy to test
        //-Important Question?
        //How to avoid this tightly coupled state?
        //The answer is by using Dependency injection.
        //Dependency injection is achieved using interfaces.
        //Interfaces are a powerful tool to use for decoupling. decoupling means tight coupling conversion in loose coupling.
        //Classes can communicate through interfaces rather than other concrete classes.
        //-What is Dependency Injection?
        //1st Client, 3rd Injector(Mediator), 2nd Service:- Here Client use Service by Injecting in our application not directly.
        //-What is Dependency Injection?
        //Dependency Injection(DI) is a software pattern.
        //Dependency Injection is basically providing the objects that an object needs, instead of having it construct the objects themselves. <- Not making object own injecting object by other
        //DI is a technique whereby one object supplies the dependencies of another object.
        //With the help of DI, we can write lossely coupled code.
        //DI is achieved by writing loosely couple code.
        //A loosely-coupled code is a code where all your classes can work independently without relying on each other.
        //-Types of Dependency Injection
        //There are 3 types of DI in C#
        //1. Constructor Injection
        //2. Setter or property Injection
        //3. Method Injection

        //(134)What Is Concrete Class In C# - C# Concrete Class - C# Interview Questions And Answers
        //A concreate class is a class that has an implementation for all of its methods. All methods have their body {}. It cannot contain abstract methods.
        //Concreate class can also extend an abstract class or implement an interface as long as it implements all their methods.
        //Concreate class is nothing but normal class, we can use as a base class or may not.
        //Note:- In other words, we can say that any class which is not abstract is a concreate class. <- Main Point

        //(133)Deserialization In C#.NET | C# Deserialization | Serialization And Deserialization C#
        //In Deserialization We Convert our File into Stream of Bytes then in Object simple
        //As the name suggests, deserialization in C# is the reverse process of serialization.
        //Deserialization is the opposing process which takes data from a file, stream or network and rebuilds it into an object.
        //It resurrects the state of the object by setting properties, fields etc.


        //(132)Serialization In C#.NET | C# Serialization | Binary Serialization | Serializable C# .Net
        //In Serialization we convert our object in stream of bytes then this stream of bytes we can store in our memory(hard disk/flash etc), file(xml, txt etc) and Database. this code is in Encoded form not understandable by user.
        //What is Stream of bytes :- Byte streams are a sequence of bytes used by programs to input and output information. example:- one byte = 8 bits, on one byte store one ascii input, after stream of bytes conversion its converted in encoded form thats not understandable by user.
        //After making class Serializable we can't inherited this class/can't use inheritance concept with this class now

        //Its main purpose is to save the state of an object in order to be able to recreate it when needed.
        //This reverse process is called "De-Serialization".

        //The General Steps for serializing are:-
        //Create an instance of File that will store serialized object.
        //Create a stream from the file object.
        //Create an instance of BinaryFormatter.
        //Call serialize method of the BinaryFormatter class and then pass stream and object of class for serialization.

        //How serialization works
        //The object is serialized to a stream(file) with stream of data that carries the object data.
        //The stream may also have information about the object's type, such as its version, culture, and assembly name.
        //from that stream, the object can be stored in a database, a file, or memory.

        //Uses of serialization
        //serialization allows the developer to save the state of an object and re-create it as needed, providing storage of objects as well as data exchange.
        //Through serialization, a developer can perform actions such as:
        //Sending the object to a remote application by using a web service.
        //Passing an object from one domain to another.
        //Passing an object through a firewall as a Json or Xml string.
        //Maintaining security or user-specific information across applications.

        //Important Points
        //If you want to make a class Serializable then you have to use [Serializable] attribute on top of your class.
        //If you have applied [Serializable] attribute to the class then that class will not be inherited.
        //We can serialize data in Xml and Json as well.

        //Types of Serialization
        //Serializing In Binary
        //Serializing In XML
        //Serializing In JSON

        [Serializable]//Without this attribute generate a error of System.Runtime.Serialization.SerializationException because without this class making Serializable we can't serialize this class object simply.
        class ClassSerialization
        {
            public int Id;
            public string Name;
            public ClassSerialization(int Id, string Name)
            {
                this.Id = Id;
                this.Name = Name;
            }
        }

        //(128)C# Interview Question - Can We Store Different Types Of Data In An Array Without Using Collection ?
        class FinallyBlockException
        {
            public static void Shows()
            {
                try
                {
                    int va1 = 10;
                    int va2 = 0;
                    int va3 = va1 / va2;
                    Console.WriteLine(va3);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You cannot Divided a number by zero");
                }
                finally
                {
                    string name = null;
                    Console.WriteLine(name.Length);
                }
            }
        }

        //(130)Null Coalesce Operator In C#
        class Emp
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }

            //public override string ToString()//For Overriding our ToString() method here
            //{
            //    return EmpName;
            //}
        }



        //(114)( PART-2 ) WHAT IS STRUCTURE AND DIFFERENCE BETWEEN STRUCTURES AND CLASSES IN C#
        //In case of a class "new" keyword is compulsory while creating the object/instance, on the other hand "new" is not compulsory while working with srtuctures.
        //In case of structure, we cannot explicitly create default constructor/parameterless constructor because it is always pre-defined, we can create only parameterized constructor in structures.
        //Class support inheritance whereas structures don't supported inheritance.
        //Class can implement interfaces as well as structures can implement interfaces.
        //In Vs has no template for Structures so use code file this is a blank file we can use for Structure.
        struct StructClass2
        {
            public int a;

            public void func1()
            {
                Console.WriteLine("This is my new function.." + a);
            }
            public StructClass2(int a)
            {
                this.a = a;
            }
        }

        interface myInterface
        {
            void Show();
        }

        struct myStruct : myInterface
        {
            public void Show()
            {
                Console.WriteLine("This is my Interface..");
            }
        }

        //(113)( PART-1 ) WHAT IS STRUCTURE AND DIFFERENCE BETWEEN STRUCTURES AND CLASSES IN C#
        //Structure is a user-defined data type. //Class is also a user-defined data type.
        //Structures are introduced first before classes.
        //Structures are first introduced in procedural language called C programming language.
        //Classes are introduced after Structures in OOP language.
        //Structures in C programming language can contain only fields/variables.
        //Structures in C# programming language can contain most of the members that a class can contain like Methods, Fields, Constructors, Properties, Indexers etc.
        //In C#, classes and structs are blueprints that are used to create instance of a class.
        //Structures is a value type. Structures are stored in stack memory. Stack memory small in size.
        //Class is a reference type and it is stored in Heap memory. While Heap memory big in size.
        //Class and Structures both are use to represent entities(new user define data types) like student, employee, customer etc.
        //We can use class for representing large amount of data.
        //On the other hand we can use structures for representing small amount of data.
        //Structs are used for lightweight objects such as Color, Rectangle, Point etc.
        //For knowing data type of any data type like class(reference type)/struct(value type) use mouse hover simply
        struct StructClass
        {
            public void func1()
            {
                Console.WriteLine("This is my new function..");
            }
        }


        //(111, 112)( PART-1, PART-2 ) EXTENSION METHODS IN C#
        //Extension methods used for adding additional methods in class or struct, which we have no source code and no permition
        //Inheritence not worked with sealed class and struct then we can use Extension methods
        //We make static class with static/extension methods and these methods bind with class/struct for extending methods, this parameter used for binding only not works as a normal parameter
        //Extension methods are defined as static methods but once they bind with any class or struct then they converts into non-static or instance methods.
        //If an extension method is defined with the same name ans asme signature of an existing method in the class, then extension method will not be called.
        //binding parameter always be the first parameter in the parameter list.
        //Only one binding parameter is allowed.
        //Extension methods can be added to your own custom class, .Net framework classes, or third party classes or interfaces.
        public sealed class ExtensionClass
        {
            public void Func1()
            {
                Console.WriteLine("This is first function..");
            }
            public void Func2()
            {
                Console.WriteLine("This is second function..");
            }
        }

        //static class ExtensionMethods//Why here this class generated error
        //{
        //    public static void Func3(this ExtensionClass ec)//This is an extension method//this extension method parameter is called binding parameters thats belongs to ExtensionClass specified here
        //    {
        //        Console.WriteLine("This is third method..");
        //    }
        //}

        //(109, 110)( PART-1, PART-2 ) MULTI THREADING IN C#
        class ThreadClass
        {
            public static void func1()
            {
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine("Func1= " + i);
                }
            }

            public static void func2()
            {
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine("Func2= " + i);
                    if (i == 25)
                    {
                        Console.WriteLine("Thread is going to sleep for 8 seconds..");
                        Thread.Sleep(8000);
                    }
                }
            }

            public static void func3()
            {
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine("Func3= " + i);
                }
            }
        }

        //(106)PARAMS KEYWORD IN C#
        //Params is used for getting comma seprated values as an argument, without params keyword we required a array as an argument simple
        //Params is an important keyword in C#. It is used as a parameter which can take the variable number of arguments.
        //-Important point about params keyword:
        //It is useful when programmer don't have any prior knowledge about the number of parameters to be used.
        //Only one params keyword is allowed and no additional params will be allowed in function declaration after a params keyword.
        //The length of params will be zero if no arguments will be passed.
        //Param keyword always pass on last as a argument in function because its a array type
        class ClassParams
        {
            public static int Add(int a, int b, params int[] nums)
            {
                int sum = 0;
                foreach (var i in nums)
                {
                    sum = sum + i;
                }
                return sum;
            }

            public static int Adds(int[] nums)
            {
                int sum = 0;
                foreach (var i in nums)
                {
                    sum = sum + i;
                }
                return sum;
            }
        }

        //(104)Partial Class In C#
        //Partial Class is created in C# using partial keyword
        //Partial Class is a single Class, using partial keyword we can seprate/make multiple copys of partial class according user requirements, when Class maked more complex then seprated it by user simple
        //-Advantages:-
        //Multiple developers can work simultaneously with a single class in seprate files., When working on large projects.
        //Visual Studio uses partial classes to separate, automatically generated system code from the developer's code. For Example when you add a Windows Forms Application or Asp.Net Web Application Project.
        public partial class ClassPartial
        {
            string _firstName;
            string _lastName;

            public string FirstName
            {
                set
                {
                    _firstName = value;
                }
                get
                {
                    return _firstName;
                }
            }

            public string LastName { get => _lastName; set => _lastName = value; }
        }

        public partial class ClassPartial
        {
            public string GetCompleateName()
            {
                return _firstName + " " + _lastName;
            }
        }

        //(94)( PART-1 ) DICTIONARY GENERIC COLLECTION IN C#
        class ClassDictionary
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Designation { get; set; }
            public int Salary { get; set; }
        }

        //(91)( PART-1 ) LIST GENERIC COLLECTION IN C#        
        class ClassList
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        //(84)GENERIC CLASS IN C# PROGRAMMING
        //Generic classes define functionalities that can be used for any data type with any class member.
        //Generic allow you to define a class with placeholders<T> for the types of its fields, methods, parameters, etc.
        class GenericClass<T>//Now this class is generic type, we can use its T with any member of this class for making it Generic(for working with more than one data type)
        {
            T box;
            //public GenericClass(T b)
            //{
            //    box = b;
            //}

            //public T getbox()
            //{
            //    return box;
            //}

            public T Box
            {
                set
                {
                    box = value;
                }
                get
                {
                    return box;
                }
            }
        }


        //(83)GENERICS AND GENERIC METHOD IN C#
        //Generic allow you to write a class or method that can work with any data type.
        //When we want without method overloading make an versatile method that can handel any kind of data type then use, Generic type data type in method as an argument , thats help for converting our data type in T type(Generic type any kind of data type on compile time simple)
        //Generic allow you to define a class with angle type parameter/brackets/angular brackets/placeholder<T> for the type of its fields, methods, parameters, etc. generic replace these placeholders with some specific type at compile time. It helps you to maximize code reuse, type safety, and performance.
        //You can create your own generic classes, interfaces, methods, events, delegates.
        //You may get information on the types used in a generic data type at run-time.
        //Generic can be applied on interface, Abstract class, Class, Method, Static method, Property, Event, Delegates, Operator
        //We can declare a generic method within generic or non-generic class declarations.
        //Generic methods can be declared with the following keywords:- Virtual, Override, Abstract
        class Generic
        {
            public static void ShowArray<T>(T[] arr)//passed array as an argument, its values print here, yahan dinamic tarike se kam ho jaega
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            public static bool Check<T>(T a, T b)//Two Data type comparision using generic method
            {
                bool c = a.Equals(b);
                return c;
            }

            //public static bool Check<T>(object a, object b)//Here value type converting in object type so, by this boxing and unboxing our data type this is not good so avoid them by using generic, performance also impacted by this <-  so ignore it because its only a concept only
            //{
            //    bool c = a.Equals(b);
            //    return c;
            //}

            public static void Check<T>(T a)
            {
                Console.WriteLine(typeof(T));
            }
        }

        //(82)MULTIPLE INHERITANCE IN C# - WHAT IS MULTIPLE INHERITANCE - C#
        //Multiple inheritence is a feature in which a class can inherit characteristics and features from more than one parent class.
        //child class can be only one parent class but can be multiple parent interfaces, using with a single class also

        class Persoon
        {
            public void Show()
            {
                Console.WriteLine("This is a method of Person class..");
            }
        }

        interface Employye
        {
            void Show();
        }

        interface Employye1
        {
            void Show();
        }

        class Teacher : Persoon, Employye, Employye1
        {
            void Employye.Show()
            {
                Console.WriteLine("This is a method of Employee Interface..");
            }

            void Employye1.Show()
            {
                Console.WriteLine("This is a method of Employee1 Interface..");
            }
        }

        //(81)DIFFERENCE BETWEEN ABSTRACT CLASS AND INTERFACE IN C#
        //abstract class can inherit a class and multiple interfaces.
        //interface can inherit multiple interfaces but can't a class.
        //abstract class can have methods with a body.
        //interface can't methods with a body.
        //abstract class methods is implemented using the override keyword.
        //interface method is implimented without using the override keyword.
        //abstract class is a better option when you need to impliment common members like methods, field or say that for declare common members.
        //interface is better option when you need to declare only abstract methods.
        //abstract class can declare constructors and destructors.
        //interface cannot declare constructors and destructors.
        //for declaring abstract members in abstract class then abstract keyword is mandatory.
        //interface has declaration abstract keyword with members is not mandatory because members of interface are abstract bydefault.

        //(80)SIMILARITIES BETWEEN ABSTRACT CLASS AND INTERFACE IN C#
        //In both of them we can declare abstract methods(without body methods).
        //In both of them implimentation is provided by inherited subclass.
        //boths can inherit multiple Interfaces.
        //boths can't be instantiated. but can be referentiated by child class.

        //(79)EXPLICIT IMPLEMENTATION OF INTERFACE IN C#
        //If in multiple interface has same name/signature method then on implimentation time of interfaces produce embiguity for resolving this using explicit implimentation ex. i1.Show()
        interface i1
        {
            void Show();
        }

        interface i2
        {
            void Show();
        }

        class InterfaceClass : i1, i2
        {
            public void Show()//implicit implimentation, in embiguity between two methods we can impliment one method implicitly in interface
            {
                Console.WriteLine("this is a method of i1 interface !!");
            }

            void i2.Show()//explicit implimentation
            {
                Console.WriteLine("this is a method of i2 interface !!");
            }
        }

        //(78)INTERFACE INHERITANCE/INTERFACE INHERITANCE CHAIN IN C# PROGRAMMING
        //A class that inherit this interface must provide implementation for all interface members, that's called interface inheritence chain.
        interface I1
        {
            void Print();
        }
        interface I2 : I1
        {
            void Print1();
        }

        class InterfaceImp : I2
        {
            public void Print()
            {
                Console.WriteLine("This is a method of Interface 1 !!");
            }

            public void Print1()
            {
                Console.WriteLine("This is a method of Interface 2 !!");
            }
        }

        //(77)INTERFACES IN C# PROGRAMMING
        //Interface is an important topic of oops in c#
        //An Interface is a contract between itself and any class that implements it.
        //In Interface bydefault all members are abstract\
        //Interface only have declaration/signature means without impementaion, like methods, properties, indexers & events. compleated/inherited(implement) by child class.
        //One of the main reason to introduce interfaces is that it can be used in multiple inheritence.
        //Interface cannot contain fields.
        //If all the methods are not implimented, the class cannot be compiled.
        //the method implimented in the class should be declared with the same name and signature as defined in the interface.
        interface IEmployee//I is a prefix for knowing its an interface
        {
            void Show();//this method is bydefault public and abstract because in interface no required to declare explicitly
        }

        class PartTimeEmployees : IEmployee//cnt + . for implementation of interface
        {
            public void Show()
            {
                Console.WriteLine("This is a method of IEmployee Interface !!");
            }
        }

        //(76)ABSTRACT PROPERTIES IN C#
        //override space select member of abstract class like property is shortcut for declaration body to abstract member
        abstract class persson
        {
            abstract public uint Id { get; set; }//uint data type for storing only positive values
            abstract public string Name { get; set; }
        }

        class studentt : persson
        {
            uint StudentId;
            string StudentName;
            public override uint Id { set { if (value == 0) { Console.WriteLine("Id cannot be zero !!"); } else { StudentId = value; } } get { return StudentId; } }
            public override string Name { set => StudentName = value; get { return StudentName; } }
        }

        //(75)ABSTRACT CLASS AND ABSTRACT METHOD WITH PRACTICAL EXAMPLE IN C#
        //Abstract class we can't create an object only used as a parent class by inheritence
        //Abstract method has no body but concrete methods have a body
        //In non Abstract class we can't create Abstract methods
        //Abstract class used for declaring common members, like personn abstract class
        //override keyword is used for Parent class abstract/virtual methods, property, indexer, or event implementation by child class throw inheritence

        abstract class personn
        {
            public string name;
            public string phoneno { get; set; }//with phoneno prefix 0 is not supported so we use string with phoneno here//properties in abstract class, we can also make constants,constructors,destructors in abstract class

            public abstract void PrintDetails();
        }

        class student : personn
        {
            public int rollno;
            public int fees;

            public override void PrintDetails()
            {
                Console.WriteLine("Student name is: {0}", name);
                Console.WriteLine("Student phone number is: {0}", phoneno);
                Console.WriteLine("Student roll number is: {0}", rollno);
                Console.WriteLine("Student fees is: {0}", fees);
            }
        }

        class teacher : personn
        {
            public string qualification;
            public int salary;

            public override void PrintDetails()
            {
                Console.WriteLine("Teacher name is: {0}", name);
                Console.WriteLine("Teacher phone number is: {0}", phoneno);
                Console.WriteLine("Teacher qualification is: {0}", qualification);
                Console.WriteLine("Teacher salary is: {0}", salary);
            }
        }

        //(74)ABSTRACTION IN C# PROGRAMMING
        //Abstraction is one of the principle of oops.
        //It is used to display only necessary and essential features of an object to outside the world(other classes).
        //means displaying what is necessary and encapsulate the unnecessary things to outside the world. achieved by private.
        //Abstraction is a process of hiding the implimentation details from the user(other class user who access my methods), only the functionality will be provided to the user example Console.WriteLine().
        //In other words, the user will have the information on what the object does instead of how it does it.
        //Abstraction provide relevant information(only functionality), realtime example a Car <- Car name, color, steering, brakes, gear etc, unecessary Engine, Exhaust System, Silencer etc.
        //Abstraction can be achieved using Abstract Class, Abstract methods and interfaces as well.
        class AbstractClass
        {
            public double GrossPay;
            double TaxDeduction = 0.1;
            double NetSalary;

            public AbstractClass(double EgrossPay)
            {
                GrossPay = EgrossPay;
            }

            void CalculateSalary()//Here performed Encapsulation(by hidding unecessary function)
            {
                if (GrossPay >= 30000)
                {
                    NetSalary = GrossPay - (TaxDeduction * GrossPay);
                    Console.WriteLine("Your Salary is : {0}", NetSalary);
                }
                else
                {
                    Console.WriteLine("Your Salary is : {0}", GrossPay);
                }
            }

            public void ShowEmployeeDetails()//Here performed Abstraction(by showing only functionality)
            {
                CalculateSalary();
            }
        }

        //(73)LAMBDA EXPRESSION IN C#
        //It is also worked as a Anonymous function
        //Lambda expression is used for simplifing Anonymous function
        //In Anonymous fuction we have some use less things like delegate keyword and data type that we can remove using lambda expression(=>)
        //Lambda expression has two types statement lambda and expression lambda
        public delegate int Delegate(int num);

        //(72)ANONYMOUS FUNCTION - ANONYMOUS METHOD IN C#
        //Anonymous function used with delegate and created with delegate keyword and used for storing Anonymous function result in delegate variable(mandatory)
        //as the name suggests, an anonymous method is a method without a name just a body
        //Anonymous Function same return type of delegate return type
        //No use of Access Specifiers with Anonymous Function, Anonymous Function is not a static or instance because created outside of class
        //Anonymous advantage is lesser typing work because don't req access modifier, return type, name of function
        //Anonymous function used where code volume is less
        //Anonymous disadvantage is can't use jump statements and ref and out parameters
        //Anonymous function can be passed as a parameter
        //Anonymous function can be used as a event handler(means on button click call Anonymous function)
        public delegate int MyDelegate(int num);
        public delegate void MyDelegatenew(int num);
        class AnonymousClass
        {
            public static void MyMethod(MyDelegatenew del, int ab) //Here MyDelegate delegate del parameter expected a method as a reference that is an Anonymous method
            {
                ab += 10;
                del(ab);
            }
        }


        //(68,69,70,71)DELEGATES/SINGLE CAST DELEGATES/MULTIPLE DELEGATES/MULTI CAST DELEGATES IN C# PROGRAMMING
        //Delegate used for calling function by indirect way means by Delegate not directly call simple because delegate is an reference type
        //using single name of delegate we can call multiple methods only required same defination of all methods by delegate defination simple
        //Delegate is a tool that use for communicate between two peopels simple in realtime example
        //Delegate is a type which holds a method's reference in an object simple, it's also called function pointer in programming example.
        //Delegate is Encapsulate also the method
        //When a delegate is wrapped with more than one method that is known as a multicast delegate.

        public delegate void Calculation(int a, int b);////MULTIPLE DELEGATES(Means we can use mutiple delegates in a program)
        public delegate void ShowDelegate();

        class DelegateClass
        {
            public static void Addition(int a, int b)
            {
                int result = a + b;
                Console.WriteLine("Addition result is: {0}", result);
            }

            public void Subtraction(int a, int b)
            {
                int result = a - b;
                Console.WriteLine("Subtraction result is: {0}", result);
            }

            public static void Show()
            {
                Console.WriteLine("This is a show method !!");
            }
        }


        //(67)INDEXERS IN C# PROGRAMMING
        //Class members bydefault private
        //indexer tab-2 shorcut for making indexer
        //Our indexer has no name so class object is work as a indexer simply
        //Indexer is a special type of property which can use for get and set and acts like an array
        //Indexer must have a single parameter, othervise compiler generate a compilation error
        //Indexer can be overrided by different arguments
        class IndexerClass
        {
            private int[] Age = new int[3];
            public int this[int index]//int index(index number stored here)
            {
                set
                {
                    if (index >= 0 && index < Age.Length)
                    {
                        if (value > 0)
                        {
                            Age[index] = value;
                        }
                        else
                        {
                            Console.WriteLine("Value is invalid !!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid index !!");
                    }
                }
                get
                {
                    return Age[index];
                }
            }
        }

        //(66)SEALED METHOD IN C# PROGRAMMING
        //Sealed methods is used in method overriding concept only simply
        //we can sealed our perticular variable, property or event etc. for prevent from inheritence simply
        class Sealed
        {
            public virtual void Show()
            {
                Console.WriteLine("This is the method of Sealed class !!");
            }
        }

        class ChildSealed : Sealed
        {//sealed keyword always use with the override keyword because we can't make sealed a normal method simply
            public sealed override void Show() //Sealed methods can't be override again by restriction of sealed keyword because its occures error of seled keyword simply
            {
                Console.WriteLine("This is the method of child Sealed class !!");
            }
        }

        //class Child2Sealed : ChildSealed
        //{
        //    public override void Show()
        //    {
        //        Console.WriteLine("This is the method of child 2 Sealed class !!");
        //    }
        //}

        //(65)SEALED CLASS IN C# PROGRAMMING
        //A sealed class that prevent inheritence
        //Sealed class Purpose is for preventing data of the class which one is confidential, we don't want to alterness in it by others simply
        sealed class SealedClass //Now we can't make a child class of this class because it is sealed know or can't be parent also
        {
            public void Show()
            {
                Console.WriteLine("This is a method of Sealed class !!");
            }
        }

        //class SealedChild : SealedClass
        //{
        //    public void Show()
        //    {
        //        Console.WriteLine("This is a method of child Sealed class !!");
        //    }
        //}

        //(64)DIFFERENCE BETWEEN METHOD HIDING AND METHOD OVERRIDING IN C#
        //In Method Hiding, A Base Class reference variable pointing to a child class object, will invoke the method of the base class.
        //In Method Overriding, A Base Class reference variable pointing to a child class object, but will invoke the Overridden method of the child class(means parent method simple).


        //(63)METHOD OVERRIDING (RUN TIME POLYMORPHISM) IN C#
        //Virtual keyword gives permition to child class by base class for implimentation giving by child class using override keyword simple
        //It is used to achieve runtime polymorphism for performing different tasks
        //Virtual Keyword make method to virtual(means implimentation of method's body gayab ho jana) and say to child class for implimentation providing by override keyword of child class simple
        //Note:- Method Overriding simply means overriding the base class method by child class for providing different implimentation by child class simple
        class parent
        {
            public virtual void Show()
            {
                Console.WriteLine("This is a method of parent class !!");
            }
        }
        class child : parent
        {
            public override void Show()
            {
                //base.Show();//For calling base member using virtual and override
                Console.WriteLine("This is a method of child class !!");
            }
        }


        //(62)METHOD HIDING IN INHERITANCE IN C#
        //Method hiding occurs in inheritence relationship when base class and derives class both have a method with same name and same signature.
        //Use new keyword for using method hiding by default by user for removing green error of warning simple
        //Different ways to call a hidden base class member from derived class :- using base keyword(base keyword use for calling the base class members simple), cast child to parent type and invoke the hidden member of base class, 
        class Parent
        {
            public void Show()
            {
                Console.WriteLine("Parent class method !!");
            }
        }

        class Child : Parent//Child class also known by name of Derived class
        {
            public new void Show()
            {
                base.Show();
                Console.WriteLine("Child class method !!");
            }
        }

        //(61)OPERATOR OVERLOADING IN C#
        //This concept resides in Polymorphism.
        //There are two types of polymorphism
        //- Static Polymorphism(compile time polymorphism) :- Method Overloading, Operator Overloading
        //- Dynamic polymorphism(run time polymorphism) :- Method Overriding
        //Operator Overloading:-
        //The concept of overloading a function can also be applied to operators.
        //Operator overloading gives the ability to use the same operator to do various operations.
        //Using Operator overloading we can enhence the capability of the operators in C# using user-define data-types
        //Only the predefine set of C# operators can be overloaded.
        //Operators considered as a functions internal to the compiler, because compiler read our operator internally as a function.

        class OperatorOverloading
        {
            public string str;
            public int num;
            public float pointnum;

            //For Operators Overloading mandatory use of function
            public static OperatorOverloading operator +(OperatorOverloading obj1, OperatorOverloading obj2)//The function of the perticular operator like +,- etc is declared by using the operator keyword.
            {
                OperatorOverloading obj3 = new OperatorOverloading();
                obj3.str = obj1.str + " " + obj2.str;
                obj3.num = obj1.num + obj2.num;
                obj3.pointnum = obj1.pointnum + obj2.pointnum;
                return obj3;
            }
        }

        //(60)POLYMORPHISM AND METHOD OVERLOADING IN C#
        class MethodOverloading
        {//Method Overloading performed here by different data types/Signatures, we can make more Methods like this using float, bool etc data types
            public void Add()
            {
                int a = 20, b = 30, c = a + b;
                Console.WriteLine(c);
            }

            public void Add(int a, int b)
            {
                int c = a + b;
                Console.WriteLine(c);
            }

            public void Add(string a, string b)
            {
                string c = a + " " + b;
                Console.WriteLine(c);
            }
        }

        //(59)STATIC PROPERTIES IN C#
        class University
        {
            private static string universityName;

            public static string _universityName
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("you cannot enter null or empty value in University Name !!");
                    }
                    else
                    {
                        universityName = value;
                    }
                }
                get
                {
                    return universityName;
                }
            }
        }
        //(58)PROPERTIES WITH GET AND SET IN C#
        class Students
        {
            private int _StdId;
            private string _Name;
            private int _SubjectTotalMarks = 100; //Its only read only property maked because already setted simple
            public string FirstName { get; private set; }//This is Autoimplimented properties in this properties auto set ang get functionality we can't required to manully assign simple

            public int StdId//Only Property accessible, this property set only so we can't get it by this property our table id is secured know simple
            {
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Id cannot be zero or negative");
                    }
                    else
                    {
                        _StdId = value;
                    }
                }
            }

            public string Name
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Please Enter Your Name !!");
                    }
                    else
                    {
                        _Name = value;
                    }
                }
                get
                {
                    return _Name;
                }
            }

            public int SubjectTotalMarks //this is read only property so, know we can't set value in _SubjectTotalMarks variable simple
            {
                get
                {
                    return _SubjectTotalMarks;
                }
            }

            public Students(string fname)
            {
                FirstName = fname;
            }
        }

        //(57)ENCAPSULATION IN C#
        public class Encapsulation
        {
            private string StudentName;
            private int StudentAge;

            public void SetName(string Name)
            {
                if (string.IsNullOrEmpty(Name) == true)
                {
                    Console.WriteLine("Name is required !!");
                }
                else
                {
                    StudentName = Name;
                }
            }

            public void GetName()//Here Encapsulation accessed by Method
            {
                if (string.IsNullOrEmpty(StudentName) == true)
                {
                    //Console.WriteLine("Name is required !!");//Name validate upper already so no required to revaliate here, but condition is require here because for checking data is valid or not which is stored in private variables on getting time, so applied here simple, if invalid then else part not run bydefault everytime
                }
                else
                {
                    Console.WriteLine("You name is : " + StudentName);
                }
            }

            public int Age//Here Encapsulation accessed by Property
            {
                get
                {
                    return StudentAge;
                }
                set
                {
                    StudentAge = value;
                }
            }
        }

        //(56)(PART-2 ) ACCESS SPECIFIERS - PUBLIC - PRIVATE - PROTECTED - INTERNAL IN C#
        public class Class3
        {
            private void Show1()//Private Method accessible in only same class
            {
                Console.WriteLine("This is a private method !!");
            }
        }

        public class Class4
        {
            protected void Show1()//Protected Method accessible in same class and inherit class also
            {
                Console.WriteLine("This is a private method !!");
            }
        }

        //public class Class5 : Class4
        //{
        //    static void Main(string[] args)
        //    {
        //        Class5 c5 = new Class5();
        //        c5.Show1();
        //    }
        //}


        //(55)( PART-1 ) ACCESS SPECIFIERS - PUBLIC - PRIVATE - PROTECTED - INTERNAL IN C#
        public class Class1
        {
            public void Show1()
            {
                Console.WriteLine("This is a public method !!");
            }
        }

        class Class2 : Class1
        {
            //static void Main(string[] args)
            //{
            //    Class1 c1 = new Class1();
            //    c1.Show1();
            //    Class2 c2 = new Class2();
            //    c2.Show1();

            //    Console.ReadLine();
            //}
        }


        ////(54)CONSTRUCTOR IN INHERTANCE IN C# PROGRAMMING
        //class Base
        //{
        //    public Base(string message)//here base keyword value print by assigning the value by base keyword
        //    {
        //        Console.WriteLine(message);
        //    }
        //}
        //class Derived : Base
        //{
        //    public Derived() : base("This is Constructor of Base Class !!")//this base keyword is call/priority to Base Class, this is pre assigned by Compilor, no required to assign manually by user
        //    {
        //        Console.WriteLine("This is Constructor of Derived Class !!");
        //    }
        //}


        //(52,53)TYPES OF INHERITANCE - SINGLE - HIERARCHICAL - MULTILEVEL AND MULTIPLE IN C#
        //In Single Inheritence single base class is inherited from child class
        //In Hierarchical inheritence multiple base classes is inherited from child class, means 1 se jyada bacche hain
        //In Multilevel inheritence a compleate generation like child, parent and then its parent(grandfather)
        class BaseClass
        {
            public void Show1()
            {
                Console.WriteLine("This is method of base class !!");
            }
        }

        class DrivedClass1 : BaseClass //Single Inheritence//DrivedClass1 is now child class of BaseClass class by inheritence
        {
            public void Show2()
            {
                Console.WriteLine("This is method of Drived1 class !!");
            }
        }

        class DrivedClass2 : BaseClass //Hierarchical Inheritence //DrivedClass2(Intermediate Class)
        {
            public void Show3()
            {
                Console.WriteLine("This is method of Drived2 class !!");
            }
        }

        class DrivedClass3 : DrivedClass1 //Multilevel Inheritence
        {
            public void Show4()
            {
                Console.WriteLine("This is method of Drived3 class !!");
            }
        }

        //(51)DESTRUCTORS IN C# PROGRAMMING
        class person
        {
            public string Name = "Gulshan Kumar";
            public void GetName()
            {
                Console.WriteLine("My Name is : {0}", Name);
            }
            ~person()//this destructor here free/deallocate memory of all objects of class after compleating work simple
            {
                Console.WriteLine("Destructor has been inviked !!");
            }
            //Console.ReadLine() hold destructor freeing after enter destructor run simple
        }


        //(50)STATIC CLASS IN C# PROGRAMMING
        static class Product
        {
            public static int Age;

            static Product()
            {
                Age = 11;
            }

            //public void GetProductdDetails() //Can not declare instance member in a static class
            //{
            //    Console.WriteLine("My Age is : {0}", Age);
            //}
            public static void GetProductDetails()
            {
                Console.WriteLine("My Age is : " + Age);
            }
        }


        //class Item : Product//using static class we can't drive/child class


        //(49)PRIVATE CONSTRUCTOR IN C#
        class ConstructorPrivate
        {
            public string name;

            private ConstructorPrivate() //in this class we have only static members only so, now we don't need instance of class so, we use here Private Constructor simply, because if any create an object of class then he can't
            {
                Console.WriteLine("My Name is : {0}", name);
            }

            public static void getTime()
            {
                Console.WriteLine(DateTime.Now);
            }
        }

        //class ConstructorPrivate1 : ConstructorPrivate { }//which class have Private Constructor that class can't make a child class


        //Predefined C# Constructor example with value printing here
        class ConstructorDefault
        {
            public string Name;
            public int age;
        }

        //(48)COPY CONSTRUCTOR IN C#
        //Copy Constructor basic use is copy a object to in a another object simple
        class ConstructorClass
        {
            string Name;
            int age;
            public ConstructorClass(string Name, int age)
            {
                this.Name = Name;//this keyword represent current class variable
                this.age = age;
            }

            public ConstructorClass(ConstructorClass e)
            {
                Name = e.Name;
                age = e.age;
            }

            public void GetData()
            {
                Console.WriteLine("My Name is : {0}", Name);
                Console.WriteLine("My Age is : {0}", age);
            }
        }

        //(47)STATIC CONSTRUCTOR IN C#
        //In instance method we can use static and instance both members but in static we can't
        class Person
        {
            public static string PersonName;
            public static int PersonAge;

            public Person()//Instance fields represent the data of a class that enables an object to maintain its state.
            {
                Console.WriteLine("Default constructor invoked !!");
            }

            static Person()
            {
                PersonName = "Gulshan";
                PersonAge = 46;
                Console.WriteLine("Static constructor invoked !!");
            }

            public void GetDeatils()
            {
                Console.WriteLine("Person name is : {0}", PersonName);
                Console.WriteLine("Person age is : {0}", PersonAge);
            }
        }

        //(46)STATIC AND INSTANCE MEMBERS OF CLASS IN C#
        //INSTANCE MEMBERS Notes:-
        //each Instance member of class have a seprate single copy
        //All instance members belongs to the class
        //when no static keyword is pre assigned with member of class then its said non-static or instance members of class
        //What is the meaning of object in class in c#?
        //- An object is basically a block of memory that has been allocated and configured according to the blueprint of class
        //What is the difference between object and instance of class in c#?
        //- Object is an instance of a class. All data members and member functions of the class can be accessed with the help of
        //objects. When a class is defined, no memory is allocated, but memory is allocated when it is instantiated (i.e. an object is created).

        //STATIC MEMBERS Notes:-
        //Static Member belongs to the class
        //Static functions have only static members because instance members required object
        //Static members only works with static members and instance works with object simple
        //Static Constructor and default Constructor can't required to call auto called

        class StaticStudent
        {
            //int rollno; //this is predefine private instance so, for using out of the body of class please use public
            public int roll;
            public string firstname;
            public string lastname;
            public static string schoolName = "SVKE";//static means fixed value for all objects, because its not depended on object its depended on class simple
            static int fees = 5000;

            public void printFullName() //instance methods of class only when called when we call it from instance of class otherwise its not called/run because permition issue of class member
            {
                string fullname = firstname + " " + lastname;
                Console.WriteLine("My full name is : {0}", fullname);
            }

            public static int getFees()
            {
                return fees;
            }
        }

        //(45)CONSTRUCTOR OVERLOADING IN C# PROGRAMMING
        class ConstructorOverloading
        {
            public ConstructorOverloading()
            {
                Console.WriteLine("this is a first constructor !!");
            }

            public ConstructorOverloading(int a)
            {
                Console.WriteLine("this is a Second Constructr !! {0}", a);
            }

            public ConstructorOverloading(int a, int b)
            {
                Console.WriteLine("this is a Third Constructr !! {0}", a + b);
            }

            public ConstructorOverloading(int a, int b, int c)
            {
                Console.WriteLine("this is Fourth Constructor !! {0}", a + b + c);
            }

            public ConstructorOverloading(string a, string b, string c)
            {
                Console.WriteLine("this is Fourth Constructor !! {0}", a + b + c);
            }
        }

        //(44)WHAT IS CONSTRUCTOR IN C# PROGRAMMING
        Program()
        {
            Console.WriteLine("Parameterless Constructor !!");
        }

        static Program()//A constructor without any parameters is called a default constructor, run with every object of class
        {
            Console.WriteLine("Default Constructor !!");
        }

        Program(Program co)//Constructor Overloading making here using by different arguments/signature/parameters
        {
            nam = co.nam;
        }


        string nam;
        Program(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum is of a & b: " + sum);
        }

        Program(string name)
        {
            nam = name; // here set our field nam value for using in copy constructor
            string lastname = "Kumar";
            Console.WriteLine("Name of Employee is: " + name + " " + "{0}", lastname);
        }

        //(43)CLASSES AND OBJECTS IN C# PROGRAMMING
        //Class is used as a template for declaring and creating the objects. An object is an instance of a class.
        //An instance field, in C#, is a variable of any type contained within a class or struct, and is used to store
        //object data. It is a member of its containing type with one copy of the field for each instance of the containing type.        
        class Student//Class
        {
            public string name = "Gulshan";
            public int age = 28;
        }

        //(42)VAR AND DYNAMIC KEYWORD IN C#
        //public static var Shows(var a)//var can't use as a return type or as a parameter function
        //{
        //    return 0;
        //}

        public static dynamic shows(dynamic a)
        {
            //Console.WriteLine(a);
            return a;
        }

        //(41)PASS BY VALUE AND PASS BY REFERENCE (REF AND OUT KEYWORDS) IN C#
        public static void PassByValue(int a)
        {
            a = a + 30;
            Console.WriteLine("Value is {0}", a);
        }
        public static void PassByRef(ref int a)
        {
            a = a + 10;
            Console.WriteLine("Value is {0}", a);
        }

        //(40)VALUE TYPE AND REFERENCE TYPE (STACK AND HEAP) IN C# PROGRAMMING
        struct Employee
        {
            public int Salary;
            public int Age;
        }

        public class class1
        {
            public void Show1()
            {
                Console.WriteLine("This is a public method.. !!");
            }
        }

        //(39)CREATING CALCULATOR APPLICATION IN C#
        public static void Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("Addition result is : " + sum);
        }
        public static void Subtraction(int num1, int num2)
        {
            int sum = num1 - num2;
            Console.WriteLine("Subtraction result is : " + sum);
        }
        public static void Multiplication(int num1, int num2)
        {
            int sum = num1 * num2;
            Console.WriteLine("Multiplication result is : " + sum);
        }
        public static void Division(int num1, int num2)
        {
            int sum = num1 / num2;
            Console.WriteLine("Division result is : " + sum);
        }

        public const double PI = 3.14;
        //(38)( PART-2 ) METHODS OR FUNCTIONS IN C# PROGRAMMING
        public static void Show_Name_Age(string name, int age)
        {
            Console.WriteLine("My name and age is : " + name + " " + age);
        }

        public static int Add(int num1, int num2)
        {
            int s = num1 + num2;
            return s;
        }

        //(37)( PART-1 ) METHODS OR FUNCTIONS IN C# PROGRAMMING
        //Methods and Functions are same in C#, Methods we create always in our class
        //Which Methods we created in our class that methods are called user define methods
        public void Show()//(public)Access Specifier,(void)no return type,(show)method name, and parameters thats declared in parentheses of methods <- called method's signature
                          //non-static/instance method in C# <- for this type of member calling always make an object of your class, by calling by its name
        {
            Console.WriteLine("Welcome to in C# !!");
        }

        public static void Show1(int a = 5, int b = 8)//static with parameterized method, these parameters have default/optional values but when we assign values in parameters then these values are replaced by user defined values, also called default/optional parameters
        {
            int sum = a + b;
            Console.WriteLine("Addition result is : " + sum);
        }

        public static void PassByOut(out int a)
        {
            a = 7;
            Console.WriteLine("Value is {0}", a);
        }
    }
}
