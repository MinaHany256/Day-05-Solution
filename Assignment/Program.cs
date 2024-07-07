namespace Assignment
{
    internal class Program
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

        }
    }
}
