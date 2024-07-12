using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMod5
    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        // Перевантаження оператора +
        public static City operator +(City city, int populationIncrease)
        {
            return new City(city.Name, city.Population + populationIncrease);
        }

        // Перевантаження оператора -
        public static City operator -(City city, int populationDecrease)
        {
            return new City(city.Name, city.Population - populationDecrease);
        }

        // Перевантаження оператора ==
        public static bool operator ==(City c1, City c2)
        {
            return c1.Population == c2.Population;
        }

        // Перевантаження оператора !=
        public static bool operator !=(City c1, City c2)
        {
            return c1.Population != c2.Population;
        }

        // Перевантаження оператора <
        public static bool operator <(City c1, City c2)
        {
            return c1.Population < c2.Population;
        }

        // Перевантаження оператора >
        public static bool operator >(City c1, City c2)
        {
            return c1.Population > c2.Population;
        }

        // Перевизначення методу Equals
        public override bool Equals(object obj)
        {
            if (obj is City)
            {
                City c = (City)obj;
                return this.Population == c.Population;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Population.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Name}, Population: {Population}";
        }
    }

}
