using System;

namespace DependencyInjection_Worksheet
{
    //
    // You will need to refactor this class so you can test it properly
    // You are not allowed to pass in primitives (i.e. ints)
    // You are also not allow to edit the method signature of the
    // GenerateNotification method
    //

    public class PublicHolidayNotifier
    {
        private readonly IDateGenerator _DateGenerator;
        
        public PublicHolidayNotifier (IDateGenerator dateGenerator)
        {
            _DateGenerator = dateGenerator;
        }

        public string GenerateNotification()
        {
            return _DateGenerator.Generate() == new DateTime(2013, 6, 17) ? "Today is Youth Day" : "Today is a normal day";
        }
    }
}