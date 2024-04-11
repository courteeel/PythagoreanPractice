namespace unit6Pythagorean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables to store the sides of the triangle
            double hypotenuse, legA, legB;

            // keep the program running until the user enters "quit"
            while (true)
            {
                try
                {
                    // prompt the user to enter the hypotenuse
                    Console.WriteLine("enter the hypotenuse> ");
                    hypotenuse = double.Parse(Console.ReadLine());

                    // prompt the user to enter leg A
                    Console.WriteLine("enter leg a: ");
                    legA = double.Parse(Console.ReadLine());

                    // prompt the user to enter leg B
                    Console.WriteLine("enter leg b: ");
                    legB = double.Parse(Console.ReadLine());

                    // apply the Pythagorean theorem to check if it's a right triangle
                    if (IsRightTriangle(hypotenuse, legA, legB))
                    {
                        Console.WriteLine($"{legA}^2 + {legB}^2 = {hypotenuse}^2 => {Math.Pow(legA, 2)} + {Math.Pow(legB, 2)} = {Math.Pow(hypotenuse, 2)} => {Math.Pow(legA, 2) + Math.Pow(legB, 2)} = {Math.Pow(hypotenuse, 2)} (right triangle!)");
                    }
                    else
                    {
                        Console.WriteLine("not a right triangle.");
                    }
                }
                catch (Exception e)
                {
                    // handle bad input and display an error message
                    Console.WriteLine($"Error: {e.Message}");
                }

                // prompt the user to quit or continue
                Console.WriteLine("enter 'quit' to exit or press Enter to continue.");
                string input = Console.ReadLine();

                // check if the user wants to quit
                if (input.ToLower() == "quit")
                {
                    break;
                }
            }
        }

        // Function to check if the sides form a right triangle
        static bool IsRightTriangle(double hypotenuse, double legA, double legB)
        {
            return Math.Pow(legA, 2) + Math.Pow(legB, 2) == Math.Pow(hypotenuse, 2);
        }
    }
}