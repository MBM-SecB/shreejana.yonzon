using System;
class Compare
{
    static void main222()
    {
        Compare pp = new Compare();
        pp.CompareTwoNumbers();
    }

    void CompareTwoNumbers()
    {
        int a = 100;
        int b = 45;
        int c = a + b;
        bool k = true;
        bool l = false;
        if (c >= 500)
        {
            Console.WriteLine(k);
        }
        else
        {
            Console.WriteLine(l);
        }
    }
}