
using Common;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeA obj = new TypeA();

            //obj.x = 10; // invalid due to protection level (x is private)

            //obj.y = 10; // invalid due to protection level (x is internal)

            obj.z = 1;   // valid

        }
    }
}
