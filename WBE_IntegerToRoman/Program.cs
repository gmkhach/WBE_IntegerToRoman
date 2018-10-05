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
                Console.Write("\nPress Enter to try another number...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static string IntToRomanNumeral(int input)
        {
            if(input / 10 != 0)
            {
                return input / 10 == 4 ? "XL" + IntToRomanNumeral(input - 40) : "X" + IntToRomanNumeral(input - 10);
            }
            else if (input != 0)
            {
                if (input == 9)
                {
                    return "IX" + IntToRomanNumeral(input - 9); ;
                }
                else if (input > 4)
                {
                    return "V" + IntToRomanNumeral(input - 5);
                }
                else if (input == 4)
                {
                    return "IV" + IntToRomanNumeral(input - 4);
                }
                else
                {
                    return "I" + IntToRomanNumeral(input - 1);
                }
            }
            else
            {
                return "";
            }
        }
    }
}
