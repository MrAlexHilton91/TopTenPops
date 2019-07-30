using System;
using System.Collections.Generic;
using System.Text;

namespace TopTenPops
{
    class Country
    {
        public string Name { get; }
        public string Code { get; }
        public string Region { get; }
        public int population { get; }

        public Country(string name, string code, string region, int population)
        {
            Name = name;
            Code = code;
            Region = region;
            this.population = population;
        }


    }
}
