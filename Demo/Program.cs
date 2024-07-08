
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
        Male = 1,
        Female = 2
    }

    enum Branch : byte
    {
        Dokki = 202, NasrCity, Maadi = 252, Alex, SmartVillage, BNS
    }

    [Flags]  // Attribute
    enum Permission : Byte
    {
        Write = 1, Read = 2, Execute = 4, Delete = 8
    }

    class Employee02
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Permission Permission { get; set; }
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


            //Point P1;
            // Declare for Object of type Point
            // CLR will allocate 8 Unintialized Bytes in The STACK 

            //P1 = new Point();
            // P1 = new ();   // Syntax Sugar
            // new --> is just for constructor selection that
            // will intialize the attributes 

            //P1 = new Point();

            //Console.WriteLine(P1.x);
            //Console.WriteLine(P1.y);

            //Console.WriteLine(P1.ToString());

            //Employee employee = new Employee(10, "Mina", 5_000);

            //employee.Id = 20;  // SET Id directly throw the attribute

            //Console.WriteLine(employee.Id);   // GET Id directly throw the attribute



            //employee.SetName("MinaHanyFoad");                // SET Name using the setter Function
            //Console.WriteLine(employee.GetName()); ; // GET Name using getter Function


            //employee.Salary = 10_000;
            //Console.WriteLine(employee.Salary);


            PhoneBook Notebook = new PhoneBook(3);
            Notebook.AddPerson(0, "Mina", 123);
            Notebook.AddPerson(1, "Ahmed", 456);
            Notebook.AddPerson(2, "Aya", 782);

            //Notebook.SetNumber("Aya", 999);   // SET using Setter Method
            //Console.WriteLine(Notebook.GetNumber("Aya")); // GET using Getter Method

            //using Indexer
            Notebook["Aya"] = 888;

            //Console.WriteLine(Notebook["Aya"]);

            //for (int i = 0; i < Notebook.Size; i++)
            //{
            //    Console.WriteLine(Notebook[i]);
            //}

            Employee02 employee = new Employee02();

            employee.Id = 101;
            employee.Name = "Mina hany";
            employee.Salary = 5_000;
            employee.Permission = (Permission)7;

            Permission MyP = (Permission)3;

            MyP = MyP | Permission.Execute;   // Add

            MyP &= ~(Permission.Read);  // Remove

            MyP ^=Permission.Delete;   // Toggle (if not found , Add it)
            MyP ^=Permission.Delete;   // Toggle (if found , Remove it)

            Console.WriteLine(MyP);

            //Console.WriteLine(employee.Permission);
        }
    }
}
