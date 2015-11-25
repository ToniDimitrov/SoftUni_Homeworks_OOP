using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_Square_Root
{
    internal class Problem1
    {

        private static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number: ");
                long number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("Square root of {0}: {1}", number, Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
