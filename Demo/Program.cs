
using Common;

namespace Demo
{
    class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }

    }

    enum Grade
    {
        // labels
        A, B, C, D, E, F
    }
    enum Gender
    {
        Male=1,
        Female=2
    }

    enum Branch : byte
    {
        Dokki = 202, NasrCity, Maadi = 252, Alex, SmartVillage, BNS
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modefiers
            //TypeA obj = new TypeA();

            ////obj.x = 10; // invalid due to protection level (x is private)

            ////obj.y = 10; // invalid due to protection level (x is internal)

            //obj.z = 1;   // valid 
            #endregion

            #region Example 01
            //Person person = new Person();
            //person.Gender = Gender.Male;

            //Gender X = Gender.Male;

            ///Grade grade = Grade.A;
            ///if(grade == Grade.A)
            ///    Console.WriteLine(":)");
            ///else
            ///    Console.WriteLine(":("); 
            #endregion

            #region Example 02
            //Gender myGender;

            //Console.Write("Please Enter your Gender : ");

            #region Parse Method
            ////myGender = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine() ?? "");  //Boxing and unboxing
            //myGender = Enum.Parse<Gender>(Console.ReadLine() ?? "",true); 
            #endregion

            #region Try Parse Method
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object? obj);

            //myGender = (Gender?) obj;

            //Enum.TryParse<Gender>(Console.ReadLine(), out myGender);

            //Console.WriteLine(myGender); 
            #endregion

            #endregion


            Point P1;
            // Declare for Object of type Point
            // CLR will allocate 8 Unintialized Bytes in The STACK 

            P1 = new Point();
            // P1 = new ();   // Syntax Sugar
            // new --> is just for constructor selection that
            // will intialize the attributes 

            P1 = new Point();

            //Console.WriteLine(P1.x);
            //Console.WriteLine(P1.y);

            Console.WriteLine(P1.ToString());
        }
    }
}
