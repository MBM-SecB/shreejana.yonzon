using System;
public class MethodSum
{
    public int CompareSum()
    {
        int firstNum = 250, secondNum = 100;
        int add = firstNum + secondNum;
        if (add >= 500)
        {
            Console.WriteLine("TRUE");
        }
        else
        {
            Console.WriteLine("FALSE");
        }
    }

    static void Main55()
    {
        MethodSum s = new MethodSum();
        s.CompareSum();
    }

}