using System;
using System.Collections.Generic;

namespace Learning_CSharp
{
    class Dictionaries
    {
        static Dictionary<string, long> phonebook = new Dictionary<string, long>();
        static Dictionaries()
        {
            phonebook.Add("Alex", 415434543);
            phonebook["Jessica"] = 415984588;
        }

        public static void add()
        {
            if (phonebook.ContainsKey("Alex"))
            {
                Console.WriteLine("Alex's number is " + phonebook["Alex"]);
            }
        }

        public static void remove()
        {
            phonebook.Remove("Jessica");
            Console.WriteLine(phonebook.Count);
        }
    }
}