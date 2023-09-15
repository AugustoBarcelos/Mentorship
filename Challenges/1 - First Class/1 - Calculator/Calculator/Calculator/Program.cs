//Simple Calculator
using Calculator.Operations;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Please choose one of the following operations:\n\n 1 - Sum \n 2 - Subtraction \n 3 - Multiplication \n 4 - Divide \n 5 - Rest of the division \n 6 - Pow \n 0 - Exit \n");
                choice = int.Parse(Console.ReadLine());
                if (choice > 6)
                {
                    Console.WriteLine("\nInvalid choice! Please select one of the choices above.\n\n");
                }
                else if (choice != 0)
                {
                    Console.WriteLine("\nPlease enter the first number:\n");
                    var num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the second number:\n");
                    var num2 = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Sum sum = new Sum();
                            double result = sum.Add(num1, num2);
                            Console.WriteLine($"\nThe sum between {num1} and {num2} is: " + result);
                            Console.WriteLine("\nPress Enter to return to the main menu\n");
                            Console.ReadKey();
                            break;
                        case 2:
                            Subtraction subtraction = new Subtraction();
                            double difference = subtraction.Minus(num1, num2);
                            Console.WriteLine($"\nThe difference between {num1} and {num2} is: " + difference);
                            Console.WriteLine("\nPress Enter to return to the main menu\n");
                            Console.ReadKey();
                            break;
                        case 3:
                            Multiplication multiplication = new Multiplication();
                            double multiplicationResult = multiplication.Multiply(num1, num2);
                            Console.WriteLine($"\nThe multiplication of {num1} and {num2} is: " + multiplicationResult);
                            Console.WriteLine("\nPress Enter to return to the main menu\n");
                            Console.ReadKey();
                            break;
                        case 4:
                            Division division = new Division();
                            double divisionResult = division.Div(num1, num2);
                            if (num2 != 0)
                            {
                                Console.WriteLine($"\nThe division of {num1} and {num2} is: " + divisionResult);
                            }
                            else {
                                Console.WriteLine("\nSorry, but it is not possible to divide per Zero '0', yet!\n");
                            }
                            Console.WriteLine("\nPress Enter to return to the main menu\n");
                            Console.ReadKey();
                            break;
                        case 5:
                            Rest rest = new Rest();
                            double restResult = rest.rest(num1, num2);
                            Console.WriteLine($"\nThe rest of the division of {num1} and {num2} is: " + restResult);
                            Console.WriteLine("\nPress Enter to return to the main menu\n");
                            Console.ReadKey();
                            break;
                        case 6:
                            Pow pow = new Pow();
                            double powResult = pow.pow(num1, num2);
                            Console.WriteLine($"\nThe result of {num1} to the power of {num2} is: " + powResult);
                            Console.WriteLine("\nPress Enter to return to the main menu\n");
                            Console.ReadKey();
                            break;
                    }
                }
            } while (choice != 0);
            Console.WriteLine("\nThanks for using this aplication!\nHave a great day ahead! \nExiting the aplication...");
        }
    }
}
