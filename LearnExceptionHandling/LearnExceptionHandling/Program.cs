using System;
namespace LearnExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            try
            {
                Console.WriteLine("Enter a number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int res = Result(num1, num2);
                Console.WriteLine("Result: " + res);

                // Example: Array Index Out of Range Exception
                int[] myArray = { 1, 2, 3 };
                Console.WriteLine(myArray[3]); // This will cause an exception
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: Only numbers are allowed. Please enter valid integers.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error: Array index is out of range.");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Error: Number entered is too large or too small for an integer.");
            }
            catch (Exception e) // Catch any other exceptions
            {
                Console.WriteLine("An unexpected error occurred: " + e.Message);
            }
            finally
            {
                Console.WriteLine("This block always executes."); // Good for cleanup
                
                string message = temperature(40);
                Console.WriteLine(message);
            }
        }

        static int Result(int num1, int num2)
        {
            return num1 / num2;
        }
        static string temperature(int temp)
        {
            string message = (temp > 30) ? "It's HOT" : "its COOL";
            return message;
        }
    }
}