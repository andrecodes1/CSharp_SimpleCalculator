using System.Reflection.Metadata;

class Program
{
    private static void Main(string[] args)
    {
        while (true) {
            while (true)
            {
                Console.Write("Hello and Welcome to the andrecodes simple calculator! \n\nPlease start by entering a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter your desired operation (mult, add, sub, div: ");
                string operation = Console.ReadLine();
                if (operation == "mult")
                    Console.Write("Your result is: " + (num1 * num2));
                if (operation == "add")
                    Console.Write("Your result is: " + (num1 + num2));
                if (operation == "sub")
                    Console.Write("Your result is: " + (num1 - num2));
                if (operation == "div")
                    Console.Write("Your result is: " + (num1 / num2));
                Console.Write("\nDo you wish to calculate something else? (yes/no): ");
                string answer = Console.ReadLine();
                Console.Write('\n');
                if (answer == "yes")
                    break;
                if (answer == "no")
                    Console.WriteLine("Thank you for using my calcultor.\nSee you next time!");
                    return;
            }
        }
    }
}