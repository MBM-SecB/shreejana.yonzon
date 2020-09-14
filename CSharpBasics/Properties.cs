using System;
{
class Person
{
    private int age = 25;
    internal string name = "Sushmita";
    public string Name { get; set; }

    public int Age
    {
        //get
        //{
        //   return age;
        //}
        get => age;
        set
        {
            if (value > 20 && value < 30)
            {
                age = value;
            }
        }
    }
}
}

