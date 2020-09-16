using System;

class Points
{
    void Combine()
    {
        Console.Write("Enter the number of Wins, Draws and Losses:");
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string input3 = Console.ReadLine();
        int w = int.Parse(input1);
        int d = int.Parse(input2);
        int l = int.Parse(input3);

        int s = 5 * w + 2 * d + 0 * l;

        Console.Write("The total number of points you have obtained is:{0}", s);

    }
    static void Main22()
    {
        Points p = new Points();
        p.Combine();
    }
}