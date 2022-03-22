using System;
using System.Text;

namespace StringMerge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Merge(out name);

            foreach (var letter in name)
            {
                Console.Write(letter);
            }

        }
        static string Merge(out string name)
        {
            name = "Hikmet Abbasov Abdullah oglu";

            StringBuilder result = new StringBuilder();

            string[] Split = name.Split(" ");

            for (int i = 0; i < Split.Length; i++)
            {
                 result.Append(Split[i]);
            }

            name = result.ToString();

            return name;

        }
        
    }
}
