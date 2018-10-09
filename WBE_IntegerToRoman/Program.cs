/*
 * Write a function that accepts an integer, and returns that integer in Roman numerals (as a string).
 * Assume the number will be 0 < n < 50
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
                    Console.Write("\nEnter an integer betwen 1 and 50\n\n>>> ");
                    int input = int.Parse(Console.ReadLine());
                    if (input <= 0 || input >= 50)
                    {
                        Console.Clear();
                        throw new Exception("Invalid Entry!");
                    }
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
                else if (input >= 5)
                {
                    // if the digit is between 5 and 8 we want to place a 'V' in place first before adding the 'I's. 
                    return "V" + IntToRomanNumeral(input - 5);
                }
                else if (input == 4)
                {
                    return "IV" + IntToRomanNumeral(input - 4);
                }
                else
                {
                    // The 'I's of 1, 2, 3, 6, 7, and 8 will be added here.
                    return "I" + IntToRomanNumeral(input - 1);
                }
            }
            else
            {
                // the is the last step in building the return string and indicates that all of the digits have been converted to Roman numerals.
                return "";
            }
        }
    }
}
