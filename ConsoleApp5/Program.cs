using System;
using System.Collections.Generic;

namespace ConsoleApp5
{

    class Program
    {
        static void Main(string[] args)
        {
            //1
            Dictionary<string, City> capitalMap = new Dictionary<string, City>();
            capitalMap.Add("Toronto", new City(2000000,"Ontario"));
            capitalMap.Add("Montreal", new City(2000000,"Quebec"));
            capitalMap.Add("Winnipeg", new City(2000000,"Manitoba"));
            capitalMap.Add("Halifax", new City(2000000,"Nova Scotia"));
            capitalMap.Add("Victoria", new City(2000000,"British Columbia"));
            foreach(KeyValuePair<string,City> kv in capitalMap)
            {
                Console.WriteLine("{0} is a city in {1}", kv.Key, kv.Value.Province);
            }
            //2
            HashSet<string> topCities = new HashSet<string>();
            topCities.Add("New York");
            topCities.Add("Mexico City");
            topCities.Add("Los Angeles");
            topCities.Add("Toronto");
            topCities.Add("Chicago");
            topCities.Add("Houston");
            topCities.Add("Havana");
            topCities.Add("Montreal");
            topCities.Add("Ecatepec de Morelos");
            topCities.Add("Philadelphia");

            /*foreach(string city in cities)
            {
                Console.WriteLine(city);
            }*/
            //3
            Console.WriteLine();
            HashSet<string> answerList = new HashSet<string>(capitalMap.Keys);
            answerList.IntersectWith(topCities);
            foreach (string city in answerList)
            {
                Console.WriteLine("{0} is in Canada and also in the top 10 largest cities in North America.",city);
            }
        }
    }

    class City
    {
        public City(long population, string province)
        {
            Population = population;
            Province = province;
        }
        public long Population { get; set; }
        public string Province { get; set; }
    }
}
