using System;
using System.Collections.Generic;

namespace Learning_CSharp
{
    class Lists
    {
        static List<int> numbers = new List<int>();

        public static void add()
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            Console.WriteLine(numbers);

            int[] array = new int[] { 1, 2, 3 };
            numbers.AddRange(array);
            Console.WriteLine(numbers);
        }

        static List<string> fruits = new List<string>();
        public static void remove()
        {
            // add fruits
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("orange");
            Console.WriteLine(fruits.Count);

            // now remove the banana
            fruits.Remove("banana");
            Console.WriteLine(fruits.Count);

            // now remove the orange
            fruits.RemoveAt(1);
            Console.WriteLine(fruits.Count);
        }

        public static void concat()
        {
            List<string> food = new List<string>();
            food.Add("apple");
            food.Add("banana");

            List<string> vegetables = new List<string>();
            vegetables.Add("tomato");
            vegetables.Add("carrot");

            food.AddRange(vegetables);
            Console.WriteLine(food);
        }
    }
}