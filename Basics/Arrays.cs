using System;

namespace Learning_CSharp
{
    class Arrays
    {
        static int[] nums = { 1, 2, 3, 4, 5 };
        int[] numbers = new int[10];

        public static int[] vector()
        {

            int firstNumber = nums[0];
            int secondNumber = nums[1];
            nums[2] = 10;

            return nums;
        }

        static int[,] matrix2d = new int[2, 2];

        public static int[,] matrix()
        {
            matrix2d[0, 0] = 1;
            matrix2d[0, 1] = 2;
            matrix2d[1, 0] = 3;
            matrix2d[1, 1] = 4;

            int[,] predefinedMatrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            return matrix2d;
        }
    }
}