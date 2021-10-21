using System;

namespace BoxingVsUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;  // "i" is a value type
            Console.WriteLine("\"i\" is a value type\n i={0}", i);

            object o = i; // boxing "i" into "o"
            Console.WriteLine("Boxing \"i\" into \"o\"\n o={0}", o);

            int j = (int)o; //unboxing "o" into "j"
            Console.WriteLine("Unboxing \"o\" into \"j\"\n j={0}", j);

            Console.ReadKey();
        }
    }
}
