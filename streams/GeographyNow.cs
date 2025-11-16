namespace homework1.streams;

public class GeographyNow
{
    public static void Main()
    {
        string filePath = @"D:\TBC\ConsoleApp3\streams\cities.txt";
        string logPath = @"D:\TBC\ConsoleApp3\streams\Logs.txt";

        List<City> cities = new List<City>();
        List<Country> countries = new List<Country>();

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        string[] values = line.Split('|');
                        if (values.Length < 5) throw new Exception("Invalid line format.");

                        string cityName = values[0];
                        double cityArea = double.Parse(values[1], new System.Globalization.CultureInfo("de-DE"));
                        int cityPopulation = int.Parse(values[2]);
                        bool isCapital = bool.Parse(values[3]);
                        string countryName = values[4];
                        Country country = new Country(countryName, new List<City>());
                        countries.Add(country);
                        cities.Add(new City(cityName, cityArea, cityPopulation, isCapital, country));
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(logPath, $"Error parsing line: {line}. Exception: {ex.Message}\n");
                    }
                }
            }


            foreach (City city in cities)
            {
                foreach (var country in countries)
                {
                    if (country.Name == city.Country.Name)
                    {
                        country.Cities.Add(city);
                    }
                }
            }

            foreach (var country in countries)
            {
                int capitalsCount = country.Cities.Count(c => c.IsCapital);
                if (capitalsCount > 1)
                {
                    throw new CountryMustHaveSingleCapitalException(
                        $"Country '{country.Name}' has {capitalsCount} capitals!");
                }
            }

            bool found = false;
            Console.WriteLine("1. Search Country 2. search City");
            Console.Write("Enter number for which you want to search : ");
            int input = Convert.ToInt32(Console.ReadLine());
            while (input != 1 && input != 2)
            {
                Console.Write("Write 1 for Country or 2 for City Search : ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            if (input == 1)
            {
                Console.Write("Enter country name : ");
                string countryName = Console.ReadLine();
                foreach (Country country in countries)
                {
                    if (country.Name == countryName)
                    {
                        found = true;
                        Console.WriteLine($"Country Name: {country.Name}");
                        Console.WriteLine($"Country Area: {country.Area} KM^2");
                        Console.WriteLine($"Country Population: {country.Population}");
                        Console.Write($"Cities : ");
                        foreach (City city in country.Cities)
                        {
                            if (city.IsCapital)
                            {
                                Console.Write($"{city.Name} (Is Captial), ");
                            }
                            else
                            {
                                Console.Write($"{city.Name}, ");
                            }
                        }

                        break;
                    }
                }
            }
            else if (input == 2)
            {
                Console.Write("Enter city name : ");
                string cityName = Console.ReadLine();
                foreach (City city in cities)
                {
                    if (city.Name == cityName)
                    {
                        found = true;
                        Console.WriteLine($"City Name : {city.Name}");
                        Console.WriteLine($"City Area : {city.Area} KM^2");
                        Console.WriteLine($"City Population : {city.Population}");
                        Console.WriteLine($"City Country : {city.Country.Name}");
                        Console.WriteLine($"isCapital : {city.IsCapital}");
                    }
                }
                if (!found) Console.WriteLine("Not Found"); 
            }
        }
        catch (CountryMustHaveSingleCapitalException ex)
        {
            File.AppendAllText(logPath, $"Country capital error: {ex.Message}\n");        
        }catch (FormatException ex)
        {
            File.AppendAllText(logPath, $"formatException : {ex.Message}\n");        
        }
    }
}