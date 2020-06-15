using System;

namespace Learning_CSharp
{
    class Conditionals
    {
        public Conditionals()
        {
            int a = 4;
            bool b = a == 4;

            if ((a == 4) && !b)
                Console.WriteLine("Another line Wow!");
            else
                Console.WriteLine("Double rainbow!");

            if ((a == 4) || b)
            {
                Console.WriteLine("Another line Wow!");
            }
            else
            {
                Console.WriteLine("Double rainbow!");
            }
        }

        public bool Operators()
        {
            int a = 4;
            int b = 5;
            bool result;
            result = a < b; // true
            result = a > b; // false
            result = a <= 4; // a smaller or equal to 4 - true
            result = b >= 6; // b bigger or equal to 6 - false
            result = a == b; // a equal to b - false
            result = a != b; // a is not equal to b - true
            result = a > b || a < b; // Logical or - true
            result = 3 < a && a < 6; // Logical and - true
            result = !result; // Logical not - false

            return result;
        }
    }
}