using System;

namespace TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\ahilton\source\repos\TopTenPops\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filepath);

            Country[] countries = reader.ReadNCountries(10);

            foreach(Country country in countries)
            {
                Console.WriteLine($"{country.Population} : {country.Name}");
            }
        }
                
    }
}
