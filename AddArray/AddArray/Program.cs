using System;
using System.Text;

namespace AddArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] exampleArray = { 1, 2 };

            NewElement(ref exampleArray,7);

            foreach (var element in exampleArray)
            {
                Console.WriteLine(element);
            }

            
        }

        static int[] NewElement(ref int[] array, int element)
        {
            int[] result = new int[array.Length + 1];

            for (int i = 0; i < result.Length; i++)
            {
                if (i < array.Length)
                {
                    result[i] = array[i];
                }
                else if (i == array.Length)
                {
                    result[i] = element;
                }
            }

            array = result;

            return array;
        }
    }       
}
