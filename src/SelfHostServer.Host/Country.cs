using System;
using System.Collections.Generic;

namespace SelfHostServer.Host
{
    public sealed class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
    }

    public sealed class Car
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public static class DataStore
    {
        public static IEnumerable<Country> GetCountries()
        {
            return new Country[]
            {
                new Country { Id = Guid.NewGuid(), Name = "Sweden", Capital = "Stockholm"},
                new Country { Id = Guid.NewGuid(), Name = "Norway", Capital = "Oslo"},
                new Country { Id = Guid.NewGuid(), Name = "Belgium", Capital = "Brussels"}
            };
        }

        public static IEnumerable<Car> GetCars()
        {
            return new Car[]
            {
                new Car { Id = Guid.NewGuid(), Name = "Pontiac GTO"},
                new Car { Id = Guid.NewGuid(), Name = "Lincoln Continental"},
                new Car { Id = Guid.NewGuid(), Name = "Dodge Charger"}
            };
        }
    }
}
