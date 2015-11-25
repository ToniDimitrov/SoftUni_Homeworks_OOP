using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Enter_Numbers
{
    internal class Problem2
    {
        public static void ReadNumber(int start, int end, int counter)
        {
            int number = 0;
            Console.WriteLine("Enter number in range {0} <..< {1}", start, end);

            try
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > start && number < end)
                    {
                        Console.WriteLine("Correct input. The number \'{0}\' is in range {1} <..< {2}", number, start,
                            end);
                        counter++;

                        if (counter > 0)
                        {
                            start = number;
                        }

                        if (start == (end - 1))
                        {
                            throw new Exception("There are no more numbers in range.");
                        }
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Number out of range!");
                    }
                }
                else
                {
                    throw new FormatException("Invalid number.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine(
                    "The number \'{2}\' is out of the range {0} <..< {1}\nPlease enter a valid number {0} <..< {1}",
                    start, end, number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.\nPlease enter a valid number {0} <..< {1}", start, end);
            }
            catch (Exception)
            {
                Console.WriteLine(
                    "There are no more integer numbers in range {0} <..< {1}\n", start,
                    end);
                counter = 10;
            }
            finally
            {
                if (counter < 10)
                {
                    ReadNumber(start, end, counter);
                }
                else
                {
                    Console.WriteLine("THE END!");
                }
            }
        }

        private static void Main()
        {
            const int start = 1;
            const int end = 100;
            const int counter = 0;

            ReadNumber(start, end, counter);
        }
    }
}