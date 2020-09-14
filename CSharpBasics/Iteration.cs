using System;
{
 class IterationStatement
{
    static void Main()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnForLoops();

        AccessModifier accessModifier = new AccessModifier();
        accessModifier.DoAnotherThing();

        Person person = new Person();
        person.Age = 34;
    }
    void LearnForLoops()
    {
        //Console.WriteLine("I am beautiful.");
        int i;
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("I am Beautiful.");
        }

        byte[] personAges = { 20, 29, 22, 23, 45 };

        foreach (byte age in personAges)
        {
            if (age % 2 == 0)
            {
                Console.WriteLine(age + "is EVEN.");
            }
            else
            {
                Console.WriteLine(age + "is ODD.");
            }
        }
    }

    void LearWhileLoop()
    {
        char confirm = 'Y';
        while (confirm == 'Y')
        {
            Console.WriteLine("I am inside while loop.");
            Console.Write("Enter Y to continue:");
            confirm = Console.ReadKey().KeyChar;
        }

        do
        {
            Console.WriteLine("I am inside while loop.");
            Console.Write("Enter Y to continue:");
            confirm = Console.ReadKey().KeyChar;
        } while (confirm == 'Y');
    }

}
}







