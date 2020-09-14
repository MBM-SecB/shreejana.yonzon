namespace LearningClasses
{
    public class Country
    {
        public string Name { get; set; }

        public int Population { get; set; }

        public Country() //default constructor--parameter less
        {

        }
        //Parameterized constructor
        public Country(string name)
        {
            Name = name;

        }
        public Country(string name, int population)
        {
            Name = name;
            Population = population;

        }
    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal");


        }
    }
}