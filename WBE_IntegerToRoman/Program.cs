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
                    int input = int.Parse(Console.ReadLine());
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
            //throw new NotImplementedException();
            if (input == 1000)
            {
                return "M";
            }

            string roman = "";
            int thousands = input / 1000;
            int hundreds = (input - thousands*1000)/100;
            int tens = (input - thousands*1000 - hundreds*100) / 10;
            int digits = input - thousands*1000 - hundreds*100 - tens*10;

            string digitsPattern = "IIIVIIIX";
            string tensPattern = "XXXLXXXC";
            string hundredsPattern = "CCCDCCCM";

            return roman;
        }
    }
}
