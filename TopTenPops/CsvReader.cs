using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TopTenPops
{
    class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public Country[] ReadNCountries(int nCountries)
        {

            Country[] countries = new Country[nCountries];

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();
               for(int i=0; i<nCountries; i++)
                {
                    string csvLine = sr.ReadLine();
                    countries[i] = ReadFromCSV(csvLine);

                }
            }

            return countries;

        }

        public Country ReadFromCSV(string lineToRead)
        {
            string[] parts = lineToRead.Split(',');
            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);
        }
    }
}
