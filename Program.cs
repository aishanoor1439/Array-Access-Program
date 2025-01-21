using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Access_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            try
            {
                Console.WriteLine("Enter an index to retrieve a value from the array (0 to 4): ");
                string input = Console.ReadLine();
                int index = Convert.ToInt32(input);

                Console.WriteLine("The value at index {0} is {1}", index, numbers[index]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter an integer value.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Invalid index. Please enter a number between 0 and 4.");
            }
            finally
            {
                Console.WriteLine("End of array access operation.");
            }
        }
    }
}
