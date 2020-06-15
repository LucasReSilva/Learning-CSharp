using System;

namespace Learning_CSharp
{
    class Hello
    {
        public static void helloworld()
        {
            Console.WriteLine("Hello World!");
        }

        public static void hello(string name)
        {
            var date = DateTime.Now;

            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);

            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

            // String concatenation:
            Console.WriteLine("Hello, " + name + "! Today is " + date.DayOfWeek + ", it's " + (date.ToString("HH:mm")) +
            " now.");
        }
    }
}