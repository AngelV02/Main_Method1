using System;

namespace Main_Method1
{
    // Step 1: Create a class with math operations.
    public class MathOperations
    {
        // Method 1: Math operation for integers.
        public int PerformMathOperation(int number)
        {
            // Perform math operation on the integer parameter.
            int result = number + 5; // Example: Addition operation

            // Return the result as an integer.
            return result;
        }

        // Method 2: Math operation for decimals.
        public int PerformMathOperation(decimal number)
        {
            // Perform a different math operation on the decimal parameter.
            int result = (int)(number * 2); // Example: Multiplication operation

            // Return the result as an integer.
            return result;
        }

        // Method 3: Math operation for strings (converted to integers).
        public int PerformMathOperation(string numberString)
        {
            // Convert the string to an integer 
            int number = int.Parse(numberString);

            // Perform a different math operation on the converted integer.
            int result = number - 10; // Example: Subtraction operation

            // Return the result as an integer.
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Instantiate the MathOperations class.
            MathOperations mathOperations = new MathOperations();

            // Step 3: Call the first method with an integer parameter.
            int integerResult = mathOperations.PerformMathOperation(10);
            Console.WriteLine("Result of integer math operation: " + integerResult);

            Console.WriteLine();

            // Step 4: Call the second method with a decimal parameter.
            int decimalResult = mathOperations.PerformMathOperation(3.5m);
            Console.WriteLine("Result of decimal math operation: " + decimalResult);

            Console.WriteLine();

            // Step 5: Call the third method with a string parameter.
            int stringResult = mathOperations.PerformMathOperation("20");
            Console.WriteLine("Result of string math operation: " + stringResult);
        }
    }
}
