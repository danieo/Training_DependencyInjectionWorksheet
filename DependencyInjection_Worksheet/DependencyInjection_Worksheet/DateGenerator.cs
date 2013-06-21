using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection_Worksheet
{
    public class DateGenerator : IDateGenerator
    {
        private readonly Random _random;

        public DateGenerator()
        {
            _random = new Random(1000);
        }

        public DateTime Generate()
        {
            return GetRandomDate();
        }

        /// <summary>
        /// Generate a random date by adding a random number of days to the current Date.
        /// </summary>
        /// <returns>Random Date</returns>
        private DateTime GetRandomDate()
        {
            return DateTime.Now.AddDays(_random.Next(1000));
        }
    }
}
