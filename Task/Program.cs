namespace Task
{
    internal class Program
    {
        public static void PrintEmployees()
        {
            int Id;
            string Name;
            decimal Salary;
            Gender gender;

            do
            {
                Console.Write("Enter Your Id: ");
            }
            while (!int.TryParse(Console.ReadLine(), out Id));



            Console.Write("Enter Your Name: ");
            Name = Console.ReadLine() ?? "NoName";


            do
            {
                Console.Write("Enter Your Salary: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out Salary));

            do
            {
                Console.Write("Enter Your Gender: ");
            }
            while (!Enum.TryParse<Gender>(Console.ReadLine(), true, out gender));

            Employee employee = new Employee(Id, Name, Salary, gender);

            Console.WriteLine(employee);

        }

        static void Main(string[] args)
        {
            PrintEmployees();
        }
    }
}
