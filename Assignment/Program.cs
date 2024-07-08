namespace Assignment
{
    #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
    //enum WeekDays
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday,
    //}
    #endregion

    #region 3.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

    //enum Season
    //{
    //    spring,
    //    summer,
    //    autumn,
    //    winter
    //}

    #endregion

    #region 4.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

    //[Flags]  
    //enum Permission : Byte
    //{
    //    Write = 1, Read = 2, Execute = 4, Delete = 8
    //}

    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public decimal Salary { get; set; }
    //    public Permission Permission { get; set; }
    //}

    #endregion

    #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

    //enum primaryColors
    //{
    //    red,
    //    green,
    //    blue
    //}

    #endregion

    internal class Program
    {

        static void Main(string[] args)
        {
            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person person = new Person(3);

            //person.AddPerson(0, "Mina", 20);
            //person.AddPerson(1, "Hany", 25);
            //person.AddPerson(2, "Foad", 30);



            //for (int i = 0; i < person.Size; i++)
            //{
            //    Console.WriteLine(person[i]);
            //}

            #endregion

            #region 3.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.Write("Please Enter a season: ");


            //if(Enum.TryParse(Console.ReadLine(),true, out Season season))
            //{
            //    switch(season)
            //    {
            //        case Season.spring:
            //            Console.WriteLine("Spring is From March to May");
            //            break;
            //        case Season.summer:
            //            Console.WriteLine("Summer is From June to August");
            //            break;
            //        case Season.autumn:
            //            Console.WriteLine("Autumn is From September to November ");
            //            break;
            //        case Season.winter:
            //            Console.WriteLine("Winter is From December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Input");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion

            #region 4.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

            //Employee employee = new Employee();

            //employee.Id = 101;
            //employee.Name = "Mina hany";
            //employee.Salary = 5_000;
            //employee.Permission = (Permission)7;

            //Permission MyP = (Permission)3;

            //MyP = MyP | Permission.Execute;  

            //MyP &= ~(Permission.Read);  

            //MyP ^= Permission.Delete;   
            //MyP ^= Permission.Delete;   

            //Console.WriteLine(MyP);


            #endregion

            #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.Write("Enter any Color: ");

            //if(Enum.TryParse(Console.ReadLine(),true, out primaryColors color))
            //{
            //    Console.WriteLine($"{color} is a Primry Color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{color} is not a primary Color.");
            //}


            #endregion

            #region 6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.


            //Console.Write("Enter Point 1: ");
            //int P1 = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Enter Point 2: ");
            //int P2 = int.Parse(Console.ReadLine() ?? "0");

            //Point point = new Point(P1, P2);

            //Console.WriteLine(P1);

            #endregion

            #region 7.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person person = new Person(3);

            //person.AddPerson(0, "Mina", 65);
            //person.AddPerson(1, "Hany", 45);
            //person.AddPerson(2, "Foad", 70);



            //string oldestPersonDetails = person.GetOldestPerson();
            //Console.WriteLine(oldestPersonDetails);

            #endregion

        }
    }
}
