using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<City> citylist = new List<City>()
            {
                new City { Name = "Montreal", Country = "Canada" },
                new City { Name = "Paris", Country = "France" },
                new City { Name = "Toronto", Country = "Canada" },
                new City { Name = "Los Angeles", Country = "US" },
            };
            List<Country> countrylist = new List<Country>()
            {
                new Country { name = "France", code = "FR" },
                new Country { name = "Canada", code = "CA" },
                new Country { name = "US", code = "US" },
            };
            // Query to get all cities for Canada
            var citiesInCanada = citylist.Where(city => city.Country =="Canada").ToList();
          
            Console.WriteLine("--------City of Canada: ---------------");
            foreach (var s in citiesInCanada)
            {
                Console.WriteLine(s.Name);
            }


            //query method to get cities of US
            var citiesInUs = citylist.Where(city => city.Country == "US") ;
            Console.WriteLine("\n--------City of US: ---------------");
            foreach (var s in citiesInUs)
            {
                Console.WriteLine(s.Name);
            }

            //list of all distinct cities
            var distinctCities = citylist.Select(city => city.Name).Distinct().ToList();
            Console.WriteLine("\n--------Distinct Cities: ---------------");
            foreach (var c in distinctCities)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
       
    }
}
