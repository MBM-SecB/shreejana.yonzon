public class MethodTeacher
{
    //Simple-method: takes 2 arguments, and returns a value
    public int Multiply(int firstNum, int secondNum)
    {
        int result = firstNum * secondNum;
        return result;
    }
    //Variable-number of arguments
    public int Multiply(params int[] numbers)
    {
        int product = 1;
        foreach (int num in numbers)
        {
            product = product * num;
        }
        return product;
    }

    //Named arguments
    internal void PrintCustomerDeatails(string name, byte age, string address, DateTime dob)
    {   // using string interpolation here:$"{}"
        Console.Write($"Customer Details: {name}, {age}, {address}, {dob}");

    }
    //Returning multipel value
    //Question: Method which returns max and min value of supplied numbers

    internal (int, int) FindMinMax(params int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;

        }
        //do something on x
        return (min, max);
    }


}
public class MethodTester
{
    void TestMethods()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        int product = methodTeacher.Multiply(2345, 56483);

        product = methodTeacher.Multiply(344, 45676, 233, 577);
        product = methodTeacher.Multiply(2333, 456778, 23993, 577);

        methodTeacher.PrintCustomerDeatails(dob: DateTime.Now, name: "Shree", age: 22, address: "Boudha");
        (int Min, int Max) result = methodTeacher.FindMinMax(2, 3, 4, 5, 6, 7, 8, 9, 32, 333);
        Console.WriteLine($"Minimum: {result.Min}, Maximum: {result.Max}");

    }
}