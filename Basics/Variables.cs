using System;

namespace Learning_CSharp
{
    enum Day { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
    public enum TrafficLight
    {
        Red = 1,
        Yellow = 2,
        Green = 3,
    }
    class Variables
    {
        // Typed variables
        int myInt = 1;
        float myFloat = 1f;
        bool myBoolean = true;
        string myName = "Lucas Silva";
        char myChar = 'a';
        double myDouble = 1.75;

        public static int sum()
        {
            // Type inference
            var x = 1;
            var y = 2;
            var sum = x + y;

            return sum;
        }
    }
}
