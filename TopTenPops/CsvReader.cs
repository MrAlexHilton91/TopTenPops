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

        public Country[] ReadFirstNCountries(int nCountires)
        {
            Country[] countries = new Country[nCountires];
                        
            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                // read header line
                sr.ReadLine();

                for (int i = 0; i < nCountires; i++)
                {
                string csvLine = sr.ReadLine();
                countries[i] = ReadCountryFromCsvLine(csvLine);
                }
            }
            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);
        }
    }
}
