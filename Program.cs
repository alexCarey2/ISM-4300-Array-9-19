using System;

namespace _9_19_ISM_4300_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try statement to catch errors
           try
            {
                //Display message that states how many elements are in the array
                Console.WriteLine("This array is 25 elements:");
                Console.WriteLine("");
                //Assign array to 25 elements
                int[] alexandrasArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                
                //loop array
                foreach (int a in alexandrasArray)
                {
                    //Display text with each element in the array
                    Console.Write(" Element value = " + a );
                }
                Console.WriteLine("");
                //Prevent errors from crashing
            } catch
            {
                Console.WriteLine("There is an error");
            }




        }
    }
}
