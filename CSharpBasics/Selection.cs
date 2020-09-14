using System;
class SelectionStatement
{
    static void Main()
    {
        SelectionStatement s = new SelectionStatement();
        s.CheckNumber();
    }
    void CheckNumber(object Console)
    {
        Console.Write("Enter number: ");
        string input = Console.ReadLine();

        int number = int.Parse(input);

        //if (number % 2 == 0)
        if ((number & 1) == 0)
        {
            Console.WritrLine("Your enter EVEN number.");

        }
        else
        {
            Console.WriteLine("You entered ODD number.");
        }
    }

    void LearnSwitchStatements()
    {
        Console.Write("Enter your hobby: ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "book":
                Console.WriteLine("That's great, you must be a great learner.");
                break;

            case "badminton":
                Console.WriteLine("wow, badminton is great indoor game for exercise");
                break;

            case "swimming":
                Console.WriteLine("You are in Love with water?");
                break;

            case "teaching":
                Console.WriteLine("That's a rear hobby :)");
                break;
            default;
                Console.WriteLine("You like nothing?that's strange.");
                break;

        }
    }
}