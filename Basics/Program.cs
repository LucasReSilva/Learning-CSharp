using System;

namespace Learning_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("// Hello World");
            Hello.helloworld();
            Hello.hello("Dev");

            Console.WriteLine("\n// Variables");
            Console.WriteLine(Variables.sum());

            Console.WriteLine("\n// Conditionals");
            Console.WriteLine(new Conditionals());

            Console.WriteLine("\n// Arrays");
            Console.WriteLine(Arrays.vector().ToString());
            Console.WriteLine(Arrays.matrix().ToString());

            Console.WriteLine("\n// Lists");
            Lists.add();
            Lists.remove();
            Lists.concat();

            Console.WriteLine("\n// Dictionaries");
            Dictionaries.add();
            Dictionaries.remove();

            new Strings();

            new Loops();

            Person ww = new Person("Heisenberg", 1993);
            ww.SayMyName();
            Console.WriteLine(ww.age);

        }
    }
}
