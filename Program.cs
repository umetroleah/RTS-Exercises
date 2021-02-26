using System;

namespace RTS_Exercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Exercise 1: Above and below in array
            Console.WriteLine("Enter array of ints, seperated by commas (no spaces): ");
            string arrAsString = Console.ReadLine();
            string[] intsAsStrings = arrAsString.Split(",");
            int[] intArr = new int[intsAsStrings.Length];
            for(int i = 0; i<intArr.Length; i++)
            {
                intArr[i] = Convert.ToInt32(intsAsStrings[i]);
            }

            Console.WriteLine("Enter number to check array with: ");
            int check = Convert.ToInt32(Console.ReadLine());
            AboveBelow(intArr, check);


            //Exercise 2: String rotation
            Console.WriteLine("Enter string you want to rotate: ");
            string stringToRotate = Console.ReadLine();
            Console.WriteLine("Enter amount to rotate it: ");
            int rotation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RotateString(stringToRotate, rotation));
        }

        public static void AboveBelow(int[] arr, int input)
        {
            int above = 0;
            int below = 0;
            //Check above and then below, adding counts as you do
            foreach (int num in arr)
            {
                if (num > input)
                    above++;
                if (num < input)
                    below++;
            }

            Console.WriteLine("above: " + above + ", below: " + below);
        }

        public static string RotateString(string input, int rotation)
        {
            //Rotation is equivalent to taking end of the string and putting at the front
            //Use a modulus based on string length to prevent index < 0 error while keeping a correct result
            string end = input.Substring(input.Length - rotation % input.Length);
            end = end + input.Substring(0, input.Length - rotation % input.Length);
            return end;
        }
    }
}
