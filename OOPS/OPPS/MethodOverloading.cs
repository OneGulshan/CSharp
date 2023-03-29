namespace OOPS
{
    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        
        public int Add(int x, int y, int z)
        {            
            return x + y + z;
        }
        
        public float Add(float x, float y)
        {            
            return x + y;
        }

        public float Add(float x, float y, float z)
        {            
            return x + y + z;
        }
    }


    class calculatorDemo
    {
        //static void Main(string[] arg)
        //{
        //    Calculator calculator = new Calculator();
        //    int a = calculator.Add(13, 12);
        //    int b = calculator.Add(12, 10, 13);
        //    float c = calculator.Add(15.7f, 15.3f);
        //    float d = calculator.Add(11.2f, 19.3f, 12.5f);

        //    Console.WriteLine("Total of a is : {0}", a);
        //    Console.WriteLine("Total of b is : {0}", b);
        //    Console.WriteLine("Total of c is : {0}", c);
        //    Console.WriteLine("Total of d is : {0}", d);

        //    Console.ReadLine();
        //}
    }
}




//namespace OOPS
//{
    //class Animals
    //{
    //    public virtual void animalSound()
    //    {
    //        Console.WriteLine("Animal Sounds !!");
    //    }

    //    public virtual void animalSound(bool a)
    //    {
    //        Console.WriteLine("Animal Sounds !!");
    //    }

    //    public virtual void animalSound(int a, char b)
    //    {
    //        Console.WriteLine("Animal Sounds !!");
    //    }
    //}

    //class Cat : Animals
    //{
    //    public override void animalSound()
    //    {
    //        Console.WriteLine("Do Say's : meows meows..");
    //    }
    //}

    //class Pig : Animals
    //{
    //    public override void animalSound()
    //    {
    //        Console.WriteLine("Pig Say's : wee wee..");
    //    }
    //}    

    ////--------------------------------------------------------

    //class Sum
    //{
    //    public int Add(int a, int b)
    //    {
    //        int sum = a + b;
    //        return sum;
    //    }

    //    public int Add(int a, int b, int c)
    //    {
    //        int sum = a + b + c;
    //        return sum;
    //    }

    //    public double Add(double a, double b, double c)
    //    {
    //        double sum = a + b + c;
    //        return sum;
    //    }
    //}


    //class CallPolymorphism
    //{
    //    static void Main(string[] args)
    //    {
    //        Animals pol = new Animals();
    //        Animals pol2 = new Cat();
    //        Animals pol3 = new Pig();
    //        pol.animalSound();
    //        pol2.animalSound();
    //        pol3.animalSound();
    //        Console.WriteLine();

    //        //-------------------------------------------------------

    //        Sum s = new Sum();
    //        Console.WriteLine("Enter the First & Second Integer Number !!");
    //        int sum1 = s.Add(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
    //        Console.WriteLine("The total of two numbers is : {0}", sum1);

    //        Console.WriteLine("Enter the First, Second & Third Integer Number !!");
    //        int sum2 = s.Add(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
    //        Console.WriteLine("The total of Three integer numbers is : {0}", sum2);

    //        Console.WriteLine("Enter the First, Second & Third Double Number !!");
    //        double sum3 = s.Add(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
    //        Console.WriteLine("The total of the Three double number is : {0}", sum3);

    //        Console.ReadLine();
    //    }
    //}
//}


