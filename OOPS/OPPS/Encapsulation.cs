namespace OOPS
{
    public class Encapsulation
    {
        private string studentName;
        private int studentAge;

        public string Name
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }

        public int Age
        {
            get
            {
                return studentAge;
            }
            set
            {
                studentAge = value;
            }
        }
    }
}


class Programe
{
    //static void Main()
    //{
    //    Encapsulation obj = new Encapsulation();
    //    obj.Name = "Gulshan";
    //    obj.Age = 28;

    //    Console.WriteLine("Name: " + obj.Name);
    //    Console.WriteLine("Age: " + obj.Age);
    //}
}

//Encapsulation wrapping data in a class(single unit) for hidding data from other class and member function of
//own class in which they are declared.
//As in encapsulation, the data in a class is hidden from other classes, so it is also known as data-hiding.
//Encapsulation can be achieved by: Declaring all the variables in the class as private and using C# Properties
//in the class to set and get the values of variables.