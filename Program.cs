using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try parse method:

            Console.WriteLine("Enter a number to convert to an Integer:");
            string numberString = Console.ReadLine();
            int number;

            if (int.TryParse(numberString, out number))
            {
                Console.WriteLine("Conversion successful. Integer value: " + number);
            }
            else
            {
                Console.WriteLine("Conversion failed. Invalid input for Integer.");
            }


            //convert method

            Console.WriteLine("Enter a number to convert to a Double: ");
            string doubleString = Console.ReadLine();
            try
            {
                double convertedDouble = Convert.ToDouble(doubleString);
                Console.WriteLine("Conversion successful. Double value: " + convertedDouble);
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion failed. Invalid input for Double.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Conversion failed. Input is too large for Double.");
            }
            Console.ReadKey();


            //parse method

            Console.WriteLine("\nEnter a number to convert to a Decimal:");
            string decimalString = Console.ReadLine();
            try
            {
                decimal convertedDecimal = decimal.Parse(decimalString);
                Console.WriteLine("Conversion successful. Decimal value: " + convertedDecimal);
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion failed. Invalid input for Decimal.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Conversion failed. Input is too large for Decimal.");
            }

        }
    }
}
