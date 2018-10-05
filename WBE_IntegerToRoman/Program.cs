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
                    Console.Write("Enter an integer betwen 1 and 40\n\n>>> ");
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nRoman Numeral: " + IntToRomanNumeral(input));
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
            string roman = "";

            if (input / 10 != 0)
            {
                for (int i = 0; i < input / 10; i++)
                {
                    roman += "X";
                }
                if (roman.Length == 4)
                {
                    roman = "XL";
                }
            }
            if (input % 10 < 4 || (input % 10 > 4 && input % 10 < 9))
            {

                for (int i = 0; i < input % 10; i++)
                {
                    if (i == 0 && input % 10 > 4)
                    {
                        roman += "V";
                        i = 4;
                    }
                    else
                    {
                        roman += "I";
                    }
                }
            }
            else if (input % 10 == 4)
            {
                roman += "IV";
            }
            else if (input % 10 == 9)
            {
                roman += "IX";
            }
            return roman;
        }
    }
}
