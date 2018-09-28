/*
 * Write a function that accepts an integer, and returns that integer in Roman numerals (as a string).
 * Assume the number will be 0 < n < 40
 * ie: 4 should return "IV"
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_IntegerToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Enter an integer\n\n>>> ");
                    int input = int.Parse(Console.ReadLine().Trim());
                    Console.WriteLine(IntToRomanNumeral(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static string IntToRomanNumeral(int input)
        {
            throw new NotImplementedException();
            //string roman = "";
            //int deci = 0;
            //while (input >= 10)
            //{
            //    input %= 10;
            //    deci++;
            //}
            //input -= deci * 10;

            //return roman;
        }
    }
}
