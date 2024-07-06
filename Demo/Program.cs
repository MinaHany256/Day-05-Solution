
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
        Male,
        Female
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



        }
    }
}
