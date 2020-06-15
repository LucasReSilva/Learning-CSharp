using System;

namespace Learning_CSharp
{
    class Loops
    {
        static Loops()
        {
            // For
            for (int i = 0; i < 10; i++)
            {

            }

            for (int i = 0; i < 16; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                Console.WriteLine(i);

                if (i == 12)
                {
                    break;
                }
            }

            // While
            int n = 0;

            while (n == 0)
            {
                Console.WriteLine("N is 0");
                n++;
            }

            // Do while
            n = 0;

            do
            {
                Console.WriteLine("N is 0");
            } while (n != 0);
        }
    }
}