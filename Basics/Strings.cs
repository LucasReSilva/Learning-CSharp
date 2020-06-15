using System;

namespace Learning_CSharp
{
    class Strings
    {
        static Strings()
        {
            string emptyString = String.Empty;
            string anotherEmptyString = "";

            string firstName = "Lucas";
            string lastName = "Silva";
            string fullName = firstName + " " + lastName;

            string sentence = "I like to play ";
            sentence += "chess.";
            Console.WriteLine(sentence);

            // ToString function
            int integer = 1;
            string ourString = "Something to be replaced by an int";
            ourString = integer.ToString();
            System.Console.WriteLine(ourString);

            // String formatting
            int x = 1, y = 2;
            int sum = x + y;
            string sumCalculation = String.Format("{0} + {1} = {2}", x, y, sum);
            Console.WriteLine(sumCalculation);

            // Substring
            string fullString = "full string";
            string partOfString = fullString.Substring(5);
            string shorterPart = fullString.Substring(5, 3);
            Console.WriteLine(partOfString);
            Console.WriteLine(shorterPart);

            // Search and replace
            string name = "Lucas Renato";
            string newName = name.Replace("Renato", "Silva");
            Console.WriteLine(newName);

            // Index of
            string fruit = "apple,orange,banana";
            Console.WriteLine("Found orange in position: " + fruit.IndexOf("orange"));
            Console.WriteLine("Found lemon in position: " + fruit.IndexOf("lemon"));
        }
    }
}