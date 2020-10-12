using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()

        {
            //LINQ - Language INtegrated Query
            int[] numbers = { 12, 13, 34, 67, 445, 67, 55, 9, 123, 7683 };

            //Methods syntax
            var result1 = numbers.Where(num => num > 50).Select(num => num);

            //Query expression syntax
            var result2 = from num in numbers
                          where num > 50
                          select num;

            //Restrictions - where
            var results3 = from num in numbers
                           where num > 50 && num < 70
                           select num;


            //Projection - select
            //even no. ko square
            var result4 = from num in numbers
                          where num % 2 == 0
                          select num * num;

            // Ordering the numbers -orderby, orderby descending
            var result5 = from num in numbers
                          orderby num descending
                          select num;

            //first five elements(partitioning:take)
            var result6 = numbers.Take(5);
            //numbers.Skip(5).Take(5); 

            //boolean (Quantifiers:Any,All,Contains)
            var result7 = numbers.Any(num => num % 2 == 0);
            var result8 = numbers.All(num => num % 2 == 0);

            var result9 = numbers.Contains(23);

            //Generations : range, repeat
            var result10 = Enumerable.Range(1, 1000);
            var result11 = Enumerable.Repeat("Hello World!!", 20);



        }

        void LearnLinqOnComplexCollection()
        {
            Country c1 = new Country("Nepal", "Kathmandu", "Asia", 324242234);
            Country c2 = new Country("India", "Delhi", "Asia", 332224242234, DateTime.Parse("1947/11/1"));
            Country c3 = new Country("England", "GB", "Europe", 6756753);
            Country c4 = new Country("Bhutan", "Thimpu", "Asia", 658600);
            Country c5 = new Country("Russia", "Masco", "Asia", 324242234, DateTime.Parse("1904/11/6"));
            Country c6 = new Country("Brazil", "South America", "Asia", 212135466);
            Country c7 = new Country("Bulgaria", "Sofia", "Europe", 6951482);
            Country c8 = new Country("Cambodia", "Phnim", "Asia", 15288489);
            Country c9 = new Country("Cameroon", "Yaounde", "Africa", 324242234);
            Country c10 = new Country("Austria", "Vienna", "Europe", 25672454);
            Country c11 = new Country("Bangladesh", "Dhaka", "Asia", 169390226);
            Country c12 = new Country("Canada", "Ottawa", "North America", 38190809);
            Country c13 = new Country("China", "Beijing", "Asia", 7509200);
            Country c14 = new Country("Denmark", "Copenhagen", "Europe", 324242234);
            Country c15 = new Country("Egypt", "Cairo", "Africa", 100980066);
            Country c16 = new Country("Finland", "Helsinki", "Europe", 123597544);
            Country c17 = new Country("France", "Paris", "Europe", 67132000);
            Country c18 = new Country("Germany", "Berlin", "Europe", 83157201);
            Country c19 = new Country("Japan", "Tokyo", "Asia", 125810000);
            Country c20 = new Country("Philippines", "Manila", "Asia", 109231741);


            /* c1.Name = "Nepal";
             c1.Capitol = "Kathmandu";
             c1.Continent = "Asia";
             c1.Population = 324242234;*/

            List<Country> countries = new List<Country> { c1, c2, c3, c4, c5 };

            //List all asian country names
            var result1 = from Country in countries
                          where Country.Continent == "Asia"
                          select Country.Name;

            //List all asian country names which are never been invaded
            var result2 = from Country in countries

            //List all europian countries in ascending order that has population less than 500k              

        }
    }
}
